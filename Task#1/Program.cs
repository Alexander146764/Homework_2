/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

Console.WriteLine("Введите число: ");
var number = Console.ReadLine();
int Length = number.Length;

if (Length == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine("ДА");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
else
{
    Console.WriteLine("Число не пятизначное");
}



/* Введите число:
14212
Нет
PS C:\Users\poval\Desktop\Homework_2\Task#1> dotnet run
Введите число: 
12821
ДА
PS C:\Users\poval\Desktop\Homework_2\Task#1> dotnet run
Введите число: 
23432
ДА
PS C:\Users\poval\Desktop\Homework_2\Task#1> dotnet run
Введите число: 
1457456
Число не пятизначное
PS C:\Users\poval\Desktop\Homework_2\Task#1>  */