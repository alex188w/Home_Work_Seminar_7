void Zadacha47()
// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
{
    Console.WriteLine("Введите число m ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число n ");
    int n = Convert.ToInt32(Console.ReadLine());
    
    int rows =  m;
    int colums = n;
    double[,] array = new double[rows, colums];

    FillArrayDouble(array);
    Console.WriteLine("Заданный массив ");
    PrintArrayDouble(array);
}

void Zadacha50()
// Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет
{
    Random random = new Random();
    int rows = random.Next(4, 10);
    int colums = random.Next(4, 10);
    int[,] array = new int[rows, colums];
    FillArray(array, 0, 10);
    Console.WriteLine("Заданный массив ");
    PrintArray(array);

    Console.WriteLine("Введите номер строки нужного элемента ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер столбца нужного элемента");
    int n = Convert.ToInt32(Console.ReadLine());
    if((m-1) >= rows || m <= 0 || (n-1) >= colums || n <= 0 ) Console.WriteLine("Такого элемента нет в массиве ");
    else Console.WriteLine("Значение данного элемента: " + array[m-1, n-1]);
}

void Zadacha52()
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце
{
    Random random = new Random();
    int rows = random.Next(4, 8);
    int colums = random.Next(4, 8);
    int[,] array = new int[rows, colums];
    FillArray(array, 0, 10);
    Console.WriteLine("Заданный массив ");
    PrintArray(array);
    Console.WriteLine("Среднее арифметическое столбцов элементов массива равно ");
    for (int j = 0; j < colums; j++) 
    {
        double sum = 0;
        for (int i = 0; i < rows; i++)
        {
            sum = sum + array[i, j];   
        }
        
        Console.Write(Math.Round(sum/rows, 1) + "\t");
    }
    Console.WriteLine();
}

void FillArrayDouble(double[,] array) 
{
    Random random = new Random();
    int rows =  array.GetLength(0);
    int colums = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            array[i, j] = random.Next(-100, 100) + random.NextDouble();   
        }
    }       
}

void PrintArrayDouble(double[,] array)    
{   
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
              Console.Write(Math.Round(array[i, j], 1) + "\t");
        }
        Console.WriteLine();
    }    
}

void FillArray(int[,] array, int startNumber, int finishNumder)
{
    Random random = new Random();
    finishNumder++;
    int rows =  array.GetLength(0);
    int colums = array.GetLength(1);

    for (int i = 0; i < rows; i++) 
    {
        for (int j = 0; j < colums; j++)
        {
            array[i, j] = new Random().Next(startNumber, finishNumder);   
        }
    }
}

void PrintArray(int[,] array)
{
    int rows =  array.GetLength(0);
    int colums = array.GetLength(1);

    for (int i = 0; i < rows; i++) 
    {
        for (int j = 0; j < colums; j++)
        {
              Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

//Zadacha47();
//Zadacha50();
Zadacha52();


