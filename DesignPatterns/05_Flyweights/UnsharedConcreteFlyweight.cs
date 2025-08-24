namespace DesignPatterns._05_Flyweights;

public class UnsharedConcreteFlyweight
{
    private IEnumerable<Flyweight> _flyweights;

    public UnsharedConcreteFlyweight(IEnumerable<Flyweight> flyweights)
    {
        _flyweights = flyweights;
    }

    public void Operation(string extrinsicstate)
    {
        foreach (var flyweight in _flyweights)
        {
            flyweight.Operation(extrinsicstate);
        }
    }
}