// Напишите программу, которая на вход принимает число и выдаёт его квадрат.
// Нпример: 4 -> 16, -3 -> 9, -7 -> 49.

int number = Convert.ToInt32(Console.ReadLine());

int square = number * number;

//int result = Convert.ToInt32(Math.Pow(number,2)); второй способ

Console.WriteLine("Квадрат от числа " + number + " = " + square);

// Склеить строки - конкатенация