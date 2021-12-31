using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceTransformFeedbackPropertiesEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("uint32_t")] public uint MaxTransformFeedbackStreams;

        [NativeTypeName("uint32_t")] public uint MaxTransformFeedbackBuffers;

        [NativeTypeName("ulong")] public ulong MaxTransformFeedbackBufferSize;

        [NativeTypeName("uint32_t")] public uint MaxTransformFeedbackStreamDataSize;

        [NativeTypeName("uint32_t")] public uint MaxTransformFeedbackBufferDataSize;

        [NativeTypeName("uint32_t")] public uint MaxTransformFeedbackBufferDataStride;

        [NativeTypeName("Bool32")] public uint TransformFeedbackQueries;

        [NativeTypeName("Bool32")] public uint TransformFeedbackStreamsLinesTriangles;

        [NativeTypeName("Bool32")] public uint TransformFeedbackRasterizationStreamSelect;

        [NativeTypeName("Bool32")] public uint TransformFeedbackDraw;
    }
}
