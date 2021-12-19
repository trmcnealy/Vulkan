using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkGetDeviceQueue([NativeTypeName("VkDevice")]      VkDevice device,
                                                     [NativeTypeName("uint32_t")]      uint     queueFamilyIndex,
                                                     [NativeTypeName("uint32_t")]      uint     queueIndex,
                                                     [NativeTypeName("VkQueue *")] out VkQueue pQueue);
}
