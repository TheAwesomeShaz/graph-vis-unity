using System;
using System.Collections;
using UnityEngine;
using static UnityEngine.Mathf;

public static class FunctionLibrary
{
    public static float Wave(float x, float t)
    {
        return Sin(PI * (x + t));
    }
    
    public static float MultiWave(float x, float t)
    {
        float y = Sin(PI * (x + t));
        y += Sin(2f* PI * (x + t)) * (1f / 2f);
     
        // divide result by 1.5 to limit the range of function within -1 and 1
        // or else limits were gonna become -1.5 to 1.5
        // (sin value can be 1 or -1 so sin plus sin2pi/2 will be 1 + 1/2 which will be 1.5)
        // dividing a variable takes more time than multiplying for a compiler
        // instead of 1.5 we write 2/3 
        //we always prefer multiplication to division for efficiency 
        return y * (2f / 3f);

        // we are at Division requires a bit more work than multiplication
    }
}
