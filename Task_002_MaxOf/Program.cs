// Максимальное из двух

int a, b, max;
Console.Write("a: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("b: ");
b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    max = a;
}
else max = b;
Console.WriteLine("Максимальное из двух, равно " +max);
Console.WriteLine("Max"+max.ToString()); //Console.WriteLine("Max="+max);