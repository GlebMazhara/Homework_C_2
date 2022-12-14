// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.Write("Введите набор чисел: ");
int n=Convert.ToInt32(Console.ReadLine());
int a = n;
int b = n;
while ( n!= 0 )
{
    if(n>a)
    a=n;
    else if(n>b)
    b=n;
    n=Convert.ToInt32(Console.ReadLine());
}
Console.Write($"Конец, второй максимум{b}");