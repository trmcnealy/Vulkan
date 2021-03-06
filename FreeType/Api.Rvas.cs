using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;


namespace FreeType
{
    public static partial class Api
    {
        public static readonly nint FTC_CMapCache_Lookup_Rva                    = 0x00026590;
        public static readonly nint FTC_CMapCache_New_Rva                       = 0x00026300;
        public static readonly nint FTC_ImageCache_Lookup_Rva                   = 0x000245E0;
        public static readonly nint FTC_ImageCache_LookupScaler_Rva             = 0x00024E00;
        public static readonly nint FTC_ImageCache_New_Rva                      = 0x000239C0;
        public static readonly nint FTC_Manager_Done_Rva                        = 0x00026D20;
        public static readonly nint FTC_Manager_LookupFace_Rva                  = 0x00025B00;
        public static readonly nint FTC_Manager_LookupSize_Rva                  = 0x000244C0;
        public static readonly nint FTC_Manager_New_Rva                         = 0x00026870;
        public static readonly nint FTC_Manager_RemoveFaceID_Rva                = 0x00027000;
        public static readonly nint FTC_Manager_Reset_Rva                       = 0x00026EB0;
        public static readonly nint FTC_Node_Unref_Rva                          = 0x00027290;
        public static readonly nint FTC_SBitCache_Lookup_Rva                    = 0x00025BB0;
        public static readonly nint FTC_SBitCache_LookupScaler_Rva              = 0x00025F50;
        public static readonly nint FTC_SBitCache_New_Rva                       = 0x00025110;
        public static readonly nint FT_Activate_Size_Rva                        = 0x000140D0;
        public static readonly nint FT_Add_Default_Modules_Rva                  = 0x0001ABB0;
        public static readonly nint FT_Add_Module_Rva                           = 0x000144F0;
        public static readonly nint FT_Angle_Diff_Rva                           = 0x00017DD0;
        public static readonly nint FT_Atan2_Rva                                = 0x00017980;
        public static readonly nint FT_Attach_File_Rva                          = 0x000120B0;
        public static readonly nint FT_Attach_Stream_Rva                        = 0x000121A0;
        public static readonly nint FT_Bitmap_Blend_Rva                         = 0x00019830;
        public static readonly nint FT_Bitmap_Convert_Rva                       = 0x000192E0;
        public static readonly nint FT_Bitmap_Copy_Rva                          = 0x00018920;
        public static readonly nint FT_Bitmap_Done_Rva                          = 0x000197E0;
        public static readonly nint FT_Bitmap_Embolden_Rva                      = 0x00018AA0;
        public static readonly nint FT_Bitmap_Init_Rva                          = 0x000188E0;
        public static readonly nint FT_Bitmap_New_Rva                           = 0x00018900;
        public static readonly nint FT_CMap_Done_Rva                            = 0x00013370;
        public static readonly nint FT_CMap_New_Rva                             = 0x00013520;
        public static readonly nint FT_CeilFix_Rva                              = 0x0000AC90;
        public static readonly nint FT_ClassicKern_Free_Rva                     = 0x0001AB90;
        public static readonly nint FT_ClassicKern_Validate_Rva                 = 0x0001AB20;
        public static readonly nint FT_Cos_Rva                                  = 0x000175A0;
        public static readonly nint FT_DivFix_Rva                               = 0x0000AEC0;
        public static readonly nint FT_Done_Face_Rva                            = 0x0000FB10;
        public static readonly nint FT_Done_FreeType_Rva                        = 0x0001AEE0;
        public static readonly nint FT_Done_Glyph_Rva                           = 0x0001A560;
        public static readonly nint FT_Done_GlyphSlot_Rva                       = 0x0000DFC0;
        public static readonly nint FT_Done_Library_Rva                         = 0x00014E60;
        public static readonly nint FT_Done_MM_Var_Rva                          = 0x0001B050;
        public static readonly nint FT_Done_Memory_Rva                          = 0x0007DD90;
        public static readonly nint FT_Done_Size_Rva                            = 0x000122E0;
        public static readonly nint FT_Error_String_Rva                         = 0x0000BD80;
        public static readonly nint FT_Face_CheckTrueTypePatents_Rva            = 0x0001BAD0;
        public static readonly nint FT_Face_GetCharVariantIndex_Rva             = 0x000138B0;
        public static readonly nint FT_Face_GetCharVariantIsDefault_Rva         = 0x000139B0;
        public static readonly nint FT_Face_GetCharsOfVariant_Rva               = 0x00013C50;
        public static readonly nint FT_Face_GetVariantSelectors_Rva             = 0x00013A90;
        public static readonly nint FT_Face_GetVariantsOfChar_Rva               = 0x00013B70;
        public static readonly nint FT_Face_Properties_Rva                      = 0x000137F0;
        public static readonly nint FT_Face_SetUnpatentedHinting_Rva            = 0x0001BAE0;
        public static readonly nint FT_FloorFix_Rva                             = 0x0000ACA0;
        public static readonly nint FT_Get_Advance_Rva                          = 0x0000A0E0;
        public static readonly nint FT_Get_Advances_Rva                         = 0x0000A400;
        public static readonly nint FT_Get_BDF_Charset_ID_Rva                   = 0x000187C0;
        public static readonly nint FT_Get_BDF_Property_Rva                     = 0x00018860;
        public static readonly nint FT_Get_CID_From_Glyph_Index_Rva             = 0x0001A0C0;
        public static readonly nint FT_Get_CID_Is_Internally_CID_Keyed_Rva      = 0x0001A050;
        public static readonly nint FT_Get_CID_Registry_Ordering_Supplement_Rva = 0x00019FA0;
        public static readonly nint FT_Get_CMap_Format_Rva                      = 0x000132C0;
        public static readonly nint FT_Get_CMap_Language_ID_Rva                 = 0x00014070;
        public static readonly nint FT_Get_Char_Index_Rva                       = 0x0000E6B0;
        public static readonly nint FT_Get_Charmap_Index_Rva                    = 0x00013320;
        public static readonly nint FT_Get_Color_Glyph_ClipBox_Rva              = 0x00015220;
        public static readonly nint FT_Get_Color_Glyph_Layer_Rva                = 0x000144B0;
        public static readonly nint FT_Get_Color_Glyph_Paint_Rva                = 0x000151F0;
        public static readonly nint FT_Get_Colorline_Stops_Rva                  = 0x000152D0;
        public static readonly nint FT_Get_FSType_Flags_Rva                     = 0x0001A130;
        public static readonly nint FT_Get_First_Char_Rva                       = 0x000136A0;
        public static readonly nint FT_Get_Font_Format_Rva                      = 0x0000BD90;
        public static readonly nint FT_Get_Gasp_Rva                             = 0x0001A1B0;
        public static readonly nint FT_Get_Glyph_Rva                            = 0x0001A640;
        public static readonly nint FT_Get_Glyph_Name_Rva                       = 0x00013DD0;
        public static readonly nint FT_Get_Kerning_Rva                          = 0x00012F00;
        public static readonly nint FT_Get_MM_Blend_Coordinates_Rva             = 0x0001B770;
        public static readonly nint FT_Get_MM_Var_Rva                           = 0x0001AFB0;
        public static readonly nint FT_Get_MM_WeightVector_Rva                  = 0x0001B220;
        public static readonly nint FT_Get_Module_Rva                           = 0x00010140;
        public static readonly nint FT_Get_Module_Interface_Rva                 = 0x000149D0;
        public static readonly nint FT_Get_Multi_Master_Rva                     = 0x0001AF10;
        public static readonly nint FT_Get_Name_Index_Rva                       = 0x00013D30;
        public static readonly nint FT_Get_Next_Char_Rva                        = 0x00013760;
        public static readonly nint FT_Get_PFR_Advance_Rva                      = 0x0001BCB0;
        public static readonly nint FT_Get_PFR_Kerning_Rva                      = 0x0001BBF0;
        public static readonly nint FT_Get_PFR_Metrics_Rva                      = 0x0001BAF0;
        public static readonly nint FT_Get_PS_Font_Info_Rva                     = 0x0001F460;
        public static readonly nint FT_Get_PS_Font_Private_Rva                  = 0x0001F520;
        public static readonly nint FT_Get_PS_Font_Value_Rva                    = 0x0001F590;
        public static readonly nint FT_Get_Paint_Rva                            = 0x00015280;
        public static readonly nint FT_Get_Paint_Layers_Rva                     = 0x00015250;
        public static readonly nint FT_Get_Postscript_Name_Rva                  = 0x00013EA0;
        public static readonly nint FT_Get_Renderer_Rva                         = 0x00014100;
        public static readonly nint FT_Get_Sfnt_LangTag_Rva                     = 0x00016B20;
        public static readonly nint FT_Get_Sfnt_Name_Rva                        = 0x000169D0;
        public static readonly nint FT_Get_Sfnt_Name_Count_Rva                  = 0x000169B0;
        public static readonly nint FT_Get_Sfnt_Table_Rva                       = 0x00013F20;
        public static readonly nint FT_Get_SubGlyph_Info_Rva                    = 0x00015180;
        public static readonly nint FT_Get_Track_Kerning_Rva                    = 0x00013080;
        public static readonly nint FT_Get_Transform_Rva                        = 0x0000E2E0;
        public static readonly nint FT_Get_TrueType_Engine_Type_Rva             = 0x00015100;
        public static readonly nint FT_Get_Var_Axis_Flags_Rva                   = 0x0001B8D0;
        public static readonly nint FT_Get_Var_Blend_Coordinates_Rva            = 0x0001B820;
        public static readonly nint FT_Get_Var_Design_Coordinates_Rva           = 0x0001B420;
        public static readonly nint FT_Get_WinFNT_Header_Rva                    = 0x0001F600;
        public static readonly nint FT_Get_X11_Font_Format_Rva                  = 0x0000BDC0;
        public static readonly nint FT_GlyphLoader_Add_Rva                      = 0x0000CC10;
        public static readonly nint FT_GlyphLoader_CheckPoints_Rva              = 0x0000C390;
        public static readonly nint FT_GlyphLoader_CheckSubGlyphs_Rva           = 0x0000CA20;
        public static readonly nint FT_GlyphLoader_CreateExtra_Rva              = 0x0000C190;
        public static readonly nint FT_GlyphLoader_Done_Rva                     = 0x0000C060;
        public static readonly nint FT_GlyphLoader_New_Rva                      = 0x0000BDF0;
        public static readonly nint FT_GlyphLoader_Prepare_Rva                  = 0x0000CB40;
        public static readonly nint FT_GlyphLoader_Reset_Rva                    = 0x0000BF30;
        public static readonly nint FT_GlyphLoader_Rewind_Rva                   = 0x0000BEC0;
        public static readonly nint FT_GlyphSlot_Embolden_Rva                   = 0x0001F360;
        public static readonly nint FT_GlyphSlot_Oblique_Rva                    = 0x0001F320;
        public static readonly nint FT_GlyphSlot_Own_Bitmap_Rva                 = 0x00019F10;
        public static readonly nint FT_Glyph_Copy_Rva                           = 0x0001A480;
        public static readonly nint FT_Glyph_Get_CBox_Rva                       = 0x0001A7D0;
        public static readonly nint FT_Glyph_Stroke_Rva                         = 0x0001EFE0;
        public static readonly nint FT_Glyph_StrokeBorder_Rva                   = 0x0001F1A0;
        public static readonly nint FT_Glyph_To_Bitmap_Rva                      = 0x0001A850;
        public static readonly nint FT_Glyph_Transform_Rva                      = 0x0001A770;
        public static readonly nint FT_Gzip_Uncompress_Rva                      = 0x00031C10;
        public static readonly nint FT_Has_PS_Glyph_Names_Rva                   = 0x0001F4D0;
        public static readonly nint FT_Hypot_Rva                                = 0x0000ACB0;
        public static readonly nint FT_Init_FreeType_Rva                        = 0x0001AE80;
        public static readonly nint FT_Library_SetLcdFilter_Rva                 = 0x0000D3D0;
        public static readonly nint FT_Library_SetLcdFilterWeights_Rva          = 0x0000D3C0;
        public static readonly nint FT_Library_SetLcdGeometry_Rva               = 0x0000D3E0;
        public static readonly nint FT_Library_Version_Rva                      = 0x00014E20;
        public static readonly nint FT_List_Add_Rva                             = 0x0000F950;
        public static readonly nint FT_List_Finalize_Rva                        = 0x00011FA0;
        public static readonly nint FT_List_Find_Rva                            = 0x00012280;
        public static readonly nint FT_List_Insert_Rva                          = 0x00017F90;
        public static readonly nint FT_List_Iterate_Rva                         = 0x00017FC0;
        public static readonly nint FT_List_Remove_Rva                          = 0x000122B0;
        public static readonly nint FT_List_Up_Rva                              = 0x00014230;
        public static readonly nint FT_Load_Char_Rva                            = 0x0000E660;
        public static readonly nint FT_Load_Glyph_Rva                           = 0x0000A610;
        public static readonly nint FT_Load_Sfnt_Table_Rva                      = 0x00013F80;
        public static readonly nint FT_Lookup_Renderer_Rva                      = 0x0000E610;
        public static readonly nint FT_Match_Size_Rva                           = 0x00012400;
        public static readonly nint FT_Matrix_Check_Rva                         = 0x0000B5C0;
        public static readonly nint FT_Matrix_Invert_Rva                        = 0x0000B040;
        public static readonly nint FT_Matrix_Multiply_Rva                      = 0x0000AF20;
        public static readonly nint FT_Matrix_Multiply_Scaled_Rva               = 0x0000B1D0;
        public static readonly nint FT_MulDiv_Rva                               = 0x0000A590;
        public static readonly nint FT_MulDiv_No_Round_Rva                      = 0x0000AE20;
        public static readonly nint FT_MulFix_Rva                               = 0x0000AEA0;
        public static readonly nint FT_New_Face_Rva                             = 0x0000E6F0;
        public static readonly nint FT_New_Glyph_Rva                            = 0x0001A5A0;
        public static readonly nint FT_New_GlyphSlot_Rva                        = 0x0000DC20;
        public static readonly nint FT_New_Library_Rva                          = 0x00014DA0;
        public static readonly nint FT_New_Memory_Rva                           = 0x0007DD20;
        public static readonly nint FT_New_Memory_Face_Rva                      = 0x00012030;
        public static readonly nint FT_New_Size_Rva                             = 0x0000F980;
        public static readonly nint FT_OpenType_Free_Rva                        = 0x0001BAB0;
        public static readonly nint FT_OpenType_Validate_Rva                    = 0x0001BA20;
        public static readonly nint FT_Open_Face_Rva                            = 0x00012090;
        public static readonly nint FT_Outline_Check_Rva                        = 0x0000E310;
        public static readonly nint FT_Outline_Copy_Rva                         = 0x00015950;
        public static readonly nint FT_Outline_Decompose_Rva                    = 0x00015300;
        public static readonly nint FT_Outline_Done_Rva                         = 0x000158C0;
        public static readonly nint FT_Outline_Embolden_Rva                     = 0x00015CB0;
        public static readonly nint FT_Outline_EmboldenXY_Rva                   = 0x00015CC0;
        public static readonly nint FT_Outline_GetInsideBorder_Rva              = 0x0001BD50;
        public static readonly nint FT_Outline_GetOutsideBorder_Rva             = 0x0001BD70;
        public static readonly nint FT_Outline_Get_BBox_Rva                     = 0x00018020;
        public static readonly nint FT_Outline_Get_Bitmap_Rva                   = 0x00015C60;
        public static readonly nint FT_Outline_Get_CBox_Rva                     = 0x0000DAA0;
        public static readonly nint FT_Outline_Get_Orientation_Rva              = 0x000163E0;
        public static readonly nint FT_Outline_New_Rva                          = 0x00015700;
        public static readonly nint FT_Outline_Render_Rva                       = 0x00015AB0;
        public static readonly nint FT_Outline_Reverse_Rva                      = 0x000159F0;
        public static readonly nint FT_Outline_Transform_Rva                    = 0x0000E430;
        public static readonly nint FT_Outline_Translate_Rva                    = 0x0000E510;
        public static readonly nint FT_Palette_Data_Get_Rva                     = 0x0000BC80;
        public static readonly nint FT_Palette_Select_Rva                       = 0x0000BCE0;
        public static readonly nint FT_Palette_Set_Foreground_Color_Rva         = 0x0000BD50;
        public static readonly nint FT_Property_Get_Rva                         = 0x00014BD0;
        public static readonly nint FT_Property_Set_Rva                         = 0x00014AF0;
        public static readonly nint FT_Raccess_Get_DataOffsets_Rva              = 0x00010B90;
        public static readonly nint FT_Raccess_Get_HeaderInfo_Rva               = 0x00010860;
        public static readonly nint FT_Raccess_Guess_Rva                        = 0x000110B0;
        public static readonly nint FT_Reference_Face_Rva                       = 0x00012260;
        public static readonly nint FT_Reference_Library_Rva                    = 0x00014D80;
        public static readonly nint FT_Remove_Module_Rva                        = 0x000146B0;
        public static readonly nint FT_Render_Glyph_Rva                         = 0x0000E5E0;
        public static readonly nint FT_Render_Glyph_Internal_Rva                = 0x00014270;
        public static readonly nint FT_Request_Metrics_Rva                      = 0x00012730;
        public static readonly nint FT_Request_Size_Rva                         = 0x00012B40;
        public static readonly nint FT_RoundFix_Rva                             = 0x0000AC70;
        public static readonly nint FT_Select_Charmap_Rva                       = 0x00013100;
        public static readonly nint FT_Select_Metrics_Rva                       = 0x000125A0;
        public static readonly nint FT_Select_Size_Rva                          = 0x00012AE0;
        public static readonly nint FT_Set_Char_Size_Rva                        = 0x00012BF0;
        public static readonly nint FT_Set_Charmap_Rva                          = 0x000131F0;
        public static readonly nint FT_Set_Debug_Hook_Rva                       = 0x000150E0;
        public static readonly nint FT_Set_Default_Log_Handler_Rva              = 0x0007DE20;
        public static readonly nint FT_Set_Default_Properties_Rva               = 0x0001ACD0;
        public static readonly nint FT_Set_Log_Handler_Rva                      = 0x0007DE10;
        public static readonly nint FT_Set_MM_Blend_Coordinates_Rva             = 0x0001B4D0;
        public static readonly nint FT_Set_MM_Design_Coordinates_Rva            = 0x0001B080;
        public static readonly nint FT_Set_MM_WeightVector_Rva                  = 0x0001B150;
        public static readonly nint FT_Set_Named_Instance_Rva                   = 0x0001B8F0;
        public static readonly nint FT_Set_Pixel_Sizes_Rva                      = 0x00012DB0;
        public static readonly nint FT_Set_Renderer_Rva                         = 0x00014140;
        public static readonly nint FT_Set_Transform_Rva                        = 0x0000E240;
        public static readonly nint FT_Set_Var_Blend_Coordinates_Rva            = 0x0001B620;
        public static readonly nint FT_Set_Var_Design_Coordinates_Rva           = 0x0001B2D0;
        public static readonly nint FT_Sfnt_Table_Info_Rva                      = 0x00014000;
        public static readonly nint FT_Sin_Rva                                  = 0x00017780;
        public static readonly nint FT_Stream_Close_Rva                         = 0x0000D630;
        public static readonly nint FT_Stream_EnterFrame_Rva                    = 0x00016E20;
        public static readonly nint FT_Stream_ExitFrame_Rva                     = 0x00016F40;
        public static readonly nint FT_Stream_ExtractFrame_Rva                  = 0x00016D30;
        public static readonly nint FT_Stream_Free_Rva                          = 0x0000D650;
        public static readonly nint FT_Stream_GetByte_Rva                       = 0x00016F80;
        public static readonly nint FT_Stream_GetULong_Rva                      = 0x00017040;
        public static readonly nint FT_Stream_GetULongLE_Rva                    = 0x00017060;
        public static readonly nint FT_Stream_GetUOffset_Rva                    = 0x00017000;
        public static readonly nint FT_Stream_GetUShort_Rva                     = 0x00016FA0;
        public static readonly nint FT_Stream_GetUShortLE_Rva                   = 0x00016FD0;
        public static readonly nint FT_Stream_New_Rva                           = 0x0000D4C0;
        public static readonly nint FT_Stream_Open_Rva                          = 0x0007DBE0;
        public static readonly nint FT_Stream_OpenBzip2_Rva                     = 0x000239B0;
        public static readonly nint FT_Stream_OpenGzip_Rva                      = 0x000314E0;
        public static readonly nint FT_Stream_OpenLZW_Rva                       = 0x00031CF0;
        public static readonly nint FT_Stream_OpenMemory_Rva                    = 0x0000D610;
        public static readonly nint FT_Stream_Pos_Rva                           = 0x0000FDC0;
        public static readonly nint FT_Stream_Read_Rva                          = 0x0000FDD0;
        public static readonly nint FT_Stream_ReadAt_Rva                        = 0x00016C70;
        public static readonly nint FT_Stream_ReadByte_Rva                      = 0x00017080;
        public static readonly nint FT_Stream_ReadFields_Rva                    = 0x00017270;
        public static readonly nint FT_Stream_ReadULong_Rva                     = 0x0000FFB0;
        public static readonly nint FT_Stream_ReadULongLE_Rva                   = 0x000171F0;
        public static readonly nint FT_Stream_ReadUOffset_Rva                   = 0x00017160;
        public static readonly nint FT_Stream_ReadUShort_Rva                    = 0x00010030;
        public static readonly nint FT_Stream_ReadUShortLE_Rva                  = 0x000170F0;
        public static readonly nint FT_Stream_ReleaseFrame_Rva                  = 0x00016F10;
        public static readonly nint FT_Stream_Seek_Rva                          = 0x0000F440;
        public static readonly nint FT_Stream_Skip_Rva                          = 0x000100B0;
        public static readonly nint FT_Stream_TryRead_Rva                       = 0x00016CE0;
        public static readonly nint FT_Stroker_BeginSubPath_Rva                 = 0x0001DDD0;
        public static readonly nint FT_Stroker_ConicTo_Rva                      = 0x0001CA30;
        public static readonly nint FT_Stroker_CubicTo_Rva                      = 0x0001D2C0;
        public static readonly nint FT_Stroker_Done_Rva                         = 0x0001BEC0;
        public static readonly nint FT_Stroker_EndSubPath_Rva                   = 0x0001DE20;
        public static readonly nint FT_Stroker_Export_Rva                       = 0x0001E700;
        public static readonly nint FT_Stroker_ExportBorder_Rva                 = 0x0001E450;
        public static readonly nint FT_Stroker_GetBorderCounts_Rva              = 0x0001E290;
        public static readonly nint FT_Stroker_GetCounts_Rva                    = 0x0001E340;
        public static readonly nint FT_Stroker_LineTo_Rva                       = 0x0001BF90;
        public static readonly nint FT_Stroker_New_Rva                          = 0x0001BD90;
        public static readonly nint FT_Stroker_ParseOutline_Rva                 = 0x0001EC00;
        public static readonly nint FT_Stroker_Rewind_Rva                       = 0x0001BE90;
        public static readonly nint FT_Stroker_Set_Rva                          = 0x0001BE30;
        public static readonly nint FT_Tan_Rva                                  = 0x00017850;
        public static readonly nint FT_Trace_Disable_Rva                        = 0x0007DDD0;
        public static readonly nint FT_Trace_Enable_Rva                         = 0x0007DDE0;
        public static readonly nint FT_Trace_Get_Count_Rva                      = 0x0007DDB0;
        public static readonly nint FT_Trace_Get_Name_Rva                       = 0x0007DDC0;
        public static readonly nint FT_Trace_Set_Default_Level_Rva              = 0x0007DE00;
        public static readonly nint FT_Trace_Set_Level_Rva                      = 0x0007DDF0;
        public static readonly nint FT_TrueTypeGX_Free_Rva                      = 0x0001AB00;
        public static readonly nint FT_TrueTypeGX_Validate_Rva                  = 0x0001AA90;
        public static readonly nint FT_Vector_From_Polar_Rva                    = 0x00017DB0;
        public static readonly nint FT_Vector_Length_Rva                        = 0x0000ACD0;
        public static readonly nint FT_Vector_NormLen_Rva                       = 0x0000BA30;
        public static readonly nint FT_Vector_Polarize_Rva                      = 0x00017C40;
        public static readonly nint FT_Vector_Rotate_Rva                        = 0x00017A90;
        public static readonly nint FT_Vector_Transform_Rva                     = 0x0000E550;
        public static readonly nint FT_Vector_Transform_Scaled_Rva              = 0x0000B840;
        public static readonly nint FT_Vector_Unit_Rva                          = 0x00017680;
        public static readonly nint TT_New_Context_Rva                          = 0x0006B600;
        public static readonly nint TT_RunIns_Rva                               = 0x0006B690;

        public static readonly nint af_shaper_buf_create_Rva                    = 0x0000A0D0;
        public static readonly nint af_shaper_buf_destroy_Rva                   = 0x000025C0;
        public static readonly nint af_shaper_get_cluster_Rva                   = 0x00002450;
        public static readonly nint af_shaper_get_coverage_Rva                  = 0x000098D0;
        public static readonly nint af_shaper_get_elem_Rva                      = 0x00002580;
        public static readonly nint ft_corner_is_flat_Rva                       = 0x0000BBF0;
        public static readonly nint ft_corner_orientation_Rva                   = 0x0000BBC0;
        public static readonly nint ft_debug_init_Rva                           = 0x0007DDA0;
        public static readonly nint ft_glyphslot_alloc_bitmap_Rva               = 0x0000DB90;
        public static readonly nint ft_glyphslot_free_bitmap_Rva                = 0x0000D6A0;
        public static readonly nint ft_glyphslot_preset_bitmap_Rva              = 0x0000D700;
        public static readonly nint ft_glyphslot_set_bitmap_Rva                 = 0x0000DB30;
        public static readonly nint ft_hash_num_init_Rva                        = 0x0000CE90;
        public static readonly nint ft_hash_num_insert_Rva                      = 0x0000D1C0;
        public static readonly nint ft_hash_num_lookup_Rva                      = 0x0000D250;
        public static readonly nint ft_hash_str_free_Rva                        = 0x0000CF10;
        public static readonly nint ft_hash_str_init_Rva                        = 0x0000CD70;
        public static readonly nint ft_hash_str_insert_Rva                      = 0x0000CF90;
        public static readonly nint ft_hash_str_lookup_Rva                      = 0x0000D1D0;
        public static readonly nint ft_lcd_padding_Rva                          = 0x0000D2D0;
        public static readonly nint ft_lzwstate_done_Rva                        = 0x00032990;
        public static readonly nint ft_lzwstate_init_Rva                        = 0x00032220;
        public static readonly nint ft_lzwstate_io_Rva                          = 0x00032300;
        public static readonly nint ft_lzwstate_reset_Rva                       = 0x000322D0;
        public static readonly nint ft_mem_alloc_Rva                            = 0x0000BE60;
        public static readonly nint ft_mem_dup_Rva                              = 0x00017E50;
        public static readonly nint ft_mem_free_Rva                             = 0x0000C050;
        public static readonly nint ft_mem_qalloc_Rva                           = 0x0000F920;
        public static readonly nint ft_mem_qrealloc_Rva                         = 0x00013480;
        public static readonly nint ft_mem_realloc_Rva                          = 0x0000C2B0;
        public static readonly nint ft_mem_strcpyn_Rva                          = 0x00017F50;
        public static readonly nint ft_mem_strdup_Rva                           = 0x00017EC0;
        public static readonly nint ft_module_get_service_Rva                   = 0x00014A50;
        public static readonly nint ft_property_string_set_Rva                  = 0x00014CA0;
        public static readonly nint ft_service_list_lookup_Rva                  = 0x0000D410;
        public static readonly nint ft_synthesize_vertical_metrics_Rva          = 0x00012520;
        public static readonly nint ft_validator_error_Rva                      = 0x0000D4A0;
        public static readonly nint ft_validator_init_Rva                       = 0x0000D470;
        public static readonly nint ft_validator_run_Rva                        = 0x0000D490;
        public static readonly nint ps_hints_apply_Rva                          = 0x00048A80;
        public static readonly nint ps_property_get_Rva                         = 0x00016900;
        public static readonly nint ps_property_set_Rva                         = 0x00016580;
    }
}
