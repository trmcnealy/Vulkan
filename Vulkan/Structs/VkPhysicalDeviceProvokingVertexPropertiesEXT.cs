using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceProvokingVertexPropertiesEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("VkBool32")] public uint ProvokingVertexModePerPipeline;

        [NativeTypeName("VkBool32")] public uint TransformFeedbackPreservesTriangleFanProvokingVertex;
    }
}
