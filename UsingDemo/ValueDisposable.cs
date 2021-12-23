namespace UsingDemo;

public struct ValueDisposable : IDisposable
{
    public DisposeSource DisposedFrom {get; set;} = DisposeSource.NotDisposed;

    public void Dispose() => DisposedFrom = DisposeSource.Implicit;

    void IDisposable.Dispose() => DisposedFrom = DisposeSource.Explicit;
}