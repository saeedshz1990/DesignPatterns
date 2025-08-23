namespace DesignPatterns._04_Composite;

public class Composite : Component
{
    private List<Component> _components = new List<Component>();

    public Composite(string name) : base(name)
    {
    }

    public Composite(string name, Component[] components) : base(name)
    {
        foreach (Component item in components)
        {
            Add(item);
        }
    }

    public override void Add(Component component)
    {
        _components.Add(component);
    }

    public override void Remove(Component component)
    {
        _components.Remove(component);
    }

    public override void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + _name);
        foreach (var item in _components)
        {
            item.Display(depth + 2);
        }
    }
}