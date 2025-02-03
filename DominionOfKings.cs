// Written by Nahom Amde
// 02/02/2025

using System;

class DominionGame  // Changed class name to avoid project conflict
{
    static void Main()
    {
        // Ask the user for the number of estates
        Console.WriteLine("How many estates do you have?");
        int estateCount = Convert.ToInt32(Console.ReadLine());

        // Ask the user for the number of duchies
        Console.WriteLine("How many duchies do you have?");
        int duchyCount = Convert.ToInt32(Console.ReadLine());

        // Ask the user for the number of provinces
        Console.WriteLine("How many provinces do you have?");
        int provinceCount = Convert.ToInt32(Console.ReadLine());

        // Calculate total points
        int totalPoints = estateCount + (duchyCount * 3) + (provinceCount * 6);

        // Display total score
        Console.WriteLine("Your point total: " + totalPoints);
    }
}
