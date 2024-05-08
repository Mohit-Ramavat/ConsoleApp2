//Task1
using System.Text.RegularExpressions;

class substr
{
    static void Main()
    {
        string input = "hello";


        for (int i = 0; i < input.Length; i++)
        {
            for (int j = i + 1; j <= input.Length; j++)
            {
                string substring = input.Substring(i, j - i);
                Console.WriteLine(substring);
            }
        }
    }
}

//Task2
class Program
{
    static void Main(string[] args)
    {
        string inputString = "Hello, World!";
        char charToCount = 'o';

        int occurrenceCount = CountCharacterOccurrences(inputString, charToCount);

        Console.WriteLine($"The character '{charToCount}' occurs {occurrenceCount} times in the string.");
    }

    static int CountCharacterOccurrences(string input, char target)
    {
        int count = 0;
        foreach (char c in input)
        {
            if (c == target)
            {
                count++;
            }
        }
        return count;
    }
}

//Task3


class Program
{
    static void Main(string[] args)
    {
        string inputString = "Hello, World!";
        string reversedString = ReverseString(inputString);

        Console.WriteLine("Original string: " + inputString);
        Console.WriteLine("Reversed string: " + reversedString);
    }

    static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray(); 
        int start = 0;
        int end = input.Length - 1;

       
        while (start < end)
        {
            char temp = charArray[start];
            charArray[start] = charArray[end];
            charArray[end] = temp;
            start++;
            end--;
        }

        return new string(charArray); 
    }
}


//Task 4


class Program
{
    static void Main(string[] args)
    {
        string inputString = "Hello, World!";
        string reversedWordsString = ReverseWords(inputString);

        Console.WriteLine("Original string: " + inputString);
        Console.WriteLine("String with reversed words: " + reversedWordsString);
    }

    static string ReverseWords(string input)
    {
        string[] words = input.Split(' '); 
        for (int i = 0; i < words.Length; i++)
        {
            words[i] = ReverseString(words[i]);
        }
        return string.Join(" ", words); 
    static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        int start = 0;
        int end = input.Length - 1;

        
        while (start < end)
        {
            char temp = charArray[start];
            charArray[start] = charArray[end];
            charArray[end] = temp;
            start++;
            end--;
        }

        return new string(charArray); 
    }
}

 //Task 5

   
class Program
{
    static void Main(string[] args)
    {
        string inputString = "hello";
        string stringWithoutDuplicates = RemoveDuplicates(inputString);

        Console.WriteLine("Original string: " + inputString);
        Console.WriteLine("String without duplicates: " + stringWithoutDuplicates);
    }

    static string RemoveDuplicates(string input)
    {
        HashSet<char> seen = new HashSet<char>(); 
        string result = ""; 

        foreach (char c in input)
        {
            if (!seen.Contains(c))
            {
                seen.Add(c); 
                result += c;
            }
        }

        return result;
    }
}

    //Task6
 

class Program
{
    static void Main(string[] args)
    {
        string inputString = "Hello, World!";
        int wordCount = CountWords(inputString);

        Console.WriteLine("Number of words in the string: " + wordCount);
    }

    static int CountWords(string input)
    {
        string[] words = input.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }
}
//Task7


class Program
{
    static void Main(string[] args)
    {
        string inputString = "radar";
        bool isPalindrome = IsPalindrome(inputString);

        Console.WriteLine($"Is \"{inputString}\" a palindrome? {isPalindrome}");
    }

    static bool IsPalindrome(string input)
    {
        int left = 0;
        int right = input.Length - 1;

        while (left < right)
        {
            if (input[left] != input[right])
            {
                return false; 
            }
            left++;
            right--;
        }
        return true;
    }
}
//Task8

class Program
{
    static void Main(string[] args)
    {
        string inputString = "hello world";

        char highestChar = GetHighestOccurredChar(inputString);
        char minimumChar = GetMinimumOccurredChar(inputString);

        Console.WriteLine($"Highest occurred character: {highestChar}");
        Console.WriteLine($"Minimum occurred character: {minimumChar}");
    }

    static char GetHighestOccurredChar(string input)
    {
        Dictionary<char, int> charCounts = new Dictionary<char, int>();

        foreach (char c in input)
        {
            if (charCounts.ContainsKey(c))
            {
                charCounts[c]++;
            }
            else
            {
                charCounts[c] = 1;
            }
        }

        return charCounts.OrderByDescending(kv => kv.Value).First().Key;
    }

    static char GetMinimumOccurredChar(string input)
    {
        Dictionary<char, int> charCounts = new Dictionary<char, int>();

        foreach (char c in input)
        {
            if (charCounts.ContainsKey(c))
            {
                charCounts[c]++;
            }
            else
            {
                charCounts[c] = 1;
            }
        }

        return charCounts.OrderBy(kv => kv.Value).First().Key;
    }
}
//Task9
class Program
{
    static void Main(string[] args)
    {
        string inputString = "C:\\Users\\John\\Documents\\File.txt";
        string arrangedString = ArrangeString(inputString);

        Console.WriteLine("Original string:");
        Console.WriteLine(inputString);

        Console.WriteLine("\nArranged string:");
        Console.WriteLine(arrangedString);
    }

    static string ArrangeString(string input)
    {
        
        return input.Replace('\\', '/');
    }
}

//Task10



class Program
{
    static void Main(string[] args)
    {
        string inputString = "The quick brown fox jumps over the lazy dog";
        string substring = "brown";

        int index = FindSubstringIndex(inputString, substring);

        if (index != -1)
        {
            Console.WriteLine($"Substring \"{substring}\" found at index {index}.");
        }
        else
        {
            Console.WriteLine($"Substring \"{substring}\" not found in the string.");
        }
    }

    static int FindSubstringIndex(string input, string substring)
    {
        return input.IndexOf(substring);
    }
}

//Task11


class Program
{
    static void Main(string[] args)
    {
        string inputString = "Hello, World! This is a test string with 123 and special characters like @#$.";

        string result = RemoveNonAlphanumeric(inputString);

        Console.WriteLine("Original string:");
        Console.WriteLine(inputString);

        Console.WriteLine("\nString with non-alphanumeric characters removed:");
        Console.WriteLine(result);
    }

    static string RemoveNonAlphanumeric(string input)
    {
        
        string pattern = @"[^a-zA-Z0-9\s]";

        return Regex.Replace(input, pattern, "");
    }
}
