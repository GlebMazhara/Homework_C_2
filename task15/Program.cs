// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.Write("ВВедите день недели:");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1 || n > 7)
{
    Console.Write("В недели 7 дней, введите правильное число:  ");
    n = Convert.ToInt32(Console.ReadLine());
}
if(n == 1)
    Console.Write("Нет");
if(n == 2 )
    Console.Write("Нет");
else if(n == 3)
    Console.Write("Нет");
else if(n == 4)
    Console.Write("Нет");
else if(n == 5)
    Console.Write("Нет");
else if(n == 6)
    Console.Write("Да");
else 
    Console.Write("Да");

