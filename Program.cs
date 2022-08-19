// //Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.Write("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// if (number1 > number2)
// {
//     int maxnumber = number1;
//     int minnumber = number2;
//     Console.WriteLine("Максимальное число: " + number1);
//     Console.WriteLine("Минимальное число: " + number2);
// }
// else
// {
//     int maxnumber = number2;
//     int minnumber = number1;
//     Console.WriteLine("Максимальное число: " + number2);
//     Console.WriteLine("Минимальное число: " + number1);
// }

// // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.Write("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите третье число: ");
// int number3 = Convert.ToInt32(Console.ReadLine());

// int maxnumber = 0;

// if (number2 > number1)
// {
//     maxnumber = number2;
//     if (number3 > number2)
//     {
//     maxnumber = number3; 
//     }
//     else
//     {
//         maxnumber = number2;
//     }    
// }
// else
// {
//    maxnumber = number1; 
// }
// Console.WriteLine("Максимальное число: " + maxnumber);

// // Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Console.Write("Введите число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());

// if (number1%2 == 0)
// {
//    Console.WriteLine("Число является четным!"); 
// }
// else
// {
//   Console.WriteLine("Число НЕ является четным!");  
// }

// // Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

int number2 = 1;

while (number1 >= number2)
{
   int del = number2 % 2;
        if (del == 0)
        {
            Console.Write(number2 + ", ");
        } 
number2++;
}