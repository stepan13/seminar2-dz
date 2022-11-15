// See https://aka.ms/new-console-template for more information
Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int ost=-1;
if (num1 < 100)
    Console.WriteLine("Третьей цифры нет");
else
{
    int num2 = num1;
    int count = 0;
    while (num2 > 0)
    {
        ost = num2 % 10;
        num2 = (num2-ost)/10;
        count++;
    }
    Console.WriteLine("Всего цифр: " + count);
    num2 = num1;
    for (int i = 1; i<=count-2;i++)
    {
        ost = num2 % 10;
        num2 = (num2-ost)/10;
    }
    Console.WriteLine("Третья слева цифра: " + ost);

}

