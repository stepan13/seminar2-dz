// See https://aka.ms/new-console-template for more information
Console.Write("Введиет номер дня недели: ");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 < 1 || num1 > 7)
    Console.WriteLine("Неверный номер дня");
else if (num1 == 6 || num1 == 7)
    Console.WriteLine("Это выходной");
else
    Console.WriteLine("Это будний день");
