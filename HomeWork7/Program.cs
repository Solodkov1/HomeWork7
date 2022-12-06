/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/
/*
double[,] Creat2DRandomArray (int min, int max, int m, int n)
{
    double[,] newArray = new double[m, n];
for (int i = 0; i < m; i ++)
    {
        for (int j = 0; j < n; j ++)
        {   
            newArray[i, j] = Math.Round(new Random().NextDouble(), 4) *100;
        }
        
    }
    return newArray;
}
void Show2DRandomArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i ++)
    {
        for (int j = 0; j < array.GetLength(1); j ++)
        {
            Console.Write(array[i, j] + "    ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Input min = ");
 int min = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Input max = ");
 int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input m = ");
 int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input n = ");
 int n = Convert.ToInt32(Console.ReadLine());
 
 Show2DRandomArray(Creat2DRandomArray(min, max, m, n));
 */
 /*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
 и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/

int[,] Creat2DRandomArray (int min, int max, int m, int n)
{
    int[,] newArray = new int[m, n];
for (int i = 0; i < m; i ++)
    {
        for (int j = 0; j < n; j ++)
        {   
            newArray[i, j] = new Random().Next(min, max);
        }
        
    }
    return newArray;
}
void Show2DRandomArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i ++)
    {
        for (int j = 0; j < array.GetLength(1); j ++)
        {
            Console.Write(array[i, j] + "    ");
        }
        Console.WriteLine();
    }
}
void ChekNumber (int [,] array, int number)
{   
    int firstNumber = number / 10;  //находим 1 цифру нашего числа
    int secondNumber = number % 10;
    if (firstNumber <= array.GetLength(0) && secondNumber <= array.GetLength(1)) 
    Console.WriteLine($"Your number  {array[firstNumber-1,secondNumber-1]}");
    else
    Console.Write("Rong Number");
}
Console.Write("Input number = ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] array = Creat2DRandomArray(0, 10, 3, 4);
Show2DRandomArray(array);
ChekNumber(array, number);

/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
/*
double[,] Creat2DRandomArray (int min, int max, int m, int n)
{
    double[,] newArray = new double[m, n];
for (int i = 0; i < m; i ++)
    {
        for (int j = 0; j < n; j ++)
        {   
            newArray[i, j] = new Random().Next(min, max);
        }
        
    }
    return newArray;
}
void Show2DRandomArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i ++)
    {
        for (int j = 0; j < array.GetLength(1); j ++)
        {
            Console.Write(array[i, j] + "    ");
        }
        Console.WriteLine();
    }
}
void MediumArifmet(double[,] array)
{       
    double mediumArifmet = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double summ = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
           summ = summ + array [i,j];
           Console.WriteLine($"{array [i, j]}");
        }
        Console.Write($"сумма {j+1} столбца {summ}");
        Console.WriteLine();
     Console.Write($"среднеарифметическое {j+1} столбец {mediumArifmet = summ /array.GetLength(1)}"); 
     Console.WriteLine();
    }
}

Console.Write("Input min = ");
 int min = Convert.ToInt32(Console.ReadLine());
 Console.Write("Input max = ");
 int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Input rows = ");
 int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input columns = ");
 int n = Convert.ToInt32(Console.ReadLine());
 double [,] array = Creat2DRandomArray(min, max, m, n);
 Show2DRandomArray(array);
 MediumArifmet(array);
 */