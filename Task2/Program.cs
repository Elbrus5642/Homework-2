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
int firstDigit = 0;
int secondDigit = 0;
int thirdDigit = 0;
int stepenOne = 0; 
int stepenTwo = 0;
int stepenThree = 0;

while (resultDiv > 0)
{
    resultDiv = resultDiv / 10;
    numberDigit ++; 
}
if (numberDigit > 2)
{

Console.WriteLine($"Разрядность числа {number} -> {numberDigit}");
stepenOne = Convert.ToInt32(Math.Pow (10,numberDigit - 1));
Console.WriteLine($"Делитель числа {number}  для определения первой цифры -> {stepenOne}");
firstDigit = number / stepenOne;
Console.WriteLine($"Первая цифра числа {number} -> {firstDigit}");

stepenTwo = Convert.ToInt32(Math.Pow (10,numberDigit - 2));
Console.WriteLine($"Делитель числа {number}  для определения второй цифры -> {stepenTwo}");
secondDigit = Convert.ToInt32((number - (firstDigit * stepenOne)) / stepenTwo);
Console.WriteLine($"Вторая цифра числа {number} -> {secondDigit}"); 

stepenThree = Convert.ToInt32(Math.Pow (10,numberDigit - 3));
Console.WriteLine($"Делитель числа {number}  для определения третьей цифры -> {stepenThree}");
thirdDigit = (number - firstDigit * (stepenOne - 1) - secondDigit * (stepenTwo - 2))/stepenThree;
Console.WriteLine($"Третья цифра числа {number} -> {thirdDigit}");
}
else
{
  Console.WriteLine($"Число {number} состоит менее чем из трёх разрядов, третьей цифры нет");  
}
