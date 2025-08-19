namespace DesignPatterns._01_Decorator;

public class ConcreteComponent :Component
{
    public override void Operations()
    {
        Console.WriteLine("ConcreteComponent.Operations()");
    }
}

//https://en.wikipedia.org/wiki/Decorator_pattern
//https://refactoring.guru/design-patterns/decorator