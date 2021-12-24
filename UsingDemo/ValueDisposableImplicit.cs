namespace UsingDemo;

public struct ValueDisposableImplicit : IDisposable
{
    public DisposeSource DisposedFrom {get; set;} = DisposeSource.NotDisposed;

    public void Dispose() => DisposedFrom = DisposeSource.Implicit;
}
