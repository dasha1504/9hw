/* Console.WriteLine("Input number");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Input number");
int m = int.Parse(Console.ReadLine());
for(int i = n; i<=m; i++)
{
Console.Write($"{i},");
} */
/* Console.WriteLine("Input number");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Input number");
int m = int.Parse(Console.ReadLine());
int sum = 0;
for(int i = n; i<=m; i++)
{
sum = sum+i;
}
Console.Write($"{sum}"); */
/* int Akerman(int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return Akerman(n - 1, 1);
    if (n > 0 && m > 0) return Akerman(n - 1, Akerman(n, m - 1));
    return Akerman(n,m);
}

Console.Write(Akerman(2, 3)); */