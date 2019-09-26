object Form1: TForm1
  Left = 0
  Top = 0
  Caption = 'Form1'
  ClientHeight = 377
  ClientWidth = 541
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 24
    Top = 160
    Width = 93
    Height = 13
    Caption = 'Modulo de gerar Qr'
  end
  object Button1: TButton
    Left = 464
    Top = 8
    Width = 75
    Height = 25
    Caption = 'Button1'
    TabOrder = 0
    OnClick = Button1Click
  end
  object Button2: TButton
    Left = 24
    Top = 192
    Width = 113
    Height = 97
    Caption = 'Carregar Livro txt'
    TabOrder = 1
    OnClick = Button2Click
  end
  object Button3: TButton
    Left = 420
    Top = 192
    Width = 113
    Height = 97
    Caption = 'Diretorio de imgs'
    TabOrder = 2
    OnClick = Button3Click
  end
  object RichEdit1: TRichEdit
    Left = 144
    Top = 8
    Width = 257
    Height = 353
    Font.Charset = ANSI_CHARSET
    Font.Color = clWindowText
    Font.Height = -11
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    ScrollBars = ssBoth
    TabOrder = 3
  end
  object OpenDialog1: TOpenDialog
    Left = 65528
  end
end
