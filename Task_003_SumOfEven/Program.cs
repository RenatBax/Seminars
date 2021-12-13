// Сумма четных чисел из 15

int sumOfEven = 0, sumOfOdd = 0, i = 1;
while (i <= 15)
{
    if (i%2 == 0) sumOfEven = sumOfEven + i; 
    
    if (i%2 != 0) sumOfOdd = sumOfOdd + i; // для нечетных
    i++;
}
Console.WriteLine(sumOfEven);
Console.WriteLine(sumOfOdd);