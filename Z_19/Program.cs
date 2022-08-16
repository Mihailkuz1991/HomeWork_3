// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Clear(); 

Console.WriteLine("Введите пятизначное число");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Введите пятизначное число -> {number}");

if (number < 10000 || number > 99999)
Console.WriteLine("Введено некорректное число");
else 
{
    int firstDigit = number / 10000;
    int secondDigit = number / 1000 % 10;
    int thirdDigit = number / 100 % 10;
    int foursDigit = number / 10 % 10;
    int fiveDigit = number % 10;

    
    if (firstDigit == fiveDigit && secondDigit == foursDigit)
    Console.WriteLine("Число является полиндромом");
    else Console.WriteLine("Число не является полиндромом");
};
   
Console.WriteLine();
   
