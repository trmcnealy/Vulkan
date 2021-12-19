using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkCooperativeMatrixPropertiesNV
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("uint32_t")] public uint MSize;

        [NativeTypeName("uint32_t")] public uint NSize;

        [NativeTypeName("uint32_t")] public uint KSize;

        public VkComponentTypeNV AType;

        public VkComponentTypeNV BType;

        public VkComponentTypeNV CType;

        public VkComponentTypeNV DType;

        public VkScopeNV Scope;
    }
}
