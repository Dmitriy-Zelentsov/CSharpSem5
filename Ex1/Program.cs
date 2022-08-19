// Задайте массив из 12 элемеентов,заполненный случайными числами
//из заданного промежутка [-9, 9].Найдите сумму отрицательных
//и положительных элементов масиива.

int [] CreateArray(int length, int min, int max)
{
    int [] array = new int [length];
    for (int i = 0; i < length; i++)
    {
        array [i] = new Random().Next(min, max+1);
    }
    return array;
}
void PrintArray(int[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
int FindPositiveSum(int [] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]>0)
            sum+= arr[i];
    }
    return sum;
}
int FindNegativeSum(int [] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]<0)
            sum+= arr[i];
    }
    return sum;
}
int [] array = CreateArray(5, -9, 9);
PrintArray(array);
Console.WriteLine ();
Console.WriteLine($"Сумма полож элементов равна {FindPositiveSum(array)}");
Console.WriteLine($"Сумма отр элементов равна {FindNegativeSum(array)}");

