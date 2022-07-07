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
WriteLine(String.Join(", ", Encrypt(new int[]{0, 1, 1, 1, 1, 0, 0, 0, 1 }, new int[]{2, 3, 3, 1 })));


double[] Encrypt(int[] data, int[] info) {
	double[] result = new double[info.Length];
	int count = 0;
	for (int i = 0; i < info.Length; i ++ )
		for (int j = 0; j < info[i]; j ++) {
			result[i] += data[count] * Math.Pow(2, info[i] - j - 1);
			count ++;
		}
	return result;
}
