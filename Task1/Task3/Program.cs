// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа на промежутке от -N до N
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int currentNumber = number * -1; currentNumber <= number; currentNumber++)
{
    Console.Write (currentNumber + " ");
}




