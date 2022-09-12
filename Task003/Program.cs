// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Cube()
{
    // Определяем входное число N
    Console.WriteLine("Введите число: ");
    int N = int.Parse(Console.ReadLine());
    int num = 1;
    // Определяем значение чисел в кубе от 1 до N
    while(num <= N)
    {
        int result = num*num*num;
        Console.Write($"{result} ");
        num++;
    }  
   }
Cube();