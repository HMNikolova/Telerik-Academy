﻿// 1. Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.

using System;


class FiveVariables
{
    static void Main()
    {
        ushort var1 = 52130; // because the number is between 0 and 65535
        sbyte var2 = -115; // because the number is between -128 and 127
        int var3 = 4825932; // because the number is between -2147483648 and 2147483647
        byte var4 = 97; // because the number is lower than 255
        short var5 = -10000; // because the number is between -32768 and 32767



        Console.WriteLine("Print the variables: {0} {1} {2} {3} {4}", var1, var2, var3, var4, var5);
    }
}