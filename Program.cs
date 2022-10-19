/*// Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();
Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);
if (num1 > num2)
{
    Console.WriteLine($"Первое число  {num1}   больше чем второе {num2}" );
}
else
{
    Console.WriteLine($"Второе чиcло  {num2}  больше чем первое  {num1}");
}

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();
Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число: ");
int num3 = int.Parse(Console.ReadLine()!);
if (num1 > num2 && num1 > num3)
{
    Console.WriteLine($"Первое число {num1} больше чем второе {num2} и третье {num3}");
}
else if (num2 > num3)
{
    Console.WriteLine($"Второе число {num2} больше чем первое {num1} и третье {num3}");
}
else
{
    Console.WriteLine($"Третье число {num3} больше чем первое {num1} и второе {num2} ");
}

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Clear();
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
if (num % 2 == 0) Console.WriteLine("Четное");
else 
Console.WriteLine("Нечетное");

Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
int i = 1;
bool not = true;

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Чётные числа от 1 до " + num);
while (i <= num)
{
if (i % 2 != 1)
    {
     Console.Write(i + ", ");
     not = false;
    }
i++;
}

if (not)
{
 Console.WriteLine("Нет чётных чисел!");
}     */     
