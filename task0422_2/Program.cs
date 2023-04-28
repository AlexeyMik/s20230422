//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("Нахождение максимума из двух - как метод -функция");
Console.WriteLine("Task0423_2 ищем максимальное значение из трех целых чисел, вводимых с консоли");
int maxOf2( int x1, int x2)
{
    int result=x1;
    if (x2>result)
    { result=x2;
    }
    return result;
}
int i=1;
Console.Write("Введите "+i+"-е целое число: ");
int ibest= Convert.ToInt32(Console.ReadLine());
while (i<3)
{
    i++;
    Console.Write("Введите "+i+"-е целое число: ");
    int icandidate= Convert.ToInt32(Console.ReadLine());
    ibest=maxOf2(ibest, icandidate);
}
Console.WriteLine("Наибольшее число = "+ibest);