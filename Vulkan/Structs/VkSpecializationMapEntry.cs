using System;
using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSpecializationMapEntry
    {
        [NativeTypeName("uint32_t")] public uint ConstantId;

        [NativeTypeName("uint32_t")] public uint Offset;

        [NativeTypeName("size_t")] public nuint Size;
    }
}
