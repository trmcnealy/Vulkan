using System.Runtime.InteropServices;

namespace Vulkan.Windows
{
    public struct VkSurfaceFullScreenExclusiveWin32InfoEXT
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("HMONITOR")] public nint Hmonitor;
    }
}
