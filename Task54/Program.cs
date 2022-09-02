/*
Задача 54: Задайте двумерный массив. Напишите 
программу, которая упорядочит по убыванию элементы 
каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2

Я вижу 2 варианта: 
Вариант 1: просто разработать метод сортировки
строки двумерного массива


using MyMethods;
using static System.Console;
int[,] integerMatrix = MyMatrixes.GetIntegerMatrix(6, 10, -10, 10);
MyMatrixes.PrintMatrix(integerMatrix);
WriteLine(string.Empty);
MyMatrixes.PrintMatrix(MyMatrixes.SortMatrixFromMaxToMinInRowSingle(integerMatrix));



Вариант 2: перевести каждую строку двумерного 
массива в одномерный и использовать метод 
пузырьковой сортировки, показанной на предпоследнем
 семинаре.  
*/

using MyMethods;
using static System.Console;
int[,] integerMatrix = MyMatrixes.GetIntegerMatrix(6, 10, -10, 10);
MyMatrixes.PrintMatrix(integerMatrix);
WriteLine();
MyMatrixes.SortMatrixFromMaxToMinInRow(integerMatrix);
