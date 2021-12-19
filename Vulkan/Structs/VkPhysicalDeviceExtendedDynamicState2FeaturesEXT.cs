using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceExtendedDynamicState2FeaturesEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("VkBool32")] public uint ExtendedDynamicState2;

        [NativeTypeName("VkBool32")] public uint ExtendedDynamicState2LogicOp;

        [NativeTypeName("VkBool32")] public uint ExtendedDynamicState2PatchControlPoints;
    }
}
