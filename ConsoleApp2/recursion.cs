/*//Task1



class Program
{
    static int Factorial(int n)
    {
       
        if (n == 0)
            return 1;

        return n * Factorial(n - 1);
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a number to find its factorial: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int result = Factorial(num);
        Console.WriteLine("Factorial of " + num + " is: " + result);
    }
}

//Task2


class Progra
{
    static void Main(string[] args)
    {
        
        if (args.Length == 0)
        {
            Console.WriteLine("No command-line arguments provided.");
        }
        else
        {
            Console.WriteLine("Command-line arguments:");

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {args[i]}");
            }
        }
    }
}

//Task3


class Student
{
    public string Name { get; set; }

    public Student(string name)
    {
        Name = name;
    }
}

class Progr
{
    static void UpdateStudentName(Student student, string newName)
    {
        student.Name = newName;
    }

    static void Main(string[] args)
    {
        
        Student student = new Student("John");

        
        Console.WriteLine("Original name: " + student.Name);

        
        UpdateStudentName(student, "Alice");

       
        Console.WriteLine("Updated name: " + student.Name);
    }
}

//Task4

class Prog
{
    static void Main(string[] args)
    {
       
        StringBuilder sb = new StringBuilder();

        
        sb.Append("Hello, ");
        sb.Append("world!");

        
        Console.WriteLine(sb.ToString());
    }
}

//Task5



class Pro
{
    static void Main(string[] args)
    {
       
        StringBuilder sb = new StringBuilder("This is a sample sentence.");

        
        sb.Replace("sample", "new");

       
        Console.WriteLine(sb.ToString());
    }
}
*/