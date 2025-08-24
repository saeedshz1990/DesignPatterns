using DesignPatterns._01_Decorator;
using DesignPatterns._02_Facade;
using DesignPatterns._03_Bridge.Abstractions;
using DesignPatterns._04_Composite;
using DesignPatterns._05_Flyweights;
using Component = DesignPatterns._04_Composite.Component;

ConcreteComponent concreteComponent =new ConcreteComponent();

// concreteComponent.Operations();
// Console.WriteLine("----------------------------------------------------------------");

// ConcreteComponent concreteComponent2 =new ConcreteComponent();

// ConcreteDecorator decorator = new ConcreteDecorator(concreteComponent2);

// decorator.Operations();
// Console.WriteLine("----------------------------------------------------------------");

// Facade facade = new Facade();
//
// facade.DoSomething();


// Abstraction abstraction = new RefinedAbstraction();
//
// abstraction.Function();

// DesignPatterns._04_Composite.Component component = new Composite("RootItem",new Component[]
// {
//     new Leaf("Leaf_Item_1"),
//     new Leaf("Leaf_Item_2"),
//     new Composite("Composite_1",new Component[]
//     {
//         new Leaf("leaf_Item_Composite_1-1"),
//         new Leaf("leaf_Item_Composite_1-2"),
//         new Leaf("leaf_Item_Composite_1-3"),
//     }),
//     new Leaf("Leaf_Item_3"),
//     new Leaf("Leaf_Item_4"),
// });
//
// component.Display(1);

FlyweightFactory flyweightFactory = new FlyweightFactory();

var result=flyweightFactory.GetFlyweight("saeed");

result.Operation("extrinsicstate");

UnsharedConcreteFlyweight unsharedConcreteFlyweight = new UnsharedConcreteFlyweight
(new List<Flyweight>
{
    flyweightFactory.GetFlyweight("Saeed"),
    flyweightFactory.GetFlyweight("Mohammad"),
    flyweightFactory.GetFlyweight("Reza"),
    flyweightFactory.GetFlyweight("Ali"),
    flyweightFactory.GetFlyweight("Hassan"),
    
});

unsharedConcreteFlyweight.Operation("unsharedConcreteFlyweight");


Console.ReadLine();