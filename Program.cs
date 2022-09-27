/* Console.WriteLine("Input number");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Input number");
int m = int.Parse(Console.ReadLine());
int Sum(int n, int m)
{
int sum = n;
while(n<=m)
{if(n == m) return m;
else return n+Sum(n+1, m);
}
  return Sum(n, m);
}
Console.WriteLine(Sum(n, m)); */



/* Console.WriteLine("Input number");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Input number");
int m = int.Parse(Console.ReadLine());
string result(int n, int m)
{
    if(n<=m) return  $"{n}"+ " " + result(n+1, m);
    else return $"";
}
Console.WriteLine(result(n, m)); */


/* int Akerman(int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return Akerman(n - 1, 1);
    if (n > 0 && m > 0) return Akerman(n - 1, Akerman(n, m - 1));
    return Akerman(n,m);
}

Console.Write(Akerman(2, 3)); */
