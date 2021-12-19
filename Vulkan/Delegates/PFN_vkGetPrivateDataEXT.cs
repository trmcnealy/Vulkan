using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkGetPrivateDataEXT([NativeTypeName("VkDevice")] VkDevice device,
                                                        VkObjectType                          objectType,
                                                        [NativeTypeName("uint64_t")] ulong    objectHandle,
                                                        [NativeTypeName("VkPrivateDataSlotEXT")]
                                                        ref VkPrivateDataSlotEXT privateDataSlot,
                                                        [NativeTypeName("uint64_t *")] in ulong pData);
}
