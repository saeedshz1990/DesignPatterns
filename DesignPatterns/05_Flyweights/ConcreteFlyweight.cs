namespace DesignPatterns._05_Flyweights;

public class ConcreteFlyweight :Flyweight
{
    private readonly string _intrinsicState;

    public ConcreteFlyweight(string intrinsicState)
    {
        _intrinsicState = intrinsicState;
    }

    public override void Operation(string extrinsicstate)
    {
        Console.WriteLine($"ConcreteFlyweight.Operation()==> extrinsic ==>{extrinsicstate} ==> intrinsic ==>{_intrinsicState}");
    }
}