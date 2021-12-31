using System.Runtime.CompilerServices;

namespace Vulkan;

public interface IArray
{
    int Capacity
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get;
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set;
    }

    void RemoveRange(int index,
                     int count);

    void Resize(int size);

    void Resize(uint size);

    void Reverse(int index,
                 int count);

    void Sort();

    void Swap(int indexA,
              int indexB);

    void TrimExcess();
}
