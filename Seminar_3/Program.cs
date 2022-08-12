// 1. Напишите программу, которая на вход принимает два числа и проверяет, 
//  является ли первое квадратом второго.
// a = 25, b = 5 -> да
// a = 2,  b = 10 -> нет
// a = 9,  b = -3 -> да
// a = -3, b = 9 -> нет

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

// "==" - проверка на равенство: 5 == 5 - True
// "!=" - проверка на не равенство: 5 != 5 -False

if (firstNumber == secondNumber * secondNumber)
{
    Console.WriteLine(firstNumber + " является квадратом от " + secondNumber );
}
else Console.WriteLine(firstNumber + " НЕ является квадратом от " + secondNumber );