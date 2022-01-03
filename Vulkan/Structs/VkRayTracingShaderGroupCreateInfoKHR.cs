using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkRayTracingShaderGroupCreateInfoKHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        public VkRayTracingShaderGroupTypeKHR Type;

        [NativeTypeName("uint32_t")] public uint GeneralShader;

        [NativeTypeName("uint32_t")] public uint ClosestHitShader;

        [NativeTypeName("uint32_t")] public uint AnyHitShader;

        [NativeTypeName("uint32_t")] public uint IntersectionShader;

        [NativeTypeName("const void *")] public nint PShaderGroupCaptureReplayHandle;
    }
}
