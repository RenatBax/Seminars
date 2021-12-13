// Заполнение массива случайными числами


int[] arrayRandom = new int[10];

//Random rnd = new Random().Next(0, 100);
for(int i = 0; i < 10; i++)
{
    arrayRandom[i] = new Random().Next(0, 100);
}

for(int i = 0; i < 10; i++)
{
    Console.Write(arrayRandom[i] +" ");
}
