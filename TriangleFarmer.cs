// Written by Nahom Amde
// 02/02/2025

using System;

class Triangle
{
    private double x1, y1, x2, y2, x3, y3;

    // Constructor to store the coordinates of the triangle
    public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        this.x1 = x1;
        this.y1 = y1;
        this.x2 = x2;
        this.y2 = y2;
        this.x3 = x3;
        this.y3 = y3;
    }

    // Calculates the area using the Shoelace theorem
    public double CalculateArea()
    {
        // Shoelace formula: |(x1(y2 - y3) + x2(y3 - y1) + x3(y1 - y2)) / 2|
        return Math.Abs((x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2.0);
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the coordinates of the three vertices of the triangle:");

        // Get x and y coordinates from the user
        Console.Write("x1: ");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("y1: ");
        double y1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("x2: ");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("y2: ");
        double y2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("x3: ");
        double x3 = Convert.ToDouble(Console.ReadLine());
        Console.Write("y3: ");
        double y3 = Convert.ToDouble(Console.ReadLine());

        // Create a Triangle object with the user-provided coordinates
        Triangle triangle = new Triangle(x1, y1, x2, y2, x3, y3);

        // Compute the area and display the result
        Console.WriteLine($"The area of the triangular land is: {triangle.CalculateArea()} square units");
    }
}
