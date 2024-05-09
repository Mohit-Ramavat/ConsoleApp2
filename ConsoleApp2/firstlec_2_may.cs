/*//Task1

class Progra
{
    static void Main(string[] args)
    {
        int sum = 0;
        Console.WriteLine("The first 10 natural numbers are:");
        for (int i = 1; i <= 10; i++)
        {
            Console.Write(i + " ");
            sum += i;
        }
        Console.WriteLine("\nThe sum is: " + sum);
    }
}

//Task2


class Progr
{
    static void Main(string[] args)
    {
        int sum = 0;
        double average;
        int count = 1;

        Console.WriteLine("Input the 10 numbers:");

        while (count <= 10)
        {
            Console.Write("Number-" + count + " : ");
            int num = Convert.ToInt32(Console.ReadLine());
            sum += num;
            count++;
        }

        average = (double)sum / 10;

        Console.WriteLine("The sum of 10 numbers is: " + sum);
        Console.WriteLine("The average is: " + average.ToString("0.000000"));
    }
}

//Task3


class Prog
{
    static void Main(string[] args)
    {
        int rows = 4; 

       
        for (int i = 1; i <= rows; i++)
        {
            
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}

//Task4


class Pro
{
    static string GetDayOfWeek(int day)
    {
        string dayOfWeek;

        switch (day)
        {
            case 1:
                dayOfWeek = "Monday";
                break;
            case 2:
                dayOfWeek = "Tuesday";
                break;
            case 3:
                dayOfWeek = "Wednesday";
                break;
            case 4:
                dayOfWeek = "Thursday";
                break;
            case 5:
                dayOfWeek = "Friday";
                break;
            case 6:
                dayOfWeek = "Saturday";
                break;
            case 7:
                dayOfWeek = "Sunday";
                break;
            default:
                dayOfWeek = "Invalid day";
                break;
        }

        return dayOfWeek;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a number (1-7): ");
        int day = Convert.ToInt32(Console.ReadLine());

        string dayString = GetDayOfWeek(day);
        Console.WriteLine("Day: " + dayString);
    }
}

//Task5


class Pr
{
    static string GetDayOfWeek(int day)
    {
        string dayOfWeek;

        if (day == 1)
        {
            dayOfWeek = "Monday";
        }
        else if (day == 2)
        {
            dayOfWeek = "Tuesday";
        }
        else if (day == 3)
        {
            dayOfWeek = "Wednesday";
        }
        else if (day == 4)
        {
            dayOfWeek = "Thursday";
        }
        else if (day == 5)
        {
            dayOfWeek = "Friday";
        }
        else if (day == 6)
        {
            dayOfWeek = "Saturday";
        }
        else if (day == 7)
        {
            dayOfWeek = "Sunday";
        }
        else
        {
            dayOfWeek = "Invalid day";
        }

        return dayOfWeek;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a number (1-7): ");
        int day = Convert.ToInt32(Console.ReadLine());

        string dayString = GetDayOfWeek(day);
        Console.WriteLine("Day: " + dayString);
    }
}
*/