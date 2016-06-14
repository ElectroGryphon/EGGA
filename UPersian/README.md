# EGGA

UPersian:
Unity Game Engine RTL Support

This project used [ArabicSupprt for Unity](https://www.assetstore.unity3d.com/en/#!/content/2674) Asset.


![alt tag](https://cloud.githubusercontent.com/assets/6388730/16043232/f08871e8-3253-11e6-8153-d251e7dc67d0.PNG)

Features:
New GUI Items(Creation MenuItem > UPersian > ): 
- RTL Text
- RTL Inputfield
- RTL Buton 
- RTL Checkbox

Supports BestFit:

![bestfit](https://cloud.githubusercontent.com/assets/6388730/16043398/b79198fa-3254-11e6-83a0-4724a62712b9.PNG)


String Extentions:
- string RtlFix(): fixes original rtl strings to show in unity GUI. (ie. string hello = "سلام".RtlFix();)
- bool IsRtl: returns whether string is rtl or not. (ie. bool checkRtl = "سلام".IsRtl();)


How to use:
- Import latest unitypackage into your project.
- Right click in hierarchy panel > UPersian > Rtl Text
- Select RtlText in hierarchy and change text inside inspector! yes! everything should show correct in GUI
