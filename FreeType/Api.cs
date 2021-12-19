using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using utf8string = Vulkan.utf8string;

using static FreeType.FT_Encoding;
using static FreeType.FT_Glyph_BBox_Mode;
using static FreeType.FT_Glyph_Format;
using static FreeType.FT_Kerning_Mode;
using static FreeType.FT_Pixel_Mode;
using static FreeType.FT_Render_Mode;
using static FreeType.FT_Sfnt_Tag;
using static FreeType.T1_Blend_Flags;


namespace FreeType
{
    public static unsafe partial class Api
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Init_FreeType([NativeTypeName("FT_Library *")] out FT_LibraryRec alibrary);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Done_FreeType([NativeTypeName("FT_Library")] FT_Library library);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_New_Face([NativeTypeName("FT_Library")] FT_Library library,
                                             [NativeTypeName("const char *")] utf8string filepathname,
                                             [NativeTypeName("CLong")] int face_index,
                                             [NativeTypeName("FT_Face *")] out FT_Face aface);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_New_Memory_Face([NativeTypeName("FT_Library")] FT_Library library,
                                                    [NativeTypeName("const FT_Byte *")] byte* file_base,
                                                    [NativeTypeName("CLong")] int file_size,
                                                    [NativeTypeName("CLong")] int face_index,
                                                    [NativeTypeName("FT_Face *")] out FT_Face aface);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Open_Face([NativeTypeName("FT_Library")] FT_Library library,
                                              [NativeTypeName("const FT_Open_Args *")]
                                              FT_Open_Args* args,
                                              [NativeTypeName("CLong")] int face_index,
                                              [NativeTypeName("FT_Face *")] out FT_Face aface);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Attach_File([NativeTypeName("FT_Face")] FT_Face face,
                                                [NativeTypeName("const char *")] utf8string filepathname);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Attach_Stream([NativeTypeName("FT_Face")] FT_Face face,
                                                  [NativeTypeName("FT_Open_Args *")] FT_Open_Args* parameters);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Reference_Face([NativeTypeName("FT_Face")] FT_Face face);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Done_Face([NativeTypeName("FT_Face")] FT_Face face);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Select_Size([NativeTypeName("FT_Face")] FT_Face face,
                                                [NativeTypeName("FT_Int")] int strike_index);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Request_Size([NativeTypeName("FT_Face")] FT_Face face,
                                                 [NativeTypeName("FT_Size_Request")] FT_Size_RequestRec* req);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Set_Char_Size([NativeTypeName("FT_Face")] FT_Face face,
                                                  [NativeTypeName("FT_F26Dot6")] int char_width,
                                                  [NativeTypeName("FT_F26Dot6")] int char_height,
                                                  [NativeTypeName("FT_UInt")] uint horz_resolution,
                                                  [NativeTypeName("FT_UInt")] uint vert_resolution);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Set_Pixel_Sizes([NativeTypeName("FT_Face")] FT_Face face,
                                                    [NativeTypeName("FT_UInt")] uint pixel_width,
                                                    [NativeTypeName("FT_UInt")] uint pixel_height);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Load_Glyph([NativeTypeName("FT_Face")] FT_Face face,
                                               [NativeTypeName("FT_UInt")] uint glyph_index,
                                               [NativeTypeName("FT_Int32")] int load_flags);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Load_Char([NativeTypeName("FT_Face")] FT_Face face,
                                              [NativeTypeName("CULong")] uint char_code,
                                              [NativeTypeName("FT_Int32")] int load_flags);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        public static extern void FT_Set_Transform([NativeTypeName("FT_Face")] FT_Face face,
                                                   [NativeTypeName("FT_Matrix *")] FT_Matrix* matrix,
                                                   [NativeTypeName("FT_Vector *")] FT_Vector* delta);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        public static extern void FT_Get_Transform([NativeTypeName("FT_Face")] FT_Face face,
                                                   [NativeTypeName("FT_Matrix *")] FT_Matrix* matrix,
                                                   [NativeTypeName("FT_Vector *")] FT_Vector* delta);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Render_Glyph([NativeTypeName("FT_GlyphSlot")] FT_GlyphSlotRec* slot,
                                                 [NativeTypeName("FT_Render_Mode")] FT_Render_Mode render_mode);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Get_Kerning([NativeTypeName("FT_Face")] FT_Face face,
                                                [NativeTypeName("FT_UInt")] uint left_glyph,
                                                [NativeTypeName("FT_UInt")] uint right_glyph,
                                                [NativeTypeName("FT_UInt")] uint kern_mode,
                                                [NativeTypeName("FT_Vector *")] FT_Vector* akerning);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Get_Track_Kerning([NativeTypeName("FT_Face")] FT_Face face,
                                                      [NativeTypeName("FT_Fixed")] int point_size,
                                                      [NativeTypeName("FT_Int")] int degree,
                                                      [NativeTypeName("FT_Fixed *")] int* akerning);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Get_Glyph_Name([NativeTypeName("FT_Face")] FT_Face face,
                                                   [NativeTypeName("FT_UInt")] uint glyph_index,
                                                   [NativeTypeName("FT_Pointer")] nint buffer,
                                                   [NativeTypeName("FT_UInt")] uint buffer_max);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern utf8string FT_Get_Postscript_Name([NativeTypeName("FT_Face")] FT_Face face);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Select_Charmap([NativeTypeName("FT_Face")] FT_Face face,
                                                   [NativeTypeName("FT_Encoding")] FT_Encoding encoding);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Set_Charmap([NativeTypeName("FT_Face")] FT_Face face,
                                                [NativeTypeName("FT_CharMap")] FT_CharMap charmap);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Int")]
        public static extern int FT_Get_Charmap_Index([NativeTypeName("FT_CharMap")] FT_CharMap charmap);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_UInt")]
        public static extern uint FT_Get_Char_Index([NativeTypeName("FT_Face")] FT_Face face,
                                                    [NativeTypeName("CULong")] uint charcode);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("CULong")]
        public static extern uint FT_Get_First_Char([NativeTypeName("FT_Face")] FT_Face face,
                                                    [NativeTypeName("FT_UInt *")] uint* agindex);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("CULong")]
        public static extern uint FT_Get_Next_Char([NativeTypeName("FT_Face")] FT_Face face,
                                                   [NativeTypeName("CULong")] uint char_code,
                                                   [NativeTypeName("FT_UInt *")] uint* agindex);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Face_Properties([NativeTypeName("FT_Face")] FT_Face face,
                                                    [NativeTypeName("FT_UInt")] uint num_properties,
                                                    [NativeTypeName("FT_Parameter *")] FT_Parameter* properties);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_UInt")]
        public static extern uint FT_Get_Name_Index([NativeTypeName("FT_Face")] FT_Face face,
                                                    [NativeTypeName("const FT_String *")] utf8string glyph_name);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Get_SubGlyph_Info([NativeTypeName("FT_GlyphSlot")] FT_GlyphSlotRec* glyph,
                                                      [NativeTypeName("FT_UInt")] uint sub_index,
                                                      [NativeTypeName("FT_Int *")] int* p_index,
                                                      [NativeTypeName("FT_UInt *")] uint* p_flags,
                                                      [NativeTypeName("FT_Int *")] int* p_arg1,
                                                      [NativeTypeName("FT_Int *")] int* p_arg2,
                                                      [NativeTypeName("FT_Matrix *")] FT_Matrix* p_transform);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("ushort")]
        public static extern ushort FT_Get_FSType_Flags([NativeTypeName("FT_Face")] FT_Face face);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_UInt")]
        public static extern uint FT_Face_GetCharVariantIndex([NativeTypeName("FT_Face")] FT_Face face,
                                                              [NativeTypeName("CULong")] uint charcode,
                                                              [NativeTypeName("CULong")] uint variantSelector);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Int")]
        public static extern int FT_Face_GetCharVariantIsDefault([NativeTypeName("FT_Face")] FT_Face face,
                                                                 [NativeTypeName("CULong")] uint charcode,
                                                                 [NativeTypeName("CULong")] uint variantSelector);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("uint *")]
        public static extern uint* FT_Face_GetVariantSelectors([NativeTypeName("FT_Face")] FT_Face face);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("uint *")]
        public static extern uint* FT_Face_GetVariantsOfChar([NativeTypeName("FT_Face")] FT_Face face,
                                                             [NativeTypeName("CULong")] uint charcode);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("uint *")]
        public static extern uint* FT_Face_GetCharsOfVariant([NativeTypeName("FT_Face")] FT_Face face,
                                                             [NativeTypeName("CULong")] uint variantSelector);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("CLong")]
        public static extern int FT_MulDiv([NativeTypeName("CLong")] int a,
                                           [NativeTypeName("CLong")] int b,
                                           [NativeTypeName("CLong")] int c);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("CLong")]
        public static extern int FT_MulFix([NativeTypeName("CLong")] int a,
                                           [NativeTypeName("CLong")] int b);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("CLong")]
        public static extern int FT_DivFix([NativeTypeName("CLong")] int a,
                                           [NativeTypeName("CLong")] int b);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Fixed")]
        public static extern int FT_RoundFix([NativeTypeName("FT_Fixed")] int a);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Fixed")]
        public static extern int FT_CeilFix([NativeTypeName("FT_Fixed")] int a);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Fixed")]
        public static extern int FT_FloorFix([NativeTypeName("FT_Fixed")] int a);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        public static extern void FT_Vector_Transform([NativeTypeName("FT_Vector *")] FT_Vector* vector,
                                                      [NativeTypeName("const FT_Matrix *")] FT_Matrix* matrix);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        public static extern void FT_Library_Version([NativeTypeName("FT_Library")] FT_Library library,
                                                     [NativeTypeName("FT_Int *")] int* amajor,
                                                     [NativeTypeName("FT_Int *")] int* aminor,
                                                     [NativeTypeName("FT_Int *")] int* apatch);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Bool")]
        public static extern byte FT_Face_CheckTrueTypePatents([NativeTypeName("FT_Face")] FT_Face face);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Bool")]
        public static extern byte FT_Face_SetUnpatentedHinting([NativeTypeName("FT_Face")] FT_Face face,
                                                               [NativeTypeName("FT_Bool")] byte value);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_ListNode")]
        public static extern FT_ListNodeRec* FT_List_Find([NativeTypeName("FT_List")] FT_ListRec* list,
                                                          [NativeTypeName("void *")] nint data);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        public static extern void FT_List_Add([NativeTypeName("FT_List")] FT_ListRec* list,
                                              [NativeTypeName("FT_ListNode")] FT_ListNodeRec* node);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        public static extern void FT_List_Insert([NativeTypeName("FT_List")] FT_ListRec* list,
                                                 [NativeTypeName("FT_ListNode")] FT_ListNodeRec* node);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        public static extern void FT_List_Remove([NativeTypeName("FT_List")] FT_ListRec* list,
                                                 [NativeTypeName("FT_ListNode")] FT_ListNodeRec* node);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        public static extern void FT_List_Up([NativeTypeName("FT_List")] FT_ListRec* list,
                                             [NativeTypeName("FT_ListNode")] FT_ListNodeRec* node);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_List_Iterate([NativeTypeName("FT_List")] FT_ListRec* list,
                                                 [NativeTypeName("FT_List_Iterator")] nint iterator,
                                                 [NativeTypeName("void *")] nint user);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        public static extern void FT_List_Finalize([NativeTypeName("FT_List")] FT_ListRec* list,
                                                   [NativeTypeName("FT_List_Destructor")] nint destroy,
                                                   [NativeTypeName("FT_Memory")] FT_MemoryRec* memory,
                                                   [NativeTypeName("void *")] nint user);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Outline_Decompose([NativeTypeName("FT_Outline *")] ref FT_Outline outline,
                                                      [NativeTypeName("const FT_Outline_Funcs *")]
                                                      FT_Outline_Funcs* func_interface,
                                                      [NativeTypeName("void *")] nint user);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Outline_New([NativeTypeName("FT_Library")] FT_Library library,
                                                [NativeTypeName("FT_UInt")] uint numPoints,
                                                [NativeTypeName("FT_Int")] int numContours,
                                                [NativeTypeName("FT_Outline *")] out FT_Outline anoutline);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Outline_Done([NativeTypeName("FT_Library")] FT_Library library,
                                                 [NativeTypeName("FT_Outline *")] ref FT_Outline outline);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Outline_Check([NativeTypeName("FT_Outline *")] ref FT_Outline outline);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        public static extern void FT_Outline_Get_CBox([NativeTypeName("const FT_Outline *")] ref FT_Outline outline,
                                                      [NativeTypeName("FT_BBox *")] FT_BBox* acbox);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        public static extern void FT_Outline_Translate([NativeTypeName("const FT_Outline *")] ref FT_Outline outline,
                                                       [NativeTypeName("FT_Pos")] int xOffset,
                                                       [NativeTypeName("FT_Pos")] int yOffset);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Outline_Copy([NativeTypeName("const FT_Outline *")] ref FT_Outline source,
                                                 [NativeTypeName("FT_Outline *")] ref FT_Outline target);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        public static extern void FT_Outline_Transform([NativeTypeName("const FT_Outline *")] ref FT_Outline outline,
                                                       [NativeTypeName("const FT_Matrix *")] FT_Matrix* matrix);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Outline_Embolden([NativeTypeName("FT_Outline *")] ref FT_Outline outline,
                                                     [NativeTypeName("FT_Pos")] int strength);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Outline_EmboldenXY([NativeTypeName("FT_Outline *")] ref FT_Outline outline,
                                                       [NativeTypeName("FT_Pos")] int xstrength,
                                                       [NativeTypeName("FT_Pos")] int ystrength);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        public static extern void FT_Outline_Reverse([NativeTypeName("FT_Outline *")] ref FT_Outline outline);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Outline_Get_Bitmap([NativeTypeName("FT_Library")] FT_Library library,
                                                       [NativeTypeName("FT_Outline *")] ref FT_Outline outline,
                                                       [NativeTypeName("const FT_Bitmap *")] FT_Bitmap* abitmap);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Outline_Render([NativeTypeName("FT_Library")] FT_Library library,
                                                   [NativeTypeName("FT_Outline *")] ref FT_Outline outline,
                                                   [NativeTypeName("FT_Raster_Params *")] FT_Raster_Params* @params);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Orientation")]
        public static extern FT_Orientation FT_Outline_Get_Orientation([NativeTypeName("FT_Outline *")] ref FT_Outline outline);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_New_Size([NativeTypeName("FT_Face")] FT_Face face,
                                             [NativeTypeName("FT_Size *")] out FT_Size size);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Done_Size([NativeTypeName("FT_Size")] FT_Size size);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Activate_Size([NativeTypeName("FT_Size")] FT_Size size);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Add_Module([NativeTypeName("FT_Library")] FT_Library library,
                                               [NativeTypeName("const FT_Module_Class *")]
                                               FT_Module_Class* clazz);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Module")]
        public static extern FT_Module* FT_Get_Module([NativeTypeName("FT_Library")] FT_Library library,
                                                         [NativeTypeName("const char *")] utf8string module_name);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Remove_Module([NativeTypeName("FT_Library")] FT_Library library,
                                                  [NativeTypeName("FT_Module")] FT_Module* module);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Property_Set([NativeTypeName("FT_Library")] FT_Library library,
                                                 [NativeTypeName("const FT_String *")] utf8string module_name,
                                                 [NativeTypeName("const FT_String *")] utf8string property_name,
                                                 [NativeTypeName("const void *")] nint value);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Property_Get([NativeTypeName("FT_Library")] FT_Library library,
                                                 [NativeTypeName("const FT_String *")] utf8string module_name,
                                                 [NativeTypeName("const FT_String *")] utf8string property_name,
                                                 [NativeTypeName("void *")] nint value);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        public static extern void FT_Set_Default_Properties([NativeTypeName("FT_Library")] FT_Library library);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Reference_Library([NativeTypeName("FT_Library")] FT_Library library);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_New_Library([NativeTypeName("FT_Memory")] FT_MemoryRec* memory,
                                                [NativeTypeName("FT_Library *")] out FT_Library alibrary);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Done_Library([NativeTypeName("FT_Library")] FT_Library library);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        public static extern void FT_Set_Debug_Hook([NativeTypeName("FT_Library")] FT_Library library,
                                                    [NativeTypeName("FT_UInt")] uint hook_index,
                                                    [NativeTypeName("FT_DebugHook_Func")] nint debug_hook);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        public static extern void FT_Add_Default_Modules([NativeTypeName("FT_Library")] FT_Library library);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_TrueTypeEngineType")]
        public static extern FT_TrueTypeEngineType FT_Get_TrueType_Engine_Type([NativeTypeName("FT_Library")] FT_Library library);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Renderer")]
        public static extern FT_Renderer FT_Get_Renderer([NativeTypeName("FT_Library")] FT_Library library,
                                                             [NativeTypeName("FT_Glyph_Format")] FT_Glyph_Format format);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Set_Renderer([NativeTypeName("FT_Library")] FT_Library library,
                                                 [NativeTypeName("FT_Renderer")] FT_Renderer renderer,
                                                 [NativeTypeName("FT_UInt")] uint num_params,
                                                 [NativeTypeName("FT_Parameter *")] FT_Parameter* parameters);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Int")]
        public static extern int FT_Has_PS_Glyph_Names([NativeTypeName("FT_Face")] FT_Face face);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Get_PS_Font_Info([NativeTypeName("FT_Face")] FT_Face face,
                                                     [NativeTypeName("PS_FontInfo")] PS_FontInfoRec* afont_info);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Get_PS_Font_Private([NativeTypeName("FT_Face")] FT_Face face,
                                                        [NativeTypeName("PS_Private")] PS_PrivateRec* afont_private);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("CLong")]
        public static extern int FT_Get_PS_Font_Value([NativeTypeName("FT_Face")] FT_Face face,
                                                      [NativeTypeName("PS_Dict_Keys")] PS_Dict_Keys key,
                                                      [NativeTypeName("FT_UInt")] uint idx,
                                                      [NativeTypeName("void *")] nint value,
                                                      [NativeTypeName("CLong")] int value_len);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("void *")]
        public static extern nint FT_Get_Sfnt_Table([NativeTypeName("FT_Face")] FT_Face face,
                                                    [NativeTypeName("FT_Sfnt_Tag")] FT_Sfnt_Tag tag);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        internal static extern int _FT_Load_Sfnt_Table([NativeTypeName("FT_Face")] FT_Face face,
                                                      [NativeTypeName("CULong")] uint tag,
                                                      [NativeTypeName("CLong")] int offset,
                                                      [NativeTypeName("FT_Byte *")] byte* buffer,
                                                      [NativeTypeName("CULong *")] out uint length);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Sfnt_Table_Info([NativeTypeName("FT_Face")] FT_Face face,
                                                    [NativeTypeName("FT_UInt")] uint table_index,
                                                    [NativeTypeName("CULong *")] uint* tag,
                                                    [NativeTypeName("CULong *")] out uint length);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("CULong")]
        public static extern uint FT_Get_CMap_Language_ID([NativeTypeName("FT_CharMap")] FT_CharMap charmap);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("CLong")]
        public static extern int FT_Get_CMap_Format([NativeTypeName("FT_CharMap")] FT_CharMap charmap);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Get_BDF_Charset_ID([NativeTypeName("FT_Face")] FT_Face face,
                                                       [NativeTypeName("const char **")] out utf8string acharset_encoding,
                                                       [NativeTypeName("const char **")] out utf8string acharset_registry);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Get_BDF_Property([NativeTypeName("FT_Face")] FT_Face face,
                                                     [NativeTypeName("const char *")] utf8string prop_name,
                                                     [NativeTypeName("BDF_PropertyRec *")] BDF_PropertyRec* aproperty);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Get_CID_Registry_Ordering_Supplement([NativeTypeName("FT_Face")] FT_Face face,
                                                                         [NativeTypeName("const char **")] out utf8string registry,
                                                                         [NativeTypeName("const char **")] out utf8string ordering,
                                                                         [NativeTypeName("FT_Int *")] int* supplement);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Get_CID_Is_Internally_CID_Keyed([NativeTypeName("FT_Face")] FT_Face face,
                                                                    [NativeTypeName("FT_Bool *")] byte* is_cid);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Get_CID_From_Glyph_Index([NativeTypeName("FT_Face")] FT_Face face,
                                                             [NativeTypeName("FT_UInt")] uint glyph_index,
                                                             [NativeTypeName("FT_UInt *")] uint* cid);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Stream_OpenGzip([NativeTypeName("FT_Stream")] FT_StreamRec* stream,
                                                    [NativeTypeName("FT_Stream")] FT_StreamRec* source);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Gzip_Uncompress([NativeTypeName("FT_Memory")] FT_MemoryRec* memory,
                                                    [NativeTypeName("FT_Byte *")] byte* output,
                                                    [NativeTypeName("CULong *")] uint* output_len,
                                                    [NativeTypeName("const FT_Byte *")] byte* input,
                                                    [NativeTypeName("CULong")] uint input_len);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Stream_OpenLZW([NativeTypeName("FT_Stream")] FT_StreamRec* stream,
                                                   [NativeTypeName("FT_Stream")] FT_StreamRec* source);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Stream_OpenBzip2([NativeTypeName("FT_Stream")] FT_StreamRec* stream,
                                                     [NativeTypeName("FT_Stream")] FT_StreamRec* source);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Get_WinFNT_Header([NativeTypeName("FT_Face")] FT_Face face,
                                                      [NativeTypeName("FT_WinFNT_HeaderRec *")]
                                                      FT_WinFNT_HeaderRec* aheader);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_New_Glyph([NativeTypeName("FT_Library")] FT_Library library,
                                              [NativeTypeName("FT_Glyph_Format")] FT_Glyph_Format format,
                                              [NativeTypeName("FT_Glyph *")] out FT_GlyphRec* aglyph);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Get_Glyph([NativeTypeName("FT_GlyphSlot")] FT_GlyphSlotRec* slot,
                                              [NativeTypeName("FT_Glyph *")] out FT_Glyph aglyph);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Glyph_Copy([NativeTypeName("FT_Glyph")] FT_Glyph source,
                                               [NativeTypeName("FT_Glyph *")] out FT_Glyph target);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Glyph_Transform([NativeTypeName("FT_Glyph")] FT_Glyph glyph,
                                                    [NativeTypeName("const FT_Matrix *")] FT_Matrix* matrix,
                                                    [NativeTypeName("const FT_Vector *")] FT_Vector* delta);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        public static extern void FT_Glyph_Get_CBox([NativeTypeName("FT_Glyph")] FT_Glyph glyph,
                                                    [NativeTypeName("FT_UInt")] uint bbox_mode,
                                                    [NativeTypeName("FT_BBox *")] out FT_BBox acbox);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Glyph_To_Bitmap([NativeTypeName("FT_Glyph *")] ref FT_Glyph the_glyph,
                                                    [NativeTypeName("FT_Render_Mode")] FT_Render_Mode render_mode,
                                                    [NativeTypeName("const FT_Vector *")] ref FT_Vector origin,
                                                    [NativeTypeName("FT_Bool")] byte destroy);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        public static extern void FT_Done_Glyph([NativeTypeName("FT_Glyph")] FT_Glyph glyph);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        public static extern void FT_Matrix_Multiply([NativeTypeName("const FT_Matrix *")] FT_Matrix* a,
                                                     [NativeTypeName("FT_Matrix *")] FT_Matrix* b);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Matrix_Invert([NativeTypeName("FT_Matrix *")] FT_Matrix* matrix);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        public static extern void FT_Bitmap_Init([NativeTypeName("FT_Bitmap *")] FT_Bitmap* abitmap);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        public static extern void FT_Bitmap_New([NativeTypeName("FT_Bitmap *")] FT_Bitmap* abitmap);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Bitmap_Copy([NativeTypeName("FT_Library")] FT_Library library,
                                                [NativeTypeName("const FT_Bitmap *")] FT_Bitmap* source,
                                                [NativeTypeName("FT_Bitmap *")] FT_Bitmap* target);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Bitmap_Embolden([NativeTypeName("FT_Library")] FT_Library library,
                                                    [NativeTypeName("FT_Bitmap *")] FT_Bitmap* bitmap,
                                                    [NativeTypeName("FT_Pos")] int xStrength,
                                                    [NativeTypeName("FT_Pos")] int yStrength);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Bitmap_Convert([NativeTypeName("FT_Library")] FT_Library library,
                                                   [NativeTypeName("const FT_Bitmap *")] FT_Bitmap* source,
                                                   [NativeTypeName("FT_Bitmap *")] FT_Bitmap* target,
                                                   [NativeTypeName("FT_Int")] int alignment);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Bitmap_Blend([NativeTypeName("FT_Library")] FT_Library library,
                                                 [NativeTypeName("const FT_Bitmap *")] FT_Bitmap* source,
                                                 [NativeTypeName("const FT_Vector")] FT_Vector source_offset,
                                                 [NativeTypeName("FT_Bitmap *")] FT_Bitmap* target,
                                                 [NativeTypeName("FT_Vector *")] FT_Vector* atarget_offset,
                                                 [NativeTypeName("FT_Color")] FT_Color color);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_GlyphSlot_Own_Bitmap([NativeTypeName("FT_GlyphSlot")] FT_GlyphSlotRec* slot);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Bitmap_Done([NativeTypeName("FT_Library")] FT_Library library,
                                                [NativeTypeName("FT_Bitmap *")] FT_Bitmap* bitmap);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Outline_Get_BBox([NativeTypeName("FT_Outline *")] ref FT_Outline outline,
                                                     [NativeTypeName("FT_BBox *")] FT_BBox* abbox);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FTC_Manager_New([NativeTypeName("FT_Library")] FT_Library library,
                                                 [NativeTypeName("FT_UInt")] uint max_faces,
                                                 [NativeTypeName("FT_UInt")] uint max_sizes,
                                                 [NativeTypeName("CULong")] uint max_bytes,
                                                 [NativeTypeName("FTC_Face_Requester")] delegate*<nint, FT_Library, nint, out FT_Face, int> requester,
                                                 [NativeTypeName("FT_Pointer")] nuint req_data,
                                                 [NativeTypeName("FTC_Manager *")] out nuint amanager);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        public static extern void FTC_Manager_Reset([NativeTypeName("FTC_Manager")] FTC_Manager manager);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        public static extern void FTC_Manager_Done([NativeTypeName("FTC_Manager")] FTC_Manager manager);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FTC_Manager_LookupFace([NativeTypeName("FTC_Manager")] FTC_Manager manager,
                                                        [NativeTypeName("FTC_FaceID")] nint face_id,
                                                        [NativeTypeName("FT_Face *")] out FT_Face aface);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FTC_Manager_LookupSize([NativeTypeName("FTC_Manager")] FTC_Manager manager,
                                                        [NativeTypeName("FTC_Scaler")] FTC_Scaler scaler,
                                                        [NativeTypeName("FT_Size *")] out FT_Size asize);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        public static extern void FTC_Node_Unref([NativeTypeName("FTC_Node")] FTC_Node node,
                                                 [NativeTypeName("FTC_Manager")] FTC_Manager manager);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        public static extern void FTC_Manager_RemoveFaceID([NativeTypeName("FTC_Manager")] FTC_Manager manager,
                                                           [NativeTypeName("FTC_FaceID")] nint face_id);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FTC_CMapCache_New([NativeTypeName("FTC_Manager")] FTC_Manager manager,
                                                   [NativeTypeName("FTC_CMapCache *")] out FTC_CMapCache acache);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_UInt")]
        public static extern uint FTC_CMapCache_Lookup([NativeTypeName("FTC_CMapCache")] FTC_CMapCache cache,
                                                       [NativeTypeName("FTC_FaceID")] nint face_id,
                                                       [NativeTypeName("FT_Int")] int cmap_index,
                                                       [NativeTypeName("uint")] uint char_code);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FTC_ImageCache_New([NativeTypeName("FTC_Manager")] FTC_Manager manager,
                                                    [NativeTypeName("FTC_ImageCache *")] out FTC_ImageCache acache);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FTC_ImageCache_Lookup([NativeTypeName("FTC_ImageCache")] FTC_ImageCache cache,
                                                       [NativeTypeName("FTC_ImageType")] FTC_ImageType type,
                                                       [NativeTypeName("FT_UInt")] uint gindex,
                                                       [NativeTypeName("FT_Glyph *")] out FT_Glyph aglyph,
                                                       [NativeTypeName("FTC_Node *")] out FTC_Node anode);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FTC_ImageCache_LookupScaler([NativeTypeName("FTC_ImageCache")] FTC_ImageCache cache,
                                                             [NativeTypeName("FTC_Scaler")] FTC_Scaler scaler,
                                                             [NativeTypeName("CULong")] uint load_flags,
                                                             [NativeTypeName("FT_UInt")] uint gindex,
                                                             [NativeTypeName("FT_Glyph *")] ref FT_Glyph aglyph,
                                                             [NativeTypeName("FTC_Node *")] out FTC_Node anode);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FTC_SBitCache_New([NativeTypeName("FTC_Manager")] FTC_Manager manager,
                                                   [NativeTypeName("FTC_SBitCache *")] out FTC_SBitCache acache);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FTC_SBitCache_Lookup([NativeTypeName("FTC_SBitCache")] FTC_SBitCache cache,
                                                      [NativeTypeName("FTC_ImageType")] FTC_ImageType type,
                                                      [NativeTypeName("FT_UInt")] uint gindex,
                                                      [NativeTypeName("FTC_SBit *")] out FTC_SBit sbit,
                                                      [NativeTypeName("FTC_Node *")] out FTC_Node anode);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FTC_SBitCache_LookupScaler([NativeTypeName("FTC_SBitCache")] FTC_SBitCache* cache,
                                                            [NativeTypeName("FTC_Scaler")] FTC_Scaler scaler,
                                                            [NativeTypeName("CULong")] uint load_flags,
                                                            [NativeTypeName("FT_UInt")] uint gindex,
                                                            [NativeTypeName("FTC_SBit *")] out FTC_SBit sbit,
                                                            [NativeTypeName("FTC_Node *")] out FTC_Node anode);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Get_Multi_Master([NativeTypeName("FT_Face")] FT_Face face,
                                                     [NativeTypeName("FT_Multi_Master *")] FT_Multi_Master* amaster);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Get_MM_Var([NativeTypeName("FT_Face")] FT_Face face,
                                               [NativeTypeName("FT_MM_Var **")] out FT_MM_Var* amaster);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Done_MM_Var([NativeTypeName("FT_Library")] FT_Library library,
                                                [NativeTypeName("FT_MM_Var *")] FT_MM_Var* amaster);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Set_MM_Design_Coordinates([NativeTypeName("FT_Face")] FT_Face face,
                                                              [NativeTypeName("FT_UInt")] uint num_coords,
                                                              [NativeTypeName("CLong *")] int* coords);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Set_Var_Design_Coordinates([NativeTypeName("FT_Face")] FT_Face face,
                                                               [NativeTypeName("FT_UInt")] uint num_coords,
                                                               [NativeTypeName("FT_Fixed *")] int* coords);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Get_Var_Design_Coordinates([NativeTypeName("FT_Face")] FT_Face face,
                                                               [NativeTypeName("FT_UInt")] uint num_coords,
                                                               [NativeTypeName("FT_Fixed *")] int* coords);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Set_MM_Blend_Coordinates([NativeTypeName("FT_Face")] FT_Face face,
                                                             [NativeTypeName("FT_UInt")] uint num_coords,
                                                             [NativeTypeName("FT_Fixed *")] int* coords);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Get_MM_Blend_Coordinates([NativeTypeName("FT_Face")] FT_Face face,
                                                             [NativeTypeName("FT_UInt")] uint num_coords,
                                                             [NativeTypeName("FT_Fixed *")] int* coords);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Set_Var_Blend_Coordinates([NativeTypeName("FT_Face")] FT_Face face,
                                                              [NativeTypeName("FT_UInt")] uint num_coords,
                                                              [NativeTypeName("FT_Fixed *")] int* coords);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Get_Var_Blend_Coordinates([NativeTypeName("FT_Face")] FT_Face face,
                                                              [NativeTypeName("FT_UInt")] uint num_coords,
                                                              [NativeTypeName("FT_Fixed *")] int* coords);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Set_MM_WeightVector([NativeTypeName("FT_Face")] FT_Face face,
                                                        [NativeTypeName("FT_UInt")] uint len,
                                                        [NativeTypeName("FT_Fixed *")] int* weightvector);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Get_MM_WeightVector([NativeTypeName("FT_Face")] FT_Face face,
                                                        [NativeTypeName("FT_UInt *")] uint* len,
                                                        [NativeTypeName("FT_Fixed *")] int* weightvector);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Get_Var_Axis_Flags([NativeTypeName("FT_MM_Var *")] FT_MM_Var* master,
                                                       [NativeTypeName("FT_UInt")] uint axis_index,
                                                       [NativeTypeName("FT_UInt *")] uint* flags);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Set_Named_Instance([NativeTypeName("FT_Face")] FT_Face face,
                                                       [NativeTypeName("FT_UInt")] uint instance_index);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_UInt")]
        public static extern uint FT_Get_Sfnt_Name_Count([NativeTypeName("FT_Face")] FT_Face face);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Get_Sfnt_Name([NativeTypeName("FT_Face")] FT_Face face,
                                                  [NativeTypeName("FT_UInt")] uint idx,
                                                  [NativeTypeName("FT_SfntName *")] FT_SfntName* aname);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Get_Sfnt_LangTag([NativeTypeName("FT_Face")] FT_Face face,
                                                     [NativeTypeName("FT_UInt")] uint langID,
                                                     [NativeTypeName("FT_SfntLangTag *")] FT_SfntLangTag* alangTag);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_OpenType_Validate([NativeTypeName("FT_Face")] FT_Face face,
                                                      [NativeTypeName("FT_UInt")] uint validation_flags,
                                                      [NativeTypeName("FT_Bytes *")] byte** BASE_table,
                                                      [NativeTypeName("FT_Bytes *")] byte** GDEF_table,
                                                      [NativeTypeName("FT_Bytes *")] byte** GPOS_table,
                                                      [NativeTypeName("FT_Bytes *")] byte** GSUB_table,
                                                      [NativeTypeName("FT_Bytes *")] byte** JSTF_table);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        public static extern void FT_OpenType_Free([NativeTypeName("FT_Face")] FT_Face face,
                                                   [NativeTypeName("FT_Bytes")] byte* table);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_TrueTypeGX_Validate([NativeTypeName("FT_Face")] FT_Face face,
                                                        [NativeTypeName("FT_UInt")] uint validation_flags,
                                                        [NativeTypeName("FT_Bytes [10]")] byte** tables,
                                                        [NativeTypeName("FT_UInt")] uint table_length);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        public static extern void FT_TrueTypeGX_Free([NativeTypeName("FT_Face")] FT_Face face,
                                                     [NativeTypeName("FT_Bytes")] byte* table);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_ClassicKern_Validate([NativeTypeName("FT_Face")] FT_Face face,
                                                         [NativeTypeName("FT_UInt")] uint validation_flags,
                                                         [NativeTypeName("FT_Bytes *")] byte** ckern_table);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        public static extern void FT_ClassicKern_Free([NativeTypeName("FT_Face")] FT_Face face,
                                                      [NativeTypeName("FT_Bytes")] byte* table);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Get_PFR_Metrics([NativeTypeName("FT_Face")] FT_Face face,
                                                    [NativeTypeName("FT_UInt *")] uint* aoutline_resolution,
                                                    [NativeTypeName("FT_UInt *")] uint* ametrics_resolution,
                                                    [NativeTypeName("FT_Fixed *")] int* ametrics_x_scale,
                                                    [NativeTypeName("FT_Fixed *")] int* ametrics_y_scale);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Get_PFR_Kerning([NativeTypeName("FT_Face")] FT_Face face,
                                                    [NativeTypeName("FT_UInt")] uint left,
                                                    [NativeTypeName("FT_UInt")] uint right,
                                                    [NativeTypeName("FT_Vector *")] FT_Vector* avector);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Get_PFR_Advance([NativeTypeName("FT_Face")] FT_Face face,
                                                    [NativeTypeName("FT_UInt")] uint gindex,
                                                    [NativeTypeName("FT_Pos *")] int* aadvance);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_StrokerBorder")]
        public static extern FT_StrokerBorder FT_Outline_GetInsideBorder([NativeTypeName("FT_Outline *")] ref FT_Outline outline);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_StrokerBorder")]
        public static extern FT_StrokerBorder FT_Outline_GetOutsideBorder([NativeTypeName("FT_Outline *")] ref FT_Outline outline);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Stroker_New([NativeTypeName("FT_Library")] FT_Library library,
                                                [NativeTypeName("FT_Stroker *")] out FT_Stroker* astroker);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        public static extern void FT_Stroker_Set([NativeTypeName("FT_Stroker")] FT_Stroker* stroker,
                                                 [NativeTypeName("FT_Fixed")] int radius,
                                                 [NativeTypeName("FT_Stroker_LineCap")] FT_Stroker_LineCap line_cap,
                                                 [NativeTypeName("FT_Stroker_LineJoin")]
                                                 FT_Stroker_LineJoin line_join,
                                                 [NativeTypeName("FT_Fixed")] int miter_limit);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        public static extern void FT_Stroker_Rewind([NativeTypeName("FT_Stroker")] FT_Stroker* stroker);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Stroker_ParseOutline([NativeTypeName("FT_Stroker")] FT_Stroker* stroker,
                                                         [NativeTypeName("FT_Outline *")] ref FT_Outline outline,
                                                         [NativeTypeName("FT_Bool")] byte opened);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Stroker_BeginSubPath([NativeTypeName("FT_Stroker")] FT_Stroker* stroker,
                                                         [NativeTypeName("FT_Vector *")] FT_Vector* to,
                                                         [NativeTypeName("FT_Bool")] byte open);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Stroker_EndSubPath([NativeTypeName("FT_Stroker")] FT_Stroker* stroker);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Stroker_LineTo([NativeTypeName("FT_Stroker")] FT_Stroker* stroker,
                                                   [NativeTypeName("FT_Vector *")] FT_Vector* to);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Stroker_ConicTo([NativeTypeName("FT_Stroker")] FT_Stroker* stroker,
                                                    [NativeTypeName("FT_Vector *")] FT_Vector* control,
                                                    [NativeTypeName("FT_Vector *")] FT_Vector* to);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Stroker_CubicTo([NativeTypeName("FT_Stroker")] FT_Stroker* stroker,
                                                    [NativeTypeName("FT_Vector *")] FT_Vector* control1,
                                                    [NativeTypeName("FT_Vector *")] FT_Vector* control2,
                                                    [NativeTypeName("FT_Vector *")] FT_Vector* to);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Stroker_GetBorderCounts([NativeTypeName("FT_Stroker")] FT_Stroker* stroker,
                                                            [NativeTypeName("FT_StrokerBorder")] FT_StrokerBorder border,
                                                            [NativeTypeName("FT_UInt *")] uint* anum_points,
                                                            [NativeTypeName("FT_UInt *")] uint* anum_contours);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        public static extern void FT_Stroker_ExportBorder([NativeTypeName("FT_Stroker")] FT_Stroker* stroker,
                                                          [NativeTypeName("FT_StrokerBorder")] FT_StrokerBorder border,
                                                          [NativeTypeName("FT_Outline *")] ref FT_Outline outline);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Stroker_GetCounts([NativeTypeName("FT_Stroker")] FT_Stroker* stroker,
                                                      [NativeTypeName("FT_UInt *")] uint* anum_points,
                                                      [NativeTypeName("FT_UInt *")] uint* anum_contours);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        public static extern void FT_Stroker_Export([NativeTypeName("FT_Stroker")] FT_Stroker* stroker,
                                                    [NativeTypeName("FT_Outline *")] ref FT_Outline outline);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        public static extern void FT_Stroker_Done([NativeTypeName("FT_Stroker")] FT_Stroker* stroker);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Glyph_Stroke([NativeTypeName("FT_Glyph *")] ref FT_Glyph pglyph,
                                                 [NativeTypeName("FT_Stroker")] FT_Stroker* stroker,
                                                 [NativeTypeName("FT_Bool")] byte destroy);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Glyph_StrokeBorder([NativeTypeName("FT_Glyph *")] ref FT_Glyph pglyph,
                                                       [NativeTypeName("FT_Stroker")] FT_Stroker* stroker,
                                                       [NativeTypeName("FT_Bool")] byte inside,
                                                       [NativeTypeName("FT_Bool")] byte destroy);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        public static extern void FT_GlyphSlot_Embolden([NativeTypeName("FT_GlyphSlot")] FT_GlyphSlotRec* slot);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        public static extern void FT_GlyphSlot_Oblique([NativeTypeName("FT_GlyphSlot")] FT_GlyphSlotRec* slot);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern utf8string FT_Get_Font_Format([NativeTypeName("FT_Face")] FT_Face face);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern utf8string FT_Get_X11_Font_Format([NativeTypeName("FT_Face")] FT_Face face);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Fixed")]
        public static extern int FT_Sin([NativeTypeName("FT_Angle")] int angle);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Fixed")]
        public static extern int FT_Cos([NativeTypeName("FT_Angle")] int angle);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Fixed")]
        public static extern int FT_Tan([NativeTypeName("FT_Angle")] int angle);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Angle")]
        public static extern int FT_Atan2([NativeTypeName("FT_Fixed")] int x,
                                          [NativeTypeName("FT_Fixed")] int y);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Angle")]
        public static extern int FT_Angle_Diff([NativeTypeName("FT_Angle")] int angle1,
                                               [NativeTypeName("FT_Angle")] int angle2);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        public static extern void FT_Vector_Unit([NativeTypeName("FT_Vector *")] FT_Vector* vec,
                                                 [NativeTypeName("FT_Angle")] int angle);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        public static extern void FT_Vector_Rotate([NativeTypeName("FT_Vector *")] FT_Vector* vec,
                                                   [NativeTypeName("FT_Angle")] int angle);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Fixed")]
        public static extern int FT_Vector_Length([NativeTypeName("FT_Vector *")] FT_Vector* vec);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        public static extern void FT_Vector_Polarize([NativeTypeName("FT_Vector *")] FT_Vector* vec,
                                                     [NativeTypeName("FT_Fixed *")] int* length,
                                                     [NativeTypeName("FT_Angle *")] int* angle);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        public static extern void FT_Vector_From_Polar([NativeTypeName("FT_Vector *")] FT_Vector* vec,
                                                       [NativeTypeName("FT_Fixed")] int length,
                                                       [NativeTypeName("FT_Angle")] int angle);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Library_SetLcdFilter([NativeTypeName("FT_Library")] FT_Library library,
                                                         [NativeTypeName("FT_LcdFilter")] FT_LcdFilter filter);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Library_SetLcdFilterWeights([NativeTypeName("FT_Library")] FT_Library library,
                                                                [NativeTypeName("unsigned char *")] byte* weights);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Library_SetLcdGeometry([NativeTypeName("FT_Library")] FT_Library library,
                                                           [NativeTypeName("FT_Vector [3]")] FT_Vector* sub);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Int")]
        public static extern int FT_Get_Gasp([NativeTypeName("FT_Face")] FT_Face face,
                                             [NativeTypeName("FT_UInt")] uint ppem);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Get_Advance([NativeTypeName("FT_Face")] FT_Face face,
                                                [NativeTypeName("FT_UInt")] uint gindex,
                                                [NativeTypeName("FT_Int32")] int load_flags,
                                                [NativeTypeName("FT_Fixed *")] int* padvance);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Get_Advances([NativeTypeName("FT_Face")] FT_Face face,
                                                 [NativeTypeName("FT_UInt")] uint start,
                                                 [NativeTypeName("FT_UInt")] uint count,
                                                 [NativeTypeName("FT_Int32")] int load_flags,
                                                 [NativeTypeName("FT_Fixed *")] int* padvances);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Palette_Data_Get([NativeTypeName("FT_Face")] FT_Face face,
                                                     [NativeTypeName("FT_Palette_Data *")] FT_Palette_Data* apalette);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Palette_Select([NativeTypeName("FT_Face")] FT_Face face,
                                                   [NativeTypeName("ushort")] ushort palette_index,
                                                   [NativeTypeName("FT_Color **")] out FT_Color* apalette);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern FT_Error FT_Palette_Set_Foreground_Color([NativeTypeName("FT_Face")] FT_Face face,
                                                                 [NativeTypeName("FT_Color")] FT_Color foreground_color);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Bool")]
        public static extern byte FT_Get_Color_Glyph_Layer([NativeTypeName("FT_Face")] FT_Face face,
                                                           [NativeTypeName("FT_UInt")] uint base_glyph,
                                                           [NativeTypeName("FT_UInt *")] uint* aglyph_index,
                                                           [NativeTypeName("FT_UInt *")] uint* acolor_index,
                                                           [NativeTypeName("FT_LayerIterator *")] FT_LayerIterator* iterator);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Bool")]
        public static extern byte FT_Get_Color_Glyph_Paint([NativeTypeName("FT_Face")] FT_Face face,
                                                           [NativeTypeName("FT_UInt")] uint base_glyph,
                                                           [NativeTypeName("FT_Color_Root_Transform")]
                                                           FT_Color_Root_Transform root_transform,
                                                           [NativeTypeName("FT_OpaquePaint *")] FT_Opaque_Paint* paint);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Bool")]
        public static extern byte FT_Get_Color_Glyph_ClipBox([NativeTypeName("FT_Face")] FT_Face face,
                                                             [NativeTypeName("FT_UInt")] uint base_glyph,
                                                             [NativeTypeName("FT_ClipBox *")] FT_ClipBox* clip_box);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Bool")]
        public static extern byte FT_Get_Paint_Layers([NativeTypeName("FT_Face")] FT_Face face,
                                                      [NativeTypeName("FT_LayerIterator *")] FT_LayerIterator* iterator,
                                                      [NativeTypeName("FT_OpaquePaint *")] FT_Opaque_Paint* paint);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Bool")]
        public static extern byte FT_Get_Colorline_Stops([NativeTypeName("FT_Face")] FT_Face face,
                                                         [NativeTypeName("FT_ColorStop *")] FT_ColorStop* color_stop,
                                                         [NativeTypeName("FT_ColorStopIterator *")]
                                                         FT_ColorStopIterator* iterator);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization), SuppressGCTransition, SuppressUnmanagedCodeSecurity, DllImport("freetype.dll",
                                                                                                                                                                     CallingConvention = CallingConvention.Cdecl,
                                                                                                                                                                     ExactSpelling = true)]
        [return: NativeTypeName("FT_Bool")]
        public static extern byte FT_Get_Paint([NativeTypeName("FT_Face")] FT_Face face,
                                               [NativeTypeName("FT_OpaquePaint")] FT_Opaque_Paint opaque_paint,
                                               [NativeTypeName("FT_COLR_Paint *")] FT_COLR_Paint* paint);







        [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("FT_Error")]
        public static extern int FT_List_Iterate([NativeTypeName("FT_List")] FT_ListRec* list, [NativeTypeName("FT_List_Iterator")] delegate* unmanaged<FT_ListNodeRec*, nint, int> iterator, [NativeTypeName("void *")] nint user);

        [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void FT_List_Finalize([NativeTypeName("FT_List")] FT_ListRec* list, [NativeTypeName("FT_List_Destructor")] delegate* unmanaged<FT_MemoryRec*, nint, nint, void> destroy, [NativeTypeName("FT_Memory")] FT_MemoryRec* memory, [NativeTypeName("void *")] nint user);

        [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void FT_Trace_Set_Level([NativeTypeName("const char *")] utf8string tracing_level);

        [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void FT_Trace_Set_Default_Level();

        [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void FT_Set_Log_Handler([NativeTypeName("FT_Custom_Log_Handler")] delegate* unmanaged<utf8string, utf8string, utf8string, void> handler);

        [DllImport("freetype", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void FT_Set_Default_Log_Handler();
        
    }
}
