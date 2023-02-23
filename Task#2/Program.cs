/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

Console.Write("Введите координату точки А по оси Х: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки А по оси Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки А по оси Z: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату точки В по оси Х: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки В по оси Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки B по оси Z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"Результат: {result:F2}"); 

/* PS C:\Users\poval\Desktop\Homework_2\Task#2> dotnet run
Введите координату точки А по оси Х: 3
Введите координату точки А по оси Y: 6
Введите координату точки А по оси Z: 8
Введите координату точки В по оси Х: 2
Введите координату точки В по оси Y: 1
Введите координату точки B по оси Z: -7
Результат: 15,84
PS C:\Users\poval\Desktop\Homework_2\Task#2> dotnet run
Введите координату точки А по оси Х: 7
Введите координату точки А по оси Y: -5
Введите координату точки А по оси Z: 0
Введите координату точки В по оси Х: 1
Введите координату точки В по оси Y: -1
Введите координату точки B по оси Z: 9
Результат: 11,53
PS C:\Users\poval\Desktop\Homework_2\Task#2>  */