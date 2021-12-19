using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkDestroyPrivateDataSlotEXT([NativeTypeName("VkDevice")] VkDevice device,
                                                                [NativeTypeName("VkPrivateDataSlotEXT")]
                                                                ref VkPrivateDataSlotEXT privateDataSlot,
                                                                [NativeTypeName("const VkAllocationCallbacks *")]
                                                                in VkAllocationCallbacks pAllocator);
}
