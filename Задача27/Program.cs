//Задача 27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
int num1 = 0;
int res = 0;
int sum = 0;
while (n > 10)
{
    num1 = n % 10;
    sum = sum + num1;
    n = n / 10;
}
if (n<10)
{
    res = sum + n;
}
Console.WriteLine($"Сумма цифр во введенном числе {n} = {res}");
