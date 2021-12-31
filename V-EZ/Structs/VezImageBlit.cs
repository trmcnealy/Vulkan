using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using FreeType;
using Vulkan;

namespace VEZ;

[StructLayout(LayoutKind.Sequential)]
public struct VezImageBlit
{
    public static readonly int VkOffset3DSize;

    static VezImageBlit()
    {
        VkOffset3DSize = Unsafe.SizeOf<VkOffset3D>();
    }

    public VezImageSubresourceLayers srcSubresource;
            
    //[MarshalAs(UnmanagedType.LPArray, SizeConst = 2)]
    //public VkOffset3D[] srcOffsets;

    public VkOffset3D_fixed_size_array_2 srcOffsets;
            
    public VezImageSubresourceLayers dstSubresource;
            
    //[MarshalAs(UnmanagedType.LPArray, SizeConst = 2)]
    public VkOffset3D_fixed_size_array_2 dstOffsets;




    [StructLayout(LayoutKind.Sequential)]
    public struct VkOffset3D_fixed_size_array_2
    {
        public VkOffset3D E0;

        public VkOffset3D E1;

        public unsafe VkOffset3D this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                VkOffset3D* ptr = (VkOffset3D*)Unsafe.AsPointer(ref E0);
                //ptr += (index * VkOffset3DSize);
                return ptr[index];
            }
        }
    }

}