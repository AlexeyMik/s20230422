//Console.WriteLine("Task0423_2 использование методов (функций, процедур)");
//Console.WriteLine("Task0423_2 ищем максимальное значение из трех целых чисел, вводимых с консоли");
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