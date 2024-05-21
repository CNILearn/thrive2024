namespace UnsafeAccessorSample;

public class Book(string title)
{
    private readonly string _title = title;
    
    private void PrivatePrint() =>
        Console.WriteLine($"PrivatePrint: {_title}");
    
    public override string ToString() => _title;
}