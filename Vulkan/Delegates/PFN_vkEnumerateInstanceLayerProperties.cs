using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkEnumerateInstanceLayerProperties([NativeTypeName("uint32_t *")] in uint pPropertyCount,
                                                                           VkLayerProperties*                   pProperties);
}
