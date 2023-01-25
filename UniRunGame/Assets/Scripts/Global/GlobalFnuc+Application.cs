using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public static partial class GlobalFnuc
{
    //! 게임을 종료하는 함수
    public static void QuitThisGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
                Application.Quit();
#endif

    }

    public static void LoadScene(string sceneName_)
    {
        SceneManager.LoadScene(sceneName_);

    }

}
