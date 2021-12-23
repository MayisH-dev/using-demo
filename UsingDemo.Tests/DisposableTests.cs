namespace UsingDemo.Tests;

public sealed class DisposableTests
{
    [Fact]
    public void UsingBlock_WhenAssigningOutsideBlock_CallsExplicitImplementation()
    {
        Disposable disposable = new ();

        using (disposable){}

        disposable.DisposedFrom.Should().Be(DisposeSource.Explicit);
    }

    [Fact]
    public void UsingBlock_WhenAssigningInsideBlock_CallsExplicitImplementation()
    {
        Disposable disposable;

        using (disposable = new ()){}

        disposable.DisposedFrom.Should().Be(DisposeSource.Explicit);
    }
}