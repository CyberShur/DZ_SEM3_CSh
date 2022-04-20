// Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// N = √(X²+Y²+Z²)

int xA = Coordinate("x", "A");
int yA = Coordinate("y", "A");
int zA = Coordinate("z", "A");
int xB = Coordinate("x", "B");
int yB = Coordinate("y", "B");
int zB = Coordinate("z", "B");

Console.WriteLine($"Введённые координаты: А - ({xA}, {yA}, {zA}) и B - ({xB}, {yB}, {zB})");

int diffX = xB - xA;
int diffY = yB - yA;
int diffZ = zB - zA;

double result0 = Math.Sqrt(resultSquare(diffX, diffY, diffZ));
double result = Math.Round(result0, 2);

Console.WriteLine($"Расстояние между точками равно - {result}");


int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: "); 
    return Convert.ToInt32(Console.ReadLine());
}

double resultSquare(int A, int B, int C)
{
    double resultS = Math.Pow(A, 2)+Math.Pow(B, 2)+Math.Pow(C, 2);
    return resultS;
}













