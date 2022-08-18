// Задача 32: Напишите программу замена элементов
//массива: положительные элементы замените на
//соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

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
void FindRevPositive(int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]<0)
            arr[i]= arr[i]*-1;
             Console.Write($"{arr[i]} ");
    }
}


void FindRevNegative(int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]>0)
            arr[i] = arr[i] * -1;
            Console.Write($"{arr[i]} ");
    }
}


int [] array = CreateArray(12, -9, 9);
PrintArray(array);
Console.WriteLine();
FindRevPositive(array);
Console.WriteLine();
FindRevNegative(array);