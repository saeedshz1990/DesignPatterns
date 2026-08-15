using DesignPatterns._01_Decorator;
using DesignPatterns._02_Facade;
using DesignPatterns._03_Bridge.Abstractions;
using DesignPatterns._03_Bridge.Implementors;
using DesignPatterns._04_Composite;
using DesignPatterns._05_Flyweights;
using Component = DesignPatterns._04_Composite.Component;

Console.WriteLine("=== Decorator ===");

var concreteComponent = new ConcreteComponent();
var decorator = new ConcreteDecorator(concreteComponent);
decorator.Operations();

Console.WriteLine();
Console.WriteLine("=== Facade ===");

var facade = new Facade();
facade.DoSomething();

Console.WriteLine();
Console.WriteLine("=== Bridge ===");

var abstraction = new RefinedAbstraction();
abstraction.Function();

abstraction.Function();

Console.WriteLine();
Console.WriteLine("=== Composite ===");

Component component = new Composite(
    "RootItem",
    new Component[]
    {
        new Leaf("Leaf_Item_1"),
        new Leaf("Leaf_Item_2"),
        new Composite(
            "Composite_1",
            new Component[]
            {
                new Leaf("Leaf_Item_Composite_1-1"),
                new Leaf("Leaf_Item_Composite_1-2")
            })
    });

component.Display(1);

Console.WriteLine();
Console.WriteLine("=== Flyweight ===");

var flyweightFactory = new FlyweightFactory();

var flyweight = flyweightFactory.GetFlyweight("Saeed");
flyweight.Operation("Extrinsic State");

var unsharedFlyweight = new UnsharedConcreteFlyweight(
    new List<Flyweight>
    {
        flyweightFactory.GetFlyweight("Saeed"),
        flyweightFactory.GetFlyweight("Mohammad"),
        flyweightFactory.GetFlyweight("Reza")
    });

unsharedFlyweight.Operation("Unshared Flyweight");