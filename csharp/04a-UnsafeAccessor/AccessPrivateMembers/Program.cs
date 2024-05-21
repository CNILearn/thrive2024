using System.Runtime.CompilerServices;
using UnsafeAccessorSample;

Book b1 = new("Pragmatic Microservices");
Console.WriteLine(b1);

// set the private field using this unsafe accessor
PrivateBookAccessor.GetTitle(b1) = "Pragmatic Microservices with .NET and Azure";
Console.WriteLine(b1);

// call the private method using this unsafe accessor
PrivateBookAccessor.CallPrivatePrint(b1);

internal class PrivateBookAccessor
{
    [UnsafeAccessor(UnsafeAccessorKind.Field, Name = "_title")] // Define the kind of accessor and the name of the private member (in this case, the field _title)
    public extern static ref string GetTitle(Book @this); // Here we get the reference to the private member (in this case, the field _title)

    [UnsafeAccessor(UnsafeAccessorKind.Method, Name = "PrivatePrint")] // Define the kind of accessor and the name of the private member (in this case, the method PrivatePrint)
    public extern static void CallPrivatePrint(Book @this); // Here we call the private method PrivatePrint
}