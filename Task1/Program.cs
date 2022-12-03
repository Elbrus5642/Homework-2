/* Напишите программу, которая принимает на вход трёхзначное число
 и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
Console.WriteLine("Введите положительное трёхзначное число:");
string  numberStr = Console.ReadLine() ??"";
int threeDigitnumber = int.Parse(numberStr);
int firstDigit = 0;
int secondDigit = 0;

if (threeDigitnumber >= 100 && threeDigitnumber < 1000)
{
    firstDigit = threeDigitnumber / 100;
        secondDigit = (threeDigitnumber - firstDigit * 100) / 10; 
    Console.WriteLine($"Вторая цифра трёхзначного числа {threeDigitnumber} -> {secondDigit}"); 
}
else
{
  Console.WriteLine("Число введено неверно, повторите ввод:");  
}