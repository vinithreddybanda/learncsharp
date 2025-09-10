using System;
using Humanizer;
// TODO: Add the Humanizer package to this project using the CLI.
// Then, use it below to capitalize the string "csharp" and print it.

class Program
{
    static void Main(string[] args)
    {
        // Challenge 1: Humanizer string manipulation
        // TODO: Use Humanizer to capitalize the string "csharp" and print it
        // Example:
        // string input = "csharp";
        // string output = ... // use Humanizer here
        // Console.WriteLine(output);

        Console.WriteLine("hi".Humanize());

        // Challenge 2: Humanizer quantities and dates
        Console.WriteLine("Quantities:");
        HumanizeQuantities();

        Console.WriteLine("\nDate/Time Manipulation:");
        HumanizeDates();
    }

    // Challenge 2: Template for Humanizer quantity manipulation
    static void HumanizeQuantities()
    {
        // TODO: Use Humanizer's ToQuantity method to print:
        // 0 cases
        // 1 case
        // 5 cases
        // Example:
        // Console.WriteLine("case".ToQuantity(0));

        int caseCount = 0;
        Console.WriteLine("case".ToQuantity(caseCount));
    }

    // Challenge 2: Template for Humanizer date/time manipulation
    static void HumanizeDates()
    {
        // TODO: Use Humanizer's Humanize method to print:
        // yesterday
        // 2 hours ago
        // 1 day
        // 2 weeks
        // Example:
        // Console.WriteLine(DateTime.UtcNow.AddHours(-24).Humanize());
        Console.WriteLine(DateTime.UtcNow.AddDays(-1).Humanize());
        Console.WriteLine(DateTime.UtcNow.AddHours(-2).Humanize());
        Console.WriteLine(DateTime.UtcNow.AddDays(-1).Humanize());
        Console.WriteLine(DateTime.UtcNow.AddDays(-14).Humanize());

    }
}
