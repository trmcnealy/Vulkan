using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceRayTracingPipelineFeaturesKHR
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("VkBool32")] public uint RayTracingPipeline;

        [NativeTypeName("VkBool32")] public uint RayTracingPipelineShaderGroupHandleCaptureReplay;

        [NativeTypeName("VkBool32")] public uint RayTracingPipelineShaderGroupHandleCaptureReplayMixed;

        [NativeTypeName("VkBool32")] public uint RayTracingPipelineTraceRaysIndirect;

        [NativeTypeName("VkBool32")] public uint RayTraversalPrimitiveCulling;
    }
}
