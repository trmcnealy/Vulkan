using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkPipelineColorWriteCreateInfoEXT
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("uint32_t")] public uint AttachmentCount;

        [NativeTypeName("const Bool32 *")] public uint* PColorWriteEnables;
    }
}
