using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceShaderAtomicFloat2FeaturesEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("VkBool32")] public uint ShaderBufferFloat16Atomics;

        [NativeTypeName("VkBool32")] public uint ShaderBufferFloat16AtomicAdd;

        [NativeTypeName("VkBool32")] public uint ShaderBufferFloat16AtomicMinMax;

        [NativeTypeName("VkBool32")] public uint ShaderBufferFloat32AtomicMinMax;

        [NativeTypeName("VkBool32")] public uint ShaderBufferFloat64AtomicMinMax;

        [NativeTypeName("VkBool32")] public uint ShaderSharedFloat16Atomics;

        [NativeTypeName("VkBool32")] public uint ShaderSharedFloat16AtomicAdd;

        [NativeTypeName("VkBool32")] public uint ShaderSharedFloat16AtomicMinMax;

        [NativeTypeName("VkBool32")] public uint ShaderSharedFloat32AtomicMinMax;

        [NativeTypeName("VkBool32")] public uint ShaderSharedFloat64AtomicMinMax;

        [NativeTypeName("VkBool32")] public uint ShaderImageFloat32AtomicMinMax;

        [NativeTypeName("VkBool32")] public uint SparseImageFloat32AtomicMinMax;
    }
}
