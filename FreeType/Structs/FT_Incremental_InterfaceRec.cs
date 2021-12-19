using System.Runtime.InteropServices;

namespace FreeType
{
    public unsafe struct FT_Incremental_InterfaceRec
    {
        [NativeTypeName("const FT_Incremental_FuncsRec *")]
        public FT_Incremental_FuncsRec* funcs;

        public FT_Incremental @object;
    }
}
