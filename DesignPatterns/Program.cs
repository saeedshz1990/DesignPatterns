using DesignPatterns._01_Decorator;
using DesignPatterns._02_Facade;
using DesignPatterns._03_Bridge.Abstractions;

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


Abstraction abstraction = new RefinedAbstraction();

abstraction.Function();

Console.ReadLine();