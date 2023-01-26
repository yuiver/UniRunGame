using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class GlobalFnuc
{
    //복붙의 장점은 -> 변수 이름과 함수 이름 그리고 파라미터 이름을 잘못 써서 발생하는 실수를 줄일 수 있다.
    //복붙의 단점은 -> 익숙하지 않은 메서드나 기능들을 외울 떄,특히 기억이 잘 안남.

    //Debug.Log 함수를 어떻게 랩핑해야 하는지 알아보자
    #region Print log func
    [System.Diagnostics.Conditional("DEBUG_MODE")]
    public static void Log(object message)
    {
#if DEBUG_MODE
        Debug.Log(message);
#endif //DEBUG_MODE
    }

    [System.Diagnostics.Conditional("DEBUG_MODE")]
    public static void Log(object message, UnityEngine.Object context)
    {
#if DEBUG_MODE
        Debug.Log(message, context);
#endif //DEBUG_MODE
    }
#endregion //Print log func

#region Assert for debug
    [System.Diagnostics.Conditional("DEBUG_MOD")]
    public static void Assert(bool condition)
    {
#if DEBUG_MODE
        Debug.Assert(condition);
#endif //DEBUG_MODE
    }
#endregion
    #region Assert for debug
    [System.Diagnostics.Conditional("DEBUG_MOD")]
    public static void Assert(bool condition ,object message)
    {
#if DEBUG_MODE
        Debug.Assert(condition, message);
#endif //DEBUG_MODE
    }
    #endregion

    public static bool IsValid(this Component component_)
    {
        bool isValid = false;
        if (component_ == null || component_ == default) { /*Pass*/ }
        else
        {
            isValid = true;
        }
        return isValid;
    }
}


