using System;
using System.Linq;
using static System.Console;
namespace MyMethods;
public class MyMatrixes
{
 
    public static int[,] GetIntegerMatrix(int rows, int colums, int minValue, int maxValue)
    {
        int[,] result = new int[rows, colums];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colums; j++)
            {
                result[i, j] = new Random().Next(minValue, maxValue + 1);
            }
        }
        return result;
    }


    public static double[,] GetRealMatrix(int lines, int top, int[] parametersArray)
    {
        double[,] result = new double[lines, top];
        for (int i = 0; i < lines; i++)
        {
            for (int j = 0; j < top; j++)
            {
                result[i, j] = Math.Round(new Random().Next(parametersArray[0], parametersArray[1] + 1) +
                new Random().NextDouble(), 2);
            }
        }
        return result;
    }

///<summary>
///вещественная матрица
///</summary>
    public static void PrintMatrix(double[,] inArray)
    {
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                Write($"{inArray[i, j]}   ");
            }
            WriteLine();// возврат каретки
        }
    }
///<summary>
///целочисленная матрица
///</summary>
  public static void PrintMatrix(int[,] inArray)
    {
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                Write($"{inArray[i, j]}   ");
            }
            WriteLine();// возврат каретки
        }
    }
///<summary>
///вывод строковой матрицы
///>/summary?
 public static void PrintMatrix(string[,] inArray)
    {
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                Write($"{inArray[i, j]}   ");
            }
            WriteLine();// возврат каретки
        }
    }

public static void FindElementByIndex(int[] indexes, int[,] inArray)
{
    if ((inArray.GetLength(0)<indexes[0])
    || (inArray.GetLength(1)<indexes[1]))
    {
    WriteLine("Такого элемента нет");
    }
    else WriteLine(inArray[indexes[0],indexes[1]]);
}


public static double[] FindArithmeticMeanOfColumns(int[,] integerMatrix)
{
    int count = integerMatrix.GetLength(1);
    double[] result = new double[count];
    for (int i = 0; i < integerMatrix.GetLength(1); i++)
    {
        int sum = 0;
        for (int j = 0; j < integerMatrix.GetLength(0); j++)
        {
            sum +=integerMatrix[j, i];

        }
        result[i]= (double)sum/count;
    }
    return result;
}

public static void SortMatrixFromMaxToMinInRow(int[,] inMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        int[] arrayRow = new int[inMatrix.GetLength(1)];
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            arrayRow[j] = inMatrix[i, j];
        }
        MyArrays.SortArrayFromMaxToMin(arrayRow);
    }
}

public static int[,] SortMatrixFromMaxToMinInRowSingle(int[,] inMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            for (int index = j + 1; index < inMatrix.GetLength(1); index++)
            {
                if (inMatrix[i, j] < inMatrix[i, index])
                {
                    int temp = inMatrix[i,j];
                    inMatrix[i,j]= inMatrix[i,index];
                    inMatrix[i,index] = temp;
                }
            }

        }

    }
    return inMatrix;
}


public static int[] CreateArrayFromSummaryRowsMatrix(int[,] matrix)
{
    int[] newArray = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        newArray[i] = sum;
    }
    return newArray;
}


public static void MultiplicationMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    if (firstMatrix.GetLength(0) == secondMatrix.GetLength(1)
    && firstMatrix.GetLength(1) == secondMatrix.GetLongLength(0))
    {
        int[,] result = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
        for (int i = 0; i < firstMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < secondMatrix.GetLength(1); j++)
            {
                for (int k = 0; k < secondMatrix.GetLength(0); k++)
                {
                    result[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
                }
            }
        }
        MyMatrixes.PrintMatrix(result);
    }
    else WriteLine("Невозможно перемножить данныые матрицы");
}


public static int[,,] Get3DMatrix(int rows, int colums, int levels, int minValue, int maxValue)
{
    int[,,] matrix3D = new int[rows, colums, levels];
    for (int z = 0; z < levels; z++)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colums; j++)
            {
                matrix3D[i, j, z] = new Random().Next(minValue, maxValue + 1);
            }
        }
    }
    return matrix3D;
}

public static void Print3DMatrix(int[,,] inMatrix3D)
{
    for (int z = 0; z < inMatrix3D.GetLength(2); z++)
    {
        for (int i = 0; i < inMatrix3D.GetLength(0); i++)
        {
            for (int j = 0; j < inMatrix3D.GetLength(1); j++)
            {
                Write($"{inMatrix3D[i, j, z]}({i},{j},{z}) ");
            }
            WriteLine();
        }
    }
}



public static int[,,] Get3DUniqueMatrix(int rows, int colums, int levels, int minValue, int maxValue)
{
    int[,,] matrix3D = new int[rows, colums, levels];
    for (int z = 0; z < levels; z++)
    {
        for (int i = 0; i < rows; i++)
        {
            int number = new Random().Next(minValue, maxValue + 1);
            for (int j = 0; j < colums; j++)
            {
                while (FindElementIn3DMatrix(number, matrix3D))
                {
                    number = new Random().Next(minValue, maxValue + 1);
                }
                matrix3D[i, j, z] = number;
            }
        }
    }
    return matrix3D;
}

public static bool FindElementIn3DMatrix(int element, int[,,] array)
{
    bool result = false;
    for (int z = 0; z < array.GetLength(0); z++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = 0; j < array.GetLength(2); j++)
            {
                if (element == array[i, j, z]) result = true;
            }
        }
    }
    return result;
}

public static string[,] GetSpiralMatrix(int rows, int colums)
{
    string[,] spiralMatrix = new string[rows, colums];
    int i, j, temp, a;
    temp = 0;
    a = 1;
    while ((rows - 2 * temp) * (colums - 2 * temp) != 0)//формулу можно представит ьв виде 
                                                        //среза булки хлеба с корочкой и мы ищем площадь мякиша
    {
        i = temp;
        for (j = temp; j < colums - 1 - temp; j++)
        {

            spiralMatrix[i, j] = a.ToString("00");
            a++;
        }
        for (i = temp; i < rows - 1 - temp; i++)
        {
            spiralMatrix[i, j] = a.ToString("00") ;
            a++;
        }
        for (j = colums - 1 - temp; j > temp; j--)
        {
            spiralMatrix[i, j] = a.ToString("00");
            a++;
        }
        for (i = rows - 1 - temp; i > temp; i--)
        {
            spiralMatrix[i, j] = a.ToString("00");
            a++;
        }
        temp++;
    }
    return spiralMatrix;
}


}


