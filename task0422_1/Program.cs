Console.WriteLine("Task 20230422_4 C sharp: вычислние суммы чётных чисел от нуля до заданного с консоли");
// Попытка 
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
//   Console.WriteLine("Для "+i+" остаток="+j+" Сумма равна "+acc);
    };
    i++;
}
acc=acc+Number;
Console.WriteLine("Сумма равна "+acc);