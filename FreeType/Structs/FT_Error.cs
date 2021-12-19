
namespace FreeType
{
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [System.Runtime.Versioning.NonVersionable]
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct FT_Error
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        static FT_Error()
        {
            Ok = new FT_Error(OkConst);
            Cannot_Open_Resource = new FT_Error(Cannot_Open_ResourceConst);
            Unknown_File_Format = new FT_Error(Unknown_File_FormatConst);
            Invalid_File_Format = new FT_Error(Invalid_File_FormatConst);
            Invalid_Version = new FT_Error(Invalid_VersionConst);
            Lower_Module_Version = new FT_Error(Lower_Module_VersionConst);
            Invalid_Argument = new FT_Error(Invalid_ArgumentConst);
            Unimplemented_Feature = new FT_Error(Unimplemented_FeatureConst);
            Invalid_Table = new FT_Error(Invalid_TableConst);
            Invalid_Offset = new FT_Error(Invalid_OffsetConst);
            Array_Too_Large = new FT_Error(Array_Too_LargeConst);
            Missing_Module = new FT_Error(Missing_ModuleConst);
            Missing_Property = new FT_Error(Missing_PropertyConst);
            Invalid_Glyph_Index = new FT_Error(Invalid_Glyph_IndexConst);
            Invalid_Character_Code = new FT_Error(Invalid_Character_CodeConst);
            Invalid_Glyph_Format = new FT_Error(Invalid_Glyph_FormatConst);
            Cannot_Render_Glyph = new FT_Error(Cannot_Render_GlyphConst);
            Invalid_Outline = new FT_Error(Invalid_OutlineConst);
            Invalid_Composite = new FT_Error(Invalid_CompositeConst);
            Too_Many_Hints = new FT_Error(Too_Many_HintsConst);
            Invalid_Pixel_Size = new FT_Error(Invalid_Pixel_SizeConst);
            Invalid_Handle = new FT_Error(Invalid_HandleConst);
            Invalid_Library_Handle = new FT_Error(Invalid_Library_HandleConst);
            Invalid_Driver_Handle = new FT_Error(Invalid_Driver_HandleConst);
            Invalid_Face_Handle = new FT_Error(Invalid_Face_HandleConst);
            Invalid_Size_Handle = new FT_Error(Invalid_Size_HandleConst);
            Invalid_Slot_Handle = new FT_Error(Invalid_Slot_HandleConst);
            Invalid_CharMap_Handle = new FT_Error(Invalid_CharMap_HandleConst);
            Invalid_Cache_Handle = new FT_Error(Invalid_Cache_HandleConst);
            Invalid_Stream_Handle = new FT_Error(Invalid_Stream_HandleConst);
            Too_Many_Drivers = new FT_Error(Too_Many_DriversConst);
            Too_Many_Extensions = new FT_Error(Too_Many_ExtensionsConst);
            Out_Of_Memory = new FT_Error(Out_Of_MemoryConst);
            Unlisted_Object = new FT_Error(Unlisted_ObjectConst);
            Cannot_Open_Stream = new FT_Error(Cannot_Open_StreamConst);
            Invalid_Stream_Seek = new FT_Error(Invalid_Stream_SeekConst);
            Invalid_Stream_Skip = new FT_Error(Invalid_Stream_SkipConst);
            Invalid_Stream_Read = new FT_Error(Invalid_Stream_ReadConst);
            Invalid_Stream_Operation = new FT_Error(Invalid_Stream_OperationConst);
            Invalid_Frame_Operation = new FT_Error(Invalid_Frame_OperationConst);
            Nested_Frame_Access = new FT_Error(Nested_Frame_AccessConst);
            Invalid_Frame_Read = new FT_Error(Invalid_Frame_ReadConst);
            Raster_Uninitialized = new FT_Error(Raster_UninitializedConst);
            Raster_Corrupted = new FT_Error(Raster_CorruptedConst);
            Raster_Overflow = new FT_Error(Raster_OverflowConst);
            Raster_Negative_Height = new FT_Error(Raster_Negative_HeightConst);
            Too_Many_Caches = new FT_Error(Too_Many_CachesConst);
            Invalid_Opcode = new FT_Error(Invalid_OpcodeConst);
            Too_Few_Arguments = new FT_Error(Too_Few_ArgumentsConst);
            Stack_Overflow = new FT_Error(Stack_OverflowConst);
            Code_Overflow = new FT_Error(Code_OverflowConst);
            Bad_Argument = new FT_Error(Bad_ArgumentConst);
            Divide_By_Zero = new FT_Error(Divide_By_ZeroConst);
            Invalid_Reference = new FT_Error(Invalid_ReferenceConst);
            Debug_OpCode = new FT_Error(Debug_OpCodeConst);
            ENDF_In_Exec_Stream = new FT_Error(ENDF_In_Exec_StreamConst);
            Nested_DEFS = new FT_Error(Nested_DEFSConst);
            Invalid_CodeRange = new FT_Error(Invalid_CodeRangeConst);
            Execution_Too_Long = new FT_Error(Execution_Too_LongConst);
            Too_Many_Function_Defs = new FT_Error(Too_Many_Function_DefsConst);
            Too_Many_Instruction_Defs = new FT_Error(Too_Many_Instruction_DefsConst);
            Table_Missing = new FT_Error(Table_MissingConst);
            Horiz_Header_Missing = new FT_Error(Horiz_Header_MissingConst);
            Locations_Missing = new FT_Error(Locations_MissingConst);
            Name_Table_Missing = new FT_Error(Name_Table_MissingConst);
            CMap_Table_Missing = new FT_Error(CMap_Table_MissingConst);
            Hmtx_Table_Missing = new FT_Error(Hmtx_Table_MissingConst);
            Post_Table_Missing = new FT_Error(Post_Table_MissingConst);
            Invalid_Horiz_Metrics = new FT_Error(Invalid_Horiz_MetricsConst);
            Invalid_CharMap_Format = new FT_Error(Invalid_CharMap_FormatConst);
            Invalid_PPem = new FT_Error(Invalid_PPemConst);
            Invalid_Vert_Metrics = new FT_Error(Invalid_Vert_MetricsConst);
            Could_Not_Find_Context = new FT_Error(Could_Not_Find_ContextConst);
            Invalid_Post_Table_Format = new FT_Error(Invalid_Post_Table_FormatConst);
            Invalid_Post_Table = new FT_Error(Invalid_Post_TableConst);
            DEF_In_Glyf_Bytecode = new FT_Error(DEF_In_Glyf_BytecodeConst);
            Missing_Bitmap = new FT_Error(Missing_BitmapConst);
            Syntax_Error = new FT_Error(Syntax_ErrorConst);
            Stack_Underflow = new FT_Error(Stack_UnderflowConst);
            Ignore = new FT_Error(IgnoreConst);
            No_Unicode_Glyph_Name = new FT_Error(No_Unicode_Glyph_NameConst);
            Glyph_Too_Big = new FT_Error(Glyph_Too_BigConst);
            Missing_Startfont_Field = new FT_Error(Missing_Startfont_FieldConst);
            Missing_Font_Field = new FT_Error(Missing_Font_FieldConst);
            Missing_Size_Field = new FT_Error(Missing_Size_FieldConst);
            Missing_Fontboundingbox_Field = new FT_Error(Missing_Fontboundingbox_FieldConst);
            Missing_Chars_Field = new FT_Error(Missing_Chars_FieldConst);
            Missing_Startchar_Field = new FT_Error(Missing_Startchar_FieldConst);
            Missing_Encoding_Field = new FT_Error(Missing_Encoding_FieldConst);
            Missing_Bbx_Field = new FT_Error(Missing_Bbx_FieldConst);
            Bbx_Too_Big = new FT_Error(Bbx_Too_BigConst);
            Corrupted_Font_Header = new FT_Error(Corrupted_Font_HeaderConst);
            Corrupted_Font_Glyphs = new FT_Error(Corrupted_Font_GlyphsConst);

            ValueNames = new Dictionary<FT_Error, string>()
            {
                {Ok, "Ok"},
                {Cannot_Open_Resource, "Cannot_Open_Resource"},
                {Unknown_File_Format, "Unknown_File_Format"},
                {Invalid_File_Format, "Invalid_File_Format"},
                {Invalid_Version, "Invalid_Version"},
                {Lower_Module_Version, "Lower_Module_Version"},
                {Invalid_Argument, "Invalid_Argument"},
                {Unimplemented_Feature, "Unimplemented_Feature"},
                {Invalid_Table, "Invalid_Table"},
                {Invalid_Offset, "Invalid_Offset"},
                {Array_Too_Large, "Array_Too_Large"},
                {Missing_Module, "Missing_Module"},
                {Missing_Property, "Missing_Property"},
                {Invalid_Glyph_Index, "Invalid_Glyph_Index"},
                {Invalid_Character_Code, "Invalid_Character_Code"},
                {Invalid_Glyph_Format, "Invalid_Glyph_Format"},
                {Cannot_Render_Glyph, "Cannot_Render_Glyph"},
                {Invalid_Outline, "Invalid_Outline"},
                {Invalid_Composite, "Invalid_Composite"},
                {Too_Many_Hints, "Too_Many_Hints"},
                {Invalid_Pixel_Size, "Invalid_Pixel_Size"},
                {Invalid_Handle, "Invalid_Handle"},
                {Invalid_Library_Handle, "Invalid_Library_Handle"},
                {Invalid_Driver_Handle, "Invalid_Driver_Handle"},
                {Invalid_Face_Handle, "Invalid_Face_Handle"},
                {Invalid_Size_Handle, "Invalid_Size_Handle"},
                {Invalid_Slot_Handle, "Invalid_Slot_Handle"},
                {Invalid_CharMap_Handle, "Invalid_CharMap_Handle"},
                {Invalid_Cache_Handle, "Invalid_Cache_Handle"},
                {Invalid_Stream_Handle, "Invalid_Stream_Handle"},
                {Too_Many_Drivers, "Too_Many_Drivers"},
                {Too_Many_Extensions, "Too_Many_Extensions"},
                {Out_Of_Memory, "Out_Of_Memory"},
                {Unlisted_Object, "Unlisted_Object"},
                {Cannot_Open_Stream, "Cannot_Open_Stream"},
                {Invalid_Stream_Seek, "Invalid_Stream_Seek"},
                {Invalid_Stream_Skip, "Invalid_Stream_Skip"},
                {Invalid_Stream_Read, "Invalid_Stream_Read"},
                {Invalid_Stream_Operation, "Invalid_Stream_Operation"},
                {Invalid_Frame_Operation, "Invalid_Frame_Operation"},
                {Nested_Frame_Access, "Nested_Frame_Access"},
                {Invalid_Frame_Read, "Invalid_Frame_Read"},
                {Raster_Uninitialized, "Raster_Uninitialized"},
                {Raster_Corrupted, "Raster_Corrupted"},
                {Raster_Overflow, "Raster_Overflow"},
                {Raster_Negative_Height, "Raster_Negative_Height"},
                {Too_Many_Caches, "Too_Many_Caches"},
                {Invalid_Opcode, "Invalid_Opcode"},
                {Too_Few_Arguments, "Too_Few_Arguments"},
                {Stack_Overflow, "Stack_Overflow"},
                {Code_Overflow, "Code_Overflow"},
                {Bad_Argument, "Bad_Argument"},
                {Divide_By_Zero, "Divide_By_Zero"},
                {Invalid_Reference, "Invalid_Reference"},
                {Debug_OpCode, "Debug_OpCode"},
                {ENDF_In_Exec_Stream, "ENDF_In_Exec_Stream"},
                {Nested_DEFS, "Nested_DEFS"},
                {Invalid_CodeRange, "Invalid_CodeRange"},
                {Execution_Too_Long, "Execution_Too_Long"},
                {Too_Many_Function_Defs, "Too_Many_Function_Defs"},
                {Too_Many_Instruction_Defs, "Too_Many_Instruction_Defs"},
                {Table_Missing, "Table_Missing"},
                {Horiz_Header_Missing, "Horiz_Header_Missing"},
                {Locations_Missing, "Locations_Missing"},
                {Name_Table_Missing, "Name_Table_Missing"},
                {CMap_Table_Missing, "CMap_Table_Missing"},
                {Hmtx_Table_Missing, "Hmtx_Table_Missing"},
                {Post_Table_Missing, "Post_Table_Missing"},
                {Invalid_Horiz_Metrics, "Invalid_Horiz_Metrics"},
                {Invalid_CharMap_Format, "Invalid_CharMap_Format"},
                {Invalid_PPem, "Invalid_PPem"},
                {Invalid_Vert_Metrics, "Invalid_Vert_Metrics"},
                {Could_Not_Find_Context, "Could_Not_Find_Context"},
                {Invalid_Post_Table_Format, "Invalid_Post_Table_Format"},
                {Invalid_Post_Table, "Invalid_Post_Table"},
                {DEF_In_Glyf_Bytecode, "DEF_In_Glyf_Bytecode"},
                {Missing_Bitmap, "Missing_Bitmap"},
                {Syntax_Error, "Syntax_Error"},
                {Stack_Underflow, "Stack_Underflow"},
                {Ignore, "Ignore"},
                {No_Unicode_Glyph_Name, "No_Unicode_Glyph_Name"},
                {Glyph_Too_Big, "Glyph_Too_Big"},
                {Missing_Startfont_Field, "Missing_Startfont_Field"},
                {Missing_Font_Field, "Missing_Font_Field"},
                {Missing_Size_Field, "Missing_Size_Field"},
                {Missing_Fontboundingbox_Field, "Missing_Fontboundingbox_Field"},
                {Missing_Chars_Field, "Missing_Chars_Field"},
                {Missing_Startchar_Field, "Missing_Startchar_Field"},
                {Missing_Encoding_Field, "Missing_Encoding_Field"},
                {Missing_Bbx_Field, "Missing_Bbx_Field"},
                {Bbx_Too_Big, "Bbx_Too_Big"},
                {Corrupted_Font_Header, "Corrupted_Font_Header"},
                {Corrupted_Font_Glyphs, "Corrupted_Font_Glyphs"},
            };

            ValueStrings = new Dictionary<int, string>()
            {
                {0x00, "no error"},
                {0x01, "cannot open resource"},
                {0x02, "unknown file format"},
                {0x03, "broken file"},
                {0x04, "invalid FreeType version"},
                {0x05, "module version is too low"},
                {0x06, "invalid argument"},
                {0x07, "unimplemented feature"},
                {0x08, "broken table"},
                {0x09, "broken offset within table"},
                {0x0A, "array allocation size too large"},
                {0x0B, "missing module"},
                {0x0C, "missing property"},
                {0x10, "invalid glyph index"},
                {0x11, "invalid character code"},
                {0x12, "unsupported glyph image format"},
                {0x13, "cannot render this glyph format"},
                {0x14, "invalid outline"},
                {0x15, "invalid composite glyph"},
                {0x16, "too many hints"},
                {0x17, "invalid pixel size"},
                {0x20, "invalid object handle"},
                {0x21, "invalid library handle"},
                {0x22, "invalid module handle"},
                {0x23, "invalid face handle"},
                {0x24, "invalid size handle"},
                {0x25, "invalid glyph slot handle"},
                {0x26, "invalid charmap handle"},
                {0x27, "invalid cache manager handle"},
                {0x28, "invalid stream handle"},
                {0x30, "too many modules"},
                {0x31, "too many extensions"},
                {0x40, "out of memory"},
                {0x41, "unlisted object"},
                {0x51, "cannot open stream"},
                {0x52, "invalid stream seek"},
                {0x53, "invalid stream skip"},
                {0x54, "invalid stream read"},
                {0x55, "invalid stream operation"},
                {0x56, "invalid frame operation"},
                {0x57, "nested frame access"},
                {0x58, "invalid frame read"},
                {0x60, "raster uninitialized"},
                {0x61, "raster corrupted"},
                {0x62, "raster overflow"},
                {0x63, "negative height while rastering"},
                {0x70, "too many registered caches"},
                {0x80, "invalid opcode"},
                {0x81, "too few arguments"},
                {0x82, "stack overflow"},
                {0x83, "code overflow"},
                {0x84, "bad argument"},
                {0x85, "division by zero"},
                {0x86, "invalid reference"},
                {0x87, "found debug opcode"},
                {0x88, "found ENDF opcode in execution stream"},
                {0x89, "nested DEFS"},
                {0x8A, "invalid code range"},
                {0x8B, "execution context too long"},
                {0x8C, "too many function definitions"},
                {0x8D, "too many instruction definitions"},
                {0x8E, "SFNT font table missing"},
                {0x8F, "horizontal header (hhea table missing"},
                {0x90, "locations (loca table missing"},
                {0x91, "name table missing"},
                {0x92, "character map (cmap table missing"},
                {0x93, "horizontal metrics (hmtx table missing"},
                {0x94, "PostScript (post table missing"},
                {0x95, "invalid horizontal metrics"},
                {0x96, "invalid character map (cmap format"},
                {0x97, "invalid ppem value"},
                {0x98, "invalid vertical metrics"},
                {0x99, "could not find context"},
                {0x9A, "invalid PostScript (post table format"},
                {0x9B, "invalid PostScript (post table"},
                {0x9C, "found FDEF or IDEF opcode in glyf bytecode"},
                {0x9D, "missing bitmap in strike"},
                {0xA0, "opcode syntax error"},
                {0xA1, "argument stack underflow"},
                {0xA2, "ignore"},
                {0xA3, "no Unicode glyph name found"},
                {0xA4, "glyph too big for hinting"},
                {0xB0, "`STARTFONT` field missing"},
                {0xB1, "`FONT` field missing"},
                {0xB2, "`SIZE` field missing"},
                {0xB3, "`FONTBOUNDINGBOX` field missing"},
                {0xB4, "`CHARS` field missing"},
                {0xB5, "`STARTCHAR` field missing"},
                {0xB6, "`ENCODING` field missing"},
                {0xB7, "`BBX` field missing"},
                {0xB8, "`BBX` too big"},
                {0xB9, "Font header corrupted or missing fields"},
                {0xBA, "Font glyphs corrupted or missing fields"},
            };

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public FT_Error(int value) { _value = value; }

        private readonly int _value;

        public int Value { [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] get { return _value; } }

        public static readonly Dictionary<FT_Error, string> ValueNames;

        public static readonly Dictionary<int, string> ValueStrings;

        public static readonly FT_Error Ok;
        public const int OkConst = 0x00;

        public static readonly FT_Error Cannot_Open_Resource;
        public const int Cannot_Open_ResourceConst = 0x01;

        public static readonly FT_Error Unknown_File_Format;
        public const int Unknown_File_FormatConst = 0x02;

        public static readonly FT_Error Invalid_File_Format;
        public const int Invalid_File_FormatConst = 0x03;

        public static readonly FT_Error Invalid_Version;
        public const int Invalid_VersionConst = 0x04;

        public static readonly FT_Error Lower_Module_Version;
        public const int Lower_Module_VersionConst = 0x05;

        public static readonly FT_Error Invalid_Argument;
        public const int Invalid_ArgumentConst = 0x06;

        public static readonly FT_Error Unimplemented_Feature;
        public const int Unimplemented_FeatureConst = 0x07;

        public static readonly FT_Error Invalid_Table;
        public const int Invalid_TableConst = 0x08;

        public static readonly FT_Error Invalid_Offset;
        public const int Invalid_OffsetConst = 0x09;

        public static readonly FT_Error Array_Too_Large;
        public const int Array_Too_LargeConst = 0x0A;

        public static readonly FT_Error Missing_Module;
        public const int Missing_ModuleConst = 0x0B;

        public static readonly FT_Error Missing_Property;
        public const int Missing_PropertyConst = 0x0C;

        public static readonly FT_Error Invalid_Glyph_Index;
        public const int Invalid_Glyph_IndexConst = 0x10;

        public static readonly FT_Error Invalid_Character_Code;
        public const int Invalid_Character_CodeConst = 0x11;

        public static readonly FT_Error Invalid_Glyph_Format;
        public const int Invalid_Glyph_FormatConst = 0x12;

        public static readonly FT_Error Cannot_Render_Glyph;
        public const int Cannot_Render_GlyphConst = 0x13;

        public static readonly FT_Error Invalid_Outline;
        public const int Invalid_OutlineConst = 0x14;

        public static readonly FT_Error Invalid_Composite;
        public const int Invalid_CompositeConst = 0x15;

        public static readonly FT_Error Too_Many_Hints;
        public const int Too_Many_HintsConst = 0x16;

        public static readonly FT_Error Invalid_Pixel_Size;
        public const int Invalid_Pixel_SizeConst = 0x17;

        public static readonly FT_Error Invalid_Handle;
        public const int Invalid_HandleConst = 0x20;

        public static readonly FT_Error Invalid_Library_Handle;
        public const int Invalid_Library_HandleConst = 0x21;

        public static readonly FT_Error Invalid_Driver_Handle;
        public const int Invalid_Driver_HandleConst = 0x22;

        public static readonly FT_Error Invalid_Face_Handle;
        public const int Invalid_Face_HandleConst = 0x23;

        public static readonly FT_Error Invalid_Size_Handle;
        public const int Invalid_Size_HandleConst = 0x24;

        public static readonly FT_Error Invalid_Slot_Handle;
        public const int Invalid_Slot_HandleConst = 0x25;

        public static readonly FT_Error Invalid_CharMap_Handle;
        public const int Invalid_CharMap_HandleConst = 0x26;

        public static readonly FT_Error Invalid_Cache_Handle;
        public const int Invalid_Cache_HandleConst = 0x27;

        public static readonly FT_Error Invalid_Stream_Handle;
        public const int Invalid_Stream_HandleConst = 0x28;

        public static readonly FT_Error Too_Many_Drivers;
        public const int Too_Many_DriversConst = 0x30;

        public static readonly FT_Error Too_Many_Extensions;
        public const int Too_Many_ExtensionsConst = 0x31;

        public static readonly FT_Error Out_Of_Memory;
        public const int Out_Of_MemoryConst = 0x40;

        public static readonly FT_Error Unlisted_Object;
        public const int Unlisted_ObjectConst = 0x41;

        public static readonly FT_Error Cannot_Open_Stream;
        public const int Cannot_Open_StreamConst = 0x51;

        public static readonly FT_Error Invalid_Stream_Seek;
        public const int Invalid_Stream_SeekConst = 0x52;

        public static readonly FT_Error Invalid_Stream_Skip;
        public const int Invalid_Stream_SkipConst = 0x53;

        public static readonly FT_Error Invalid_Stream_Read;
        public const int Invalid_Stream_ReadConst = 0x54;

        public static readonly FT_Error Invalid_Stream_Operation;
        public const int Invalid_Stream_OperationConst = 0x55;

        public static readonly FT_Error Invalid_Frame_Operation;
        public const int Invalid_Frame_OperationConst = 0x56;

        public static readonly FT_Error Nested_Frame_Access;
        public const int Nested_Frame_AccessConst = 0x57;

        public static readonly FT_Error Invalid_Frame_Read;
        public const int Invalid_Frame_ReadConst = 0x58;

        public static readonly FT_Error Raster_Uninitialized;
        public const int Raster_UninitializedConst = 0x60;

        public static readonly FT_Error Raster_Corrupted;
        public const int Raster_CorruptedConst = 0x61;

        public static readonly FT_Error Raster_Overflow;
        public const int Raster_OverflowConst = 0x62;

        public static readonly FT_Error Raster_Negative_Height;
        public const int Raster_Negative_HeightConst = 0x63;

        public static readonly FT_Error Too_Many_Caches;
        public const int Too_Many_CachesConst = 0x70;

        public static readonly FT_Error Invalid_Opcode;
        public const int Invalid_OpcodeConst = 0x80;

        public static readonly FT_Error Too_Few_Arguments;
        public const int Too_Few_ArgumentsConst = 0x81;

        public static readonly FT_Error Stack_Overflow;
        public const int Stack_OverflowConst = 0x82;

        public static readonly FT_Error Code_Overflow;
        public const int Code_OverflowConst = 0x83;

        public static readonly FT_Error Bad_Argument;
        public const int Bad_ArgumentConst = 0x84;

        public static readonly FT_Error Divide_By_Zero;
        public const int Divide_By_ZeroConst = 0x85;

        public static readonly FT_Error Invalid_Reference;
        public const int Invalid_ReferenceConst = 0x86;

        public static readonly FT_Error Debug_OpCode;
        public const int Debug_OpCodeConst = 0x87;

        public static readonly FT_Error ENDF_In_Exec_Stream;
        public const int ENDF_In_Exec_StreamConst = 0x88;

        public static readonly FT_Error Nested_DEFS;
        public const int Nested_DEFSConst = 0x89;

        public static readonly FT_Error Invalid_CodeRange;
        public const int Invalid_CodeRangeConst = 0x8A;

        public static readonly FT_Error Execution_Too_Long;
        public const int Execution_Too_LongConst = 0x8B;

        public static readonly FT_Error Too_Many_Function_Defs;
        public const int Too_Many_Function_DefsConst = 0x8C;

        public static readonly FT_Error Too_Many_Instruction_Defs;
        public const int Too_Many_Instruction_DefsConst = 0x8D;

        public static readonly FT_Error Table_Missing;
        public const int Table_MissingConst = 0x8E;

        public static readonly FT_Error Horiz_Header_Missing;
        public const int Horiz_Header_MissingConst = 0x8F;

        public static readonly FT_Error Locations_Missing;
        public const int Locations_MissingConst = 0x90;

        public static readonly FT_Error Name_Table_Missing;
        public const int Name_Table_MissingConst = 0x91;

        public static readonly FT_Error CMap_Table_Missing;
        public const int CMap_Table_MissingConst = 0x92;

        public static readonly FT_Error Hmtx_Table_Missing;
        public const int Hmtx_Table_MissingConst = 0x93;

        public static readonly FT_Error Post_Table_Missing;
        public const int Post_Table_MissingConst = 0x94;

        public static readonly FT_Error Invalid_Horiz_Metrics;
        public const int Invalid_Horiz_MetricsConst = 0x95;

        public static readonly FT_Error Invalid_CharMap_Format;
        public const int Invalid_CharMap_FormatConst = 0x96;

        public static readonly FT_Error Invalid_PPem;
        public const int Invalid_PPemConst = 0x97;

        public static readonly FT_Error Invalid_Vert_Metrics;
        public const int Invalid_Vert_MetricsConst = 0x98;

        public static readonly FT_Error Could_Not_Find_Context;
        public const int Could_Not_Find_ContextConst = 0x99;

        public static readonly FT_Error Invalid_Post_Table_Format;
        public const int Invalid_Post_Table_FormatConst = 0x9A;

        public static readonly FT_Error Invalid_Post_Table;
        public const int Invalid_Post_TableConst = 0x9B;

        public static readonly FT_Error DEF_In_Glyf_Bytecode;
        public const int DEF_In_Glyf_BytecodeConst = 0x9C;

        public static readonly FT_Error Missing_Bitmap;
        public const int Missing_BitmapConst = 0x9D;

        public static readonly FT_Error Syntax_Error;
        public const int Syntax_ErrorConst = 0xA0;

        public static readonly FT_Error Stack_Underflow;
        public const int Stack_UnderflowConst = 0xA1;

        public static readonly FT_Error Ignore;
        public const int IgnoreConst = 0xA2;

        public static readonly FT_Error No_Unicode_Glyph_Name;
        public const int No_Unicode_Glyph_NameConst = 0xA3;

        public static readonly FT_Error Glyph_Too_Big;
        public const int Glyph_Too_BigConst = 0xA4;

        public static readonly FT_Error Missing_Startfont_Field;
        public const int Missing_Startfont_FieldConst = 0xB0;

        public static readonly FT_Error Missing_Font_Field;
        public const int Missing_Font_FieldConst = 0xB1;

        public static readonly FT_Error Missing_Size_Field;
        public const int Missing_Size_FieldConst = 0xB2;

        public static readonly FT_Error Missing_Fontboundingbox_Field;
        public const int Missing_Fontboundingbox_FieldConst = 0xB3;

        public static readonly FT_Error Missing_Chars_Field;
        public const int Missing_Chars_FieldConst = 0xB4;

        public static readonly FT_Error Missing_Startchar_Field;
        public const int Missing_Startchar_FieldConst = 0xB5;

        public static readonly FT_Error Missing_Encoding_Field;
        public const int Missing_Encoding_FieldConst = 0xB6;

        public static readonly FT_Error Missing_Bbx_Field;
        public const int Missing_Bbx_FieldConst = 0xB7;

        public static readonly FT_Error Bbx_Too_Big;
        public const int Bbx_Too_BigConst = 0xB8;

        public static readonly FT_Error Corrupted_Font_Header;
        public const int Corrupted_Font_HeaderConst = 0xB9;

        public static readonly FT_Error Corrupted_Font_Glyphs;
        public const int Corrupted_Font_GlyphsConst = 0xBA;

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator int(in FT_Error ft_error)
        {
            return ft_error.Value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator FT_Error(int value)
        {
            return new FT_Error(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static string GetName(in FT_Error ft_error)
        {
            return ValueNames[ft_error];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static FT_Error operator ~(in FT_Error left) { return (FT_Error)(~left.Value); }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static FT_Error operator <<(in FT_Error left, int right) { return (FT_Error)(left.Value << right); }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static FT_Error operator >>(in FT_Error left, int right) { return (FT_Error)(left.Value >> right); }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static FT_Error operator ^(in FT_Error left, in FT_Error right) { return (FT_Error)(left.Value ^ right.Value); }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static FT_Error operator &(in FT_Error left, in FT_Error right) { return (FT_Error)(left.Value & right.Value); }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static FT_Error operator |(in FT_Error left, in FT_Error right) { return (FT_Error)(left.Value | right.Value); }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(FT_Error other) { return Value == other.Value; }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override bool Equals(object? obj) { return obj is FT_Error other && Equals(other); }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override int GetHashCode() { return Value.GetHashCode(); }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in FT_Error left, in FT_Error right) { return Equals(left, right); }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in FT_Error left, int right) { return left.Value == right; }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(int left, in FT_Error right) { return left == right.Value; }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in FT_Error left, in FT_Error right) { return !Equals(left, right); }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in FT_Error left, int right) { return left.Value != right; }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(int left, in FT_Error right) { return left != right.Value; }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override string? ToString()
        {
            return ValueNames[this] + ":" + ValueStrings[Value];
        }

    }

}
