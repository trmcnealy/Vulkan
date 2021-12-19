using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkCreatePrivateDataSlotEXT([NativeTypeName("VkDevice")] VkDevice device,
                                                                   [NativeTypeName("const VkPrivateDataSlotCreateInfoEXT *")]
                                                                   in VkPrivateDataSlotCreateInfoEXT pCreateInfo,
                                                                   [NativeTypeName("const VkAllocationCallbacks *")]
                                                                   in VkAllocationCallbacks pAllocator,
                                                                   [NativeTypeName("VkPrivateDataSlotEXT *")]
                                                                   out VkPrivateDataSlotEXT pPrivateDataSlot);
}
