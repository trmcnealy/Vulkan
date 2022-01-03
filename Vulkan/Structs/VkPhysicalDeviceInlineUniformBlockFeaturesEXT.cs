using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceInlineUniformBlockFeaturesEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        [NativeTypeName("Bool32")] public uint InlineUniformBlock;

        [NativeTypeName("Bool32")] public uint DescriptorBindingInlineUniformBlockUpdateAfterBind;
    }
}
