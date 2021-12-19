using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceShaderAtomicFloatFeaturesEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("VkBool32")] public uint ShaderBufferFloat32Atomics;

        [NativeTypeName("VkBool32")] public uint ShaderBufferFloat32AtomicAdd;

        [NativeTypeName("VkBool32")] public uint ShaderBufferFloat64Atomics;

        [NativeTypeName("VkBool32")] public uint ShaderBufferFloat64AtomicAdd;

        [NativeTypeName("VkBool32")] public uint ShaderSharedFloat32Atomics;

        [NativeTypeName("VkBool32")] public uint ShaderSharedFloat32AtomicAdd;

        [NativeTypeName("VkBool32")] public uint ShaderSharedFloat64Atomics;

        [NativeTypeName("VkBool32")] public uint ShaderSharedFloat64AtomicAdd;

        [NativeTypeName("VkBool32")] public uint ShaderImageFloat32Atomics;

        [NativeTypeName("VkBool32")] public uint ShaderImageFloat32AtomicAdd;

        [NativeTypeName("VkBool32")] public uint SparseImageFloat32Atomics;

        [NativeTypeName("VkBool32")] public uint SparseImageFloat32AtomicAdd;
    }
}
