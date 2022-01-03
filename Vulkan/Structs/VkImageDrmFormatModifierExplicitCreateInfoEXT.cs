using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkImageDrmFormatModifierExplicitCreateInfoEXT
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("uint64_t")] public ulong DrmFormatModifier;

        [NativeTypeName("uint32_t")]
        public uint DrmFormatModifierPlaneCount;

        [NativeTypeName("const VkSubresourceLayout *")]
        public VkSubresourceLayout* PPlaneLayouts;

        public VkSubresourceLayout[] PlaneLayouts
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(DrmFormatModifierPlaneCount, PPlaneLayouts);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PPlaneLayouts = NativeIntExtensions.ToPointer(value, out DrmFormatModifierPlaneCount);
            }
        }
    }
}
