using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkCreateAccelerationStructureNV([NativeTypeName("VkDevice")] VkDevice device,
                                                                        [NativeTypeName("const VkAccelerationStructureCreateInfoNV *")]
                                                                        in VkAccelerationStructureCreateInfoNV pCreateInfo,
                                                                        [NativeTypeName("const VkAllocationCallbacks *")]
                                                                        in VkAllocationCallbacks pAllocator,
                                                                        [NativeTypeName("VkAccelerationStructureNV *")]
                                                                        out VkAccelerationStructureNV pAccelerationStructure);
}
