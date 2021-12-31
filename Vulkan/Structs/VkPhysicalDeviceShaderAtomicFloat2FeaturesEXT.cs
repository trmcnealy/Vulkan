using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceShaderAtomicFloat2FeaturesEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("Bool32")] public uint ShaderBufferFloat16Atomics;

        [NativeTypeName("Bool32")] public uint ShaderBufferFloat16AtomicAdd;

        [NativeTypeName("Bool32")] public uint ShaderBufferFloat16AtomicMinMax;

        [NativeTypeName("Bool32")] public uint ShaderBufferFloat32AtomicMinMax;

        [NativeTypeName("Bool32")] public uint ShaderBufferFloat64AtomicMinMax;

        [NativeTypeName("Bool32")] public uint ShaderSharedFloat16Atomics;

        [NativeTypeName("Bool32")] public uint ShaderSharedFloat16AtomicAdd;

        [NativeTypeName("Bool32")] public uint ShaderSharedFloat16AtomicMinMax;

        [NativeTypeName("Bool32")] public uint ShaderSharedFloat32AtomicMinMax;

        [NativeTypeName("Bool32")] public uint ShaderSharedFloat64AtomicMinMax;

        [NativeTypeName("Bool32")] public uint ShaderImageFloat32AtomicMinMax;

        [NativeTypeName("Bool32")] public uint SparseImageFloat32AtomicMinMax;
    }
}
