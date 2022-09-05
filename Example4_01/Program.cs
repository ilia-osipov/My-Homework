// Задача 25: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("введите основание");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("введите степень");
int b = int.Parse(Console.ReadLine());
int Result(int i)
{
    int res = a;
    for ( i=1; i<b; i++)
    {
        res *= a;
    }
    return res;
}
Console.WriteLine(Result(b));