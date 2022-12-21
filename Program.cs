// See https://aka.ms/new-console-template for more information


using System.Drawing;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("enter number");
double N = double.Parse(Console.ReadLine());


for (double i = 1; i <= N; i++)
{

    
    if (check(i)==true)
    {
       
        Console.WriteLine("the prime number = "+i);
    }
    
}
static bool check(double n)
{
   
    if (n == 1 || n == 0) return false ;

    
    for (double i = 2; i < n; i++)
    {
       
        if (n % i == 0) return false;
    }
    
    return true;
}


