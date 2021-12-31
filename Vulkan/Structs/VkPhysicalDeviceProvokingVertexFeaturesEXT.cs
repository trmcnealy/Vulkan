using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceProvokingVertexFeaturesEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("Bool32")] public uint ProvokingVertexLast;

        [NativeTypeName("Bool32")] public uint TransformFeedbackPreservesProvokingVertex;
    }
}
