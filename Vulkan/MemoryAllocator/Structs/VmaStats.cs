using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan.MemoryAllocator;

/// <summary>
/// General statistics from current state of Allocator.
/// </summary>
[StructLayout(LayoutKind.Sequential,
              CharSet = CharSet.Unicode)]
public unsafe struct VmaStats : IDispose
{
    private static readonly int VmaStatInfoSize;

    static VmaStats()
    {
        VmaStatInfoSize = Unsafe.SizeOf<VmaStatInfo>();
    }


    public VmaStatInfo* memoryType;
    
    public VmaStatInfo* memoryHeap;

    public VmaStatInfo total;

    public VmaStats()
    {
        memoryType = (VmaStatInfo*)NativeMemory.Alloc((nuint)VmaStatInfoSize * 32);
        memoryHeap = (VmaStatInfo*)NativeMemory.Alloc((nuint)VmaStatInfoSize * 16);
        total      = new VmaStatInfo();
    }

    public void Dispose(VkInstance instance,
                        VkDevice   device)
    {
        if(memoryType != null)
        {
            NativeMemory.Free(memoryType);
            memoryType = null;
        }

        if(memoryHeap != null)
        {
            NativeMemory.Free(memoryHeap);
            memoryHeap = null;
        }
    }
}