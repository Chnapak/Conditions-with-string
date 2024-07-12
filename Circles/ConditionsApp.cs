namespace Conditions;
public class PodminkyApp
{
    public void Run()
    {
        // User inputs four strings:

        // Translation: Input first (second, third etc.)
        Console.WriteLine("Zadej first:");
        string first = Console.ReadLine()!;
        Console.WriteLine("Zadej second:");
        string second = Console.ReadLine()!;
        Console.WriteLine("Zadej third:");
        string third = Console.ReadLine()!;
        Console.WriteLine("Zadej fourth:");
        string fourth = Console.ReadLine()!;

        // Creates two string of two words, where the longer word goes first and is capitalized.
        string result1 = GetResult(first, second);
        string result2 = GetResult(third, fourth);

        // I assume this was to prevent DRY principle, but now is pretty useless.
        PrintDelimiter();

        // This one will join the two sentences and capitalize the first.
        Console.WriteLine(Process(result1, result2));
        // This one will pick the longer of the two setences and puts it first and capitalizes it.
        Console.WriteLine(GetResult(GetResult(first, second), GetResult(third, fourth)));
    }
    
    public void PrintDelimiter()
    {
        Console.WriteLine("--------");
    }

    /* GetResult finds the longer of the two sentences and sends both into Process(),
       so the longer one is first. */
    public string GetResult(string a, string b)
    {
        string x;
        if (a.Length >= b.Length){
            x = Process(a, b);
        }
        else{
            x = Process(b, a);
        }
        return x;
    }

    // Process capilizes the first input and lowers the second.
    public string Process(string a, string b)
    {
       return a.ToUpper() + b.ToLower();
    }
}   