// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Введите размерность");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите размерность");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows,columns];

void GetArray()
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0,10);
        }
    }
}

void PrintArray()
{
      for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j]+ " ");
        }
        Console.WriteLine();
    }
}
 GetArray();
PrintArray();
Console.WriteLine();

for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int k = j + 1; k < matrix.GetLength(1); k++)
                {
                    if (matrix[i, j] < matrix[i, k])
                    {
                        int temp = matrix[i, j];
                        matrix[i, j] = matrix[i, k];
                        matrix[i, k] = temp;
                    }
                }
            }
        }

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите размерность");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите размерность");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int[,] matrix = new int[rows,columns];

void GetArray()
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0,10);
        }
    }
}
void PrintArray()
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j]+ " ");
        }
        Console.WriteLine();
    }
}
GetArray();
PrintArray();
Console.WriteLine();

int minSumRow = 0;
int minSum = SumRow(matrix, 0);

        for (int i = 1; i < matrix.GetLength(0); i++)
        {
            int currentSum = SumRow(matrix, i);
            if (currentSum < minSum)
            {
                minSum = currentSum;
                minSumRow = i;
            }
        }

        Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRow + 1}");

   int SumRow(int[,] matrix, int row)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[row, j];
        }
        return sum;
    }

int sum=0;
 for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                  if (matrix[i, 0] < matrix.GetLength(1))
                    {
                        sum+=matrix[i, 0];
                    }
              }
         }


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите размерность матриц");
int rows = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows,rows];
int[,] matrix2 = new int[rows,rows];

void GetArray()
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0,10);
               Console.Write(matrix[i,j]+ " ");
        }
        Console.WriteLine();
    }
Console.WriteLine();

     for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            matrix2[i,j] = new Random().Next(0,10);
               Console.Write(matrix2[i,j]+ " ");
        }
        Console.WriteLine();
    }
}
GetArray();
Console.WriteLine();

int[,] result = new int[rows, rows];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < rows; j++)
    {
        for (int k = 0; k < rows; k++)
        {
            result[i, j] += matrix[i, k] * matrix2[k, j];
        }
    }
}
Console.WriteLine("Результат умножения матриц:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < rows; j++)
    {
        Console.Write(result[i, j] + " ");
    }
    Console.WriteLine();
}


Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)

Console.WriteLine("Введите размерность");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите размерность");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите размерность");
int content = Convert.ToInt32(Console.ReadLine());

int[,,] matrix = new int[rows,columns,content];

void GetArray()
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i,j,k] = new Random().Next(10,100);
            }
        }
    }
}
void PrintArray()
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}
GetArray();
PrintArray();

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 0

int[,] spiral = new int[4,4];
int number = 1;
int rowStart = 0, rowLast = 3;
int colStart = 0, colEnd = 3;

while (rowStart <= rowLast && colStart <= colEnd)
{
    for (int i = colStart; i <= colEnd; i++)
    {
        spiral[rowStart, i] = number++;
    }
    rowStart++;

    for (int i = rowStart; i <= rowLast; i++)
    {
        spiral[i, colEnd] = number++;
    }
    colEnd--;

    for (int i = colEnd; i >= colStart; i--)
    {
        spiral[rowLast, i] = number++;
    }
    rowLast--;

    for (int i = rowLast; i >= rowStart; i--)
    {
        spiral[i, colStart] = number++;
    }
    colStart++;
}

for (int i = 0; i < spiral.GetLength(0); i++)
{
    for (int j = 0; j < spiral.GetLength(1); j++)
    {
        if (spiral[i,j]<10)
        {
            Console.Write("0"+spiral[i, j] + " ");
        }
        else
        {
            Console.Write(spiral[i, j] + " ");
        }
    }
    Console.WriteLine();
}