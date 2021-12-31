using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceConditionalRenderingFeaturesEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("Bool32")] public uint ConditionalRendering;

        [NativeTypeName("Bool32")] public uint InheritedConditionalRendering;
    }
}
