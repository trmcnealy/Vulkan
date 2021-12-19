using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkGetMemoryFdPropertiesKHR([NativeTypeName("VkDevice")] VkDevice device,
                                                                   VkExternalMemoryHandleTypeFlagBits    handleType,
                                                                   int                                   fd,
                                                                   VkMemoryFdPropertiesKHR*              pMemoryFdProperties);
}
