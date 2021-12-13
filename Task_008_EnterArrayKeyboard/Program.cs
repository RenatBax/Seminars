// ВВод масивы с клавиатуры

int[] array = new int[10];

for(int i = 0; i < 10; i++)
{
    string s = Console.ReadLine();
    array[i] = Convert.ToInt32(s);
}

for(int j = 0; j < 10; j++)
{
    Console.Write(array[j] +" ");
}

Console.WriteLine();

