// ReSharper disable InconsistentNaming

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.Linq;
using Vulkan;

using static FreeType.FT_Encoding;
using static FreeType.FT_Glyph_BBox_Mode;
using static FreeType.FT_Glyph_Format;
using static FreeType.FT_Kerning_Mode;
using static FreeType.FT_Pixel_Mode;
using static FreeType.FT_Render_Mode;
using static FreeType.FT_Sfnt_Tag;
using static FreeType.T1_Blend_Flags;

#if x86
using size_t = System.UInt32;
#else
using size_t = System.UInt64;
#endif


namespace FreeType
{
    public static unsafe partial class Api
    {
        public static readonly uint ApiVersion;

        public static readonly string DLL_NAME;

        public static readonly nint Handle;

        #region RVAs

        //public static readonly nint vkAcquireNextImage2KHROffset                          = 0x00008410;

        #endregion

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        static unsafe Api()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                DLL_NAME = "libfreetype.so";
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                DLL_NAME = "libfreetype.dylib";
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                DLL_NAME = "freetype.dll";
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.FreeBSD))
            {
                DLL_NAME = "freetype";
            }
            else
            {
                DLL_NAME = "freetype";
            }

            Handle = Vulkan.DllMap.MapAndLoad(DLL_NAME);

            Marshal.PrelinkAll(typeof(Api));

#if LOAD_FROM_DEVICEPROCADDR
            #region LOAD_FROM_DEVICEPROCADDR
            
            #endregion

#elif true //LOAD_FROM_RVA

            #region LOAD_FROM_RVA

            //GetInstanceProcAddr = (delegate*<VkInstance, utf8string, nint>)(Handle + vkGetInstanceProcAddrOffset);

            #endregion

#elif LOAD_FROM_GETEXPORT
            #region LOAD_FROM_GETEXPORT
            
            #endregion

#endif
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static uint FT_MAKE_TAG(char _x1,
                                       char _x2,
                                       char _x3,
                                       char _x4)
        {
            return ((Convert.ToUInt32(_x1) << 24) |
                    (Convert.ToUInt32(_x2) << 16) |
                    (Convert.ToUInt32(_x3) << 8) |
                    Convert.ToUInt32(_x4));
        }


        public static FT_Library Library;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        internal static IEnumerable<int> Range(int start, int end)
        {
            int count = end - start;

            for(int i = 0; i < count + 1; ++i)
            {
                yield return start + i;
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        internal static IEnumerable<uint> Range(uint start, uint end)
        {
            uint count = end - start;

            for(uint i = 0; i < count + 1; ++i)
            {
                yield return start + i;
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe byte[] FT_Load_Sfnt_Table(FT_Face face,
                                                       uint    tag,
                                                       int     offset = 0)
        {
            _FT_Load_Sfnt_Table(face, tag, offset, null, out uint length);

            ArrayPointer<byte> pArray = NativeIntExtensions.CreateArrayPointer<byte>(length);

            _FT_Load_Sfnt_Table(face, tag, offset, pArray.Pointer, out length);

            return NativeIntExtensions.CopyAndDeleteArrayPointer(pArray);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static FT_Face LoadFontFaceFromFile(utf8string filePath,
                                                   int        face_index = 0)
        {
            if(Library == FT_Library.Null)
            {
                Library = new FT_Library();
            }

            FT_New_Face(Library,
                        filePath,
                        face_index,
                        out FT_Face face);




            TT_VertHeader* vert_header = (TT_VertHeader*)FT_Get_Sfnt_Table( face, FT_SFNT_VHEA );




            

            //byte[] buffer = FT_Load_Sfnt_Table( face, tag, 0);



















            const uint rows = 6;
            const uint cols = 16;
            const uint n    = rows * cols;


            IEnumerable<uint> FONT_MAP_CHAR_INDICES = Range(32,
                                                            32 + n);

            FT_Vector origin = FT_Vector.Zero;

            FT_BitmapGlyph[] glyph_bitmaps = new FT_BitmapGlyph[n];
            
            foreach(uint glyph_index in FONT_MAP_CHAR_INDICES)
            {
                //FONT_MAP_CHARS += Convert.ToChar(glyph_index);

                FT_Load_Char(face,
                             glyph_index,
                             FT_LOAD_DEFAULT);

                FT_Get_Glyph(face.Glyph,
                             out FT_Glyph glyph);

                if(glyph.format != FT_GLYPH_FORMAT_BITMAP )
                {
                    FT_Glyph_To_Bitmap(ref glyph,
                                       FT_RENDER_MODE_NORMAL,
                                       ref origin,
                                       1);

                    FT_Glyph_Copy(glyph, out FT_Glyph glyph_copy);

                    glyph_bitmaps[glyph_index] = (FT_BitmapGlyph)glyph_copy;
                }

                FT_Done_Glyph(glyph);
            }

            return face;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static FT_BBox ComputeStringBBox(FT_Face face, string charSequence, out FT_Glyph[] glyphs)
        {
            glyphs = new FT_Glyph[charSequence.Length];
            
            for(int n = 0; n < charSequence.Length; n++)
            {
                FT_Load_Char(face, Convert.ToUInt32(charSequence[n]), FT_LOAD_DEFAULT);
  
                FT_Get_Glyph(face.Glyph, out FT_Glyph glyph);

                FT_Glyph_Copy(glyph, out glyphs[n]);
            }
            
            FT_BBox bbox = new();

            bbox.xMin = bbox.yMin = 32000;
            bbox.xMax = bbox.yMax = -32000;

            for(int n = 0; n < glyphs.Length; n++)
            {
                FT_Glyph_Get_CBox(glyphs[n],
                                  (uint)FT_GLYPH_BBOX_PIXELS,
                                  out FT_BBox glyph_bbox);

                if(glyph_bbox.xMin < bbox.xMin)
                {
                    bbox.xMin = glyph_bbox.xMin;
                }

                if(glyph_bbox.yMin < bbox.yMin)
                {
                    bbox.yMin = glyph_bbox.yMin;
                }

                if(glyph_bbox.xMax > bbox.xMax)
                {
                    bbox.xMax = glyph_bbox.xMax;
                }

                if(glyph_bbox.yMax > bbox.yMax)
                {
                    bbox.yMax = glyph_bbox.yMax;
                }
            }

            return bbox;
        }








    }
}
