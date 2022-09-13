// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// Расчитываем расстояние между двумя точками 
double GetDistanceThreePoints (int x1, int y1, int z1, int x2, int y2, int z2)
{
    int distX = (x2 - x1) * (x2 - x1);
    int distY = (y2 - y1) * (y2 - y1);
    int distZ = (z2 - z1) * (z2 - z1);
    double distXYZ = Math.Pow((distX + distY + distZ), 0.5);
    return distXYZ;
}
// Определяем входные значение двух точек
Console.Write("Введите координаты первой точки Х1: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты первой точки Y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты первой точки Z1: ");
int z1 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты второй точки Х2: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты второй точки Y2: ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты второй точки Z2: ");
int z2 = int.Parse(Console.ReadLine());

double Distance = GetDistanceThreePoints (x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Растояние между точками {x1},{y1},{z1} и {x2},{y2},{z2} = {Math.Round(Distance, 2, MidpointRounding.ToNegativeInfinity)}");