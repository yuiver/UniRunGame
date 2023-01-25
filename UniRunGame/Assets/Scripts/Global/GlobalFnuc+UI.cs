using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public static partial class GlobalFnuc
{
    public static void SetTmpText(GameObject obj_, string text_)
    {
        TMP_Text tmpTxt = obj_.GetComponent<TMP_Text>();
        if (tmpTxt == null || tmpTxt == default(TMP_Text))
    {
            return;
    }       //if  가져올 텍스트 메쉬가 없는경우

        tmpTxt.text = text_;
    }
}
