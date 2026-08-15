using DesignPatterns._03_Bridge.Implementors;

namespace DesignPatterns._03_Bridge.Abstractions;

public abstract class Abstraction
{
    private Implementors.Implementor _implementor;

    public virtual void Function()
    {
        _implementor = new ConcreteImplementor();
        
        _implementor.Implementation();
    }
}

//https://refactoring.guru/design-patterns/bridge/csharp/example#lang-features
//https://en.wikipedia.org/wiki/Bridge_pattern