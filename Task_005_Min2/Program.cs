// Нахождение минимального из 2

int min(int x, int y)
{
    if (x > y) return y;
    else return x;
}

int a, b;
Console.Write("a: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("b: ");
b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Минимальное из двух, равно " + min(a, b));