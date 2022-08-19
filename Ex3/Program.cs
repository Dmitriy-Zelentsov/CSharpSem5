// Задайте массив. Напишите программу,
//которая определяет, присутствует ли заданное
//число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//-3; массив [6, 7, 19, 345, 3] -> да

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
void FindNumber(int [] array)
{
    int num = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == num)
        {
             Console.WriteLine("да");
             return;
        }
    }
    Console.WriteLine("нет");
}
int [] array = CreateArray(7, 3, 5);
PrintArray(array);
Console.WriteLine();
FindNumber(array);

