// 4. Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника

Console.WriteLine("Введите n для треугольника Паскаля");
int n = int.Parse(Console.ReadLine());
int space=0;
 
int Factorial (int n)
{
    if (n==0 || n==1 ) return 1;
    else return n*Factorial(n-1);
}

for (int i =0; i<=n; i++)
{ Console.WriteLine();
    for (space=((n-i)*2); space>0; space--)
        {
            Console.Write(" "); 
        }
    
    for (int j =0; j<i+1; j++)
    {
        
         Console.Write($" {Factorial(i)/(Factorial(j)*Factorial(i-j))} ");
    }
}




