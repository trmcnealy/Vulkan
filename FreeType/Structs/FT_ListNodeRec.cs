using System.Runtime.InteropServices;

namespace FreeType
{
    public struct FT_ListNodeRec
    {
        [NativeTypeName("FT_ListNode")]
        public FT_ListNode prev;

        [NativeTypeName("FT_ListNode")]
        public FT_ListNode next;

        [NativeTypeName("void *")]
        public nint data;
    }
}
