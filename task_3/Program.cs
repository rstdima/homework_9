// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Например, заданы 2 массива:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// и

// 1 5 8 5

// 4 9 4 2

// 7 2 2 6

// 2 3 4 7

// Их произведение будет равно следующему массиву:

// 1 20 56 10

// 20 81 8 6

// 56 8 4 24

// 10 6 24 49
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

int[,] m = new int[size, size];
int[,] n = new int[size, size];

FillArrayRandomNumbers(m);
FillArrayRandomNumbers(n);

int[,] number = new int[size, size];

void FillArrayRandomNumbers(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         array[i, j] = new Random().Next(1, 10);
      }
   }
}

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


for (int i = 0; i < size; i++)
{
   for (int j = 0; j < size; j++)
   {
      for (int k = 0; k < size; k++)
      {
         number[i, j] = number[i, j] + (m[i, k] * n[k, j]);
      }
   }
}
Console.WriteLine("Первая матрица");
PrintArray(m);
Console.WriteLine();
Console.WriteLine("Вторая матрица");
PrintArray(n);
Console.WriteLine();
Console.WriteLine("Произведение матриц");
PrintArray(number);
