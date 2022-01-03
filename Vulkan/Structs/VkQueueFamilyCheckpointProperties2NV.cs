using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkQueueFamilyCheckpointProperties2NV
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        [NativeTypeName("VkPipelineStageFlags2KHR")]
        public ulong CheckpointExecutionStageMask;
    }
}
