//---------------------------------------------------------------------------

#ifndef FrameCapture_H
#define FrameCapture_H
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include <ComCtrls.hpp>
#include <ExtCtrls.hpp>
#include <Menus.hpp>
#include "VidGrab.hpp"
#include <Buttons.hpp>
#include <Dialogs.hpp>
//---------------------------------------------------------------------------
class TForm1 : public TForm
{
__published:	// IDE-managed Components
        TImage *Image1;
        TGroupBox *GroupBox2;
        TButton *Button6;
        TButton *Button7;
        TButton *Button4;
        TEdit *Edit2;
        TCheckBox *CheckBox3;
        TGroupBox *GroupBox3;
        TComboBox *ComboBox1;
        TComboBox *ComboBox2;
        TComboBox *ComboBox4;
        TComboBox *ComboBox5;
        TButton *Button10;
        TButton *Button9;
        TVideoGrabber *VideoGrabber1;
        TGroupBox *GroupBox1;
        TLabel *Label2;
        TButton *Button2;
        TButton *Button1;
        TButton *Button5;
        TButton *Button11;
        TEdit *Edit3;
        TButton *Button3;
        TButton *Button8;
        TLabel *Label1;
        TEdit *Edit1;
        TLabel *Label4;
        TMemo *Memo1;
        void __fastcall FormCreate(TObject *Sender);
        void __fastcall Button1Click(TObject *Sender);
        void __fastcall Button2Click(TObject *Sender);
        void __fastcall Button6Click(TObject *Sender);
        void __fastcall Button7Click(TObject *Sender);
        void __fastcall ComboBox1Change(TObject *Sender);
        void __fastcall ComboBox2Change(TObject *Sender);
        void __fastcall Button8Click(TObject *Sender);
        void __fastcall ComboBox4Change(TObject *Sender);
        void __fastcall ComboBox5Change(TObject *Sender);
        void __fastcall Button3Click(TObject *Sender);
        void __fastcall Button9Click(TObject *Sender);
        void __fastcall Button10Click(TObject *Sender);
        void __fastcall Button5Click(TObject *Sender);
        void __fastcall Button4Click(TObject *Sender);
        void __fastcall VideoGrabber1ResizeVideo(TObject *Sender,
          int SourceWidth, int SourceHeight);
        void __fastcall Edit3Change(TObject *Sender);
        void __fastcall Edit1Change(TObject *Sender);
        void __fastcall CheckBox3Click(TObject *Sender);
        void __fastcall Button11Click(TObject *Sender);
        void __fastcall VideoGrabber1VideoDeviceSelected(TObject *Sender);
        void __fastcall VideoGrabber1FrameCaptureCompleted(TObject *Sender,
          Pointer FrameBitmap, int BitmapWidth, int BitmapHeight,
          DWORD FrameNumber, Int64 FrameTime, TFrameCaptureDest DestType,
          String FileName, bool Success, int FrameId);
private:
public:
        __fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
