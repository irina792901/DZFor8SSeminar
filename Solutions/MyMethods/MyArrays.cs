namespace MyMethods;
using static System.Console;
public class MyArrays
{
    public static int GetIntegerNumber()
    {
        return new Random().Next(1, 20);
    }

   
///<summary>
///получить из запроса натуральное число
///</summary>
    public static int InputNaturalNumber(string text)
    {
        int result = 0;
        while (result <= 0)
        {
            WriteLine($"Введите {text} двумерного массива: ");
            result = int.Parse(ReadLine()!);
        }
        return result;
    }
    
///<summary>
///получить из запроса целое число
///</summary>
    public static int Input(string text)
    {
        WriteLine($"Введите {text} двумерного массива: ");
        int result = int.Parse(ReadLine()!);
        return result;
    }

    public static int[] InputParameters(string text)
    {
        WriteLine(text);
        int[] result = ReadLine()!
             .Split(" ", StringSplitOptions.RemoveEmptyEntries)
             .Select(x => int.Parse(x))
             .ToArray();
        return result;
    }

public static void SortArrayFromMaxToMin(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        for (int j = i + 1; j < inArray.Length; j++)
        {
            if (inArray[i] < inArray[j])
            {
                int temp = inArray[i];
                inArray[i] = inArray[j];
                inArray[j] = temp;
            }
        }
    }
    WriteLine(String.Join(" ", inArray));
}


public static int FindIndexMin(int[] array)
{
    int min = array[0];
    int index=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            index = i; 
        }
    }
    return index;
}




}
