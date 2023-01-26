using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public static partial class GFunc
{
    //! �ؽ�Ʈ�޽����� ������ ������Ʈ�� �ؽ�Ʈ�� �����ϴ� �Լ�
    public static void SetTmpText(GameObject obj_, string text_)
    {
        TMP_Text tmpTxt = obj_.GetComponent<TMP_Text>();

        if (tmpTxt == null || tmpTxt == default(TMP_Text)) 
        {
            return;
        } // if : ������ �ؽ�Ʈ�޽� ������Ʈ�� ���� ���

        // ������ �ؽ�Ʈ�޽� ������Ʈ�� ������ ���
        tmpTxt.text = text_;
    } // SetTmpText()
}
