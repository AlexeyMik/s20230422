Console.WriteLine("Task 20230422_4 C sharp: вычислние суммы чётных чисел от нуля до заданного с консоли");
// и попутно вывод всех четных чисел до заданного 
Console.WriteLine("Введите целое число: ");
int Number = Convert.ToInt32(Console.ReadLine());
int i=0;
int acc=0;
while (i<=Number)
{
    int j=i%2;
    if (j==0)
    {
    acc=acc+i;
// Трассировка для отладки
    Console.WriteLine($"{i} делится на 2, остаток={j}");
    };
    i++;
};
Console.WriteLine($"Сумма равна {acc}");
// второй ваариант с циклом for
acc=0;
for (i=0; i<=Number; i=i+2)
{
    Console.WriteLine($"к {acc} прибавляем {i}");
    acc=acc+i;
};
Console.WriteLine($"Второй вариант дает сумму {acc}");