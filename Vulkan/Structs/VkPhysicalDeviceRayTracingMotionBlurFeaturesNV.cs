using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceRayTracingMotionBlurFeaturesNV
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("VkBool32")] public uint RayTracingMotionBlur;

        [NativeTypeName("VkBool32")] public uint RayTracingMotionBlurPipelineTraceRaysIndirect;
    }
}
