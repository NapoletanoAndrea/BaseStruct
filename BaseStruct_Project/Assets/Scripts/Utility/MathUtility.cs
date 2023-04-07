using UnityEngine;
using Utils.Enums;

public static class MathUtility
{
    public static float Repeat(float value, float min, float max)
    {
        return value > max ? min : value;
    }

    public static float Distance(float a, float b)
    {
        return a > b ? a - b : b - a;
    }

    public static bool Compare(float value, float compareValue, NumericComparison comparison)
    {
        switch (comparison)
        {
            case NumericComparison.Less:
                return value < compareValue;
            case NumericComparison.Greater:
                return value > compareValue;
            case NumericComparison.Equal:
                return value == compareValue;
            case NumericComparison.LEqual:
                return value <= compareValue;
            case NumericComparison.GEqual:
                return value >= compareValue;
            default: 
                return value < compareValue;
        }
    }
    
    public static float Remap(float x, Vector2 inRange, Vector2 outRange)
    {
        return outRange.x + (x - inRange.x) * (outRange.y - outRange.x) / (inRange.y - inRange.x);
    }
}