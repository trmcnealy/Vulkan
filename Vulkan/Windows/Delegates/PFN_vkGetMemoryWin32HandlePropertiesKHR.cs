using System.Runtime.InteropServices;

namespace Vulkan.Windows
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkGetMemoryWin32HandlePropertiesKHR([NativeTypeName("VkDevice")] VkDevice device,
                                                                            VkExternalMemoryHandleTypeFlagBits    handleType,
                                                                            [NativeTypeName("HANDLE")] nint       handle,
                                                                            VkMemoryWin32HandlePropertiesKHR*     pMemoryWin32HandleProperties);
}
