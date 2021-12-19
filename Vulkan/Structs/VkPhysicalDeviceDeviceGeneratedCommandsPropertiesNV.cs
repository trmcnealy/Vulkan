using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceDeviceGeneratedCommandsPropertiesNV
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("uint32_t")] public uint MaxGraphicsShaderGroupCount;

        [NativeTypeName("uint32_t")] public uint MaxIndirectSequenceCount;

        [NativeTypeName("uint32_t")] public uint MaxIndirectCommandsTokenCount;

        [NativeTypeName("uint32_t")] public uint MaxIndirectCommandsStreamCount;

        [NativeTypeName("uint32_t")] public uint MaxIndirectCommandsTokenOffset;

        [NativeTypeName("uint32_t")] public uint MaxIndirectCommandsStreamStride;

        [NativeTypeName("uint32_t")] public uint MinSequencesCountBufferOffsetAlignment;

        [NativeTypeName("uint32_t")] public uint MinSequencesIndexBufferOffsetAlignment;

        [NativeTypeName("uint32_t")] public uint MinIndirectCommandsBufferOffsetAlignment;
    }
}
