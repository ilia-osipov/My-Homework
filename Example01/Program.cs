// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
Console.Write("Введите A: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите B: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if(number1 > number2)
{
    Console.WriteLine("A больше B");
}
else
{
    if(number1 < number2)
    {
      Console.WriteLine("B больше A");  
    }
    else
    {
       Console.WriteLine("A равно B"); 
    }
}