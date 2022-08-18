//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    int maxnumber = number1;
    int minnumber = number2;
    Console.WriteLine("Максимальное число: " + number1);
    Console.WriteLine("Минимальное число: " + number2);
}
else
{
    int maxnumber = number2;
    int minnumber = number1;
    Console.WriteLine("Максимальное число: " + number2);
    Console.WriteLine("Минимальное число: " + number1);
}

