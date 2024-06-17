namespace GeometricShapesIntro;

internal class Program
{
    static void Main(string[] args)
    {    
        Sqr Sq = new Sqr(6);
        Console.WriteLine($"Square perimeter is {Sq.Perimeter()} & area is {Sq.Area()}.");
    
        Rectangle rp1 = new Rectangle(10, 5);
        Console.WriteLine($"Rectangle perimeter is {rp1.Perimeter()} & area is {rp1.Area()}.");
    
        Quad q1 = new Quad(3, 4, 5, 6);
        Console.WriteLine($"Perimeter 1 is {q1.Perimeter()}.");

        Quad q2 = new Quad(11, 12, 13, 14);
        Console.WriteLine($"Perimeter 2 is {q2.Perimeter()}.");
    }
}

//this .cs file has no changes compared to the previous version (without using inheritence) but all other classes have significantly less code.