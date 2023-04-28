//Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8
Console.WriteLine("Task 20230422_4 C sharp: вычислние суммы чётных чисел от нуля до заданного с консоли");
// и попутно вывод всех четных чисел до заданного 
Console.WriteLine("Введите целое число: ");
int Number = Convert.ToInt32(Console.ReadLine());
int i = 1;
int acc = 0;
while (i <= Number)
{
    int j = i % 2;
    if (j == 0)
    {
        acc = acc + i;
        // Трассировка для отладки
        Console.WriteLine($"{i} делится на 2, остаток={j}");
    };
    i++;
};
Console.WriteLine($"Сумма равна {acc}");
// второй вариант с циклом for
acc = 0;
for (i = 0; i <= Number; i = i + 2)
{
    if (i > 0)
    {
        Console.WriteLine($"к {acc} прибавляем {i}");
    }
    acc = acc + i;
};
Console.WriteLine($"Второй вариант дает сумму {acc}");