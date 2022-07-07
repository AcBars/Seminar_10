/***Задача 72:** Заданы 2 массива: info и data. В массиве info хранятся двоичные представления
нескольких чисел (без разделителя). В массиве data хранится информация о количестве бит,
которые занимают числа из массива info. Напишите программу, которая составит массив десятичных
представлений чисел массива data с учётом информации из массива info.

Комментарий: первое число занимает 2 бита (01 -> 1); второе число занимает 3 бита (111 -> 7);
третье число занимает 3 бита (000 -> 0; четвёртое число занимает 1 бит (1 -> 1)
входные данные:
data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
info = {2, 3, 3, 1 }

выходные данные:
1, 7, 0, 1
*/

using System;
using static System.Console;
Clear();

int[] GetResultArray(int[] dataArray, int[] infoArray)
{
    int[] result = new int[infoArray.Length];
    string data = String.Join("", dataArray);
    for (int i = 0; i < result.Length; i++)
    {
        string subData = data.Substring(0, infoArray[i]);
        result[i] = Convert.ToInt32(subData, 2);
        data = data.Remove(0, infoArray[i]);
    }
    return result;
}
