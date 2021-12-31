namespace Vulkan;

public interface IIterator<T> : IIterator
where T : notnull
{
    T this[int _Pos] { get; set; }

    T Current { get; }

    Array<T>? Container();
    int       Distance(Iterator<T> _Right);
    bool      LessThan(Iterator<T> otherIterator);
}
