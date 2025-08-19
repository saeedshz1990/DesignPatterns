namespace DesignPatterns._01_Decorator;

public abstract class Decorator : Component
{
    private readonly Component _component;

    protected Decorator(Component component)
    {
        _component = component;
    }

    public override void Operations()
    {
        _component.Operations();    
        
    }
}