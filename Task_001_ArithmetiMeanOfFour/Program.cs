// Среднеарифметическое четырех чисел
double a, b, c, d, S;

Console.Write("a: ");
a = Convert.ToDouble(Console.ReadLine());
Console.Write("b: ");
b = Convert.ToDouble(Console.ReadLine());
Console.Write("c: ");
c = Convert.ToDouble(Console.ReadLine());
Console.Write("d: ");
d = Convert.ToDouble(Console.ReadLine());

S = (a  + b + c + d) / 4;
Console.WriteLine($"Среднеарифметическое из четырех чисел, равно: {S} ");
