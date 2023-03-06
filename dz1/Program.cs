// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int a = number / 10000;
int b = (number / 1000) % 10;
int d = (number / 10) % 10;
int e = number % 10;

if (a == e && b == d)
{
    Console.WriteLine("Число " + number + " является палиндромом");
}
else
{
    Console.WriteLine("Число " + number + " не является палиндромом");
}