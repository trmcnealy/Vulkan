using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate VkResult PFN_vkBindBufferMemory([NativeTypeName("VkDevice")]           VkDevice       device,
                                                    [NativeTypeName("VkBuffer")] ref       VkBuffer       buffer,
                                                    [NativeTypeName("VkDeviceMemory")] ref VkDeviceMemory memory,
                                                    [NativeTypeName("VkDeviceSize")]       ulong          memoryOffset);
}
