using System;

namespace PackageExpress
{
    class Program
    }
static void Main(string[] args)
{
    // Requirement 1: Display the mandatory opening welcome message
    Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

    //Requirement 2: Prompt the user to enter the package weight
    Console.WriteLine("Please enter the package weight:");
    int weight = Convert.ToInt32(Console.ReadLine());

    // Requirement 3: Weight check
    if (weight > 50)
    {
        Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
        return; // end the program
    }

    //Requirement 4: Prompt for width
    Console.WriteLine("Please enter the package width:");
    int width = Convert.ToInt32(Console.ReadLine());

    //Requirement 5: Prompt for height
    Console.WriteLine("Please enter the package height:");
    int height = Convert.ToInt32(Console.ReadLine());

    //Requirement 6: Prompt for length
    Console.WriteLine("Please enter the package length:");
    int length = Convert.ToInt32(Console.ReadLine());

    //Requirement 7: Dimension check (total greater than 50)
    if ((width + height + length) > 50)
    {
        Console.WriteLine("Package too big to be shipped via Package Express.");
        return; // End the program
    }

    //Requirement 8 and 9: Calculate the quote
    //Multiply dimensions, then multiply by weight, finally divide by 100
    decimal quote = ((decimal)height * width * length * weight) / 100;

    //Requirement 10: Display the quote to the user as a dollar amount
    Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("F2"));
    Console.WriteLine("Thank you!");
    }


        
