using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class Calculate
{
static void Main()
{
int n = int.Parse(Console.ReadLine());
int k = int.Parse(Console.ReadLine());
BigInteger result = 0;
result = fact(n) / fact(k);
Console.WriteLine(result);
}
private static BigInteger fact(int number)
{
BigInteger result = 1;
for (int i = 1; i <= number; i++)
{
result *= i;
}
return result;
}
}
