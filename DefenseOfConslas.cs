// Written by Nahom Amde
// 02/02/2025

using System;

class DefenseOfConsolas
{
    static void Main()
    {
        // Set the console title
        Console.Title = "Defense of Consolas";

        // Prompt the user for the target row
        Console.Write("Target Row? ");
        int row = Convert.ToInt32(Console.ReadLine());

        // Prompt the user for the target column
        Console.Write("Target Column? ");
        int column = Convert.ToInt32(Console.ReadLine());

        // Change text color to red for warning effect
        Console.ForegroundColor = ConsoleColor.Red;

        // Display defensive positions (above, below, left, right)
        Console.WriteLine($"({row}, {column - 1})"); // Left
        Console.WriteLine($"({row - 1}, {column})"); // Above
        Console.WriteLine($"({row}, {column + 1})"); // Right
        Console.WriteLine($"({row + 1}, {column})"); // Below

        // Play a warning sound
        Console.Beep();
    }
}
