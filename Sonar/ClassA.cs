namespace Sonar;

public record ClassA
{
    public void DoSomething()
    {
        // ...
    }
}

public record ClassB
{
    public void DoSomethingElse()
    {
        // Depends on ClassA.DoSomething
    }
}