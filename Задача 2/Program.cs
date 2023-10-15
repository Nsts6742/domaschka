//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число: ");
string digit = Console.ReadLine();
int number;
number = int.Parse(digit);
if (number > 99)
{
    while (number > 999)
    {
        number = number / 10;
    }
    int thirdDigit = number % 10;
    Console.WriteLine("Третья цифра - " + thirdDigit);
}
else
{
    Console.WriteLine("Третьей цифры не существует.");
}