using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceShaderSMBuiltinsPropertiesNV
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("uint32_t")] public uint ShaderSmCount;

        [NativeTypeName("uint32_t")] public uint ShaderWarpsPerSm;
    }
}
