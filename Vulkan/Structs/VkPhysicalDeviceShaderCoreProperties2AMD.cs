using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceShaderCoreProperties2AMD
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        [NativeTypeName("VkShaderCorePropertiesFlagsAMD")]
        public uint ShaderCoreFeatures;

        [NativeTypeName("uint32_t")] public uint ActiveComputeUnitCount;
    }
}
