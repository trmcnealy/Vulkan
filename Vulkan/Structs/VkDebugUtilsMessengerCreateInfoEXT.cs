using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDebugUtilsMessengerCreateInfoEXT
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkDebugUtilsMessengerCreateFlagsEXT")]
        public uint Flags;

        [NativeTypeName("VkDebugUtilsMessageSeverityFlagsEXT")]
        public uint MessageSeverity;

        [NativeTypeName("VkDebugUtilsMessageTypeFlagsEXT")]
        public uint MessageType;

        [NativeTypeName("PFN_vkDebugUtilsMessengerCallbackEXT")]
        public nint PfnUserCallback;

        [NativeTypeName("void *")] public nint PUserData;
    }
}
