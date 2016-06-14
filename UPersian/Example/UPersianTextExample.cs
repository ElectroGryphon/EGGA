using UnityEngine;
using UPersian.Components;
using UPersian.Utils;

public class UPersianTextExample : MonoBehaviour
{

    [SerializeField] private RtlText upText;

	void Awake ()
	{
        // Set Rtl Text without any additional changes.
	    upText.text = "سلام بدون نیاز به تغییر متن!";

        // returns modified text. (Reverse and line fix to show correctly in Ui)
        print(upText.text);

        // BaseText returns original text. you sould use BaseText if you want to post rtl usernames to server or anywhere you need original rtl text value
        print(upText.BaseText);

        // keep in mind that you allways can fix original BaseText and use whereever you want using .RtfFix()
        print(upText.BaseText.RtlFix());
	}
}
