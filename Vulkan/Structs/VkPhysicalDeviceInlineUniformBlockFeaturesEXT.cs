using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceInlineUniformBlockFeaturesEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("VkBool32")] public uint InlineUniformBlock;

        [NativeTypeName("VkBool32")] public uint DescriptorBindingInlineUniformBlockUpdateAfterBind;
    }
}
