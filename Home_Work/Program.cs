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
              Console.Write(Math.Round(array[i, j], 2) + "\t");
        }
        Console.WriteLine();
    }    
}

Zadacha47();


