//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трёхзначное число: ");
string digit = Console.ReadLine();
int number;
number = int.Parse(digit);
if (number > 99 & number < 1000) 
{
    int oneAndSecondNumber = number / 10;
    int secondNumber = oneAndSecondNumber % 10;
    Console.WriteLine("Вторая цифра числа - " + secondNumber);
}
else
{
    Console.WriteLine("Неверно введено число.");
}