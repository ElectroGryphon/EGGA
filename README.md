# EGGA

UPersian:
Unity Game Engine RTL Support
![alt tag](https://cloud.githubusercontent.com/assets/6388730/16043232/f08871e8-3253-11e6-8153-d251e7dc67d0.PNG)
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
