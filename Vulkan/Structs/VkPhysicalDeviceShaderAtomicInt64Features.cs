using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceShaderAtomicInt64Features
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        [NativeTypeName("Bool32")] public uint ShaderBufferInt64Atomics;

        [NativeTypeName("Bool32")] public uint ShaderSharedInt64Atomics;
    }
}
