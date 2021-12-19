using System.Runtime.InteropServices;

namespace FreeType
{
    public struct FT_Size_RequestRec
    {
        [NativeTypeName("FT_Size_Request_Type")]
        public FT_Size_Request_Type type;

        [NativeTypeName("FT_Long")]
        public int width;

        [NativeTypeName("FT_Long")]
        public int height;

        [NativeTypeName("FT_UInt")]
        public uint horiResolution;

        [NativeTypeName("FT_UInt")]
        public uint vertResolution;
    }
}
