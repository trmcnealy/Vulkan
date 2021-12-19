using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkMutableDescriptorTypeCreateInfoVALVE
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("uint32_t")]
        public uint MutableDescriptorTypeListCount;

        [NativeTypeName("const VkMutableDescriptorTypeListVALVE *")]
        public VkMutableDescriptorTypeListVALVE* PMutableDescriptorTypeLists;

        public VkMutableDescriptorTypeListVALVE[] MutableDescriptorTypeLists
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(MutableDescriptorTypeListCount, PMutableDescriptorTypeLists);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PMutableDescriptorTypeLists = NativeIntExtensions.ToPointer(value, out MutableDescriptorTypeListCount);
            }
        }
    }
}
