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

        [NativeTypeName("VkDeviceSize")] public ulong MaxTransformFeedbackBufferSize;

        [NativeTypeName("uint32_t")] public uint MaxTransformFeedbackStreamDataSize;

        [NativeTypeName("uint32_t")] public uint MaxTransformFeedbackBufferDataSize;

        [NativeTypeName("uint32_t")] public uint MaxTransformFeedbackBufferDataStride;

        [NativeTypeName("VkBool32")] public uint TransformFeedbackQueries;

        [NativeTypeName("VkBool32")] public uint TransformFeedbackStreamsLinesTriangles;

        [NativeTypeName("VkBool32")] public uint TransformFeedbackRasterizationStreamSelect;

        [NativeTypeName("VkBool32")] public uint TransformFeedbackDraw;
    }
}
