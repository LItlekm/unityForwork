using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class YieldHelper
{
    public static IEnumerator WaitForSeconds(float totalTime, bool ignoreTimeScale = false)
    {
        float time = 0;
        while(time < totalTime)
        {
            time += (ignoreTimeScale ? Time.unscaledDeltaTime : Time.deltaTime);
            yield return null;
        }
    }
}
