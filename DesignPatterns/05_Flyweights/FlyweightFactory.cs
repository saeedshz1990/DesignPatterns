namespace DesignPatterns._05_Flyweights;

public class FlyweightFactory
{
    private readonly Dictionary<string, Flyweight> _flyweightDictionary = new();

    public Flyweight GetFlyweight(string key)
    {
        Flyweight? flyweight;

        if (!_flyweightDictionary.TryGetValue(key, out flyweight))
        {
            flyweight = new ConcreteFlyweight(key);

            _flyweightDictionary.Add(key, flyweight);
        }
        
        return flyweight;
    }
}

//https://refactoring.guru/design-patterns/flyweight/csharp/example
//https://en.wikipedia.org/wiki/Flyweight_pattern