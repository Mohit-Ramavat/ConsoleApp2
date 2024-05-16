/*//Task1

class Animal
{
    public void Speak()
    {
        Console.WriteLine("Animal speaks");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog barks");
    }
}

class last
{
    static void Main(string[] args)
    {
        
        Dog dog = new Dog();
        dog.Speak(); 
        dog.Bark();  
    }
}

//Task2
    

class Animal
{
    public void Speak()
    {
        Console.WriteLine("Animal speaks");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog barks");
    }
}

class Labrador : Dog
{
    public void Color()
    {
        Console.WriteLine("Labrador is brown");
    }
}

class Program
{
    static void Main(string[] args)
    {
       
        Labrador labrador = new Labrador();
        labrador.Speak(); 
        labrador.Bark();  
        labrador.Color(); 
    }
}
//Task3


class Animal
{
    public void Speak()
    {
        Console.WriteLine("Animal speaks");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog barks");
    }
}

class Cat : Animal
{
    public void Meow()
    {
        Console.WriteLine("Cat meows");
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Cat cat = new Cat();
        cat.Speak(); 
        cat.Meow();  
    }
}
//Task4




interface IA
{
    void MethodA();
}


interface IB
{
    void MethodB();
}


class A : IA
{
    public void MethodA()
    {
        Console.WriteLine("Method A");
    }
}


class C : A, IB
{
    public void MethodB()
    {
        Console.WriteLine("Method B");
    }
        
    public void MethodC()
    {
        Console.WriteLine("Method C");
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        C cObj = new C();
        cObj.MethodA(); 
        cObj.MethodB(); 
        cObj.MethodC(); 
    }
}

//Task5



interface IShape
{
    double Area();
}


class Rectangle : IShape
{
    private double length;
    private double width;

    
    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    
    public double Area()
    {
        return length * width;
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Rectangle rectangle = new Rectangle(5, 4);

        
        double area = rectangle.Area();

        Console.WriteLine($"Area of rectangle: {area}");
    }
}

//Task6


interface IShape
{
    double Area();
}


class Rectangle : IShape
{
    private double length;
    private double width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    
    double IShape.Area()
    {
        return length * width;
    }
}

class Program
{
    static void Main(string[] args)
    {
      
        Rectangle rectangle = new Rectangle(5, 4);

        
        double area = ((IShape)rectangle).Area();

        Console.WriteLine($"Area of rectangle: {area}");
    }
}

*/