// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.WriteLine("Введите размерность");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите размерность");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[rows,columns];

// void GetArray()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = new Random().Next(0,10);
//         }
//     }
// }

// void PrintArray()
// {
//       for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i,j]+ " ");
//         }
//         Console.WriteLine();
//     }
// }
//  GetArray();
// PrintArray();
// Console.WriteLine();

// for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 for (int k = j + 1; k < matrix.GetLength(1); k++)
//                 {
//                     if (matrix[i, j] < matrix[i, k])
//                     {
//                         int temp = matrix[i, j];
//                         matrix[i, j] = matrix[i, k];
//                         matrix[i, k] = temp;
//                     }
//                 }
//             }
//         }

//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 Console.Write(matrix[i, j] + " ");
//             }
//             Console.WriteLine();
//         }


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Console.WriteLine("Введите размерность");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите размерность");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[rows,columns];

// void GetArray()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = new Random().Next(0,10);
//         }
//     }
// }
// void PrintArray()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i,j]+ " ");
//         }
//         Console.WriteLine();
//     }
// }
// GetArray();
// PrintArray();
// Console.WriteLine();

// int minSumRow = 0;
// int minSum = SumRow(matrix, 0);

//         for (int i = 1; i < matrix.GetLength(0); i++)
//         {
//             int currentSum = SumRow(matrix, i);
//             if (currentSum < minSum)
//             {
//                 minSum = currentSum;
//                 minSumRow = i;
//             }
//         }

//         Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRow + 1}");

//    int SumRow(int[,] matrix, int row)
//     {
//         int sum = 0;
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             sum += matrix[row, j];
//         }
//         return sum;
//     }

// int sum=0;
//  for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                   if (matrix[i, 0] < matrix.GetLength(1))
//                     {
//                         sum+=matrix[i, 0];
//                     }
//               }
//          }


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18