using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkPipelineShaderStageCreateInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkPipelineShaderStageCreateFlags")]
        public uint Flags;

        public VkShaderStageFlagBits Stage;

        [NativeTypeName("VkShaderModule")]
        public VkShaderModule Module;

        [NativeTypeName("const char *")] 
        public utf8string PName;

        [NativeTypeName("const VkSpecializationInfo *")]
        public VkSpecializationInfo* PSpecializationInfo;
    }
}
