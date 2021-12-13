// Нахождение махимального из 3

int maxOfThree(int a, int b, int c)
{
    if (a > b && a > c) return a;
    if (b > a && b > c) return b;
    else return c;
}
int a, b, c;
Console.WriteLine("Введите первое число: ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Максимальное из трех, равно " +maxOfThree(a, b, c));