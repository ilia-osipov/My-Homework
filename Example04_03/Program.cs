// Задача 29: Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.

Console.Clear();

int[] array = GetArray(8);

Console.WriteLine("Массив из 8 элементов: ");

Console.WriteLine($"[{string.Join(",",array)}]");

int[] GetArray(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }

    return arr;
}