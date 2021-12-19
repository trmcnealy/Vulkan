using System.Runtime.InteropServices;

namespace FreeType
{
    public struct FT_Vector
    {
        public static readonly FT_Vector Zero  = new(0, 0);
        public static readonly  FT_Vector UnitX = new(1, 0);
        public static readonly  FT_Vector UnitY = new(0, 1);
        public static readonly FT_Vector One = new(1, 1);
        
        [NativeTypeName("FT_Pos")]
        public int X;

        [NativeTypeName("FT_Pos")]
        public int Y;

        public FT_Vector()
        {
            X = 0;
            Y = 0;
        }

        public FT_Vector(int v)
        {
            X = v;
            Y = v;
        }

        public FT_Vector(int x,
                         int y)
        {
            X = x;
            Y = y;
        }
    }
}
