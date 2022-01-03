using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceExtendedDynamicState2FeaturesEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        [NativeTypeName("Bool32")] public uint ExtendedDynamicState2;

        [NativeTypeName("Bool32")] public uint ExtendedDynamicState2LogicOp;

        [NativeTypeName("Bool32")] public uint ExtendedDynamicState2PatchControlPoints;
    }
}
