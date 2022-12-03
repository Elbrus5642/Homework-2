/* Напишите программу, 
которая выводит третью цифру заданного числа
 или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Console.WriteLine("Введите число:");
string  numberStr = Console.ReadLine() ??"";
int number = int.Parse(numberStr);
int resultDiv = number;
int numberDigit = 0;
//int firstDigit = 0;
double stepen = 0;
//int secondDigit = 0;
//int thirdnumber = 0;

while (resultDiv > 0)
{
    resultDiv = resultDiv / 10;
    numberDigit ++; 
}

Console.WriteLine($"Разрядность числа {number} -> {numberDigit}");

stepen = Math.Pow (10,numberDigit - 1);
Console.WriteLine($"Возведение в степень {numberDigit} -> {stepen}");
// Console.WriteLine($"Первая цифра числа {number} -> {firstDigit}");