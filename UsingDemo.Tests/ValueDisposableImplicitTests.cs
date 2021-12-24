namespace UsingDemo.Tests;

public sealed class ValueDisposableImplicitTests
{
    [Fact]
    public void UsingBlock_WhenAssigningOustsideBlock_BoxesValueType()
    {
        ValueDisposableImplicit disposable = new ();

        using (disposable){}

        disposable.DisposedFrom.Should().Be(DisposeSource.NotDisposed);
    }

    [Fact]
    public void UsingBlock_WhenAssigningInsideBlock_BoxesValueType()
    {
        ValueDisposableImplicit disposable;

        using (disposable = new ()){}

        disposable.DisposedFrom.Should().Be(DisposeSource.NotDisposed);
    }
}
