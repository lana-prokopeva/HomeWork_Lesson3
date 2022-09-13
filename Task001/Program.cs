// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Определяем является ли число палиндромом
string Palindrome(int num)
{
    int a = num/10000;
    int a1 = num%10;
    int b = num/1000%10;
    int b1 = num/10%10;
    if(a==a1 & b==b1) return "Число является палиндромом";
    else return "Число НЕ является палиндромом";
}

// Определяем входящее число
Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());

string result = Palindrome(num);
Console.WriteLine(result);
