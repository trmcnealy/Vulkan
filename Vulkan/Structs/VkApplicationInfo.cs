using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkApplicationInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")]
        public nint PNext;

        [NativeTypeName("const char *")] 
        public utf8string PApplicationName;

        [NativeTypeName("uint32_t")]
        public uint ApplicationVersion;

        [NativeTypeName("const char *")] 
        public utf8string PEngineName;

        [NativeTypeName("uint32_t")]
        public uint EngineVersion;

        [NativeTypeName("uint32_t")]
        public uint ApiVersion;
    }
}
