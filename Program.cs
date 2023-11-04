using System;

Console.WriteLine("Hello! Welcome to this program. The program allows you to convert between different units.");

while (true)
{
    Console.WriteLine("Enter a number for a unit you would like to convert or ('q', 'quit', or 'exit') to exit the program:");
    string input = Console.ReadLine();

    if (input == "q" || input == "quit" || input == "exit")
    {
        break;
    }

    if (double.TryParse(input, out double unit))
    {
        Console.WriteLine($"You entered: {unit}");
        Console.WriteLine("Select conversion:");
        Console.WriteLine("(1) Meters to Millimeters");
        Console.WriteLine("(2) Meters to Centimeters");
        Console.WriteLine("(3) Meters to Kilometers");
        Console.WriteLine("(4) Miles to Feet");
        Console.WriteLine("(5) Miles to Yards");
        Console.WriteLine("(6) Kilometers to Miles");
        Console.WriteLine("(7) Fahrenheit to Celsius");
        Console.WriteLine("(8) Celsius to Fahrenheit");

        int choice;
        if (int.TryParse(Console.ReadLine(), out choice))
        {
            double convertedValue = 0;
            string conversionType = "";

            switch (choice)
            {
                case 1:
                    convertedValue = unit * 1000; // Meters to Millimeters
                    conversionType = "Meters to Millimeters";
                    break;
                case 2:
                    convertedValue = unit * 100; // Meters to Centimeters
                    conversionType = "Meters to Centimeters";
                    break;
                case 3:
                    convertedValue = unit / 1000; // Meters to Kilometers
                    conversionType = "Meters to Kilometers";
                    break;
                case 4:
                    convertedValue = unit * 5280; // Miles to Feet
                    conversionType = "Miles to Feet";
                    break;
                case 5:
                    convertedValue = unit * 1760; // Miles to Yards
                    conversionType = "Miles to Yards";
                    break;
                case 6:
                    convertedValue = unit / 1.60934; // Kilometers to Miles
                    conversionType = "Kilometers to Miles";
                    break;
                case 7:
                    convertedValue = (unit - 32) * 5 / 9; // Fahrenheit to Celsius
                    conversionType = "Fahrenheit to Celsius";
                    break;
                case 8:
                     convertedValue = (unit * 9 / 5) + 32; // Celsius to Fahrenheit
                    conversionType = "Celsius to Fahrenheit";
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option (1-8).");
                    continue;
            }

            Console.WriteLine($"Converted value in {conversionType}: {convertedValue}");
        }
        else
        {
            Console.WriteLine("Invalid choice. Please select a valid option (1-8).");
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }
}
