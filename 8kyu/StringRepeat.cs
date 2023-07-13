/*
8kyu String Repeat
Description:

Write a function that accepts an integer n and a string s as parameters, and returns a string of s repeated exactly n times.
Examples (input -> output)

6, "I"     -> "IIIIII"
5, "Hello" -> "HelloHelloHelloHelloHello"

Fundamentals
Strings
*/
using System;
using System.Linq;

public class StringRepeat
{
    // function accepts an integer n and a string s as parameters, returns a string of s repeated
      // exactly n times;
    public static string RepeatStr(int n, string s) => string.Concat(Enumerable.Repeat(s,n));
}