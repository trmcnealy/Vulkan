using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Vulkan;

namespace FreeType
{
    public unsafe struct FT_Outline
    {
        public short n_contours;

        public short n_points;

        [NativeTypeName("FT_Vector *")]
        public FT_Vector* points;

        [NativeTypeName("char *")]
        public utf8string tags;

        public short* contours;

        public int flags;
    }
}
