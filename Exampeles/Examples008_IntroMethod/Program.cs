﻿//Ищем максимум из 9 чисел

int a1 = 11;
int b1 = 21;
int c1 = 3129;
int a2 = 12;
int b2 = 23;
int c2 = 324448;
int a3 = 13;
int b3 = 23111;
int c3 = 33;

// старый метод решения
//int max = a1;
// if (b1 > max) max = b1;
// if (c1 > max) max = c1;

// if (b2 > max) max = b2;
// if (b2 > max) max = b2;
// if (c2 > max) max = c2;

// if (b3 > max) max = b3;
// if (b3 > max) max = b3;
// if (c3 > max) max = c3;

// System.Console.WriteLine(max);
int Max(int arg1, int arg2, int arg3)
{
int result = arg1;
if (arg2 > result) result = arg2;
if (arg3 > result) result = arg3;
return result;
}
// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);
int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));



Console.WriteLine(max);

