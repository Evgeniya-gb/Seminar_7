// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Задайте количество строк двумерного массива:");
int lines = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Задайте количество столбцов двумерного массива:");
int colomns = Convert.ToInt32(Console.ReadLine());

Console.Clear();

double[,] Array = new double[lines, colomns];
Random rnd = new Random();
void PrintArray(double[,] matr)
{ for (int i = 0; i < lines; i++)
 { for (int j = 0; j < colomns; j++)
 { Console.Write($"{matr[i, j]} ");}
 Console.WriteLine();}}

void FillArray(double[,] matr)
{ for (int i = 0; i < lines; i++)
 { for (int j = 0; j < colomns; j++)
 { matr[i,j] = Convert.ToDouble(rnd.Next(-100, 100)/10.0);}}}
FillArray(Array);
Console.WriteLine();
PrintArray(Array);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Введите номер строки: ");
int line = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер столбца: ");
int colomn = Convert.ToInt32(Console.ReadLine());

Console.Clear();

int [,] numbers = new int [10,10];
FillArrayRandomNumbers(numbers);

if (line > numbers.GetLength(0) || colomn > numbers.GetLength(1))
{
 Console.WriteLine("Такого числа в массиве нет.");
}
else
{
 Console.WriteLine($"Значение элемента {line} строки и {colomn} столбца = {numbers[line-1,colomn-1]}");
}

PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
 for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100)/10;
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Введите количество строк массива: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int colomn = Convert.ToInt32(Console.ReadLine());

Console.Clear();

int[,] array = new int[line, colomn];
FillArrayRandomNumbers(array);


for (int j = 0; j < array.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        avarage = (avarage + array[i, j]);
    }
    avarage = avarage / line;
    Console.Write(avarage + "; ");
}
Console.WriteLine();
PrintArray(array);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
