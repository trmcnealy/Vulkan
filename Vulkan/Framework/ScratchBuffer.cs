using Vulkan.MemoryAllocator;

namespace Vulkan.Framework;

public class ScratchBuffer
{
    private Device _Device;

    private ulong _DeviceAddress = new ulong();

    private VkBuffer _Handle = new VkBuffer(0);

    private VmaAllocation _Allocation = new VmaAllocation(0);

    private VkDeviceMemory _Memory = new VkDeviceMemory(0);

    private uint _Size = new uint();
}
