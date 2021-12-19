using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkUnmapMemory([NativeTypeName("VkDevice")]           VkDevice       device,
                                           [NativeTypeName("VkDeviceMemory")] ref VkDeviceMemory memory);
}
