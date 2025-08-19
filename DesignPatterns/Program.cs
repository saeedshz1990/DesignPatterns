// See https://aka.ms/new-console-template for more information

using DesignPatterns._01_Decorator;

ConcreteComponent concreteComponent =new ConcreteComponent();

concreteComponent.Operations();
Console.WriteLine("----------------------------------------------------------------");

ConcreteComponent concreteComponent2 =new ConcreteComponent();

ConcreteDecorator decorator = new ConcreteDecorator(concreteComponent2);

decorator.Operations();

Console.ReadLine();