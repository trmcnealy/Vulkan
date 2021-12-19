using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkRayTracingPipelineInterfaceCreateInfoKHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("uint32_t")] public uint MaxPipelineRayPayloadSize;

        [NativeTypeName("uint32_t")] public uint MaxPipelineRayHitAttributeSize;
    }
}
