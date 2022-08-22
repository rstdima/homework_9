// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// В итоге получается вот такой массив:

// 1 2 4 7

// 2 3 5 9

// 2 4 4 8

Console.WriteLine("Введите число строк m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов n");
int n = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[m,n];

FillArrayRandomNumbers(numbers);
Console.WriteLine();
Console.WriteLine("Заданный массив");
PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         array[i, j] = new Random().Next(-10, 10);
      }
   }
}

for (int i = 0; i < numbers.GetLength(0); i++)
{
   for (int j = 0; j < numbers.GetLength(1) - 1; j++)
   {
      for (int z = 0; z < numbers.GetLength(1) - 1; z++)
      {
         if (numbers[i, z] > numbers[i, z + 1]) 
         {
            int temp = 0;
            temp = numbers[i, z];
            numbers[i, z] = numbers[i, z + 1];
            numbers[i, z + 1] = temp;
         }
      }
   }
}
Console.WriteLine();
Console.WriteLine("Упорядочный массив");
PrintArray(numbers);

void PrintArray(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         Console.Write(array[i, j] + " ");
      }
      Console.WriteLine("");
   }
}
