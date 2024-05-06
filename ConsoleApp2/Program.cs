
//Task1
class Program
{
    static void Main(string[] args)
    {
       
        List<int> numbers = new List<int>();

       
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);

       
        int firstElement = numbers.First();
        Console.WriteLine("First element in the list: " + firstElement);

        
        int firstOrDefaultElement = numbers.FirstOrDefault();
        Console.WriteLine("First or default element in the list: " + firstOrDefaultElement);

        List<int> emptyList = new List<int>();
       
    }
}
//Task 2
class Progra
{
    static void Main(string[] args)
    {
        int? nullableInt = 42;
        string stringValue;

        // Method 1: Using ToString() method
        if (nullableInt.HasValue)
        {
            stringValue = nullableInt.ToString();
            Console.WriteLine("Method 1: Converted value: " + stringValue);
        }
        else
        {
            Console.WriteLine("Method 1: Nullable integer is null.");
        }
    }
}

//task3



class Progr
{
    static void Main(string[] args)
    {
        // Boxing: Converting a value type to a reference type
        int value = 42;
        object boxedValue = value; // Boxing

        Console.WriteLine("Boxing: value = " + value + ", boxedValue = " + boxedValue);

        // Unboxing: Converting a reference type to a value type
        int unboxedValue = (int)boxedValue; // Unboxing

        Console.WriteLine("Unboxing: boxedValue = " + boxedValue + ", unboxedValue = " + unboxedValue);
    }
}
//Task4


class Prog
{
    
    const double PI = 3.14159;

    
    static double CalculateCircleArea(double radius)
    {
        return PI * radius * radius;
    }

    static void Main(string[] args)
    {
        double radius = 5.0;
        double area = CalculateCircleArea(radius);

        Console.WriteLine("Radius of the circle: " + radius);
        Console.WriteLine("Area of the circle: " + area);
    }
}

//Task5



class Pro
{
    
    readonly int readOnlyValue;

    
    public Pro(int value)
    {
        readOnlyValue = value;
    }

   
    void DisplayReadOnlyValue()
    {
        Console.WriteLine("Readonly Value: " + readOnlyValue);
    }

    static void Main(string[] args)
    {
       
        Pro program = new Pro(42);

        
        program.DisplayReadOnlyValue();

       
    }
}
