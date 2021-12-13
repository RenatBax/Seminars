// Нахождение периметра треугольника

int Perimetr(int x, int y)
{
    return 2 * (x + y);
}

int a, b;
Console.Write("a: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("b: ");
b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Perimetr(a, b));
