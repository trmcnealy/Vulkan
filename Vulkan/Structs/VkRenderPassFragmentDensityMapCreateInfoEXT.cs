using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkRenderPassFragmentDensityMapCreateInfoEXT
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        public VkAttachmentReference FragmentDensityMapAttachment;
    }
}
