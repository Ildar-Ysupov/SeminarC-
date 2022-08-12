// Напишите программу, которая на вход принимает одно число (N), А НА выходе показывает
//  все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> "-2, -1, 0, 1, 2"

int number = Convert.ToInt32(Console.ReadLine());   // n - number
int negativeNumber = number*(-1);    // -n = n*(-1)

while (negativeNumber <= number )
{
    Console.Write(negativeNumber + " ");
    negativeNumber++;
}