// Напишите программу,которая на вход принимает число (N), а на выходе
//показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int evenNumber = 2;   

while (evenNumber <= number )
{
    Console.Write(evenNumber + " ");
    evenNumber+=2;
}