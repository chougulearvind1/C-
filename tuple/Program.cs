namespace tuple;

class Program
{
    static void Main(string[] args)
    {
        //reference type tuple
        var person = new Tuple<string, int>("John", 30);
        Console.WriteLine($"Name: {person.Item1}, Age: {person.Item2}");
        //value type tuple
        var person2 = ("Alice", 25);
        Console.WriteLine($"Name: {person2.Item1}, Age: {person2.Item2}");
        Console.WriteLine("");
        //nested tuple
        var nestedTuple = new Tuple<string, int, Tuple<string, int>>("Bob", 30, new Tuple<string, int>("Charlie", 35));
        Console.WriteLine($"Name: {nestedTuple.Item1}, Age: {nestedTuple.Item2}");
        Console.WriteLine($"Name: {nestedTuple.Item3.Item1}, Age: {nestedTuple.Item3.Item2}");
        //nested value type tuple
        var nestedTuple2 = ("David", 40, ("Eve", 45));  
        Console.WriteLine($"Name: {nestedTuple2.Item1}, Age: {nestedTuple2.Item2}");
        Console.WriteLine($"Name: {nestedTuple2.Item3.Item1}, Age: {nestedTuple2.Item3.Item2}");//
        //deconstructing tuple
        var person3 = ("Frank", 50);        
        Console.WriteLine("");
        var (name, age) = person3;
        Console.WriteLine($"Name: {name}, Age: {age}");
        //deconstructing nested tuple
        var nestedTuple3 = ("Grace", 55, ("Hank", 60));
        var (name2, age2, (name3, age3)) = nestedTuple3;
        Console.WriteLine($"Name: {name2}, Age: {age2}"); 
        Console.WriteLine($"Name: {name3}, Age: {age3}");
        //using tuple method
        var (name4, age4) = GetPerson();
        Console.WriteLine($"Name: {name4}, Age: {age4}");
        int sum = Add((5, 10));
        Console.WriteLine($"Sum: {sum}");
        int sum2 = mul((20, 30));

    }
    static int mul((int x, int y) numbers)
    {
        return numbers.x * numbers.y;
    }
    static (string, int) GetPerson()
    {
        return ("Ivy", 65);
    }
    static int Add((int, int) numbers)
    {
        return numbers.Item1 + numbers.Item2;
    }
}
