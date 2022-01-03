using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceRayTracingPipelineFeaturesKHR
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        [NativeTypeName("Bool32")] public uint RayTracingPipeline;

        [NativeTypeName("Bool32")] public uint RayTracingPipelineShaderGroupHandleCaptureReplay;

        [NativeTypeName("Bool32")] public uint RayTracingPipelineShaderGroupHandleCaptureReplayMixed;

        [NativeTypeName("Bool32")] public uint RayTracingPipelineTraceRaysIndirect;

        [NativeTypeName("Bool32")] public uint RayTraversalPrimitiveCulling;
    }
}
