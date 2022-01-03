using System;
using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkCuModuleCreateInfoNVX
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("size_t")] public nuint DataSize;

        [NativeTypeName("const void *")] public nint PData;
    }
}
