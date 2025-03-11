using System;
class Program
{
    static void Main()
    {
        // Declare a variable and get an input of a number
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // If number > 0 output "The number is positive"
        // Else if number < 0 "... negative"
        // Else 0
        if (number > 0) 
            Console.WriteLine("The number is positive!");
        else if (number < 0) 
            Console.WriteLine("The number is negative!");
        else 
            Console.WriteLine("The number is '0'!");

        // Write a loop that prints out numbers 0 to 20
        for (int i = 0; i <= 20; i++)
            Console.WriteLine(i);
    }
}