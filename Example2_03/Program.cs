// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.Clear();
Console.Write("Введите число от 1 до 7: ");
int num = int.Parse(Console.ReadLine());
if ((num < 1) || (num > 7))
{
  Console.WriteLine("Не корректный ввод"); 
  return; 
}
if ((num == 6) || (num == 7))
{
Console.WriteLine("Выходной день");
}
else
{
   Console.WriteLine("Будний день"); 
}