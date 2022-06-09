// 3. Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента
Console.WriteLine("Введите количество строк в массиве: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите глубину массива: ");
int c = int.Parse(Console.ReadLine());
Console.WriteLine("----------------------------------------");

int[,,] MASS3D = new int[a, b, c];
int index = 20;

for (int i = 0; i < MASS3D.GetLength(0); i++)
{
    for (int j = 0; j < MASS3D.GetLength(1); j++)
    {
        for (int k = 0; k < MASS3D.GetLength(2); k++)
        {
            MASS3D[i, j, k] = index;
            Console.WriteLine($" Элемент массива {MASS3D[i,j,k]} имеет индексы i = {i}, j = {j}, k = {k} ");
            index++;
        }
    }
}











