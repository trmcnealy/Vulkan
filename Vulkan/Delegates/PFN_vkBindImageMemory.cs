using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate VkResult PFN_vkBindImageMemory([NativeTypeName("VkDevice")]           VkDevice       device,
                                                   [NativeTypeName("VkImage")] ref        VkImage        image,
                                                   [NativeTypeName("VkDeviceMemory")] ref VkDeviceMemory memory,
                                                   [NativeTypeName("VkDeviceSize")]       ulong          memoryOffset);
}
