using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceShaderDemoteToHelperInvocationFeaturesEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("VkBool32")] public uint ShaderDemoteToHelperInvocation;
    }
}