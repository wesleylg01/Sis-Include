
 VISTA: invoking Register.cmd Unregister.cmd (or directy regsvr32.exe)
 ---------------------------------------------------------------------

 Both Register.cmd and Unregister.cmd invoke regsvr32.exe. 
 On Vista  platforms, regsvr32.exe must be ran as Administrator to be 
 able to register the OCX on the platform.

 Therefore the user that installs the OCX must have the administrator
 rights.

 - if you run directly Register.cmd or Unregister.cmd, right-click on
 the .cmd file and click "run as Administrator".

 - if you invoke regsvr32.exe directly from your install program, 
 right-click on your install program and click "run as Administrator".

