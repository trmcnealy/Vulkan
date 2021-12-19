using System.Runtime.InteropServices;

namespace FreeType
{
    public unsafe struct FT_Outline_Funcs
    {
        public delegate*<FT_Vector*, nint, int>                         move_to;
        public delegate*<FT_Vector*, nint, int>                         line_to;
        public delegate*<FT_Vector*, nint, int>                         conic_to;
        public delegate*<FT_Vector*, FT_Vector*, FT_Vector*, nint, int> cubic_to;
        public int                                                      shift;
        public int                                                      delta;
    }
}
