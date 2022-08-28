// Задача 13: Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int k = (int)Math.Log10(num)-2;
if(k < 0)
{
    Console.WriteLine("третьей цифры нет");  
    return;
}
    else
{
Console.WriteLine(((num % (int)Math.Pow(10, k + 1) / (int)Math.Pow(10, k)).ToString()));
}


