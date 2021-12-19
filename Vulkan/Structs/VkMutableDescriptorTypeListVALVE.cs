using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkMutableDescriptorTypeListVALVE
    {
        [NativeTypeName("uint32_t")]
        public uint DescriptorTypeCount;

        [NativeTypeName("const VkDescriptorType *")]
        public VkDescriptorType* PDescriptorTypes;

        public VkDescriptorType[] DescriptorTypes
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(DescriptorTypeCount, PDescriptorTypes);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PDescriptorTypes = NativeIntExtensions.ToPointer(value, out DescriptorTypeCount);
            }
        }
    }
}
