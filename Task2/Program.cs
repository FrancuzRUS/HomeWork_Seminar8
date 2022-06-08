// 2. В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

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

Console.WriteLine("Введите количество строк в массиве: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("----------------------------------------");

int[,] MASS1 = new int[a, b];
int[,] MASS2 = new int[a-1, b-1];
int imin = 0;
int jmin = 0;
int iDEL = 0;
int jDEL = 0;

FillArray(MASS1);
PrintArray(MASS1);

for (int i = 0; i < MASS1.GetLength(0); i++)      //поиск минимального элемента по индексу
{
    for (int j = 0; j < MASS1.GetLength(1); j++)
    {
        if (MASS1[i, j] < MASS1[imin, jmin])
        {
            imin = i; jmin = j;
        }
    }
}

for (int i = 0; i < MASS1.GetLength(0)-1; i++)
{
    if (i >= imin) iDEL = i + 1;
    else iDEL = i;
    {
        for (int j = 0; j < MASS1.GetLength(1)-1; j++)
        {
            if (j >= jmin) jDEL = j + 1;
            else jDEL = j;
            {
                MASS2[i, j] = MASS1[iDEL, jDEL];
            }
        }
    }
}

Console.WriteLine($"Минимальный элемент равен {MASS1[imin, jmin]} индексы равны i = {imin}  j = {jmin} ");
Console.WriteLine("Итоговый массив имеет вид: ");
PrintArray(MASS2);
