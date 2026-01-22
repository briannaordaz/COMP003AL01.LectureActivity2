// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main(string[] args)
    {
        
        //Step 3: Prompt and Read Two Inputs & Step 4: Parse The Inputs into double Values
        Console.WriteLine("Enter The First Number:");
        double userInput = double.Parse(Console.ReadLine());
        
        
        Console.WriteLine("Enter The Second Number:");
        double userInput2 = double.Parse(Console.ReadLine());

        
        //Step 5: Compute Required Results:
        double sumvalue = (userInput + userInput2);
        double averagevalue = sumvalue / 2;
       
        //Step 6: Output Results, Part A: Output using string concatenation
        Console.WriteLine("Using Concatenation:");
        Console.WriteLine("Sum: " + sumvalue);
        Console.WriteLine("Average: " + averagevalue);
           
        //Step 6: Output Results, Part B: Output using string interpolation
        Console.WriteLine("Using Interpolation:");
        Console.WriteLine($"Sum: {sumvalue} \n Average: {averagevalue}");

    }
}


