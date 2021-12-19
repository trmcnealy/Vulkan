using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkGetMemoryHostPointerPropertiesEXT([NativeTypeName("VkDevice")] VkDevice device,
                                                                            VkExternalMemoryHandleTypeFlagBits    handleType,
                                                                            [NativeTypeName("const void *")] nint pHostPointer,
                                                                            VkMemoryHostPointerPropertiesEXT*     pMemoryHostPointerProperties);
}
