object Service1: TService1
  OldCreateOrder = False
  OnCreate = ServiceCreate
  OnDestroy = ServiceDestroy
  DisplayName = 'TVideoGrabber Capture Service'
  StartType = stManual
  OnExecute = ServiceExecute
  OnStart = ServiceStart
  OnStop = ServiceStop
  Left = 192
  Top = 122
  Height = 1000
  Width = 1740
end
