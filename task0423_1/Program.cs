
// нужно генерить случайные трех значные числ
// из них убирать вторуюцифры и превращать в двузначные
int number = new Random().Next(100, 1000);
System.Console.WriteLine($"трехзначное случайное число {number}" );
int ic= number/100;
int j= number % 10;
int result = ic*10+j;
System.Console.WriteLine($"результат {result}" );