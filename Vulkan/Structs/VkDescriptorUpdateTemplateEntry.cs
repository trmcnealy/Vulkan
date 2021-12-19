using System;
using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDescriptorUpdateTemplateEntry
    {
        [NativeTypeName("uint32_t")] public uint DstBinding;

        [NativeTypeName("uint32_t")] public uint DstArrayElement;

        [NativeTypeName("uint32_t")] public uint DescriptorCount;

        public VkDescriptorType DescriptorType;

        [NativeTypeName("size_t")] public nuint Offset;

        [NativeTypeName("size_t")] public nuint Stride;
    }
}
