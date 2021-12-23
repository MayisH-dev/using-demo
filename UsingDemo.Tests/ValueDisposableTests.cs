namespace UsingDemo.Tests;

public sealed class ValueDisposableTests
{
    [Fact]
    public void UsingBlock_WhenAssigningOustsideBlock_BoxesValueType()
    {
        ValueDisposable disposable = new ();

        using (disposable){}

        disposable.DisposedFrom.Should().Be(DisposeSource.NotDisposed);
    }

    [Fact]
    public void UsingBlock_WhenAssigningInsideBlock_BoxesValueType()
    {
        ValueDisposable disposable;

        using (disposable = new ()){}

        disposable.DisposedFrom.Should().Be(DisposeSource.NotDisposed);
    }
}