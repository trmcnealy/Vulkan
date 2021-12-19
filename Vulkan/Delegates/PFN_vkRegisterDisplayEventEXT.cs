using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkRegisterDisplayEventEXT([NativeTypeName("VkDevice")]         VkDevice     device,
                                                                  [NativeTypeName("VkDisplayKHR")] ref VkDisplayKHR display,
                                                                  [NativeTypeName("const VkDisplayEventInfoEXT *")]
                                                                  VkDisplayEventInfoEXT[] pDisplayEventInfo,
                                                                  [NativeTypeName("const VkAllocationCallbacks *")]
                                                                  in VkAllocationCallbacks pAllocator,
                                                                  [NativeTypeName("VkFence *")] out VkFence pFence);
}
