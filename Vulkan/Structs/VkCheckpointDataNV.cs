using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkCheckpointDataNV
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        public VkPipelineStageFlagBits Stage;

        [NativeTypeName("void *")] public nint PCheckpointMarker;
    }
}
