// See https://aka.ms/new-console-template for more information
Console.Write("Введиет число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num1 < 100 || num1 > 999)
    Console.WriteLine("Число не трехзначное ");
else
{
    int res = ((num1-(num1 % 10))/10)%10;
    Console.WriteLine("Вторая цифра: " + res);
}

