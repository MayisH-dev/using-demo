namespace  UsingDemo;

internal static class DisposeExpandedExample
{
    static void UsingBlock()
    {
        using(Disposable disposable = new ())
        {
            Console.WriteLine("hello");
        }
    }

    static void UsingStatement()
    {
        using Disposable disposable = new();
        Console.WriteLine("hello");
    }

    static void DisposeExpandedEquivalent()
    {
        Disposable disposable = new(); // Declared outside the try scope, to be accessible in the finally scope
        try
        {
            Console.WriteLine("hello"); // contents of using block goes here, (or the rest of the method if using statement is used)
        }
        finally
        {
            if (disposable != null) // this check is omitted when the target is a non-nullable value type
            {
                ((IDisposable)disposable).Dispose(); // cast to disposable, so always prefers explicit implementation
            }
        }
    }
}