namespace DesignPatterns._04_Composite;

public abstract class Component
{
    protected string _name;

    protected Component(string name)
    {
        _name = name;   
    }
    
    public abstract void Add(Component component);
    public abstract void Remove(Component component);
    public abstract void Display(int depth);
    
}

//https://refactoring.guru/design-patterns/composite/csharp/example
//https://en.wikipedia.org/wiki/Composite_pattern