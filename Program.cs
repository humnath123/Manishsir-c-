using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter three different numbers:");

        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        int num3 = int.Parse(Console.ReadLine());

        if (num1 > num2 && num1 > num3)
        {
            Console.WriteLine("The greatest number is: " + num1);
        }
        else if (num2 > num1 && num2 > num3)
        {
            Console.WriteLine("The greatest number is: " + num2);
        }
        else
        {
            Console.WriteLine("The greatest number is: " + num3);
        }
    }
}