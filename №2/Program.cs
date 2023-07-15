void Task2()
{
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число:");
int number_1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int number_2 = Convert.ToInt32(Console.ReadLine());

if (number_1 > number_2)
{
    Console.WriteLine("Первое число больше второго");
}

else
{
    Console.WriteLine("Второе число больше первого");
}
}

void task4()
{
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число");
int number_1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int number_2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третее число:");
int number_3 = Convert.ToInt32(Console.ReadLine());

int max = number_1;

if (number_2 > max)max = number_2;

if (number_3 > max)max = number_3;
{
    Console.WriteLine(max);
}

}

void task6()
{
    // Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("четное");
}
else
{
    Console.WriteLine("не четное");
}

}

void task8()
{
    //Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int counter = 1;

while(counter <= number)
{
    if(number % 2 == 0) Console.Write($"{counter} ");
    counter++;
}

}


