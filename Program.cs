// Written by Nahom Amde
// 02/02/2025

using System;

class RepairingTheClocktower
{
    static void Main()
    {
        // Ask the user to enter a number
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Check if the number is even or odd
        if (number % 2 == 0)
            Console.WriteLine("Tick"); // Even number
        else
            Console.WriteLine("Tock"); // Odd number
    }
}
