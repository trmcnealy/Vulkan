using System;
using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDebugMarkerObjectTagInfoEXT
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        public VkDebugReportObjectTypeEXT ObjectType;

        [NativeTypeName("uint64_t")] public ulong Object;

        [NativeTypeName("uint64_t")] public ulong TagName;

        [NativeTypeName("size_t")] public nuint TagSize;

        [NativeTypeName("const void *")] public nint PTag;
    }
}
