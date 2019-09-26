using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using VidGrabNoForm;

namespace VideoGrabberService
{
    public partial class VidgrabService : ServiceBase
    {
        protected Thread m_vidgrabThread;
        protected ManualResetEvent m_threadShutdown;
        protected VideoGrabber vg1;

        public VidgrabService()
        {
            InitializeComponent();

            if (!System.Diagnostics.EventLog.SourceExists("vglog"))
            {
                System.Diagnostics.EventLog.CreateEventSource("vglog", "TVideoGrabber");
            }

            eventLog1.Source = "vglog";
            eventLog1.Log = "TVideoGrabber";
        }

        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("vgrab service started");
            eventLog1.WriteEntry(System.IO.Path.GetTempPath());

            ThreadStart ts = new ThreadStart(this.ServiceMain);
            m_threadShutdown = new ManualResetEvent(false);
            m_vidgrabThread = new Thread(ts);
            m_vidgrabThread.Start();
            base.OnStart(args);
        }

        protected override void OnStop()
        {
            m_threadShutdown.Set();
            m_vidgrabThread.Join(10000);
            eventLog1.WriteEntry("vgrab service stopped");
            base.OnStop();
        }

        protected void ServiceMain()
        {
            eventLog1.WriteEntry("creating vg1");
            vg1 = new VideoGrabber();
            eventLog1.WriteEntry(vg1.Version);
            vg1.StoragePath = System.IO.Path.GetTempPath();
            vg1.TextOverlay_Enabled = true;
            vg1.TextOverlay_String = "system date/time: %sys_time[dd/mm/yy hh:nn:ss]%";
            eventLog1.WriteEntry("starting vg1 " + vg1.Version);
            vg1.StartPreview();

            if (vg1.GraphState() == VidGrabNoForm.TGraphState.gs_Running)
            {
                eventLog1.WriteEntry("vg1 started on capture device " + vg1.VideoDeviceName);
                ThreadLoop();
                vg1.StopPreview();
            }
            else
            {
                eventLog1.WriteEntry("failed to start vg1");
            }

            eventLog1.WriteEntry("stopping vg1");
            eventLog1.WriteEntry("destroying vg1");
            vg1.Dispose();

        }
        protected void ThreadLoop()
        {
            int waitCount = 0;
            while (!m_threadShutdown.WaitOne(100, true)) 
            {
                if (waitCount++ == 50) // every 500*10 = 5 seconds
                {
                    waitCount = 0;
                    vg1.CaptureFrameTo(TFrameCaptureDest.fc_JpegFile, "");
                }
                vg1.ContinueProcessing(); // required with VidgrabNoForm
            }
        }
    }
}
