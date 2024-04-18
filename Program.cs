namespace App006;

public class Box
{
    private double height, width;

    public Box(double a, double b)
    {
        height = a + 5;
        width = b + 1;
        ViewContent();
    }
    public void SetHeight(double height)
    {
        Console.WriteLine($"In SetHeight the value of height is {height}");
        width = height;
        height = 50;
        ViewContent();
    }

    public double MakeChanges(double a)
    {
        double width = 0;
        width = a;
        a = height;
        ViewContent();
        return height *3;
    }

    private void ViewContent()
    {
        Console.WriteLine($"Height is {height}");
        Console.WriteLine($"Width is {width}");
    }

}

class Program
{
    static void Main(string[] args)
    {
        double a = 5, b = 10;
        Box b1 = new Box(a, b);
        Console.WriteLine($"First print from Main method: a is {a} and b is {b}");
        b1.SetHeight(8);
        a = 12;
        a = b1.MakeChanges(a);
        Console.WriteLine($"Second print from Main method: a is {a} and b is {b}");

    }
}
