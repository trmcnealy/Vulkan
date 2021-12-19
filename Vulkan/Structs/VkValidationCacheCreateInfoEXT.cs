using System;
using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkValidationCacheCreateInfoEXT
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkValidationCacheCreateFlagsEXT")]
        public uint Flags;

        [NativeTypeName("size_t")] public nuint InitialDataSize;

        [NativeTypeName("const void *")] public nint PInitialData;
    }
}
