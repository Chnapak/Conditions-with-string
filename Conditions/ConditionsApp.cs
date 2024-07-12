namespace Podminky;

public class PodminkyApp
{
    public void Run()
    {
        Console.WriteLine("Zadej first:");
        string first = Console.ReadLine();
        Console.WriteLine("Zadej second:");
        string second = Console.ReadLine();
        Console.WriteLine("Zadej third:");
        string third = Console.ReadLine();
        Console.WriteLine("Zadej fourth:");
        string fourth = Console.ReadLine();
        string res1;
        string res2;
        res1 = GetResult(first, second);
        res2 = GetResult(third, fourth);
        PrintDelimiter();
        Console.WriteLine(Process(res1, res2));
        Console.WriteLine(GetResult(GetResult(first, second), GetResult(third, fourth)));
    }

    public string Process(string a, string b)
    {
        return a.ToUpper() + b.ToLower();
    }

    public void PrintDelimiter()
    {
        Console.WriteLine("####");
    }
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
}