using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceShaderAtomicFloatFeaturesEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        [NativeTypeName("Bool32")] public uint ShaderBufferFloat32Atomics;

        [NativeTypeName("Bool32")] public uint ShaderBufferFloat32AtomicAdd;

        [NativeTypeName("Bool32")] public uint ShaderBufferFloat64Atomics;

        [NativeTypeName("Bool32")] public uint ShaderBufferFloat64AtomicAdd;

        [NativeTypeName("Bool32")] public uint ShaderSharedFloat32Atomics;

        [NativeTypeName("Bool32")] public uint ShaderSharedFloat32AtomicAdd;

        [NativeTypeName("Bool32")] public uint ShaderSharedFloat64Atomics;

        [NativeTypeName("Bool32")] public uint ShaderSharedFloat64AtomicAdd;

        [NativeTypeName("Bool32")] public uint ShaderImageFloat32Atomics;

        [NativeTypeName("Bool32")] public uint ShaderImageFloat32AtomicAdd;

        [NativeTypeName("Bool32")] public uint SparseImageFloat32Atomics;

        [NativeTypeName("Bool32")] public uint SparseImageFloat32AtomicAdd;
    }
}
