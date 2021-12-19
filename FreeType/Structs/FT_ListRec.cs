using System.Runtime.InteropServices;

namespace FreeType
{
    public unsafe struct FT_ListRec
    {
        [NativeTypeName("FT_ListNode")]
        public FT_ListNodeRec* head;

        [NativeTypeName("FT_ListNode")]
        public FT_ListNodeRec* tail;
    }
}
