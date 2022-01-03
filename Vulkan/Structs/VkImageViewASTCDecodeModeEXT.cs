using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkImageViewASTCDecodeModeEXT
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        public VkFormat DecodeMode;
    }
}
