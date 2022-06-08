// 1. Найти произведение двух матриц

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

Console.WriteLine("Введите количество строк в массиве №1: ");
int a1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве №1: ");
int b1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество строк в массиве №2: ");
int a2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве №2: ");
int b2 = int.Parse(Console.ReadLine());

Console.WriteLine("----------------------------------------");

if (b1 != a2) Console.WriteLine("Матрицы заданной размерности невозможно умножить!");
else 
{
int[,] MASS1 = new int[a1, b1];
int[,] MASS2 = new int[a2, b2];
int[,] MASS3 = new int[a1, b2];

FillArray(MASS1);
PrintArray(MASS1);

FillArray(MASS2);
PrintArray(MASS2);

for (int i = 0; i < MASS1.GetLength(0); i++)
{
    for (int j = 0; j < MASS2.GetLength(1); j++)
    {
         for (int k = 0; k < MASS2.GetLength(0); k++)
                {
                    MASS3[i, j] += MASS1[i, k] * MASS2[k, j];
                }
    }
}
Console.WriteLine("Произведение двух матриц равно:  ");
PrintArray(MASS3);
}