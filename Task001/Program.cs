// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Palindrome()
{
    // Определяем входящее число
    Console.WriteLine("Введите пятизначное число: ");
    int num = int.Parse(Console.ReadLine());
    //
    int a = num/10000;
    int a1 = num%10;
    int b = num/1000%10;
    int b1 = num/10%10;
    if(a==a1 & b==b1) Console.WriteLine("Число является палиндромом");
    else Console.WriteLine("Число НЕ является палиндромом");
}

Palindrome();

