using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate VkResult PFN_vkSetPrivateDataEXT([NativeTypeName("VkDevice")] VkDevice device,
                                                     VkObjectType                          objectType,
                                                     [NativeTypeName("uint64_t")] ulong    objectHandle,
                                                     [NativeTypeName("VkPrivateDataSlotEXT")]
                                                     ref VkPrivateDataSlotEXT privateDataSlot,
                                                     [NativeTypeName("uint64_t")] ulong data);
}
