/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 
1 строка
*/
using MyMethods;
using static System.Console;
int[,] integerMatrix = MyMatrixes.GetIntegerMatrix(4, 4, 0, 9);
MyMatrixes.PrintMatrix(integerMatrix);
int[] arraySummaryRows = MyMatrixes.CreateArrayFromSummaryRowsMatrix(integerMatrix);
int numberOfString =MyArrays.FindIndexMin(arraySummaryRows)+1;
WriteLine($"{numberOfString} строка с наименьшей суммой элементов");




