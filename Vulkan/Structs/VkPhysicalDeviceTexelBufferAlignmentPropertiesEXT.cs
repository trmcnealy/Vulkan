using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceTexelBufferAlignmentPropertiesEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("VkDeviceSize")] public ulong StorageTexelBufferOffsetAlignmentBytes;

        [NativeTypeName("VkBool32")] public uint StorageTexelBufferOffsetSingleTexelAlignment;

        [NativeTypeName("VkDeviceSize")] public ulong UniformTexelBufferOffsetAlignmentBytes;

        [NativeTypeName("VkBool32")] public uint UniformTexelBufferOffsetSingleTexelAlignment;
    }
}
