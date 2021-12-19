using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkImageBlit
    {
        public VkImageSubresourceLayers SrcSubresource;

        [NativeTypeName("VkOffset3D [2]")] public _srcOffsets_e__FixedBuffer SrcOffsets;

        public VkImageSubresourceLayers DstSubresource;

        [NativeTypeName("VkOffset3D [2]")] public _dstOffsets_e__FixedBuffer DstOffsets;

        public struct _srcOffsets_e__FixedBuffer
        {
            public VkOffset3D E0;
            public VkOffset3D E1;

            public unsafe ref VkOffset3D this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    fixed(VkOffset3D* pThis = &E0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }

        public struct _dstOffsets_e__FixedBuffer
        {
            public VkOffset3D E0;
            public VkOffset3D E1;

            public unsafe ref VkOffset3D this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    fixed(VkOffset3D* pThis = &E0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }
    }
}
