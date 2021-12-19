using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkQueueFamilyCheckpointPropertiesNV
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("VkPipelineStageFlags")]
        public uint CheckpointExecutionStageMask;
    }
}
