// C# 12 - Alias Any

// Alias for tuples
using Book = (string Title, string Description, string Author);

// Alias for generics
using OneString = One<string>;
using OneInt = One<int>;

// Alias for arrays
using IntArray = int[];

// Usecase: Lengthy type definition
using Mapping = System.Collections.Generic.Dictionary<string, System.Collections.Generic.IReadOnlyCollection<MyCoolClassWithVeryVeryVeryVeryVeryLengthyName>>;


Book pragmaticMicroservices = new ("Pragmatic Microservices with C# and Azure", "Description", "Chistian Nagel");
Console.WriteLine(pragmaticMicroservices.Title);

Book pragmaticMicroservices2 = ("Pragmatic Microservices with C# and Azure", "Description", "Chistian Nagel");
(string title, string description, string author) = pragmaticMicroservices2;
Console.WriteLine(title);

OneString myString = new();
myString.Print("Hello World");

OneInt myInt = new();
myInt.Print(42);

IntArray myArray = [1, 2, 3];

Mapping mapping = new();


public class One<T>
{
    public void Print(T value) =>
        Console.WriteLine(value);
}

public class MyCoolClassWithVeryVeryVeryVeryVeryLengthyName
{
}