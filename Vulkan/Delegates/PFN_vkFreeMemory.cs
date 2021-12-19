using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkFreeMemory([NativeTypeName("VkDevice")]           VkDevice       device,
                                                 [NativeTypeName("VkDeviceMemory")] ref VkDeviceMemory memory,
                                                 [NativeTypeName("const VkAllocationCallbacks *")]
                                                 in VkAllocationCallbacks pAllocator);
}
