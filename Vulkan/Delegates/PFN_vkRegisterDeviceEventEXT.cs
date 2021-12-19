using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkRegisterDeviceEventEXT([NativeTypeName("VkDevice")] VkDevice device,
                                                                 [NativeTypeName("const VkDeviceEventInfoEXT *")]
                                                                 in VkDeviceEventInfoEXT pDeviceEventInfo,
                                                                 [NativeTypeName("const VkAllocationCallbacks *")]
                                                                 in VkAllocationCallbacks pAllocator,
                                                                 [NativeTypeName("VkFence *")] out VkFence pFence);
}
