namespace DesignPatterns._03_Bridge.Implementors;

public class ConcreteImplementor : Implementor
{
    public override void Implementation()
    {
        Console.WriteLine("ConcreteImplementor.Implementation()");
    }
}