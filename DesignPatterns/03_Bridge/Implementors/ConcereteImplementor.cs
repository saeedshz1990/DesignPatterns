namespace DesignPatterns._03_Bridge.Implementors;

public class ConcereteImplementor : Implementor
{
    public override void Implementation()
    {
        Console.WriteLine("ConcereteImplementor.Implementation()");
    }
}