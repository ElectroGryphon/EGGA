using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UPersian.Utils
{
    public static class UPersianUtils
    {

        /// <summary>
        /// and extention for strings to fix RTL Languages to unity display format
        /// </summary>
        /// <param name="str">string to fix</param>
        /// <returns>corrected RTL string</returns>
        public static string RtlFix(this string str)
        {
            //ﺉﻚﻙﯤ
            str = str.Replace('ی', 'ﻱ');
            //str = str.Replace( 'ی','ﺉ');
            str = str.Replace('ک', 'ﻙ');
            //str = str.Replace('ﻚ', 'ک');
            str = ArabicSupport.ArabicFixer.Fix(str, true, false);

            str = str.Replace('ﺃ', 'آ');
            return str;
        }

        public static bool IsRtl(this string str)
        {
            var isRtl = false;
            foreach (var _char in str)
            {
                if ((_char >= 1536 && _char <= 1791) || (_char >= 65136 && _char <= 65279))
                {
                    isRtl = true;
                    break;
                }
            }
            return isRtl;
        }

        public static void SetRTLText(this Text txtComponent, string text)
        {
            // Populate base text in rect transform and calculate number of lines.
            string baseText = txtComponent.text;
            txtComponent.cachedTextGenerator.Populate(baseText,
                txtComponent.GetGenerationSettings(txtComponent.rectTransform.rect.size));
            // Make list of lines
            List<UILineInfo> lines = txtComponent.cachedTextGenerator.lines as List<UILineInfo>;
            if (lines == null) txtComponent.text = string.Empty;
            string linedText = string.Empty;
            for (int i = 0; i < lines.Count; i++)
            {
                // Find Start and Length of RTL line and append Line Ending character.
                if (i < lines.Count - 1)
                {
                    int startIndex = lines[i].startCharIdx;
                    int length = lines[i + 1].startCharIdx - lines[i].startCharIdx;
                    linedText += baseText.Substring(startIndex, length);
                    if (linedText.Length > 0 &&
                        linedText[linedText.Length - 1] != '\n' &&
                        linedText[linedText.Length - 1] != '\r')
                    {
                        linedText += '\n';
                    }
                }
                else
                {
                    // For the Last line, we only need startIndex and line continues to the end.
                    linedText += baseText.Substring(lines[i].startCharIdx);
                    //if (resizeTextForBestFit) linedText += '\n';
                }
            }
            txtComponent.text = NBidi.NBidi.LogicalToVisual(linedText);
        }

       
    }
}
