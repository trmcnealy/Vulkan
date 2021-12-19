using System.Runtime.InteropServices;

namespace Vulkan.Windows
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkGetMemoryWin32HandleNV([NativeTypeName("VkDevice")]           VkDevice       device,
                                                                 [NativeTypeName("VkDeviceMemory")] ref VkDeviceMemory memory,
                                                                 [NativeTypeName("VkExternalMemoryHandleTypeFlagsNV")]
                                                                 uint handleType,
                                                                 [NativeTypeName("HANDLE *")] void** pHandle);
}
