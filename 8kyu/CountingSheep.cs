using System;

public static class Kata 
{
    public static int CountSheeps(bool[] sheeps)
    {
        int res = 0;
        foreach(bool v in sheeps)
        {
            res += v ? 1 : 0;
        }
        return res;
    }
}