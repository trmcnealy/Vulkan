using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineColorBlendAdvancedStateCreateInfoEXT
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkBool32")] public uint SrcPremultiplied;

        [NativeTypeName("VkBool32")] public uint DstPremultiplied;

        public VkBlendOverlapEXT BlendOverlap;
    }
}
