// Written by Nahom Amde
// 02/02/2025

using System;

class FourSistersAndDuckbear
{
    static void Main()
    {
        // Ask the user for the total number of eggs gathered
        Console.WriteLine("How many chocolate eggs were gathered today?");

        // Read user input and convert it to an integer
        int eggCount = Convert.ToInt32(Console.ReadLine());

        // Divide the eggs equally among the four sisters
        int forSisters = eggCount / 4;

        // The remainder (leftover eggs) goes to the duckbear
        int forDuckbear = eggCount % 4;

        // Display the number of eggs each sister gets
        Console.WriteLine("Each sister gets " + forSisters + ".");

        // Display the number of eggs the duckbear gets
        Console.WriteLine("The duckbear gets " + forDuckbear + ".");

        // Explanation: The duckbear gets more eggs than the sisters if there are fewer than 4 eggs,
        // or if the remainder is greater than the amount each sister gets.
        // Example counts where the duckbear gets more: 6 (1 per sister, 2 for duckbear),
        // 7 (1 per sister, 3 for duckbear), 11 (2 per sister, 3 for duckbear).
    }
}
