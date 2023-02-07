//Ищем максимум из 9 чисел
//              0   1   2   3   4   5   6   7   8
// int[] array = { 11, 21, 31, 41, 51, 16, 17, 18, 91 } ;
// array[0] = 12;
// System.Console.WriteLine(array[4]);



// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }
// int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));
// Console.WriteLine(max);



// int[] array = { 11, 21, 31, 91, 51, 16, 17, 18, 91 };
// int n = array.Length;
// int find = 91;
// int index = 0;
// while (index < n)
// {
//     if (array[index] == find) 
//     {
//         Console.WriteLine(index);
//         break;
//     }
//     index++;
// }



void FillArray(int[] collection)
{
int length = collection.Length;
int index = 0;
while (index < length)
{
    collection [index] = new Random().Next(0, 10);
    index++;
}
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        System.Console.WriteLine(col[position]);
        position++; 
    }
} 
int IndexOff (int [] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
int [] array = new int [10];
FillArray(array);
array [4] = 4;
array [6] = 4;
PrintArray(array);
System.Console.WriteLine();
int pos = IndexOff(array, 444);
System.Console.WriteLine(pos);

