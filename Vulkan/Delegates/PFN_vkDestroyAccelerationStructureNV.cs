using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkDestroyAccelerationStructureNV([NativeTypeName("VkDevice")] VkDevice device,
                                                                     [NativeTypeName("VkAccelerationStructureNV")]
                                                                     ref VkAccelerationStructureNV accelerationStructure,
                                                                     [NativeTypeName("const VkAllocationCallbacks *")]
                                                                     in VkAllocationCallbacks pAllocator);
}
