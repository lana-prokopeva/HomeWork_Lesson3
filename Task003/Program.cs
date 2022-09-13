// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// Определяем значение чисел в кубе от 1 до N 
int[] GetCubeNumers(int N)
{
    int[] cubeNumbers = new int[N];
    for (int i = 1; i <= N; i++)
    {
        cubeNumbers [i - 1]  = i*i*i;
    }  
    return cubeNumbers;
}

// Определяем входное число N
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());

// Вносим получившиеся числа в массив
int[] arrayCube = GetCubeNumers(N);
for (int i = 0; i < arrayCube.Length; i++) 
{
    Console.Write($"{arrayCube[i]} ");
}

