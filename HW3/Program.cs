// Задача 23: Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число N: ");
int Number = Convert.ToInt32(Console.ReadLine());

int i = 1;

if (Number <= 0)
{
    Console.WriteLine("Число должно быть положительным и не равняться нулю");
}

while (i <= Number)
{
    double result = sqrNumber(i);
    Console.Write(result + " ");
    i++;
}

double sqrNumber(int Number)
{
    return Math.Pow(Number, 3);
}
