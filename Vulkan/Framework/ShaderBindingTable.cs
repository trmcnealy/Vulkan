using Vulkan.MemoryAllocator;

namespace Vulkan.Framework;

public class ShaderBindingTable
{
    private Device _Device;

    private VkStridedDeviceAddressRegionKHR _StridedDeviceAddressRegion = new VkStridedDeviceAddressRegionKHR();

    private ulong _DeviceAddress = new ulong();

    private VkBuffer _Handle = new VkBuffer(0);

    private VmaAllocation _Allocation = new VmaAllocation(0);

    private VkDeviceMemory _Memory = new VkDeviceMemory(0);

    private byte _MappedData = new byte(null);
}
