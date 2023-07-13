/*
7 kyu
Binary Addition
117420586% of 12,63511,810 of 142,043garrettguy457
C#
TrainNext Kata

    Details
    Solutions
    Forks (11)
    Discourse (264)

Collect|
Description:

Implement a function that adds two numbers together and returns their sum in binary. The conversion can be done before, or after the addition.

The binary number returned should be a string.

Examples:(Input1, Input2 --> Output (explanation)))

1, 1 --> "10" (1 + 1 = 2 in decimal or 10 in binary)
5, 9 --> "1110" (5 + 9 = 14 in decimal or 1110 in binary)

Binary
Fundamentals
*/
using System;

public static class Kata
{
    public static string AddBinary(int a, int b)
    {
        return Convert.ToString((a+b),2);
    }
}