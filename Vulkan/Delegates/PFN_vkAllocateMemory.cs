using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkAllocateMemory([NativeTypeName("VkDevice")] VkDevice device,
                                                         [NativeTypeName("const VkMemoryAllocateInfo *")]
                                                         in VkMemoryAllocateInfo pAllocateInfo,
                                                         [NativeTypeName("const VkAllocationCallbacks *")]
                                                         in VkAllocationCallbacks pAllocator,
                                                         [NativeTypeName("VkDeviceMemory *")] out VkDeviceMemory pMemory);
}
