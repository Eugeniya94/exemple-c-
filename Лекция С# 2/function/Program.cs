﻿int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;

    }

int a1 = 28;
int b1 = 5;
int c1 = 8;
int a2 = 6;
int b2 = 52;
int c2 = 89;
int a3 = 257;
int b3 = 53;
int c3 = 87;

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);

int max = Max (Max(a1, b1, c1),
               Max(a2, b2, c2),
               Max(a3, b3, c3));

Console.WriteLine(max);



