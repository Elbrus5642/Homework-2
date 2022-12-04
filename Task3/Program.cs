/* Напишите программу, которая принимает на вход цифру,
 обозначающую день недели, 
 и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/ 
Console.WriteLine("Введите цифру:");
string numberStr = Console.ReadLine() ??"";
int number = int.Parse(numberStr);
if (number / 8 == 0 )
{
    if (number == 6 || number == 7)
    {
       Console.WriteLine($" Да, день недели под номером {number} выходной"); 
    }
    else
    {
      Console.WriteLine($" Нет, день недели под номером {number} не выходной");  
    }
}
else
{
    Console.WriteLine($" Число {number} не может быть связано с номером дня недели");
}