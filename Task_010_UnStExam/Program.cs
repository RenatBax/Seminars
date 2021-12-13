// Задача из ЕГЭ
// Дан целочисленный массив из 30 элементов. 
// Элементы массива могут принимать целые значения от 0 до 100.
// Опишите программу, которая находит и выводит произведение элементов массива,
// которые имеют четное значение и не оканчиваются на 0.

int[] CreateArray(int n)
{
    int[] array = new int[n];
    Random rnd = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 101);
    }
    return array;
}
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int[] arr = CreateArray(30);
PrintArray(arr);
Console.WriteLine();
long p = 1;
for(int i = 0; i < arr.Length; i++)
{
    if(arr[i]%2 == 0 && arr[i]%10 != 0)
    {
        p = p * arr[i];
        Console.WriteLine(arr[i]);
    }
}

Console.WriteLine(p);

