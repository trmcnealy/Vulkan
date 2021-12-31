using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineColorBlendAdvancedStateCreateInfoEXT
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("Bool32")] public uint SrcPremultiplied;

        [NativeTypeName("Bool32")] public uint DstPremultiplied;

        public VkBlendOverlapEXT BlendOverlap;
    }
}
