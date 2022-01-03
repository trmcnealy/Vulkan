using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceTexelBufferAlignmentPropertiesEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        [NativeTypeName("ulong")] public ulong StorageTexelBufferOffsetAlignmentBytes;

        [NativeTypeName("Bool32")] public uint StorageTexelBufferOffsetSingleTexelAlignment;

        [NativeTypeName("ulong")] public ulong UniformTexelBufferOffsetAlignmentBytes;

        [NativeTypeName("Bool32")] public uint UniformTexelBufferOffsetSingleTexelAlignment;
    }
}
