using System;
using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Explicit)]
    public struct VK_LOADER_DATA
    {
        [FieldOffset(0)] [NativeTypeName("uintptr_t")]
        public nuint loaderMagic;

        [FieldOffset(0)] [NativeTypeName("void *")]
        public nint loaderData;
    }
}
