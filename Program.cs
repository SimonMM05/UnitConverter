using System;
using System.Collections.Generic;

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

        Console.WriteLine("Select a category of units to convert:");
        Console.WriteLine("(1) Length");
        Console.WriteLine("(2) Temperature");
        Console.WriteLine("(3) Weight");
        Console.WriteLine("(4) Volume");

        int categoryChoice;
        if (int.TryParse(Console.ReadLine(), out categoryChoice))
        {
            List<string> units = new List<string>();

            switch (categoryChoice)
            {
                case 1: // Length
                    units = new List<string>
                    {
                        "(1) Meters to Millimeters",
                        "(2) Meters to Centimeters",
                        "(3) Meters to Kilometers",
                        "(4) Miles to Feet",
                        "(5) Miles to Yards",
                        "(6) Kilometers to Miles"
                    };
                    break;
                case 2: // Temperature
                    units = new List<string>
                    {
                        "(7) Fahrenheit to Celsius",
                        "(8) Celsius to Fahrenheit"
                    };
                    break;
                case 3: // Weight
                    units = new List<string>
                    {
                        "(9) Pounds to Kilograms",
                        "(10) Kilograms to Pounds"
                    };
                    break;
                case 4: // Volume
                    units = new List<string>
                    {
                        "(11) Liters to Milliliters",
                        "(12) Liters to Cubic Meters",
                        "(13) Cubic Feet to Cubic Meters"
                    };
                    break;
                default:
                    Console.WriteLine("Invalid category choice. Please select a valid option (1-4).");
                    continue;
            }

            Console.WriteLine("Available conversion options:");

            foreach (string unitOption in units)
            {
                Console.WriteLine(unitOption);
            }

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
                    case 9:
                        convertedValue = unit * 0.453592; // Pounds to Kilograms
                        conversionType = "Pounds to Kilograms";
                        break;
                    case 10:
                        convertedValue = unit * 2.20462; // Kilograms to Pounds
                        conversionType = "Kilograms to Pounds";
                        break;
                    case 11:
                        convertedValue = unit * 1000; // Liters to Milliliters
                        conversionType = "Liters to Milliliters";
                        break;
                    case 12:
                        convertedValue = unit / 1000; // Liters to Cubic Meters
                        conversionType = "Liters to Cubic Meters";
                        break;
                    case 13:
                        convertedValue = unit * 0.0283168; // Cubic Feet to Cubic Meters
                        conversionType = "Cubic Feet to Cubic Meters";
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        continue;
                }

                Console.WriteLine($"Converted value in {conversionType}: {convertedValue}");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a valid option.");
            }
        }
        else
        {
            Console.WriteLine("Invalid category choice. Please select a valid option.");
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }
}