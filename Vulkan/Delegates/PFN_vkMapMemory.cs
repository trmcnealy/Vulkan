using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkMapMemory([NativeTypeName("VkDevice")]           VkDevice       device,
                                                    [NativeTypeName("VkDeviceMemory")] ref VkDeviceMemory memory,
                                                    [NativeTypeName("VkDeviceSize")]       ulong          offset,
                                                    [NativeTypeName("VkDeviceSize")]       ulong          size,
                                                    [NativeTypeName("VkMemoryMapFlags")]   uint           flags,
                                                    [NativeTypeName("void **")]            nint*          ppData);
}
