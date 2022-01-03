using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceFloatControlsProperties
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        public VkShaderFloatControlsIndependence DenormBehaviorIndependence;

        public VkShaderFloatControlsIndependence RoundingModeIndependence;

        [NativeTypeName("Bool32")] public uint ShaderSignedZeroInfNanPreserveFloat16;

        [NativeTypeName("Bool32")] public uint ShaderSignedZeroInfNanPreserveFloat32;

        [NativeTypeName("Bool32")] public uint ShaderSignedZeroInfNanPreserveFloat64;

        [NativeTypeName("Bool32")] public uint ShaderDenormPreserveFloat16;

        [NativeTypeName("Bool32")] public uint ShaderDenormPreserveFloat32;

        [NativeTypeName("Bool32")] public uint ShaderDenormPreserveFloat64;

        [NativeTypeName("Bool32")] public uint ShaderDenormFlushToZeroFloat16;

        [NativeTypeName("Bool32")] public uint ShaderDenormFlushToZeroFloat32;

        [NativeTypeName("Bool32")] public uint ShaderDenormFlushToZeroFloat64;

        [NativeTypeName("Bool32")] public uint ShaderRoundingModeRteFloat16;

        [NativeTypeName("Bool32")] public uint ShaderRoundingModeRteFloat32;

        [NativeTypeName("Bool32")] public uint ShaderRoundingModeRteFloat64;

        [NativeTypeName("Bool32")] public uint ShaderRoundingModeRtzFloat16;

        [NativeTypeName("Bool32")] public uint ShaderRoundingModeRtzFloat32;

        [NativeTypeName("Bool32")] public uint ShaderRoundingModeRtzFloat64;
    }
}
