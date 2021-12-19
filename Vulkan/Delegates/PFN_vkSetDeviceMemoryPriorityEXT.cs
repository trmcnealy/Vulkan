using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkSetDeviceMemoryPriorityEXT([NativeTypeName("VkDevice")]           VkDevice       device,
                                                          [NativeTypeName("VkDeviceMemory")] ref VkDeviceMemory memory,
                                                          float                                                 priority);
}
