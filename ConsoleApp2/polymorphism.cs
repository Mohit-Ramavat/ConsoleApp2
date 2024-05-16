//Task1

using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            int a = 5;
            int b = 6;

            Console.WriteLine("Before swapping");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            Swap(ref a, ref b);

            Console.WriteLine("After swapping");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            double width = 5;
            double height = 10;
            double area;
            double perimeter;

            CalculateRectangleProperties(width, height, out area, out perimeter);

            Console.WriteLine("Rectangle Properties:");
            Console.WriteLine("Width = " + width);
            Console.WriteLine("Height = " + height);
            Console.WriteLine("Area = " + area);
            Console.WriteLine("Perimeter = " + perimeter);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }

    static void Swap(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }

    static void CalculateRectangleProperties(double width, double height, out double area, out double perimeter)
    {
        area = width * height;
        perimeter = 2 * (width + height);
    }
}


//Task 2

using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Choose shape from rectangle, circle, and triangle");
            Console.WriteLine("1: Rectangle");
            Console.WriteLine("2: Circle");
            Console.WriteLine("3: Triangle");
            Console.WriteLine("Enter your choice (1, 2, or 3):");

            int choice = Convert.ToInt32(Console.ReadLine());

            dynamic shape;

            switch (choice)
            {
                case 1:
                    Console.Write("Enter the length of rectangle: ");
                    var length = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter the width of rectangle: ");
                    var width = Convert.ToDouble(Console.ReadLine());

                    shape = new { Length = length, Width = width };

                    Console.WriteLine("Area of rectangle: " + CalculateRectangleArea(shape));
                    break;

                case 2:
                    Console.Write("Enter the radius of circle: ");
                    var radius = Convert.ToDouble(Console.ReadLine());
                    shape = new { Radius = radius };

                    Console.WriteLine("Area of circle: " + CalculateCircleArea(shape));
                    break;

                case 3:
                    Console.Write("Enter the base of triangle: ");
                    var @base = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter the height of triangle: ");
                    var height = Convert.ToDouble(Console.ReadLine());
                    shape = new { Base = @base, Height = height };

                    Console.WriteLine($"Area of triangle: {CalculateTriangleArea(shape)}");
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }

    static double CalculateRectangleArea(dynamic shape)
    {
        return shape.Length * shape.Width;
    }

    static double CalculateCircleArea(dynamic shape)
    {
        return Math.PI * Math.Pow(shape.Radius, 2);
    }

    static double CalculateTriangleArea(dynamic shape)
    {
        return 0.5 * shape.Base * shape.Height;
    }
}


//Task3

using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            string input = "hello world";
            string titleCase = input.ToTitleCase();
            Console.WriteLine(titleCase);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}

public static class StringExtension
{
    public static string ToTitleCase(this string input)
    {
        return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input.ToLower());
    }
}


//Task4

class vehicle
{
    public void describe()
    {
        Console.WriteLine("This is a vehicle");
    }

}

class car : vehicle
{
    public void cartype()
    {
        Console.WriteLine("This is a car");
    }
}

class electriccar : car
{
    public void battery()
    {
        Console.WriteLine("its lithium battery");
    }
}

class program
{
    static void Main(string[] args)
    {

        electriccar myecar = new electriccar();
        myecar.describe();
        myecar.cartype();
        myecar.battery();

    }
}

//Task5

interface Iemployee
{
    void work();
}

interface Imanager
{
    void manage();
}

class employee : Iemployee
{
    public void work()
    {
        Console.WriteLine("employee is working");
    }
}

class manager : employee, Imanager
{
    public void manage()
    {
        Console.WriteLine("manager is managing");
    }
}

class program
{
    static void Main(string[] args)
    {
        manager eman = new manager();
        eman.work();
        eman.manage();
    }
}