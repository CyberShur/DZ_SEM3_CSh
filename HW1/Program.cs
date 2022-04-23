// Задача 19: Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Write("Введите пятизначное число число: "); 
int Input = Convert.ToInt32(Console.ReadLine());
string array = Input.ToString();

bool Palindrome()
{
    bool Сompare = true;
    for (int count = 0; count < array.Length / 2; count++)
    {
        if (array[count] != array[array.Length - 1 - count])
        {
            Сompare = false;
        }
    }
    return Сompare;
}

if (Palindrome())
{
    Console.WriteLine($"Число {Input} является палиндромом");
}
else
{
    Console.WriteLine($"Число {Input} НЕ является палиндромом");
}