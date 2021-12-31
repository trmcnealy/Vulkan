using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceShaderIntegerFunctions2FeaturesINTEL
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("Bool32")] public uint ShaderIntegerFunctions2;
    }
}
