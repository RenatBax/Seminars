// Задача по обнулению массива

// int[] array;
// array = new int[10];

int[] array = {4, 4, 6, 3, 8, 7, 9, 2, 22, 5};
// первый способ
int i = 0;
for(i = 0; i < 10; i++)
{
    Console.WriteLine(array[i]);
}
// while (i < 10)
// {
//     array[i] = 0;
//     Console.WriteLine(array[i]);
//     i++;
// }

// второй способ
int j = 0;
for(j = 0; j < 10; j++)
{
    array[j] = 0;
}

for(j = 0; j < 10; j++)
{
    Console.Write(array[j] + " ");
}