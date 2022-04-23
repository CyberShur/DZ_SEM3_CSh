// Задача 19: Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Write("Введите число: "); 
int Input = Convert.ToInt32(Console.ReadLine());
string array = Input.ToString();
int[] newArray = new int[array.Length];
int[] reversArray = new int[array.Length];


for(int count=0; count < array.Length; count++)
{
    newArray[count] = int.Parse(array[count].ToString());
}

for(int count=0; count < array.Length; count++)
{
    reversArray[count] = newArray[(newArray.Length-1) - count];
}

int NumberRevers = reversArray[0]*10000 + reversArray[1]*1000 + reversArray[2]*100 + reversArray[3]*10 + reversArray[4];

if (Input == NumberRevers)
{
    Console.WriteLine($"Число {Input} является палиндромом");
}
else
{
    Console.WriteLine($"Число {Input} НЕ является палиндромом");
}










/* for(int count=0; count < newArray.Length; count++)
{
    while(newArray[count]==newArray[(newArray.Length-1) - count])
    {
        Console.WriteLine($"Число {Input} является полиндромом");
        break;
    }
    Console.WriteLine($"Число {Input} НЕ является полиндромом");
} */


//Console.WriteLine($"Число {Input} НЕ является полиндромом");

//Console.WriteLine($"Число {Input} является полиндромом");