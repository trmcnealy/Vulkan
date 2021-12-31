using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceProvokingVertexPropertiesEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("Bool32")] public uint ProvokingVertexModePerPipeline;

        [NativeTypeName("Bool32")] public uint TransformFeedbackPreservesTriangleFanProvokingVertex;
    }
}
