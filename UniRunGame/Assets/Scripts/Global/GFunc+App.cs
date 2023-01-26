using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // �� ���� ���� ���̺귯��

// static �����̶� �ٸ� Ŭ�������� �� �� �ִ�.
public static partial class GFunc
{
    // static �����̶� �ٸ� Ŭ�������� �� �� �ִ�.
    public static void QuitThisGame()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        Application.Quit();
        #endif
    } // QuitThisGame()


    // Extended method Ȱ���
    public static void Junil123Func(this GameObject obj_)
    {
        Debug.Log("�̰��� ���� ���� �Լ��� �и��ϴ�.");
    } // Junil123Func()


    //! �ٸ� ���� �ε��ϴ� �Լ�
    public static void LoadScene(string sceneName_)
    {
        SceneManager.LoadScene(sceneName_);

    } // LoadScene
}
