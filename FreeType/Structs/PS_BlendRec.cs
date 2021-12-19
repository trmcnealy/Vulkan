using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Vulkan;

namespace FreeType
{
    public unsafe struct PS_BlendRec
    {
        [NativeTypeName("FT_UInt")]
        public uint num_designs;

        [NativeTypeName("FT_UInt")]
        public uint num_axis;

        [NativeTypeName("FT_String *[4]")]
        public _axis_names_e__FixedBuffer axis_names;

        [NativeTypeName("FT_Fixed *[16]")]
        public _design_pos_e__FixedBuffer design_pos;

        [NativeTypeName("PS_DesignMapRec [4]")]
        public _design_map_e__FixedBuffer design_map;

        [NativeTypeName("FT_Fixed *")]
        public int* weight_vector;

        [NativeTypeName("FT_Fixed *")]
        public int* default_weight_vector;

        [NativeTypeName("PS_FontInfo [17]")]
        public _font_infos_e__FixedBuffer font_infos;

        [NativeTypeName("PS_Private [17]")]
        public _privates_e__FixedBuffer privates;

        [NativeTypeName("FT_ULong")]
        public uint blend_bitflags;

        [NativeTypeName("FT_BBox *[17]")]
        public _bboxes_e__FixedBuffer bboxes;

        [NativeTypeName("FT_UInt [16]")]
        public fixed uint default_design_vector[16];

        [NativeTypeName("FT_UInt")]
        public uint num_default_design_vector;

        public unsafe struct _axis_names_e__FixedBuffer
        {
            public utf8string e0;
            public utf8string e1;
            public utf8string e2;
            public utf8string e3;

            public ref utf8string this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    fixed(utf8string* pThis = &e0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }

        public unsafe struct _design_pos_e__FixedBuffer
        {
            public int* e0;
            public int* e1;
            public int* e2;
            public int* e3;
            public int* e4;
            public int* e5;
            public int* e6;
            public int* e7;
            public int* e8;
            public int* e9;
            public int* e10;
            public int* e11;
            public int* e12;
            public int* e13;
            public int* e14;
            public int* e15;

            public ref int* this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    fixed(int** pThis = &e0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }

        public struct _design_map_e__FixedBuffer
        {
            public PS_DesignMap e0;
            public PS_DesignMap e1;
            public PS_DesignMap e2;
            public PS_DesignMap e3;

            public unsafe ref PS_DesignMap this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    fixed(PS_DesignMap* pThis = &e0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }

        public unsafe struct _font_infos_e__FixedBuffer
        {
            public PS_FontInfoRec* e0;
            public PS_FontInfoRec* e1;
            public PS_FontInfoRec* e2;
            public PS_FontInfoRec* e3;
            public PS_FontInfoRec* e4;
            public PS_FontInfoRec* e5;
            public PS_FontInfoRec* e6;
            public PS_FontInfoRec* e7;
            public PS_FontInfoRec* e8;
            public PS_FontInfoRec* e9;
            public PS_FontInfoRec* e10;
            public PS_FontInfoRec* e11;
            public PS_FontInfoRec* e12;
            public PS_FontInfoRec* e13;
            public PS_FontInfoRec* e14;
            public PS_FontInfoRec* e15;
            public PS_FontInfoRec* e16;

            public ref PS_FontInfoRec* this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    fixed(PS_FontInfoRec** pThis = &e0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }

        public unsafe struct _privates_e__FixedBuffer
        {
            public PS_PrivateRec* e0;
            public PS_PrivateRec* e1;
            public PS_PrivateRec* e2;
            public PS_PrivateRec* e3;
            public PS_PrivateRec* e4;
            public PS_PrivateRec* e5;
            public PS_PrivateRec* e6;
            public PS_PrivateRec* e7;
            public PS_PrivateRec* e8;
            public PS_PrivateRec* e9;
            public PS_PrivateRec* e10;
            public PS_PrivateRec* e11;
            public PS_PrivateRec* e12;
            public PS_PrivateRec* e13;
            public PS_PrivateRec* e14;
            public PS_PrivateRec* e15;
            public PS_PrivateRec* e16;

            public ref PS_PrivateRec* this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    fixed(PS_PrivateRec** pThis = &e0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }

        public unsafe struct _bboxes_e__FixedBuffer
        {
            public FT_BBox* e0;
            public FT_BBox* e1;
            public FT_BBox* e2;
            public FT_BBox* e3;
            public FT_BBox* e4;
            public FT_BBox* e5;
            public FT_BBox* e6;
            public FT_BBox* e7;
            public FT_BBox* e8;
            public FT_BBox* e9;
            public FT_BBox* e10;
            public FT_BBox* e11;
            public FT_BBox* e12;
            public FT_BBox* e13;
            public FT_BBox* e14;
            public FT_BBox* e15;
            public FT_BBox* e16;

            public ref FT_BBox* this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    fixed(FT_BBox** pThis = &e0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }
    }
}
