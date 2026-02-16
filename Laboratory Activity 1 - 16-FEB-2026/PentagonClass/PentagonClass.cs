using System;

class PentagonC
{
    private double side;

    public Pentagon(double side)
    {
        this.side = side;
    }

    public double GetPerimeter() 
    {
        return 5 * side;
    }

    public double GetArea()
    {
        return Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * Math.Pow(side, 2) / 4;   
    }

    public void Display()
    {
        Console.WriteLine("Side length: " + side);
        Console.WriteLine($"Perimeter: {GetPerimeter():F3}");
        Console.WriteLine($"Area: {GetArea():F3}");
    }

    static void Main()
    {
        double side = 0; 
        Pentagon pentagon1 = new Pentagon(side); 
        Console.WriteLine("Pentagon p1");
        Console.WriteLine("-------------------------");
        pentagon1.Display();
        Console.WriteLine();

        side = 5;  
        Pentagon pentagon2 = new Pentagon(side);
        Console.WriteLine("Pentagon p2");
        Console.WriteLine("-------------------------");
        pentagon2.Display();
    }
}