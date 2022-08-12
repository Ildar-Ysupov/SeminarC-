// Напишите программу, которая на входе принимает два числа и выдаёт,
// какое число больше, а какое меньше.
// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3.

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
    Console.WriteLine(" max = " + firstNumber );
}
else Console.WriteLine(" max = " + secondNumber );