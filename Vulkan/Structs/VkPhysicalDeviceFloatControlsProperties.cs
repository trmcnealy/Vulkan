using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceFloatControlsProperties
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        public VkShaderFloatControlsIndependence DenormBehaviorIndependence;

        public VkShaderFloatControlsIndependence RoundingModeIndependence;

        [NativeTypeName("VkBool32")] public uint ShaderSignedZeroInfNanPreserveFloat16;

        [NativeTypeName("VkBool32")] public uint ShaderSignedZeroInfNanPreserveFloat32;

        [NativeTypeName("VkBool32")] public uint ShaderSignedZeroInfNanPreserveFloat64;

        [NativeTypeName("VkBool32")] public uint ShaderDenormPreserveFloat16;

        [NativeTypeName("VkBool32")] public uint ShaderDenormPreserveFloat32;

        [NativeTypeName("VkBool32")] public uint ShaderDenormPreserveFloat64;

        [NativeTypeName("VkBool32")] public uint ShaderDenormFlushToZeroFloat16;

        [NativeTypeName("VkBool32")] public uint ShaderDenormFlushToZeroFloat32;

        [NativeTypeName("VkBool32")] public uint ShaderDenormFlushToZeroFloat64;

        [NativeTypeName("VkBool32")] public uint ShaderRoundingModeRteFloat16;

        [NativeTypeName("VkBool32")] public uint ShaderRoundingModeRteFloat32;

        [NativeTypeName("VkBool32")] public uint ShaderRoundingModeRteFloat64;

        [NativeTypeName("VkBool32")] public uint ShaderRoundingModeRtzFloat16;

        [NativeTypeName("VkBool32")] public uint ShaderRoundingModeRtzFloat32;

        [NativeTypeName("VkBool32")] public uint ShaderRoundingModeRtzFloat64;
    }
}
