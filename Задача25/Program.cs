//Задача 25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Не использовать метод Math.Pow
Console.WriteLine("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень первого числа: ");
int m = Convert.ToInt32(Console.ReadLine());
int i;
int sum = 1;
for (i = 1; i <= m; i++)
{
    sum = n * sum;
}
Console.WriteLine($"Число {n} в степени {m} равно = {sum}");
