# EGGA
Unity Game Engine RTL Support

Features:
New GUI Items(Creation MenuItem > UPersian > ): 
- RTL Text (Supports BestFit!)
- RTL Inputfield
- RTL Buton 
- RTL Checkbox

String Extentions:
- string RtlFix(): fixes original rtl strings to show in unity GUI. (ie. string hello = "سلام".RtlFix();)
- bool IsRtl: returns whether string is rtl or not. (ie. bool checkRtl = "سلام".IsRtl();)


How to use:
- Import latest unitypackage into your project.
- Right click in hierarchy panel > UPersian > Rtl Text
- Select RtlText in hierarchy and change text inside inspector! yes! everything should show correct in GUI
