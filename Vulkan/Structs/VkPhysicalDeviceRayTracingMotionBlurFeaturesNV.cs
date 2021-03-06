using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceRayTracingMotionBlurFeaturesNV
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        [NativeTypeName("Bool32")] public uint RayTracingMotionBlur;

        [NativeTypeName("Bool32")] public uint RayTracingMotionBlurPipelineTraceRaysIndirect;
    }
}
