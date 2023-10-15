//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число от 1 до 7: ");
string digit = Console.ReadLine();
int day;
day = int.Parse(digit);
if (day > 0 & day < 8)
{
    if (day > 5 & day < 8)
    {
        Console.WriteLine("Это выходной день.");
    }
    else
    {
        Console.WriteLine("Это будний день.");
    }
}
else
{
    Console.WriteLine("Введены неверные данные.");
}