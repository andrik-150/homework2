Console.Write("Введите трехзначное число ");
int number = int.Parse(Console.ReadLine());
int num1 = number % 100;
int result = num1 / 10;
Console.WriteLine($"Втроя цифра числа {result}");