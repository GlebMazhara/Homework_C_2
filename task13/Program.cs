// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Введите  число");
int n =int.Parse(Console.ReadLine());
if (n>99){
    while(n >999){
        n=n/10;
    }
    Console.WriteLine(n=n%10);
 }
else
Console.WriteLine("Число не 3х значное");
