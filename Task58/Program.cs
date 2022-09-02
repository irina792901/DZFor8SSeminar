/*
Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
using MyMethods;
using static System.Console;
int[,] matrix1 = MyMatrixes.GetIntegerMatrix(2, 2, 1, 9);
int[,] matrix2 = MyMatrixes.GetIntegerMatrix(2, 2, 1, 9);
// матрицы можно перемножать, если число строк первой равно числу столбцов в другой!
// NB! правило суммируем произведение строки1 на столбец2 
MyMatrixes.PrintMatrix(matrix1);
WriteLine("Это первая матрица");
WriteLine();
MyMatrixes.PrintMatrix(matrix2);
WriteLine("Это вторая матрица");
WriteLine();
MyMatrixes.MultiplicationMatrix(matrix1, matrix2);
WriteLine("Это результат перемножения матриц");

