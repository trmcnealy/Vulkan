using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkCreateAccelerationStructureKHR([NativeTypeName("VkDevice")] VkDevice device,
                                                                         [NativeTypeName("const VkAccelerationStructureCreateInfoKHR *")]
                                                                         in VkAccelerationStructureCreateInfoKHR pCreateInfo,
                                                                         [NativeTypeName("const VkAllocationCallbacks *")]
                                                                         in VkAllocationCallbacks pAllocator,
                                                                         [NativeTypeName("VkAccelerationStructureKHR *")]
                                                                         out VkAccelerationStructureKHR pAccelerationStructure);
}
