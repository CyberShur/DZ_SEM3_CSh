// Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double[] CoordA =  massA();
double[] CoordB =  massB();
double[] diff = new double[3];

var Coord1 = string.Join(", ", CoordA);
var Coord2 = string.Join(", ", CoordB);

Console.WriteLine($"Введённые координаты: А - ({Coord1}) и B - ({Coord2})");

double Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: "); 
    return Convert.ToInt32(Console.ReadLine());
}

double[] massA()
{
    double xA = Coordinate("x", "A");
    double yA = Coordinate("y", "A");
    double zA = Coordinate("z", "A");
    double[] arrayA = new double[] {xA, yA, zA};
    return arrayA;
}

double[] massB()
{
    double xB = Coordinate("x", "B");
    double yB = Coordinate("y", "B");
    double zB = Coordinate("z", "B");
    double[] arrayB = new double[] {xB, yB, zB};
    return arrayB;
}

int count = 0;

while (count < CoordB.Length)
{
    diff[count] = CoordB[count] - CoordA[count]; 
    diff[count] = Math.Pow(diff[count], 2);
    count++;
}

double result = Math.Sqrt(diff[0] + diff[1]+ diff[2]);
double resultNew = Math.Round(result, 2);

Console.WriteLine($"Расстояние между точками равно - {resultNew}");