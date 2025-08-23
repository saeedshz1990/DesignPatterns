using DesignPatterns._02_Facade.Package_1;
using DesignPatterns._02_Facade.Package_2;
using DesignPatterns._02_Facade.Package_3;

namespace DesignPatterns._02_Facade;

public class Facade
{
    public void DoSomething()
    {
        Class1 class1 = new Class1();
        Class2 class2 = new Class2();
        Class3 class3 = new Class3();
        
        class1.Run();
        class2.Run();
        class3.Run();
        
        Console.WriteLine("DoSomething()");
    }
}


//https://refactoring.guru/design-patterns/facade/csharp/example#lang-features
//https://en.wikipedia.org/wiki/Facade_pattern