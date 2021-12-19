using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkDestroyAccelerationStructureKHR([NativeTypeName("VkDevice")] VkDevice device,
                                                                      [NativeTypeName("VkAccelerationStructureKHR")]
                                                                      ref VkAccelerationStructureKHR accelerationStructure,
                                                                      [NativeTypeName("const VkAllocationCallbacks *")]
                                                                      in VkAllocationCallbacks pAllocator);
}
