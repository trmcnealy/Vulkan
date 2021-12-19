using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate VkResult PFN_vkSetInstanceLoaderData([NativeTypeName("VkInstance")] VkInstance instance,
                                                         [NativeTypeName("void *")]     nint       @object);
}
