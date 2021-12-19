using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkFreeFunction([NativeTypeName("void *")] nint pUserData,
                                            [NativeTypeName("void *")] nint pMemory);
}
