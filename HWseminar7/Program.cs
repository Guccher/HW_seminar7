// Задача № 47

// double[,] array = new double[3, 4];
// Random random = new Random();
// for (int i = 0; i < 3; i++)
// {
//     for (int j = 0; j < 4; j++)
//     {
//         array[i, j] = random.NextDouble() * 100;
//         Console.Write("{0,8:F2}", array[i, j]);
//     }
//     Console.WriteLine();
// }


// Задача № 50

// int[,] CreateRandomArray(int SizeLines, int SizeColumns, int MinValue, int MaxValue)
// {
//     int[,] matrix = new int[SizeLines, SizeColumns];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(MinValue, MaxValue);

//         }
//     }
//     return matrix;
// }

// void ShowArray(int[,] matrix)
// {

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]}\t");
//         }
//         Console.WriteLine();
//     }

// }

// Console.Write("Input lines size: ");
// int SizeLines = int.Parse(Console.ReadLine()!);
// Console.Write("Input columns size: ");
// int SizeColumns = int.Parse(Console.ReadLine()!);
// Console.Write("Input minimal value: ");
// int MinValue = int.Parse(Console.ReadLine()!);
// Console.Write("Input maximal value: ");
// int MaxValue = int.Parse(Console.ReadLine()!);
// Console.Write("Input requied element: ");
// int RequiredElement = int.Parse(Console.ReadLine()!);
// int[,] array = CreateRandomArray(SizeLines, SizeColumns, MinValue, MaxValue);
// ShowArray(array);
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         if (RequiredElement == array[i, j])
//         {
//             Console.Write("{0,5}", RequiredElement);
//         }
//         else
//         {
//             Console.Write("");
            
//         }
//     }
// }

// задача № 52

// double[,] CreateRandomArray(int SizeLines, int SizeColumns, int MinValue, int MaxValue)
// {
//     double[,] matrix = new double[SizeLines, SizeColumns];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(MinValue, MaxValue);

//         }
//     }
//     return matrix;
// }

// void ShowArray(double[,] matrix)
// {

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]}\t");
//         }
//         Console.WriteLine();
//     }

// }

// Console.Write("Input lines size: ");
// int SizeLines = int.Parse(Console.ReadLine()!);
// Console.Write("Input columns size: ");
// int SizeColumns = int.Parse(Console.ReadLine()!);
// Console.Write("Input minimal value: ");
// int MinValue = int.Parse(Console.ReadLine()!);
// Console.Write("Input maximal value: ");
// int MaxValue = int.Parse(Console.ReadLine()!);
// double[,] array = CreateRandomArray(SizeColumns, SizeLines, MinValue, MaxValue);
// ShowArray(array);
// for (int i = 0; i < array.GetLength(1); i++)
// {
//     double ArithmeticMean = 0;
//     double AmountColumns = 0;
//     for (int j = 0; j < array.GetLength(0); j++)
//     {
//         AmountColumns += array[j, i];
//         ArithmeticMean = AmountColumns / SizeColumns;
//     }
//     Console.WriteLine("Sum in {0} column: {1}", i, ArithmeticMean);

// }



