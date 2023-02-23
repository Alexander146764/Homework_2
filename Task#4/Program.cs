/* Представим банк, в котором алгоритм начисления процента по вкладу зависит от суммы вклада. 
На вход будет подаваться число (сумма вклада). При значении меньше 100, будет начислено 5 %, 
если значение находится в диапазоне от ста до двухсот — 7 %, если больше — 10 %. 
Отработав, программа должна вывести общую сумму с начисленными процентами.
 */

Console.WriteLine("Введите сумму вклада:");
double deposit = Convert.ToDouble(Console.ReadLine());
double interestRate; //interestRate - процентная ставка

if (deposit < 100)
{
    interestRate = 0.05;
}
else if (deposit >= 100 && deposit <= 200) 
{
    interestRate = 0.07;
}
else    
{
    interestRate = 0.1;
}

double interest = deposit * interestRate;
double total = deposit + interest;

Console.WriteLine("Общая сумма с начисленными процентами: " + total);

/* Введите сумму вклада:
99
Общая сумма с начисленными процентами: 103,95
PS C:\Users\poval\Desktop\Homework_2\Task#4> dotnet run
Введите сумму вклада:
100
Общая сумма с начисленными процентами: 107
PS C:\Users\poval\Desktop\Homework_2\Task#4> dotnet run
Введите сумму вклада:
200
Общая сумма с начисленными процентами: 214 */