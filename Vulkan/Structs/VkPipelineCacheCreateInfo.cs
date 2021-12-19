using System;
using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineCacheCreateInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkPipelineCacheCreateFlags")]
        public uint Flags;

        [NativeTypeName("size_t")] public nuint InitialDataSize;

        [NativeTypeName("const void *")] public nint PInitialData;
    }
}
