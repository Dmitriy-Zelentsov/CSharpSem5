// Задайте одномерный массив из 123 случайных
//чисел. Найдите количество элементов массива, значения
//которых лежат в отрезке [10,99].
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5

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
int FindCount(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
         if (array[i] >= 10 && array[i] <= 99)
        {
            count++;
        }
    }
    return count;
}
int [] array = CreateArray(10, 1, 100);
PrintArray(array);
Console.WriteLine();
int count = FindCount(array);
Console.WriteLine(count);
