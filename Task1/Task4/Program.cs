// напишите программу, которая на входе получает трехзначное число, а на входе выдает его последнюю цифру
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int lastDigit = number%10;
System.Console.WriteLine(lastDigit);