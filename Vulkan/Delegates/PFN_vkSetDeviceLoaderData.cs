using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate VkResult PFN_vkSetDeviceLoaderData([NativeTypeName("VkDevice")] VkDevice device,
                                                       [NativeTypeName("void *")]   nint     @object);
}
