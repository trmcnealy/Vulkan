using System.Runtime.InteropServices;

namespace Vulkan.MemoryAllocator;

[StructLayout(LayoutKind.Sequential,
              CharSet = CharSet.Unicode)]
public partial struct VmaDefragmentationPassMoveInfo
{
    public VmaAllocation allocation;

    public VkDeviceMemory memory;

    public ulong offset;
}