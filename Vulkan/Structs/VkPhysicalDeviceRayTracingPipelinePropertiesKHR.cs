using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceRayTracingPipelinePropertiesKHR
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("uint32_t")] public uint ShaderGroupHandleSize;

        [NativeTypeName("uint32_t")] public uint MaxRayRecursionDepth;

        [NativeTypeName("uint32_t")] public uint MaxShaderGroupStride;

        [NativeTypeName("uint32_t")] public uint ShaderGroupBaseAlignment;

        [NativeTypeName("uint32_t")] public uint ShaderGroupHandleCaptureReplaySize;

        [NativeTypeName("uint32_t")] public uint MaxRayDispatchInvocationCount;

        [NativeTypeName("uint32_t")] public uint ShaderGroupHandleAlignment;

        [NativeTypeName("uint32_t")] public uint MaxRayHitAttributeSize;
    }
}
