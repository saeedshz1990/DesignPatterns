namespace DesignPatterns._01_Decorator;

public class ConcreteDecorator : Decorator
{
    public ConcreteDecorator(Component component) : base(component)
    {
    }

    public override void Operations()
    {
        base.Operations();
        
        Console.WriteLine("ConcreteDecorator.Operations()");

        Console.ReadLine();
    }
}