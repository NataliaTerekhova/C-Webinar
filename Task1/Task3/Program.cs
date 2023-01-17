// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа на промежутке от -N до N
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int currentNumber=number*-1;
while (currentNumber<=number)
{
    System.Console.Write(currentNumber + " "); 
    currentNumber++;
}