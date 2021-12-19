using System.Runtime.InteropServices;
using Vulkan;

namespace FreeType;

public static partial class Api
{
    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// A C~string or `NULL`, if any error occurred.</returns>
    ///// <remarks>
    ///// :FT_Error_String@description :
    ///// Retrieve the description of a valid FreeType error code.@input :
    ///// error_code ::
    ///// A valid FreeType error code.@note :
    ///// FreeType has to be compiled with `FT_CONFIG_OPTION_ERROR_STRINGS` or
    ///// `FT_DEBUG_LEVEL_ERROR` to get meaningful descriptions.
    ///// 'error_string' will be `NULL` otherwise.Module identification will be ignored:```c
    ///// strcmp( FT_Error_String(  FT_Err_Unknown_File_Format ),
    ///// FT_Error_String( BDF_Err_Unknown_File_Format ) ) == 0;
    ///// ```
    ///// </remarks>

    //public static unsafe delegate* <FT_Error,nint> FT_Error_String = (delegate* <FT_Error,nint>)NativeLibrary.GetExport(Handle, "FT_Error_String");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Init_FreeType@description :
    ///// Initialize a new FreeType library object.  The set of modules that are
    ///// registered by this function is determined at build time.@output :
    ///// alibrary ::
    ///// A handle to a new library object.@note :
    ///// In case you want to provide your own memory allocating routines, use
    ///// @FT _New_Library instead, followed by a call to @FT _Add_Default_Modules
    ///// (or a series of calls to @FT _Add_Module) and
    ///// @FT _Set_Default_Properties.See the documentation of @FT _Library and @FT _Face for multi-threading
    ///// issues.If you need reference-counting (cf. @FT _Reference_Library), use
    ///// @FT _New_Library and @FT _Done_Library.If compilation option `FT_CONFIG_OPTION_ENVIRONMENT_PROPERTIES` is
    ///// set, this function reads the `FREETYPE_PROPERTIES` environment
    ///// variable to control driver properties.  See section @properties for
    ///// more.
    ///// </remarks>

    //public static unsafe delegate* <ref FT_Library,FT_Error> FT_Init_FreeType = (delegate* <ref FT_Library,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Init_FreeType");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Done_FreeType@description :
    ///// Destroy a given FreeType library object and all of its children,
    ///// including resources, drivers, faces, sizes, etc.@input :
    ///// library ::
    ///// A handle to the target library object.
    ///// </remarks>

    //public static unsafe delegate* <FT_Library,FT_Error> FT_Done_FreeType = (delegate* <FT_Library,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Done_FreeType");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_New_Face@description :
    ///// Call @FT _Open_Face to open a font by its pathname.@inout :
    ///// library ::
    ///// A handle to the library resource.@input :
    ///// pathname ::
    ///// A path to the font file.face_index ::
    ///// See @FT _Open_Face for a detailed description of this parameter.@output :
    ///// aface ::
    ///// A handle to a new face object.  If `face_index` is greater than or
    ///// equal to zero, it must be non-`NULL`.@note :
    ///// The `pathname` string should be recognizable as such by a standard
    ///// `fopen` call on your system; in particular, this means that `pathname`
    ///// must not contain null bytes.  If that is not sufficient to address all
    ///// file name possibilities (for example, to handle wide character file
    ///// names on Windows in UTF-16 encoding) you might use @FT _Open_Face to
    ///// pass a memory array or a stream object instead.Use @FT _Done_Face to destroy the created @FT _Face object (along with
    ///// its slot and sizes).
    ///// </remarks>

    //public static unsafe delegate* <FT_Library,nint,CLong,ref FT_Face,FT_Error> FT_New_Face = (delegate* <FT_Library,nint,CLong,ref FT_Face,FT_Error>)NativeLibrary.GetExport(Handle, "FT_New_Face");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_New_Memory_Face@description :
    ///// Call @FT _Open_Face to open a font that has been loaded into memory.@inout :
    ///// library ::
    ///// A handle to the library resource.@input :
    ///// file_base ::
    ///// A pointer to the beginning of the font data.file_size ::
    ///// The size of the memory chunk used by the font data.face_index ::
    ///// See @FT _Open_Face for a detailed description of this parameter.@output :
    ///// aface ::
    ///// A handle to a new face object.  If `face_index` is greater than or
    ///// equal to zero, it must be non-`NULL`.@note :
    ///// You must not deallocate the memory before calling @FT _Done_Face.
    ///// </remarks>

    //public static unsafe delegate* <FT_Library,ref byte,CLong,CLong,ref FT_Face,FT_Error> FT_New_Memory_Face = (delegate* <FT_Library,ref byte,CLong,CLong,ref FT_Face,FT_Error>)NativeLibrary.GetExport(Handle, "FT_New_Memory_Face");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Open_Face@description :
    ///// Create a face object from a given resource described by @FT _Open_Args.@inout :
    ///// library ::
    ///// A handle to the library resource.@input :
    ///// args ::
    ///// A pointer to an `FT_Open_Args` structure that must be filled by the
    ///// caller.face_index ::
    ///// This field holds two different values.  Bits 0-15 are the index of
    ///// the face in the font file (starting with value~0).  Set it to~0 if
    ///// there is only one face in the font file.[Since 2.6.1] Bits 16-30 are relevant to GX and OpenType variation
    ///// fonts only, specifying the named instance index for the current face
    ///// index (starting with value~1; value~0 makes FreeType ignore named
    ///// instances).  For non-variation fonts, bits 16-30 are ignored.
    ///// Assuming that you want to access the third named instance in face~4,
    ///// `face_index` should be set to 0x00030004.  If you want to access
    ///// face~4 without variation handling, simply set `face_index` to
    ///// value~4.`FT_Open_Face` and its siblings can be used to quickly check whether
    ///// the font format of a given font resource is supported by FreeType.
    ///// In general, if the `face_index` argument is negative, the function's
    ///// return value is~0 if the font format is recognized, or non-zero
    ///// otherwise.  The function allocates a more or less empty face handle
    ///// in `*aface` (if `aface` isn't `NULL`); the only two useful fields in
    ///// this special case are `face-&gt;num_faces` and `face-&gt;style_flags`.
    ///// For any negative value of `face_index`, `face-&gt;num_faces` gives the
    ///// number of faces within the font file.  For the negative value
    ///// '-(N+1)' (with 'N' a non-negative 16-bit value), bits 16-30 in
    ///// `face-&gt;style_flags` give the number of named instances in face 'N'
    ///// if we have a variation font (or zero otherwise).  After examination,
    ///// the returned @FT _Face structure should be deallocated with a call to
    ///// @FT _Done_Face.@output :
    ///// aface ::
    ///// A handle to a new face object.  If `face_index` is greater than or
    ///// equal to zero, it must be non-`NULL`.@note :
    ///// Unlike FreeType 1.x, this function automatically creates a glyph slot
    ///// for the face object that can be accessed directly through
    ///// `face-&gt;glyph`.Each new face object created with this function also owns a default
    ///// @FT _Size object, accessible as `face-&gt;size`.One @FT _Library instance can have multiple face objects, this is,
    ///// @FT _Open_Face and its siblings can be called multiple times using the
    ///// same `library` argument.See the discussion of reference counters in the description of
    ///// @FT _Reference_Face.If `FT_OPEN_STREAM` is set in `args-&gt;flags`, the stream in
    ///// `args-&gt;stream` is automatically closed before this function returns
    ///// any error (including `FT_Err_Invalid_Argument`).@example :
    ///// To loop over all faces, use code similar to the following snippet
    ///// (omitting the error handling).```
    ///// ...
    ///// FT_Face  face;
    ///// CLong  i, num_faces;error = FT_Open_Face( library, args, -1, 
    ///// &amp;face
    ///// );
    ///// if ( error ) { ... }num_faces = face-&gt;num_faces;
    ///// FT_Done_Face( face );for ( i = 0; i 
    ///// &lt;
    ///// num_faces; i++ )
    ///// {
    ///// ...
    ///// error = FT_Open_Face( library, args, i, 
    ///// &amp;face
    ///// );
    ///// ...
    ///// FT_Done_Face( face );
    ///// ...
    ///// }
    ///// ```To loop over all valid values for `face_index`, use something similar
    ///// to the following snippet, again without error handling.  The code
    ///// accesses all faces immediately (thus only a single call of
    ///// `FT_Open_Face` within the do-loop), with and without named instances.```
    ///// ...
    ///// FT_Face  face;CLong  num_faces     = 0;
    ///// CLong  num_instances = 0;CLong  face_idx     = 0;
    ///// CLong  instance_idx = 0;do
    ///// {
    ///// CLong  id = ( instance_idx 
    ///// &lt;
    ///// &lt;
    ///// 16 ) + face_idx;error = FT_Open_Face( library, args, id, 
    ///// &amp;face
    ///// );
    ///// if ( error ) { ... }num_faces     = face-&gt;num_faces;
    ///// num_instances = face-&gt;style_flags &gt;&gt; 16;...FT_Done_Face( face );if ( instance_idx 
    ///// &lt;
    ///// num_instances )
    ///// instance_idx++;
    ///// else
    ///// {
    ///// face_idx++;
    ///// instance_idx = 0;
    ///// }} while ( face_idx 
    ///// &lt;
    ///// num_faces )
    ///// ```
    ///// </remarks>

    //public static unsafe delegate* <FT_Library,ref FT_Open_Args,CLong,ref FT_Face,FT_Error> FT_Open_Face = (delegate* <FT_Library,ref FT_Open_Args,CLong,ref FT_Face,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Open_Face");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Attach_File@description :
    ///// Call @FT _Attach_Stream to attach a file.@inout :
    ///// face ::
    ///// The target face object.@input :
    ///// filepathname ::
    ///// The pathname.
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,nint,FT_Error> FT_Attach_File = (delegate* <FT_Face,nint,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Attach_File");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Attach_Stream@description :
    ///// 'Attach' data to a face object.  Normally, this is used to read
    ///// additional information for the face object.  For example, you can
    ///// attach an AFM file that comes with a Type~1 font to get the kerning
    ///// values and other metrics.@inout :
    ///// face ::
    ///// The target face object.@input :
    ///// parameters ::
    ///// A pointer to @FT _Open_Args that must be filled by the caller.@note :
    ///// The meaning of the 'attach' (i.e., what really happens when the new
    ///// file is read) is not fixed by FreeType itself.  It really depends on
    ///// the font format (and thus the font driver).Client applications are expected to know what they are doing when
    ///// invoking this function.  Most drivers simply do not implement file or
    ///// stream attachments.
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,ref FT_Open_Args,FT_Error> FT_Attach_Stream = (delegate* <FT_Face,ref FT_Open_Args,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Attach_Stream");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Reference_Face@description :
    ///// A counter gets initialized to~1 at the time an @FT _Face structure is
    ///// created.  This function increments the counter.  @FT _Done_Face then
    ///// only destroys a face if the counter is~1, otherwise it simply
    ///// decrements the counter.This function helps in managing life-cycles of structures that
    ///// reference @FT _Face objects.@input :
    ///// face ::
    ///// A handle to a target face object.@since :
    ///// 2.4.2
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,FT_Error> FT_Reference_Face = (delegate* <FT_Face,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Reference_Face");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Done_Face@description :
    ///// Discard a given face object, as well as all of its child slots and
    ///// sizes.@input :
    ///// face ::
    ///// A handle to a target face object.@note :
    ///// See the discussion of reference counters in the description of
    ///// @FT _Reference_Face.
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,FT_Error> FT_Done_Face = (delegate* <FT_Face,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Done_Face");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Select_Size@description :
    ///// Select a bitmap strike.  To be more precise, this function sets the
    ///// scaling factors of the active @FT _Size object in a face so that
    ///// bitmaps from this particular strike are taken by @FT _Load_Glyph and
    ///// friends.@inout :
    ///// face ::
    ///// A handle to a target face object.@input :
    ///// strike_index ::
    ///// The index of the bitmap strike in the `available_sizes` field of
    ///// @FT _FaceRec structure.@note :
    ///// For bitmaps embedded in outline fonts it is common that only a subset
    ///// of the available glyphs at a given ppem value is available.  FreeType
    ///// silently uses outlines if there is no bitmap for a given glyph index.For GX and OpenType variation fonts, a bitmap strike makes sense only
    ///// if the default instance is active (this is, no glyph variation takes
    ///// place); otherwise, FreeType simply ignores bitmap strikes.  The same
    ///// is true for all named instances that are different from the default
    ///// instance.Don't use this function if you are using the FreeType cache API.
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,int,FT_Error> FT_Select_Size = (delegate* <FT_Face,int,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Select_Size");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Request_Size@description :
    ///// Resize the scale of the active @FT _Size object in a face.@inout :
    ///// face ::
    ///// A handle to a target face object.@input :
    ///// req ::
    ///// A pointer to a @FT _Size_RequestRec.@note :
    ///// Although drivers may select the bitmap strike matching the request,
    ///// you should not rely on this if you intend to select a particular
    ///// bitmap strike.  Use @FT _Select_Size instead in that case.The relation between the requested size and the resulting glyph size
    ///// is dependent entirely on how the size is defined in the source face.
    ///// The font designer chooses the final size of each glyph relative to
    ///// this size.  For more information refer to
    ///// 'https://www.freetype.org/freetype2/docs/glyphs/glyphs-2.html'.Contrary to @FT _Set_Char_Size, this function doesn't have special code
    ///// to normalize zero-valued widths, heights, or resolutions (which lead
    ///// to errors in most cases).Don't use this function if you are using the FreeType cache API.
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,FT_Size_Request,FT_Error> FT_Request_Size = (delegate* <FT_Face,FT_Size_Request,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Request_Size");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Set_Char_Size@description :
    ///// Call @FT _Request_Size to request the nominal size (in points).@inout :
    ///// face ::
    ///// A handle to a target face object.@input :
    ///// char_width ::
    ///// The nominal width, in 26.6 fractional points.char_height ::
    ///// The nominal height, in 26.6 fractional points.horz_resolution ::
    ///// The horizontal resolution in dpi.vert_resolution ::
    ///// The vertical resolution in dpi.@note :
    ///// While this function allows fractional points as input values, the
    ///// resulting ppem value for the given resolution is always rounded to the
    ///// nearest integer.If either the character width or height is zero, it is set equal to
    ///// the other value.If either the horizontal or vertical resolution is zero, it is set
    ///// equal to the other value.A character width or height smaller than 1pt is set to 1pt; if both
    ///// resolution values are zero, they are set to 72dpi.Don't use this function if you are using the FreeType cache API.
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,FT_F26Dot6,FT_F26Dot6,uint,uint,FT_Error> FT_Set_Char_Size = (delegate* <FT_Face,FT_F26Dot6,FT_F26Dot6,uint,uint,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Set_Char_Size");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Set_Pixel_Sizes@description :
    ///// Call @FT _Request_Size to request the nominal size (in pixels).@inout :
    ///// face ::
    ///// A handle to the target face object.@input :
    ///// pixel_width ::
    ///// The nominal width, in pixels.pixel_height ::
    ///// The nominal height, in pixels.@note :
    ///// You should not rely on the resulting glyphs matching or being
    ///// constrained to this pixel size.  Refer to @FT _Request_Size to
    ///// understand how requested sizes relate to actual sizes.Don't use this function if you are using the FreeType cache API.
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,uint,uint,FT_Error> FT_Set_Pixel_Sizes = (delegate* <FT_Face,uint,uint,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Set_Pixel_Sizes");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Load_Glyph@description :
    ///// Load a glyph into the glyph slot of a face object.@inout :
    ///// face ::
    ///// A handle to the target face object where the glyph is loaded.@input :
    ///// glyph_index ::
    ///// The index of the glyph in the font file.  For CID-keyed fonts
    ///// (either in PS or in CFF format) this argument specifies the CID
    ///// value.load_flags ::
    ///// A flag indicating what to load for this glyph.  The @FT _LOAD_XXX
    ///// constants can be used to control the glyph loading process (e.g.,
    ///// whether the outline should be scaled, whether to load bitmaps or
    ///// not, whether to hint the outline, etc).@note :
    ///// The loaded glyph may be transformed.  See @FT _Set_Transform for the
    ///// details.For subsetted CID-keyed fonts, `FT_Err_Invalid_Argument` is returned
    ///// for invalid CID values (this is, for CID values that don't have a
    ///// corresponding glyph in the font).  See the discussion of the
    ///// @FT _FACE_FLAG_CID_KEYED flag for more details.If you receive `FT_Err_Glyph_Too_Big`, try getting the glyph outline
    ///// at EM size, then scale it manually and fill it as a graphics
    ///// operation.
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,uint,int,FT_Error> FT_Load_Glyph = (delegate* <FT_Face,uint,int,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Load_Glyph");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Load_Char@description :
    ///// Load a glyph into the glyph slot of a face object, accessed by its
    ///// character code.@inout :
    ///// face ::
    ///// A handle to a target face object where the glyph is loaded.@input :
    ///// char_code ::
    ///// The glyph's character code, according to the current charmap used in
    ///// the face.load_flags ::
    ///// A flag indicating what to load for this glyph.  The @FT _LOAD_XXX
    ///// constants can be used to control the glyph loading process (e.g.,
    ///// whether the outline should be scaled, whether to load bitmaps or
    ///// not, whether to hint the outline, etc).@note :
    ///// This function simply calls @FT _Get_Char_Index and @FT _Load_Glyph.Many fonts contain glyphs that can't be loaded by this function since
    ///// its glyph indices are not listed in any of the font's charmaps.If no active cmap is set up (i.e., `face-&gt;charmap` is zero), the call
    ///// to @FT _Get_Char_Index is omitted, and the function behaves identically
    ///// to @FT _Load_Glyph.
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,CULong,int,FT_Error> FT_Load_Char = (delegate* <FT_Face,CULong,int,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Load_Char");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <remarks>
    ///// :FT_Set_Transform@description :
    ///// Set the transformation that is applied to glyph images when they are
    ///// loaded into a glyph slot through @FT _Load_Glyph.@inout :
    ///// face ::
    ///// A handle to the source face object.@input :
    ///// matrix ::
    ///// A pointer to the transformation's 2x2 matrix.  Use `NULL` for the
    ///// identity matrix.
    ///// delta ::
    ///// A pointer to the translation vector.  Use `NULL` for the null
    ///// vector.@note :
    ///// This function is provided as a convenience, but keep in mind that
    ///// @FT _Matrix coefficients are only 16.16 fixed-point values, which can
    ///// limit the accuracy of the results.  Using floating-point computations
    ///// to perform the transform directly in client code instead will always
    ///// yield better numbers.The transformation is only applied to scalable image formats after the
    ///// glyph has been loaded.  It means that hinting is unaltered by the
    ///// transformation and is performed on the character size given in the
    ///// last call to @FT _Set_Char_Size or @FT _Set_Pixel_Sizes.Note that this also transforms the `face.glyph.advance` field, but
    ///// **not** the values in `face.glyph.metrics`.
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,ref FT_Matrix,ref FT_Vector,void> FT_Set_Transform = (delegate* <FT_Face,ref FT_Matrix,ref FT_Vector,void>)NativeLibrary.GetExport(Handle, "FT_Set_Transform");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <remarks>
    ///// :FT_Get_Transform@description :
    ///// Return the transformation that is applied to glyph images when they
    ///// are loaded into a glyph slot through @FT _Load_Glyph.  See
    ///// @FT _Set_Transform for more details.@input :
    ///// face ::
    ///// A handle to the source face object.@output :
    ///// matrix ::
    ///// A pointer to a transformation's 2x2 matrix.  Set this to NULL if you
    ///// are not interested in the value.delta ::
    ///// A pointer a translation vector.  Set this to NULL if you are not
    ///// interested in the value.@since :
    ///// 2.11
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,ref FT_Matrix,ref FT_Vector,void> FT_Get_Transform = (delegate* <FT_Face,ref FT_Matrix,ref FT_Vector,void>)NativeLibrary.GetExport(Handle, "FT_Get_Transform");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Render_Glyph@description :
    ///// Convert a given glyph image to a bitmap.  It does so by inspecting the
    ///// glyph image format, finding the relevant renderer, and invoking it.@inout :
    ///// slot ::
    ///// A handle to the glyph slot containing the image to convert.@input :
    ///// render_mode ::
    ///// The render mode used to render the glyph image into a bitmap.  See
    ///// @FT _Render_Mode for a list of possible values.If @FT _RENDER_MODE_NORMAL is used, a previous call of @FT _Load_Glyph
    ///// with flag @FT _LOAD_COLOR makes FT_Render_Glyph provide a default
    ///// blending of colored glyph layers associated with the current glyph
    ///// slot (provided the font contains such layers) instead of rendering
    ///// the glyph slot's outline.  This is an experimental feature; see
    ///// @FT _LOAD_COLOR for more information.@note :
    ///// To get meaningful results, font scaling values must be set with
    ///// functions like @FT _Set_Char_Size before calling `FT_Render_Glyph`.When FreeType outputs a bitmap of a glyph, it really outputs an alpha
    ///// coverage map.  If a pixel is completely covered by a filled-in
    ///// outline, the bitmap contains 0xFF at that pixel, meaning that
    ///// 0xFF/0xFF fraction of that pixel is covered, meaning the pixel is 100%
    ///// black (or 0% bright).  If a pixel is only 50% covered (value 0x80),
    ///// the pixel is made 50% black (50% bright or a middle shade of grey).
    ///// 0% covered means 0% black (100% bright or white).On high-DPI screens like on smartphones and tablets, the pixels are so
    ///// small that their chance of being completely covered and therefore
    ///// completely black are fairly good.  On the low-DPI screens, however,
    ///// the situation is different.  The pixels are too large for most of the
    ///// details of a glyph and shades of gray are the norm rather than the
    ///// exception.This is relevant because all our screens have a second problem: they
    ///// are not linear.  1~+~1 is not~2.  Twice the value does not result in
    ///// twice the brightness.  When a pixel is only 50% covered, the coverage
    ///// map says 50% black, and this translates to a pixel value of 128 when
    ///// you use 8~bits per channel (0-255).  However, this does not translate
    ///// to 50% brightness for that pixel on our sRGB and gamma~2.2 screens.
    ///// Due to their non-linearity, they dwell longer in the darks and only a
    ///// pixel value of about 186 results in 50% brightness -- 128 ends up too
    ///// dark on both bright and dark backgrounds.  The net result is that dark
    ///// text looks burnt-out, pixely and blotchy on bright background, bright
    ///// text too frail on dark backgrounds, and colored text on colored
    ///// background (for example, red on green) seems to have dark halos or
    ///// 'dirt' around it.  The situation is especially ugly for diagonal stems
    ///// like in 'w' glyph shapes where the quality of FreeType's anti-aliasing
    ///// depends on the correct display of grays.  On high-DPI screens where
    ///// smaller, fully black pixels reign supreme, this doesn't matter, but on
    ///// our low-DPI screens with all the gray shades, it does.  0% and 100%
    ///// brightness are the same things in linear and non-linear space, just
    ///// all the shades in-between aren't.The blending function for placing text over a background is```
    ///// dst = alpha * src + (1 - alpha) * dst    ,
    ///// ```which is known as the OVER operator.To correctly composite an anti-aliased pixel of a glyph onto a
    ///// surface,1. take the foreground and background colors (e.g., in sRGB space)
    ///// and apply gamma to get them in a linear space,2. use OVER to blend the two linear colors using the glyph pixel
    ///// as the alpha value (remember, the glyph bitmap is an alpha coverage
    ///// bitmap), and3. apply inverse gamma to the blended pixel and write it back to
    ///// the image.Internal testing at Adobe found that a target inverse gamma of~1.8 for
    ///// step~3 gives good results across a wide range of displays with an sRGB
    ///// gamma curve or a similar one.This process can cost performance.  There is an approximation that
    ///// does not need to know about the background color; see
    ///// https://bel.fi/alankila/lcd/ and
    ///// https://bel.fi/alankila/lcd/alpcor.html for details.**ATTENTION**: Linear blending is even more important when dealing
    ///// with subpixel-rendered glyphs to prevent color-fringing!  A
    ///// subpixel-rendered glyph must first be filtered with a filter that
    ///// gives equal weight to the three color primaries and does not exceed a
    ///// sum of 0x100, see section @lcd _rendering.  Then the only difference to
    ///// gray linear blending is that subpixel-rendered linear blending is done
    ///// 3~times per pixel: red foreground subpixel to red background subpixel
    ///// and so on for green and blue.
    ///// </remarks>

    //public static unsafe delegate* <FT_GlyphSlot,FT_Render_Mode,FT_Error> FT_Render_Glyph = (delegate* <FT_GlyphSlot,FT_Render_Mode,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Render_Glyph");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Get_Kerning@description :
    ///// Return the kerning vector between two glyphs of the same face.@input :
    ///// face ::
    ///// A handle to a source face object.left_glyph ::
    ///// The index of the left glyph in the kern pair.right_glyph ::
    ///// The index of the right glyph in the kern pair.kern_mode ::
    ///// See @FT _Kerning_Mode for more information.  Determines the scale and
    ///// dimension of the returned kerning vector.@output :
    ///// akerning ::
    ///// The kerning vector.  This is either in font units, fractional pixels
    ///// (26.6 format), or pixels for scalable formats, and in pixels for
    ///// fixed-sizes formats.@note :
    ///// Only horizontal layouts (left-to-right 
    ///// &amp;
    ///// right-to-left) are supported
    ///// by this method.  Other layouts, or more sophisticated kernings, are
    ///// out of the scope of this API function -- they can be implemented
    ///// through format-specific interfaces.Kerning for OpenType fonts implemented in a 'GPOS' table is not
    ///// supported; use @FT _HAS_KERNING to find out whether a font has data
    ///// that can be extracted with `FT_Get_Kerning`.
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,uint,uint,uint,ref FT_Vector,FT_Error> FT_Get_Kerning = (delegate* <FT_Face,uint,uint,uint,ref FT_Vector,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Get_Kerning");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Get_Track_Kerning@description :
    ///// Return the track kerning for a given face object at a given size.@input :
    ///// face ::
    ///// A handle to a source face object.point_size ::
    ///// The point size in 16.16 fractional points.degree ::
    ///// The degree of tightness.  Increasingly negative values represent
    ///// tighter track kerning, while increasingly positive values represent
    ///// looser track kerning.  Value zero means no track kerning.@output :
    ///// akerning ::
    ///// The kerning in 16.16 fractional points, to be uniformly applied
    ///// between all glyphs.@note :
    ///// Currently, only the Type~1 font driver supports track kerning, using
    ///// data from AFM files (if attached with @FT _Attach_File or
    ///// @FT _Attach_Stream).Only very few AFM files come with track kerning data; please refer to
    ///// Adobe's AFM specification for more details.
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,FT_Fixed,int,ref FT_Fixed,FT_Error> FT_Get_Track_Kerning = (delegate* <FT_Face,FT_Fixed,int,ref FT_Fixed,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Get_Track_Kerning");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Get_Glyph_Name@description :
    ///// Retrieve the ASCII name of a given glyph in a face.  This only works
    ///// for those faces where @FT _HAS_GLYPH_NAMES(face) returns~1.@input :
    ///// face ::
    ///// A handle to a source face object.glyph_index ::
    ///// The glyph index.buffer_max ::
    ///// The maximum number of bytes available in the buffer.@output :
    ///// buffer ::
    ///// A pointer to a target buffer where the name is copied to.@note :
    ///// An error is returned if the face doesn't provide glyph names or if the
    ///// glyph index is invalid.  In all cases of failure, the first byte of
    ///// `buffer` is set to~0 to indicate an empty name.The glyph name is truncated to fit within the buffer if it is too
    ///// long.  The returned string is always zero-terminated.Be aware that FreeType reorders glyph indices internally so that glyph
    ///// index~0 always corresponds to the 'missing glyph' (called '.notdef').This function always returns an error if the config macro
    ///// `FT_CONFIG_OPTION_NO_GLYPH_NAMES` is not defined in `ftoption.h`.
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,uint,FT_Pointer,uint,FT_Error> FT_Get_Glyph_Name = (delegate* <FT_Face,uint,FT_Pointer,uint,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Get_Glyph_Name");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// A pointer to the face's PostScript name.  `NULL` if unavailable.</returns>
    ///// <remarks>
    ///// :FT_Get_Postscript_Name@description :
    ///// Retrieve the ASCII PostScript name of a given face, if available.
    ///// This only works with PostScript, TrueType, and OpenType fonts.@input :
    ///// face ::
    ///// A handle to the source face object.@note :
    ///// The returned pointer is owned by the face and is destroyed with it.For variation fonts, this string changes if you select a different
    ///// instance, and you have to call `FT_Get_PostScript_Name` again to
    ///// retrieve it.  FreeType follows Adobe TechNote #5902, 'Generating
    ///// PostScript Names for Fonts Using OpenType Font Variations'.https://download.macromedia.com/pub/developer/opentype/tech-notes/5902.AdobePSNameGeneration.html[Since 2.9] Special PostScript names for named instances are only
    ///// returned if the named instance is set with @FT _Set_Named_Instance (and
    ///// the font has corresponding entries in its 'fvar' table).  If
    ///// @FT _IS_VARIATION returns true, the algorithmically derived PostScript
    ///// name is provided, not looking up special entries for named instances.
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,nint> FT_Get_Postscript_Name = (delegate* <FT_Face,nint>)NativeLibrary.GetExport(Handle, "FT_Get_Postscript_Name");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Select_Charmap@description :
    ///// Select a given charmap by its encoding tag (as listed in
    ///// `freetype.h`).@inout :
    ///// face ::
    ///// A handle to the source face object.@input :
    ///// encoding ::
    ///// A handle to the selected encoding.@note :
    ///// This function returns an error if no charmap in the face corresponds
    ///// to the encoding queried here.Because many fonts contain more than a single cmap for Unicode
    ///// encoding, this function has some special code to select the one that
    ///// covers Unicode best ('best' in the sense that a UCS-4 cmap is
    ///// preferred to a UCS-2 cmap).  It is thus preferable to @FT _Set_Charmap
    ///// in this case.
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,FT_Encoding,FT_Error> FT_Select_Charmap = (delegate* <FT_Face,FT_Encoding,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Select_Charmap");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Set_Charmap@description :
    ///// Select a given charmap for character code to glyph index mapping.@inout :
    ///// face ::
    ///// A handle to the source face object.@input :
    ///// charmap ::
    ///// A handle to the selected charmap.@note :
    ///// This function returns an error if the charmap is not part of the face
    ///// (i.e., if it is not listed in the `face-&gt;charmaps` table).It also fails if an OpenType type~14 charmap is selected (which
    ///// doesn't map character codes to glyph indices at all).
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,FT_CharMap,FT_Error> FT_Set_Charmap = (delegate* <FT_Face,FT_CharMap,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Set_Charmap");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// The index into the array of character maps within the face to which
    ///// `charmap` belongs.  If an error occurs, -1 is returned.</returns>
    ///// <remarks>
    ///// :FT_Get_Charmap_Index@description :
    ///// Retrieve index of a given charmap.@input :
    ///// charmap ::
    ///// A handle to a charmap.
    ///// </remarks>

    //public static unsafe delegate* <FT_CharMap,int> FT_Get_Charmap_Index = (delegate* <FT_CharMap,int>)NativeLibrary.GetExport(Handle, "FT_Get_Charmap_Index");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// The glyph index.  0~means 'undefined character code'.</returns>
    ///// <remarks>
    ///// :FT_Get_Char_Index@description :
    ///// Return the glyph index of a given character code.  This function uses
    ///// the currently selected charmap to do the mapping.@input :
    ///// face ::
    ///// A handle to the source face object.charcode ::
    ///// The character code.@note :
    ///// If you use FreeType to manipulate the contents of font files directly,
    ///// be aware that the glyph index returned by this function doesn't always
    ///// correspond to the internal indices used within the file.  This is done
    ///// to ensure that value~0 always corresponds to the 'missing glyph'.  If
    ///// the first glyph is not named '.notdef', then for Type~1 and Type~42
    ///// fonts, '.notdef' will be moved into the glyph ID~0 position, and
    ///// whatever was there will be moved to the position '.notdef' had.  For
    ///// Type~1 fonts, if there is no '.notdef' glyph at all, then one will be
    ///// created at index~0 and whatever was there will be moved to the last
    ///// index -- Type~42 fonts are considered invalid under this condition.
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,CULong,uint> FT_Get_Char_Index = (delegate* <FT_Face,CULong,uint>)NativeLibrary.GetExport(Handle, "FT_Get_Char_Index");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// The charmap's first character code.</returns>
    ///// <remarks>
    ///// :FT_Get_First_Char@description :
    ///// Return the first character code in the current charmap of a given
    ///// face, together with its corresponding glyph index.@input :
    ///// face ::
    ///// A handle to the source face object.@output :
    ///// agindex ::
    ///// Glyph index of first character code.  0~if charmap is empty.@note :
    ///// You should use this function together with @FT _Get_Next_Char to parse
    ///// all character codes available in a given charmap.  The code should
    ///// look like this:```
    ///// CULong  charcode;
    ///// uint   gindex;charcode = FT_Get_First_Char( face, 
    ///// &amp;gindex
    ///// );
    ///// while ( gindex != 0 )
    ///// {
    ///// ... do something with (charcode,gindex) pair ...charcode = FT_Get_Next_Char( face, charcode, 
    ///// &amp;gindex
    ///// );
    ///// }
    ///// ```Be aware that character codes can have values up to 0xFFFFFFFF; this
    ///// might happen for non-Unicode or malformed cmaps.  However, even with
    ///// regular Unicode encoding, so-called 'last resort fonts' (using SFNT
    ///// cmap format 13, see function @FT _Get_CMap_Format) normally have
    ///// entries for all Unicode characters up to 0x1FFFFF, which can cause *a
    ///// lot* of iterations.Note that `*agindex` is set to~0 if the charmap is empty.  The result
    ///// itself can be~0 in two cases: if the charmap is empty or if the
    ///// value~0 is the first valid character code.
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,ref uint,CULong> FT_Get_First_Char = (delegate* <FT_Face,ref uint,CULong>)NativeLibrary.GetExport(Handle, "FT_Get_First_Char");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// The charmap's next character code.</returns>
    ///// <remarks>
    ///// :FT_Get_Next_Char@description :
    ///// Return the next character code in the current charmap of a given face
    ///// following the value `char_code`, as well as the corresponding glyph
    ///// index.@input :
    ///// face ::
    ///// A handle to the source face object.char_code ::
    ///// The starting character code.@output :
    ///// agindex ::
    ///// Glyph index of next character code.  0~if charmap is empty.@note :
    ///// You should use this function with @FT _Get_First_Char to walk over all
    ///// character codes available in a given charmap.  See the note for that
    ///// function for a simple code example.Note that `*agindex` is set to~0 when there are no more codes in the
    ///// charmap.
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,CULong,ref uint,CULong> FT_Get_Next_Char = (delegate* <FT_Face,CULong,ref uint,CULong>)NativeLibrary.GetExport(Handle, "FT_Get_Next_Char");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Face_Properties@description :
    ///// Set or override certain (library or module-wide) properties on a
    ///// face-by-face basis.  Useful for finer-grained control and avoiding
    ///// locks on shared structures (threads can modify their own faces as they
    ///// see fit).Contrary to @FT _Property_Set, this function uses @FT _Parameter so that
    ///// you can pass multiple properties to the target face in one call.  Note
    ///// that only a subset of the available properties can be controlled.* @FT _PARAM_TAG_STEM_DARKENING (stem darkening, corresponding to the
    ///// property `no-stem-darkening` provided by the 'autofit', 'cff',
    ///// 'type1', and 't1cid' modules; see @no -stem-darkening).* @FT _PARAM_TAG_LCD_FILTER_WEIGHTS (LCD filter weights, corresponding
    ///// to function @FT _Library_SetLcdFilterWeights).* @FT _PARAM_TAG_RANDOM_SEED (seed value for the CFF, Type~1, and CID
    ///// 'random' operator, corresponding to the `random-seed` property
    ///// provided by the 'cff', 'type1', and 't1cid' modules; see
    ///// @random -seed).Pass `NULL` as `data` in @FT _Parameter for a given tag to reset the
    ///// option and use the library or module default again.@input :
    ///// face ::
    ///// A handle to the source face object.num_properties ::
    ///// The number of properties that follow.properties ::
    ///// A handle to an @FT _Parameter array with `num_properties` elements.@example :
    ///// Here is an example that sets three properties.  You must define
    ///// `FT_CONFIG_OPTION_SUBPIXEL_RENDERING` to make the LCD filter examples
    ///// work.```
    ///// FT_Parameter         property1;
    ///// FT_Bool              darken_stems = 1;FT_Parameter         property2;
    ///// FT_LcdFiveTapFilter  custom_weight =
    ///// { 0x11, 0x44, 0x56, 0x44, 0x11 };FT_Parameter         property3;
    ///// int             random_seed = 314159265;FT_Parameter         properties[3] = { property1,
    ///// property2,
    ///// property3 };property1.tag  = FT_PARAM_TAG_STEM_DARKENING;
    ///// property1.data = 
    ///// &amp;darken
    ///// _stems;property2.tag  = FT_PARAM_TAG_LCD_FILTER_WEIGHTS;
    ///// property2.data = custom_weight;property3.tag  = FT_PARAM_TAG_RANDOM_SEED;
    ///// property3.data = 
    ///// &amp;random
    ///// _seed;FT_Face_Properties( face, 3, properties );
    ///// ```The next example resets a single property to its default value.```
    ///// FT_Parameter  property;property.tag  = FT_PARAM_TAG_LCD_FILTER_WEIGHTS;
    ///// property.data = NULL;FT_Face_Properties( face, 1, 
    ///// &amp;property
    ///// );
    ///// ```@since :
    ///// 2.8
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,uint,ref FT_Parameter,FT_Error> FT_Face_Properties = (delegate* <FT_Face,uint,ref FT_Parameter,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Face_Properties");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// The glyph index.  0~means 'undefined character code'.</returns>
    ///// <remarks>
    ///// :FT_Get_Name_Index@description :
    ///// Return the glyph index of a given glyph name.@input :
    ///// face ::
    ///// A handle to the source face object.glyph_name ::
    ///// The glyph name.
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,utf8string,uint> FT_Get_Name_Index = (delegate* <FT_Face,utf8string,uint>)NativeLibrary.GetExport(Handle, "FT_Get_Name_Index");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Get_SubGlyph_Info@description :
    ///// Retrieve a description of a given subglyph.  Only use it if
    ///// `glyph-&gt;format` is @FT _GLYPH_FORMAT_COMPOSITE; an error is returned
    ///// otherwise.@input :
    ///// glyph ::
    ///// The source glyph slot.sub_index ::
    ///// The index of the subglyph.  Must be less than
    ///// `glyph-&gt;num_subglyphs`.@output :
    ///// p_index ::
    ///// The glyph index of the subglyph.p_flags ::
    ///// The subglyph flags, see @FT _SUBGLYPH_FLAG_XXX.p_arg1 ::
    ///// The subglyph's first argument (if any).p_arg2 ::
    ///// The subglyph's second argument (if any).p_transform ::
    ///// The subglyph transformation (if any).@note :
    ///// The values of `*p_arg1`, `*p_arg2`, and `*p_transform` must be
    ///// interpreted depending on the flags returned in `*p_flags`.  See the
    ///// OpenType specification for details.https://docs.microsoft.com/en-us/typography/opentype/spec/glyf#composite-glyph-description
    ///// </remarks>

    //public static unsafe delegate* <FT_GlyphSlot,uint,ref int,ref uint,ref int,ref int,ref FT_Matrix,FT_Error> FT_Get_SubGlyph_Info = (delegate* <FT_GlyphSlot,uint,ref int,ref uint,ref int,ref int,ref FT_Matrix,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Get_SubGlyph_Info");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// The `fsType` flags, see @FT _FSTYPE_XXX.</returns>
    ///// <remarks>
    ///// :FT_Get_FSType_Flags@description :
    ///// Return the `fsType` flags for a font.@input :
    ///// face ::
    ///// A handle to the source face object.@note :
    ///// Use this function rather than directly reading the `fs_type` field in
    ///// the @PS _FontInfoRec structure, which is only guaranteed to return the
    ///// correct results for Type~1 fonts.@since :
    ///// 2.3.8
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,ushort> FT_Get_FSType_Flags = (delegate* <FT_Face,ushort>)NativeLibrary.GetExport(Handle, "FT_Get_FSType_Flags");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// The glyph index.  0~means either 'undefined character code', or
    ///// 'undefined selector code', or 'no variation selector cmap subtable',
    ///// or 'current CharMap is not Unicode'.</returns>
    ///// <remarks>
    ///// :FT_Face_GetCharVariantIndex@description :
    ///// Return the glyph index of a given character code as modified by the
    ///// variation selector.@input :
    ///// face ::
    ///// A handle to the source face object.charcode ::
    ///// The character code point in Unicode.variantSelector ::
    ///// The Unicode code point of the variation selector.@note :
    ///// If you use FreeType to manipulate the contents of font files directly,
    ///// be aware that the glyph index returned by this function doesn't always
    ///// correspond to the internal indices used within the file.  This is done
    ///// to ensure that value~0 always corresponds to the 'missing glyph'.This function is only meaningful if
    ///// a) the font has a variation selector cmap sub table, and
    ///// b) the current charmap has a Unicode encoding.@since :
    ///// 2.3.6
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,CULong,CULong,uint> FT_Face_GetCharVariantIndex = (delegate* <FT_Face,CULong,CULong,uint>)NativeLibrary.GetExport(Handle, "FT_Face_GetCharVariantIndex");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// 1~if found in the standard (Unicode) cmap, 0~if found in the variation
    ///// selector cmap, or -1 if it is not a variation.</returns>
    ///// <remarks>
    ///// :FT_Face_GetCharVariantIsDefault@description :
    ///// Check whether this variation of this Unicode character is the one to
    ///// be found in the charmap.@input :
    ///// face ::
    ///// A handle to the source face object.charcode ::
    ///// The character codepoint in Unicode.variantSelector ::
    ///// The Unicode codepoint of the variation selector.@note :
    ///// This function is only meaningful if the font has a variation selector
    ///// cmap subtable.@since :
    ///// 2.3.6
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,CULong,CULong,int> FT_Face_GetCharVariantIsDefault = (delegate* <FT_Face,CULong,CULong,int>)NativeLibrary.GetExport(Handle, "FT_Face_GetCharVariantIsDefault");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// A pointer to an array of selector code points, or `NULL` if there is
    ///// no valid variation selector cmap subtable.</returns>
    ///// <remarks>
    ///// :FT_Face_GetVariantSelectors@description :
    ///// Return a zero-terminated list of Unicode variation selectors found in
    ///// the font.@input :
    ///// face ::
    ///// A handle to the source face object.@note :
    ///// The last item in the array is~0; the array is owned by the @FT _Face
    ///// object but can be overwritten or released on the next call to a
    ///// FreeType function.@since :
    ///// 2.3.6
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,ref
    //    uint> FT_Face_GetVariantSelectors = (delegate* <FT_Face,ref
    //        uint>)NativeLibrary.GetExport(Handle, "FT_Face_GetVariantSelectors");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// A pointer to an array of variation selector code points that are
    ///// active for the given character, or `NULL` if the corresponding list is
    ///// empty.</returns>
    ///// <remarks>
    ///// :FT_Face_GetVariantsOfChar@description :
    ///// Return a zero-terminated list of Unicode variation selectors found for
    ///// the specified character code.@input :
    ///// face ::
    ///// A handle to the source face object.charcode ::
    ///// The character codepoint in Unicode.@note :
    ///// The last item in the array is~0; the array is owned by the @FT _Face
    ///// object but can be overwritten or released on the next call to a
    ///// FreeType function.@since :
    ///// 2.3.6
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,CULong,ref
    //    uint> FT_Face_GetVariantsOfChar = (delegate* <FT_Face,CULong,ref
    //        uint>)NativeLibrary.GetExport(Handle, "FT_Face_GetVariantsOfChar");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// A list of all the code points that are specified by this selector
    ///// (both default and non-default codes are returned) or `NULL` if there
    ///// is no valid cmap or the variation selector is invalid.</returns>
    ///// <remarks>
    ///// :FT_Face_GetCharsOfVariant@description :
    ///// Return a zero-terminated list of Unicode character codes found for the
    ///// specified variation selector.@input :
    ///// face ::
    ///// A handle to the source face object.variantSelector ::
    ///// The variation selector code point in Unicode.@note :
    ///// The last item in the array is~0; the array is owned by the @FT _Face
    ///// object but can be overwritten or released on the next call to a
    ///// FreeType function.@since :
    ///// 2.3.6
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,CULong,ref
    //    uint> FT_Face_GetCharsOfVariant = (delegate* <FT_Face,CULong,ref
    //        uint>)NativeLibrary.GetExport(Handle, "FT_Face_GetCharsOfVariant");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// The result of `(a*b)/c`.  This function never traps when trying to
    ///// divide by zero; it simply returns 'MaxInt' or 'MinInt' depending on
    ///// the signs of `a` and `b`.</returns>
    ///// <remarks>
    ///// :FT_MulDiv@description :
    ///// Compute `(a*b)/c` with maximum accuracy, using a 64-bit intermediate
    ///// integer whenever necessary.This function isn't necessarily as fast as some processor-specific
    ///// operations, but is at least completely portable.@input :
    ///// a ::
    ///// The first multiplier.b ::
    ///// The second multiplier.c ::
    ///// The divisor.
    ///// </remarks>

    //public static unsafe delegate* <CLong,CLong,CLong,CLong> FT_MulDiv = (delegate* <CLong,CLong,CLong,CLong>)NativeLibrary.GetExport(Handle, "FT_MulDiv");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// The result of `(a*b)/0x10000`.</returns>
    ///// <remarks>
    ///// :FT_MulFix@description :
    ///// Compute `(a*b)/0x10000` with maximum accuracy.  Its main use is to
    ///// multiply a given value by a 16.16 fixed-point factor.@input :
    ///// a ::
    ///// The first multiplier.b ::
    ///// The second multiplier.  Use a 16.16 factor here whenever possible
    ///// (see note below).@note :
    ///// This function has been optimized for the case where the absolute value
    ///// of `a` is less than 2048, and `b` is a 16.16 scaling factor.  As this
    ///// happens mainly when scaling from notional units to fractional pixels
    ///// in FreeType, it resulted in noticeable speed improvements between
    ///// versions 2.x and 1.x.As a conclusion, always try to place a 16.16 factor as the _second_
    ///// argument of this function; this can make a great difference.
    ///// </remarks>

    //public static unsafe delegate* <CLong,CLong,CLong> FT_MulFix = (delegate* <CLong,CLong,CLong>)NativeLibrary.GetExport(Handle, "FT_MulFix");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// The result of `(a*0x10000)/b`.</returns>
    ///// <remarks>
    ///// :FT_DivFix@description :
    ///// Compute `(a*0x10000)/b` with maximum accuracy.  Its main use is to
    ///// divide a given value by a 16.16 fixed-point factor.@input :
    ///// a ::
    ///// The numerator.b ::
    ///// The denominator.  Use a 16.16 factor here.
    ///// </remarks>

    //public static unsafe delegate* <CLong,CLong,CLong> FT_DivFix = (delegate* <CLong,CLong,CLong>)NativeLibrary.GetExport(Handle, "FT_DivFix");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// `a` rounded to the nearest 16.16 fixed integer, halfway cases away
    ///// from zero.</returns>
    ///// <remarks>
    ///// :FT_RoundFix@description :
    ///// Round a 16.16 fixed number.@input :
    ///// a ::
    ///// The number to be rounded.@note :
    ///// The function uses wrap-around arithmetic.
    ///// </remarks>

    //public static unsafe delegate* <FT_Fixed,FT_Fixed> FT_RoundFix = (delegate* <FT_Fixed,FT_Fixed>)NativeLibrary.GetExport(Handle, "FT_RoundFix");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// `a` rounded towards plus infinity.</returns>
    ///// <remarks>
    ///// :FT_CeilFix@description :
    ///// Compute the smallest following integer of a 16.16 fixed number.@input :
    ///// a ::
    ///// The number for which the ceiling function is to be computed.@note :
    ///// The function uses wrap-around arithmetic.
    ///// </remarks>

    //public static unsafe delegate* <FT_Fixed,FT_Fixed> FT_CeilFix = (delegate* <FT_Fixed,FT_Fixed>)NativeLibrary.GetExport(Handle, "FT_CeilFix");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// `a` rounded towards minus infinity.</returns>
    ///// <remarks>
    ///// :FT_FloorFix@description :
    ///// Compute the largest previous integer of a 16.16 fixed number.@input :
    ///// a ::
    ///// The number for which the floor function is to be computed.
    ///// </remarks>

    //public static unsafe delegate* <FT_Fixed,FT_Fixed> FT_FloorFix = (delegate* <FT_Fixed,FT_Fixed>)NativeLibrary.GetExport(Handle, "FT_FloorFix");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <remarks>
    ///// :FT_Vector_Transform@description :
    ///// Transform a single vector through a 2x2 matrix.@inout :
    ///// vector ::
    ///// The target vector to transform.@input :
    ///// matrix ::
    ///// A pointer to the source 2x2 matrix.@note :
    ///// The result is undefined if either `vector` or `matrix` is invalid.
    ///// </remarks>

    //public static unsafe delegate* <ref FT_Vector,ref FT_Matrix,void> FT_Vector_Transform = (delegate* <ref FT_Vector,ref FT_Matrix,void>)NativeLibrary.GetExport(Handle, "FT_Vector_Transform");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <remarks>
    ///// :FT_Library_Version@description :
    ///// Return the version of the FreeType library being used.  This is useful
    ///// when dynamically linking to the library, since one cannot use the
    ///// macros @FREETYPE _MAJOR, @FREETYPE _MINOR, and @FREETYPE _PATCH.@input :
    ///// library ::
    ///// A source library handle.@output :
    ///// amajor ::
    ///// The major version number.aminor ::
    ///// The minor version number.apatch ::
    ///// The patch version number.@note :
    ///// The reason why this function takes a `library` argument is because
    ///// certain programs implement library initialization in a custom way that
    ///// doesn't use @FT _Init_FreeType.In such cases, the library version might not be available before the
    ///// library object has been created.
    ///// </remarks>

    //public static unsafe delegate* <FT_Library,ref int,ref int,ref int,void> FT_Library_Version = (delegate* <FT_Library,ref int,ref int,ref int,void>)NativeLibrary.GetExport(Handle, "FT_Library_Version");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// Always returns false.</returns>
    ///// <remarks>
    ///// :FT_Face_CheckTrueTypePatents@description :
    ///// Deprecated, does nothing.@input :
    ///// face ::
    ///// A face handle.@note :
    ///// Since May 2010, TrueType hinting is no longer patented.@since :
    ///// 2.3.5
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,FT_Bool> FT_Face_CheckTrueTypePatents = (delegate* <FT_Face,FT_Bool>)NativeLibrary.GetExport(Handle, "FT_Face_CheckTrueTypePatents");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// Always returns false.</returns>
    ///// <remarks>
    ///// :FT_Face_SetUnpatentedHinting@description :
    ///// Deprecated, does nothing.@input :
    ///// face ::
    ///// A face handle.value ::
    ///// New boolean setting.@note :
    ///// Since May 2010, TrueType hinting is no longer patented.@since :
    ///// 2.3.5
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,FT_Bool,FT_Bool> FT_Face_SetUnpatentedHinting = (delegate* <FT_Face,FT_Bool,FT_Bool>)NativeLibrary.GetExport(Handle, "FT_Face_SetUnpatentedHinting");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// List node.  `NULL` if it wasn't found.</returns>
    ///// <remarks>
    ///// :FT_List_Find@description :
    ///// Find the list node for a given listed object.@input :
    ///// list ::
    ///// A pointer to the parent list.
    ///// data ::
    ///// The address of the listed object.
    ///// </remarks>

    //public static unsafe delegate* <FT_List,nint,FT_ListNode> FT_List_Find = (delegate* <FT_List,nint,FT_ListNode>)NativeLibrary.GetExport(Handle, "FT_List_Find");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <remarks>
    ///// :FT_List_Add@description :
    ///// Append an element to the end of a list.@inout :
    ///// list ::
    ///// A pointer to the parent list.
    ///// node ::
    ///// The node to append.
    ///// </remarks>

    //public static unsafe delegate* <FT_List,FT_ListNode,void> FT_List_Add = (delegate* <FT_List,FT_ListNode,void>)NativeLibrary.GetExport(Handle, "FT_List_Add");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <remarks>
    ///// :FT_List_Insert@description :
    ///// Insert an element at the head of a list.@inout :
    ///// list ::
    ///// A pointer to parent list.
    ///// node ::
    ///// The node to insert.
    ///// </remarks>

    //public static unsafe delegate* <FT_List,FT_ListNode,void> FT_List_Insert = (delegate* <FT_List,FT_ListNode,void>)NativeLibrary.GetExport(Handle, "FT_List_Insert");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <remarks>
    ///// :FT_List_Remove@description :
    ///// Remove a node from a list.  This function doesn't check whether the
    ///// node is in the list!@input :
    ///// node ::
    ///// The node to remove.@inout :
    ///// list ::
    ///// A pointer to the parent list.
    ///// </remarks>

    //public static unsafe delegate* <FT_List,FT_ListNode,void> FT_List_Remove = (delegate* <FT_List,FT_ListNode,void>)NativeLibrary.GetExport(Handle, "FT_List_Remove");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <remarks>
    ///// :FT_List_Up@description :
    ///// Move a node to the head/top of a list.  Used to maintain LRU lists.@inout :
    ///// list ::
    ///// A pointer to the parent list.
    ///// node ::
    ///// The node to move.
    ///// </remarks>

    //public static unsafe delegate* <FT_List,FT_ListNode,void> FT_List_Up = (delegate* <FT_List,FT_ListNode,void>)NativeLibrary.GetExport(Handle, "FT_List_Up");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// The result (a FreeType error code) of the last iterator call.</returns>
    ///// <remarks>
    ///// :FT_List_Iterate@description :
    ///// Parse a list and calls a given iterator function on each element.
    ///// Note that parsing is stopped as soon as one of the iterator calls
    ///// returns a non-zero value.@input :
    ///// list ::
    ///// A handle to the list.
    ///// iterator ::
    ///// An iterator function, called on each node of the list.
    ///// user ::
    ///// A user-supplied field that is passed as the second argument to the
    ///// iterator.
    ///// </remarks>

    //public static unsafe delegate* <FT_List,FT_List_Iterator,nint,FT_Error> FT_List_Iterate = (delegate* <FT_List,FT_List_Iterator,nint,FT_Error>)NativeLibrary.GetExport(Handle, "FT_List_Iterate");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <remarks>
    ///// :FT_List_Finalize@description :
    ///// Destroy all elements in the list as well as the list itself.@input :
    ///// list ::
    ///// A handle to the list.destroy ::
    ///// A list destructor that will be applied to each element of the list.
    ///// Set this to `NULL` if not needed.memory ::
    ///// The current memory object that handles deallocation.user ::
    ///// A user-supplied field that is passed as the last argument to the
    ///// destructor.@note :
    ///// This function expects that all nodes added by @FT _List_Add or
    ///// @FT _List_Insert have been dynamically allocated.
    ///// </remarks>

    //public static unsafe delegate* <FT_List,FT_List_Destructor,FT_Memory,nint,void> FT_List_Finalize = (delegate* <FT_List,FT_List_Destructor,FT_Memory,nint,void>)NativeLibrary.GetExport(Handle, "FT_List_Finalize");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Outline_Decompose@description :
    ///// Walk over an outline's structure to decompose it into individual
    ///// segments and Bezier arcs.  This function also emits 'move to'
    ///// operations to indicate the start of new contours in the outline.@input :
    ///// outline ::
    ///// A pointer to the source target.func_interface ::
    ///// A table of 'emitters', i.e., function pointers called during
    ///// decomposition to indicate path operations.@inout :
    ///// user ::
    ///// A typeless pointer that is passed to each emitter during the
    ///// decomposition.  It can be used to store the state during the
    ///// decomposition.@note :
    ///// A contour that contains a single point only is represented by a 'move
    ///// to' operation followed by 'line to' to the same point.  In most cases,
    ///// it is best to filter this out before using the outline for stroking
    ///// purposes (otherwise it would result in a visible dot when round caps
    ///// are used).Similarly, the function returns success for an empty outline also
    ///// (doing nothing, this is, not calling any emitter); if necessary, you
    ///// should filter this out, too.
    ///// </remarks>

    //public static unsafe delegate* <ref FT_Outline,ref FT_Outline_Funcs,nint,FT_Error> FT_Outline_Decompose = (delegate* <ref FT_Outline,ref FT_Outline_Funcs,nint,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Outline_Decompose");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Outline_New@description :
    ///// Create a new outline of a given size.@input :
    ///// library ::
    ///// A handle to the library object from where the outline is allocated.
    ///// Note however that the new outline will **not** necessarily be
    ///// **freed**, when destroying the library, by @FT _Done_FreeType.numPoints ::
    ///// The maximum number of points within the outline.  Must be smaller
    ///// than or equal to 0xFFFF (65535).numContours ::
    ///// The maximum number of contours within the outline.  This value must
    ///// be in the range 0 to `numPoints`.@output :
    ///// anoutline ::
    ///// A handle to the new outline.@note :
    ///// The reason why this function takes a `library` parameter is simply to
    ///// use the library's memory allocator.
    ///// </remarks>

    //public static unsafe delegate* <FT_Library,uint,int,ref FT_Outline,FT_Error> FT_Outline_New = (delegate* <FT_Library,uint,int,ref FT_Outline,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Outline_New");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Outline_Done@description :
    ///// Destroy an outline created with @FT _Outline_New.@input :
    ///// library ::
    ///// A handle of the library object used to allocate the outline.outline ::
    ///// A pointer to the outline object to be discarded.@note :
    ///// If the outline's 'owner' field is not set, only the outline descriptor
    ///// will be released.
    ///// </remarks>

    //public static unsafe delegate* <FT_Library,ref FT_Outline,FT_Error> FT_Outline_Done = (delegate* <FT_Library,ref FT_Outline,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Outline_Done");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Outline_Check@description :
    ///// Check the contents of an outline descriptor.@input :
    ///// outline ::
    ///// A handle to a source outline.@note :
    ///// An empty outline, or an outline with a single point only is also
    ///// valid.
    ///// </remarks>

    //public static unsafe delegate* <ref FT_Outline,FT_Error> FT_Outline_Check = (delegate* <ref FT_Outline,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Outline_Check");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <remarks>
    ///// :FT_Outline_Get_CBox@description :
    ///// Return an outline's 'control box'.  The control box encloses all the
    ///// outline's points, including Bezier control points.  Though it
    ///// coincides with the exact bounding box for most glyphs, it can be
    ///// slightly larger in some situations (like when rotating an outline that
    ///// contains Bezier outside arcs).Computing the control box is very fast, while getting the bounding box
    ///// can take much more time as it needs to walk over all segments and arcs
    ///// in the outline.  To get the latter, you can use the 'ftbbox'
    ///// component, which is dedicated to this single task.@input :
    ///// outline ::
    ///// A pointer to the source outline descriptor.@output :
    ///// acbox ::
    ///// The outline's control box.@note :
    ///// See @FT _Glyph_Get_CBox for a discussion of tricky fonts.
    ///// </remarks>

    //public static unsafe delegate* <ref FT_Outline,ref FT_BBox,void> FT_Outline_Get_CBox = (delegate* <ref FT_Outline,ref FT_BBox,void>)NativeLibrary.GetExport(Handle, "FT_Outline_Get_CBox");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <remarks>
    ///// :FT_Outline_Translate@description :
    ///// Apply a simple translation to the points of an outline.@inout :
    ///// outline ::
    ///// A pointer to the target outline descriptor.@input :
    ///// xOffset ::
    ///// The horizontal offset.yOffset ::
    ///// The vertical offset.
    ///// </remarks>

    //public static unsafe delegate* <ref FT_Outline,FT_Pos,FT_Pos,void> FT_Outline_Translate = (delegate* <ref FT_Outline,FT_Pos,FT_Pos,void>)NativeLibrary.GetExport(Handle, "FT_Outline_Translate");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Outline_Copy@description :
    ///// Copy an outline into another one.  Both objects must have the same
    ///// sizes (number of points 
    ///// &amp;
    ///// number of contours) when this function is
    ///// called.@input :
    ///// source ::
    ///// A handle to the source outline.@output :
    ///// target ::
    ///// A handle to the target outline.
    ///// </remarks>

    //public static unsafe delegate* <ref FT_Outline,ref FT_Outline,FT_Error> FT_Outline_Copy = (delegate* <ref FT_Outline,ref FT_Outline,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Outline_Copy");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <remarks>
    ///// :FT_Outline_Transform@description :
    ///// Apply a simple 2x2 matrix to all of an outline's points.  Useful for
    ///// applying rotations, slanting, flipping, etc.@inout :
    ///// outline ::
    ///// A pointer to the target outline descriptor.@input :
    ///// matrix ::
    ///// A pointer to the transformation matrix.@note :
    ///// You can use @FT _Outline_Translate if you need to translate the
    ///// outline's points.
    ///// </remarks>

    //public static unsafe delegate* <ref FT_Outline,ref FT_Matrix,void> FT_Outline_Transform = (delegate* <ref FT_Outline,ref FT_Matrix,void>)NativeLibrary.GetExport(Handle, "FT_Outline_Transform");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Outline_Embolden@description :
    ///// Embolden an outline.  The new outline will be at most 4~times
    ///// `strength` pixels wider and higher.  You may think of the left and
    ///// bottom borders as unchanged.Negative `strength` values to reduce the outline thickness are
    ///// possible also.@inout :
    ///// outline ::
    ///// A handle to the target outline.@input :
    ///// strength ::
    ///// How strong the glyph is emboldened.  Expressed in 26.6 pixel format.@note :
    ///// The used algorithm to increase or decrease the thickness of the glyph
    ///// doesn't change the number of points; this means that certain
    ///// situations like acute angles or intersections are sometimes handled
    ///// incorrectly.If you need 'better' metrics values you should call
    ///// @FT _Outline_Get_CBox or @FT _Outline_Get_BBox.To get meaningful results, font scaling values must be set with
    ///// functions like @FT _Set_Char_Size before calling FT_Render_Glyph.@example :
    ///// ```
    ///// FT_Load_Glyph( face, index, FT_LOAD_DEFAULT );if ( face-&gt;glyph-&gt;format == FT_GLYPH_FORMAT_OUTLINE )
    ///// FT_Outline_Embolden( 
    ///// &amp;face
    ///// -&gt;glyph-&gt;outline, strength );
    ///// ```
    ///// </remarks>

    //public static unsafe delegate* <ref FT_Outline,FT_Pos,FT_Error> FT_Outline_Embolden = (delegate* <ref FT_Outline,FT_Pos,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Outline_Embolden");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <remarks>
    ///// :FT_Outline_EmboldenXY@description :
    ///// Embolden an outline.  The new outline will be `xstrength` pixels wider
    ///// and `ystrength` pixels higher.  Otherwise, it is similar to
    ///// @FT _Outline_Embolden, which uses the same strength in both directions.@since :
    ///// 2.4.10
    ///// </remarks>

    //public static unsafe delegate* <ref FT_Outline,FT_Pos,FT_Pos,FT_Error> FT_Outline_EmboldenXY = (delegate* <ref FT_Outline,FT_Pos,FT_Pos,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Outline_EmboldenXY");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <remarks>
    ///// :FT_Outline_Reverse@description :
    ///// Reverse the drawing direction of an outline.  This is used to ensure
    ///// consistent fill conventions for mirrored glyphs.@inout :
    ///// outline ::
    ///// A pointer to the target outline descriptor.@note :
    ///// This function toggles the bit flag @FT _OUTLINE_REVERSE_FILL in the
    ///// outline's `flags` field.It shouldn't be used by a normal client application, unless it knows
    ///// what it is doing.
    ///// </remarks>

    //public static unsafe delegate* <ref FT_Outline,void> FT_Outline_Reverse = (delegate* <ref FT_Outline,void>)NativeLibrary.GetExport(Handle, "FT_Outline_Reverse");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Outline_Get_Bitmap@description :
    ///// Render an outline within a bitmap.  The outline's image is simply
    ///// OR-ed to the target bitmap.@input :
    ///// library ::
    ///// A handle to a FreeType library object.outline ::
    ///// A pointer to the source outline descriptor.@inout :
    ///// abitmap ::
    ///// A pointer to the target bitmap descriptor.@note :
    ///// This function does **not create** the bitmap, it only renders an
    ///// outline image within the one you pass to it!  Consequently, the
    ///// various fields in `abitmap` should be set accordingly.It will use the raster corresponding to the default glyph format.The value of the `num_grays` field in `abitmap` is ignored.  If you
    ///// select the gray-level rasterizer, and you want less than 256 gray
    ///// levels, you have to use @FT _Outline_Render directly.
    ///// </remarks>

    //public static unsafe delegate* <FT_Library,ref FT_Outline,ref FT_Bitmap,FT_Error> FT_Outline_Get_Bitmap = (delegate* <FT_Library,ref FT_Outline,ref FT_Bitmap,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Outline_Get_Bitmap");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Outline_Render@description :
    ///// Render an outline within a bitmap using the current scan-convert.@input :
    ///// library ::
    ///// A handle to a FreeType library object.outline ::
    ///// A pointer to the source outline descriptor.@inout :
    ///// params ::
    ///// A pointer to an @FT _Raster_Params structure used to describe the
    ///// rendering operation.@note :
    ///// This advanced function uses @FT _Raster_Params as an argument.
    ///// The field `params.source` will be set to `outline` before the scan
    ///// converter is called, which means that the value you give to it is
    ///// actually ignored.  Either `params.target` must point to preallocated
    ///// bitmap, or @FT _RASTER_FLAG_DIRECT must be set in `params.flags`
    ///// allowing FreeType rasterizer to be used for direct composition,
    ///// translucency, etc.  See @FT _Raster_Params for more details.
    ///// </remarks>

    //public static unsafe delegate* <FT_Library,ref FT_Outline,ref FT_Raster_Params,FT_Error> FT_Outline_Render = (delegate* <FT_Library,ref FT_Outline,ref FT_Raster_Params,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Outline_Render");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// The orientation.</returns>
    ///// <remarks>
    ///// :FT_Outline_Get_Orientation@description :
    ///// This function analyzes a glyph outline and tries to compute its fill
    ///// orientation (see @FT _Orientation).  This is done by integrating the
    ///// total area covered by the outline. The positive integral corresponds
    ///// to the clockwise orientation and @FT _ORIENTATION_POSTSCRIPT is
    ///// returned. The negative integral corresponds to the counter-clockwise
    ///// orientation and @FT _ORIENTATION_TRUETYPE is returned.Note that this will return @FT _ORIENTATION_TRUETYPE for empty
    ///// outlines.@input :
    ///// outline ::
    ///// A handle to the source outline.
    ///// </remarks>

    //public static unsafe delegate* <ref FT_Outline,FT_Orientation> FT_Outline_Get_Orientation = (delegate* <ref FT_Outline,FT_Orientation>)NativeLibrary.GetExport(Handle, "FT_Outline_Get_Orientation");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_New_Size@description :
    ///// Create a new size object from a given face object.@input :
    ///// face ::
    ///// A handle to a parent face object.@output :
    ///// asize ::
    ///// A handle to a new size object.@note :
    ///// You need to call @FT _Activate_Size in order to select the new size for
    ///// upcoming calls to @FT _Set_Pixel_Sizes, @FT _Set_Char_Size,
    ///// @FT _Load_Glyph, @FT _Load_Char, etc.
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,ref FT_Size,FT_Error> FT_New_Size = (delegate* <FT_Face,ref FT_Size,FT_Error>)NativeLibrary.GetExport(Handle, "FT_New_Size");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Done_Size@description :
    ///// Discard a given size object.  Note that @FT _Done_Face automatically
    ///// discards all size objects allocated with @FT _New_Size.@input :
    ///// size ::
    ///// A handle to a target size object.
    ///// </remarks>

    //public static unsafe delegate* <FT_Size,FT_Error> FT_Done_Size = (delegate* <FT_Size,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Done_Size");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Activate_Size@description :
    ///// Even though it is possible to create several size objects for a given
    ///// face (see @FT _New_Size for details), functions like @FT _Load_Glyph or
    ///// @FT _Load_Char only use the one that has been activated last to
    ///// determine the 'current character pixel size'.This function can be used to 'activate' a previously created size
    ///// object.@input :
    ///// size ::
    ///// A handle to a target size object.@note :
    ///// If `face` is the size's parent face object, this function changes the
    ///// value of `face-&gt;size` to the input size handle.
    ///// </remarks>

    //public static unsafe delegate* <FT_Size,FT_Error> FT_Activate_Size = (delegate* <FT_Size,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Activate_Size");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Add_Module@description :
    ///// Add a new module to a given library instance.@inout :
    ///// library ::
    ///// A handle to the library object.@input :
    ///// clazz ::
    ///// A pointer to class descriptor for the module.@note :
    ///// An error will be returned if a module already exists by that name, or
    ///// if the module requires a version of FreeType that is too great.
    ///// </remarks>

    //public static unsafe delegate* <FT_Library,ref FT_Module_Class,FT_Error> FT_Add_Module = (delegate* <FT_Library,ref FT_Module_Class,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Add_Module");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// A module handle.  0~if none was found.</returns>
    ///// <remarks>
    ///// :FT_Get_Module@description :
    ///// Find a module by its name.@input :
    ///// library ::
    ///// A handle to the library object.module_name ::
    ///// The module's name (as an ASCII string).@note :
    ///// FreeType's internal modules aren't documented very well, and you
    ///// should look up the source code for details.
    ///// </remarks>

    //public static unsafe delegate* <FT_Library,nint,FT_Module> FT_Get_Module = (delegate* <FT_Library,nint,FT_Module>)NativeLibrary.GetExport(Handle, "FT_Get_Module");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Remove_Module@description :
    ///// Remove a given module from a library instance.@inout :
    ///// library ::
    ///// A handle to a library object.@input :
    ///// module ::
    ///// A handle to a module object.@note :
    ///// The module object is destroyed by the function in case of success.
    ///// </remarks>

    //public static unsafe delegate* <FT_Library,FT_Module,FT_Error> FT_Remove_Module = (delegate* <FT_Library,FT_Module,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Remove_Module");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Property_Set@description :
    ///// Set a property for a given module.@input :
    ///// library ::
    ///// A handle to the library the module is part of.module_name ::
    ///// The module name.property_name ::
    ///// The property name.  Properties are described in section
    ///// @properties .Note that only a few modules have properties.value ::
    ///// A generic pointer to a variable or structure that gives the new
    ///// value of the property.  The exact definition of `value` is
    ///// dependent on the property; see section @properties .@note :
    ///// If `module_name` isn't a valid module name, or `property_name`
    ///// doesn't specify a valid property, or if `value` doesn't represent a
    ///// valid value for the given property, an error is returned.The following example sets property 'bar' (a simple integer) in
    ///// module 'foo' to value~1.```
    ///// uint  bar;bar = 1;
    ///// FT_Property_Set( library, "foo", "bar", 
    ///// &amp;bar
    ///// );
    ///// ```Note that the FreeType Cache sub-system doesn't recognize module
    ///// property changes.  To avoid glyph lookup confusion within the cache
    ///// you should call @FTC _Manager_Reset to completely flush the cache if a
    ///// module property gets changed after @FTC _Manager_New has been called.It is not possible to set properties of the FreeType Cache sub-system
    ///// itself with FT_Property_Set; use @FTC _Property_Set instead.@since :
    ///// 2.4.11
    ///// </remarks>

    //public static unsafe delegate* <FT_Library,utf8string,utf8string,nint,FT_Error> FT_Property_Set = (delegate* <FT_Library,utf8string,utf8string,nint,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Property_Set");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Property_Get@description :
    ///// Get a module's property value.@input :
    ///// library ::
    ///// A handle to the library the module is part of.module_name ::
    ///// The module name.property_name ::
    ///// The property name.  Properties are described in section
    ///// @properties .@inout :
    ///// value ::
    ///// A generic pointer to a variable or structure that gives the value
    ///// of the property.  The exact definition of `value` is dependent on
    ///// the property; see section @properties .@note :
    ///// If `module_name` isn't a valid module name, or `property_name`
    ///// doesn't specify a valid property, or if `value` doesn't represent a
    ///// valid value for the given property, an error is returned.The following example gets property 'baz' (a range) in module 'foo'.```
    ///// typedef  range_
    ///// {
    ///// int  min;
    ///// int  max;} range;range  baz;FT_Property_Get( library, "foo", "baz", 
    ///// &amp;baz
    ///// );
    ///// ```It is not possible to retrieve properties of the FreeType Cache
    ///// sub-system with FT_Property_Get; use @FTC _Property_Get instead.@since :
    ///// 2.4.11
    ///// </remarks>

    //public static unsafe delegate* <FT_Library,utf8string,utf8string,nint,FT_Error> FT_Property_Get = (delegate* <FT_Library,utf8string,utf8string,nint,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Property_Get");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <remarks>
    ///// :FT_Set_Default_Properties@description :
    ///// If compilation option `FT_CONFIG_OPTION_ENVIRONMENT_PROPERTIES` is
    ///// set, this function reads the `FREETYPE_PROPERTIES` environment
    ///// variable to control driver properties.  See section @properties for
    ///// more.If the compilation option is not set, this function does nothing.`FREETYPE_PROPERTIES` has the following syntax form (broken here into
    ///// multiple lines for better readability).```
    ///// &lt;optional
    ///// whitespace&gt;
    ///// &lt;module
    ///// -name1&gt; ':'
    ///// &lt;property
    ///// -name1&gt; '=' 
    ///// &lt;property
    ///// -value1&gt;
    ///// &lt;whitespace
    ///// &gt;
    ///// &lt;module
    ///// -name2&gt; ':'
    ///// &lt;property
    ///// -name2&gt; '=' 
    ///// &lt;property
    ///// -value2&gt;
    ///// ...
    ///// ```Example:```
    ///// FREETYPE_PROPERTIES=truetype:interpreter-version=35 
    ///// \
    ///// cff:no-stem-darkening=0
    ///// ```@inout :
    ///// library ::
    ///// A handle to a new library object.@since :
    ///// 2.8
    ///// </remarks>

    //public static unsafe delegate* <FT_Library,void> FT_Set_Default_Properties = (delegate* <FT_Library,void>)NativeLibrary.GetExport(Handle, "FT_Set_Default_Properties");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Reference_Library@description :
    ///// A counter gets initialized to~1 at the time an @FT _Library structure
    ///// is created.  This function increments the counter.  @FT _Done_Library
    ///// then only destroys a library if the counter is~1, otherwise it simply
    ///// decrements the counter.This function helps in managing life-cycles of structures that
    ///// reference @FT _Library objects.@input :
    ///// library ::
    ///// A handle to a target library object.@since :
    ///// 2.4.2
    ///// </remarks>

    //public static unsafe delegate* <FT_Library,FT_Error> FT_Reference_Library = (delegate* <FT_Library,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Reference_Library");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_New_Library@description :
    ///// This function is used to create a new FreeType library instance from a
    ///// given memory object.  It is thus possible to use libraries with
    ///// distinct memory allocators within the same program.  Note, however,
    ///// that the used @FT _Memory structure is expected to remain valid for the
    ///// life of the @FT _Library object.Normally, you would call this function (followed by a call to
    ///// @FT _Add_Default_Modules or a series of calls to @FT _Add_Module, and a
    ///// call to @FT _Set_Default_Properties) instead of @FT _Init_FreeType to
    ///// initialize the FreeType library.Don't use @FT _Done_FreeType but @FT _Done_Library to destroy a library
    ///// instance.@input :
    ///// memory ::
    ///// A handle to the original memory object.@output :
    ///// alibrary ::
    ///// A pointer to handle of a new library object.@note :
    ///// See the discussion of reference counters in the description of
    ///// @FT _Reference_Library.
    ///// </remarks>

    //public static unsafe delegate* <FT_Memory,ref FT_Library,FT_Error> FT_New_Library = (delegate* <FT_Memory,ref FT_Library,FT_Error>)NativeLibrary.GetExport(Handle, "FT_New_Library");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Done_Library@description :
    ///// Discard a given library object.  This closes all drivers and discards
    ///// all resource objects.@input :
    ///// library ::
    ///// A handle to the target library.@note :
    ///// See the discussion of reference counters in the description of
    ///// @FT _Reference_Library.
    ///// </remarks>

    //public static unsafe delegate* <FT_Library,FT_Error> FT_Done_Library = (delegate* <FT_Library,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Done_Library");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <remarks>
    ///// :FT_Set_Debug_Hook@description :
    ///// Set a debug hook function for debugging the interpreter of a font
    ///// format.While this is a public API function, an application needs access to
    ///// FreeType's internal header files to do something useful.Have a look at the source code of the `ttdebug` FreeType demo program
    ///// for an example of its usage.@inout :
    ///// library ::
    ///// A handle to the library object.@input :
    ///// hook_index ::
    ///// The index of the debug hook.  You should use defined enumeration
    ///// macros like @FT _DEBUG_HOOK_TRUETYPE.debug_hook ::
    ///// The function used to debug the interpreter.@note :
    ///// Currently, four debug hook slots are available, but only one (for the
    ///// TrueType interpreter) is defined.
    ///// </remarks>

    //public static unsafe delegate* <FT_Library,uint,FT_DebugHook_Func,void> FT_Set_Debug_Hook = (delegate* <FT_Library,uint,FT_DebugHook_Func,void>)NativeLibrary.GetExport(Handle, "FT_Set_Debug_Hook");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <remarks>
    ///// :FT_Add_Default_Modules@description :
    ///// Add the set of default drivers to a given library object.  This is
    ///// only useful when you create a library object with @FT _New_Library
    ///// (usually to plug a custom memory manager).@inout :
    ///// library ::
    ///// A handle to a new library object.
    ///// </remarks>

    //public static unsafe delegate* <FT_Library,void> FT_Add_Default_Modules = (delegate* <FT_Library,void>)NativeLibrary.GetExport(Handle, "FT_Add_Default_Modules");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// A value indicating which level is supported.</returns>
    ///// <remarks>
    ///// :FT_Get_TrueType_Engine_Type@description :
    ///// Return an @FT _TrueTypeEngineType value to indicate which level of the
    ///// TrueType virtual machine a given library instance supports.@input :
    ///// library ::
    ///// A library instance.@since :
    ///// 2.2
    ///// </remarks>

    //public static unsafe delegate* <FT_Library,FT_TrueTypeEngineType> FT_Get_TrueType_Engine_Type = (delegate* <FT_Library,FT_TrueTypeEngineType>)NativeLibrary.GetExport(Handle, "FT_Get_TrueType_Engine_Type");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_New_Glyph@description :
    ///// A function used to create a new empty glyph image.  Note that the
    ///// created @FT _Glyph object must be released with @FT _Done_Glyph.@input :
    ///// library ::
    ///// A handle to the FreeType library object.format ::
    ///// The format of the glyph's image.@output :
    ///// aglyph ::
    ///// A handle to the glyph object.@since :
    ///// 2.10
    ///// </remarks>

    //public static unsafe delegate* <FT_Library,FT_Glyph_Format,ref FT_Glyph,FT_Error> FT_New_Glyph = (delegate* <FT_Library,FT_Glyph_Format,ref FT_Glyph,FT_Error>)NativeLibrary.GetExport(Handle, "FT_New_Glyph");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Get_Glyph@description :
    ///// A function used to extract a glyph image from a slot.  Note that the
    ///// created @FT _Glyph object must be released with @FT _Done_Glyph.@input :
    ///// slot ::
    ///// A handle to the source glyph slot.@output :
    ///// aglyph ::
    ///// A handle to the glyph object.@note :
    ///// Because `*aglyph-&gt;advance.x` and `*aglyph-&gt;advance.y` are 16.16
    ///// fixed-point numbers, `slot-&gt;advance.x` and `slot-&gt;advance.y` (which
    ///// are in 26.6 fixed-point format) must be in the range ]-32768;32768[.
    ///// </remarks>

    //public static unsafe delegate* <FT_GlyphSlot,ref FT_Glyph,FT_Error> FT_Get_Glyph = (delegate* <FT_GlyphSlot,ref FT_Glyph,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Get_Glyph");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Glyph_Copy@description :
    ///// A function used to copy a glyph image.  Note that the created
    ///// @FT _Glyph object must be released with @FT _Done_Glyph.@input :
    ///// source ::
    ///// A handle to the source glyph object.@output :
    ///// target ::
    ///// A handle to the target glyph object.  0~in case of error.
    ///// </remarks>

    //public static unsafe delegate* <FT_Glyph,ref FT_Glyph,FT_Error> FT_Glyph_Copy = (delegate* <FT_Glyph,ref FT_Glyph,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Glyph_Copy");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code (if not 0, the glyph format is not scalable).</returns>
    ///// <remarks>
    ///// :FT_Glyph_Transform@description :
    ///// Transform a glyph image if its format is scalable.@inout :
    ///// glyph ::
    ///// A handle to the target glyph object.@input :
    ///// matrix ::
    ///// A pointer to a 2x2 matrix to apply.delta ::
    ///// A pointer to a 2d vector to apply.  Coordinates are expressed in
    ///// 1/64th of a pixel.@note :
    ///// The 2x2 transformation matrix is also applied to the glyph's advance
    ///// vector.
    ///// </remarks>

    //public static unsafe delegate* <FT_Glyph,ref FT_Matrix,ref FT_Vector,FT_Error> FT_Glyph_Transform = (delegate* <FT_Glyph,ref FT_Matrix,ref FT_Vector,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Glyph_Transform");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <remarks>
    ///// :FT_Glyph_Get_CBox@description :
    ///// Return a glyph's 'control box'.  The control box encloses all the
    ///// outline's points, including Bezier control points.  Though it
    ///// coincides with the exact bounding box for most glyphs, it can be
    ///// slightly larger in some situations (like when rotating an outline that
    ///// contains Bezier outside arcs).Computing the control box is very fast, while getting the bounding box
    ///// can take much more time as it needs to walk over all segments and arcs
    ///// in the outline.  To get the latter, you can use the 'ftbbox'
    ///// component, which is dedicated to this single task.@input :
    ///// glyph ::
    ///// A handle to the source glyph object.mode ::
    ///// The mode that indicates how to interpret the returned bounding box
    ///// values.@output :
    ///// acbox ::
    ///// The glyph coordinate bounding box.  Coordinates are expressed in
    ///// 1/64th of pixels if it is grid-fitted.@note :
    ///// Coordinates are relative to the glyph origin, using the y~upwards
    ///// convention.If the glyph has been loaded with @FT _LOAD_NO_SCALE, `bbox_mode` must
    ///// be set to @FT _GLYPH_BBOX_UNSCALED to get unscaled font units in 26.6
    ///// pixel format.  The value @FT _GLYPH_BBOX_SUBPIXELS is another name for
    ///// this constant.If the font is tricky and the glyph has been loaded with
    ///// @FT _LOAD_NO_SCALE, the resulting CBox is meaningless.  To get
    ///// reasonable values for the CBox it is necessary to load the glyph at a
    ///// large ppem value (so that the hinting instructions can properly shift
    ///// and scale the subglyphs), then extracting the CBox, which can be
    ///// eventually converted back to font units.Note that the maximum coordinates are exclusive, which means that one
    ///// can compute the width and height of the glyph image (be it in integer
    ///// or 26.6 pixels) as:```
    ///// width  = bbox.xMax - bbox.xMin;
    ///// height = bbox.yMax - bbox.yMin;
    ///// ```Note also that for 26.6 coordinates, if `bbox_mode` is set to
    ///// @FT _GLYPH_BBOX_GRIDFIT, the coordinates will also be grid-fitted,
    ///// which corresponds to:```
    ///// bbox.xMin = FLOOR(bbox.xMin);
    ///// bbox.yMin = FLOOR(bbox.yMin);
    ///// bbox.xMax = CEILING(bbox.xMax);
    ///// bbox.yMax = CEILING(bbox.yMax);
    ///// ```To get the bbox in pixel coordinates, set `bbox_mode` to
    ///// @FT _GLYPH_BBOX_TRUNCATE.To get the bbox in grid-fitted pixel coordinates, set `bbox_mode` to
    ///// @FT _GLYPH_BBOX_PIXELS.
    ///// </remarks>

    //public static unsafe delegate* <FT_Glyph,uint,ref FT_BBox,void> FT_Glyph_Get_CBox = (delegate* <FT_Glyph,uint,ref FT_BBox,void>)NativeLibrary.GetExport(Handle, "FT_Glyph_Get_CBox");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Glyph_To_Bitmap@description :
    ///// Convert a given glyph object to a bitmap glyph object.@inout :
    ///// the_glyph ::
    ///// A pointer to a handle to the target glyph.@input :
    ///// render_mode ::
    ///// An enumeration that describes how the data is rendered.origin ::
    ///// A pointer to a vector used to translate the glyph image before
    ///// rendering.  Can be~0 (if no translation).  The origin is expressed
    ///// in 26.6 pixels.destroy ::
    ///// A boolean that indicates that the original glyph image should be
    ///// destroyed by this function.  It is never destroyed in case of error.@note :
    ///// This function does nothing if the glyph format isn't scalable.The glyph image is translated with the `origin` vector before
    ///// rendering.The first parameter is a pointer to an @FT _Glyph handle, that will be
    ///// _replaced_ by this function (with newly allocated data).  Typically,
    ///// you would use (omitting error handling):```
    ///// FT_Glyph        glyph;
    ///// FT_BitmapGlyph  glyph_bitmap;// load glyph
    ///// error = FT_Load_Char( face, glyph_index, FT_LOAD_DEFAULT );// extract glyph image
    ///// error = FT_Get_Glyph( face-&gt;glyph, 
    ///// &amp;glyph
    ///// );// convert to a bitmap (default render mode + destroying old)
    ///// if ( glyph-&gt;format != FT_GLYPH_FORMAT_BITMAP )
    ///// {
    ///// error = FT_Glyph_To_Bitmap( 
    ///// &amp;glyph
    ///// , FT_RENDER_MODE_NORMAL,
    ///// 0, 1 );
    ///// if ( error ) // `glyph' unchanged
    ///// ...
    ///// }// access bitmap content by typecasting
    ///// glyph_bitmap = (FT_BitmapGlyph)glyph;// do funny stuff with it, like blitting/drawing
    ///// ...// discard glyph image (bitmap or not)
    ///// FT_Done_Glyph( glyph );
    ///// ```Here is another example, again without error handling:```
    ///// FT_Glyph  glyphs[MAX_GLYPHS]...for ( idx = 0; i 
    ///// &lt;
    ///// MAX_GLYPHS; i++ )
    ///// error = FT_Load_Glyph( face, idx, FT_LOAD_DEFAULT ) ||
    ///// FT_Get_Glyph ( face-&gt;glyph, 
    ///// &amp;glyphs
    ///// [idx] );...for ( idx = 0; i 
    ///// &lt;
    ///// MAX_GLYPHS; i++ )
    ///// {
    ///// FT_Glyph  bitmap = glyphs[idx];...// after this call, `bitmap' no longer points into
    ///// // the `glyphs' array (and the old value isn't destroyed)
    ///// FT_Glyph_To_Bitmap( 
    ///// &amp;bitmap
    ///// , FT_RENDER_MODE_MONO, 0, 0 );...FT_Done_Glyph( bitmap );
    ///// }...for ( idx = 0; i 
    ///// &lt;
    ///// MAX_GLYPHS; i++ )
    ///// FT_Done_Glyph( glyphs[idx] );
    ///// ```
    ///// </remarks>

    //public static unsafe delegate* <ref FT_Glyph,FT_Render_Mode,ref FT_Vector,FT_Bool,FT_Error> FT_Glyph_To_Bitmap = (delegate* <ref FT_Glyph,FT_Render_Mode,ref FT_Vector,FT_Bool,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Glyph_To_Bitmap");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <remarks>
    ///// :FT_Done_Glyph@description :
    ///// Destroy a given glyph.@input :
    ///// glyph ::
    ///// A handle to the target glyph object.
    ///// </remarks>

    //public static unsafe delegate* <FT_Glyph,void> FT_Done_Glyph = (delegate* <FT_Glyph,void>)NativeLibrary.GetExport(Handle, "FT_Done_Glyph");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <remarks>
    ///// :FT_Matrix_Multiply@description :
    ///// Perform the matrix operation `b = a*b`.@input :
    ///// a ::
    ///// A pointer to matrix `a`.@inout :
    ///// b ::
    ///// A pointer to matrix `b`.@note :
    ///// The result is undefined if either `a` or `b` is zero.Since the function uses wrap-around arithmetic, results become
    ///// meaningless if the arguments are very large.
    ///// </remarks>

    //public static unsafe delegate* <ref FT_Matrix,ref FT_Matrix,void> FT_Matrix_Multiply = (delegate* <ref FT_Matrix,ref FT_Matrix,void>)NativeLibrary.GetExport(Handle, "FT_Matrix_Multiply");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Matrix_Invert@description :
    ///// Invert a 2x2 matrix.  Return an error if it can't be inverted.@inout :
    ///// matrix ::
    ///// A pointer to the target matrix.  Remains untouched in case of error.
    ///// </remarks>

    //public static unsafe delegate* <ref FT_Matrix,FT_Error> FT_Matrix_Invert = (delegate* <ref FT_Matrix,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Matrix_Invert");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// A renderer handle.  0~if none found.</returns>
    ///// <remarks>
    ///// :FT_Get_Renderer@description :
    ///// Retrieve the current renderer for a given glyph format.@input :
    ///// library ::
    ///// A handle to the library object.format ::
    ///// The glyph format.@note :
    ///// An error will be returned if a module already exists by that name, or
    ///// if the module requires a version of FreeType that is too great.To add a new renderer, simply use @FT _Add_Module.  To retrieve a
    ///// renderer by its name, use @FT _Get_Module.
    ///// </remarks>

    //public static unsafe delegate* <FT_Library,FT_Glyph_Format,FT_Renderer> FT_Get_Renderer = (delegate* <FT_Library,FT_Glyph_Format,FT_Renderer>)NativeLibrary.GetExport(Handle, "FT_Get_Renderer");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Set_Renderer@description :
    ///// Set the current renderer to use, and set additional mode.@inout :
    ///// library ::
    ///// A handle to the library object.@input :
    ///// renderer ::
    ///// A handle to the renderer object.num_params ::
    ///// The number of additional parameters.parameters ::
    ///// Additional parameters.@note :
    ///// In case of success, the renderer will be used to convert glyph images
    ///// in the renderer's known format into bitmaps.This doesn't change the current renderer for other formats.Currently, no FreeType renderer module uses `parameters`; you should
    ///// thus always pass `NULL` as the value.
    ///// </remarks>

    //public static unsafe delegate* <FT_Library,FT_Renderer,uint,ref FT_Parameter,FT_Error> FT_Set_Renderer = (delegate* <FT_Library,FT_Renderer,uint,ref FT_Parameter,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Set_Renderer");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// Boolean.  True if glyph names are reliable.</returns>
    ///// <remarks>
    ///// :FT_Has_PS_Glyph_Names@description :
    ///// Return true if a given face provides reliable PostScript glyph names.
    ///// This is similar to using the @FT _HAS_GLYPH_NAMES macro, except that
    ///// certain fonts (mostly TrueType) contain incorrect glyph name tables.When this function returns true, the caller is sure that the glyph
    ///// names returned by @FT _Get_Glyph_Name are reliable.@input :
    ///// face ::
    ///// face handle
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,int> FT_Has_PS_Glyph_Names = (delegate* <FT_Face,int>)NativeLibrary.GetExport(Handle, "FT_Has_PS_Glyph_Names");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Get_PS_Font_Info@description :
    ///// Retrieve the @PS _FontInfoRec structure corresponding to a given
    ///// PostScript font.@input :
    ///// face ::
    ///// PostScript face handle.@output :
    ///// afont_info ::
    ///// Output font info structure pointer.@note :
    ///// String pointers within the @PS _FontInfoRec structure are owned by the
    ///// face and don't need to be freed by the caller.  Missing entries in
    ///// the font's FontInfo dictionary are represented by `NULL` pointers.If the font's format is not PostScript-based, this function will
    ///// return the `FT_Err_Invalid_Argument` error code.
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,PS_FontInfo,FT_Error> FT_Get_PS_Font_Info = (delegate* <FT_Face,PS_FontInfo,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Get_PS_Font_Info");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Get_PS_Font_Private@description :
    ///// Retrieve the @PS _PrivateRec structure corresponding to a given
    ///// PostScript font.@input :
    ///// face ::
    ///// PostScript face handle.@output :
    ///// afont_private ::
    ///// Output private dictionary structure pointer.@note :
    ///// The string pointers within the @PS _PrivateRec structure are owned by
    ///// the face and don't need to be freed by the caller.If the font's format is not PostScript-based, this function returns
    ///// the `FT_Err_Invalid_Argument` error code.
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,PS_Private,FT_Error> FT_Get_PS_Font_Private = (delegate* <FT_Face,PS_Private,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Get_PS_Font_Private");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// The amount of memory (in bytes) required to hold the requested value
    ///// (if it exists, -1 otherwise).</returns>
    ///// <remarks>
    ///// :FT_Get_PS_Font_Value@description :
    ///// Retrieve the value for the supplied key from a PostScript font.@input :
    ///// face ::
    ///// PostScript face handle.key ::
    ///// An enumeration value representing the dictionary key to retrieve.idx ::
    ///// For array values, this specifies the index to be returned.value ::
    ///// A pointer to memory into which to write the value.valen_len ::
    ///// The size, in bytes, of the memory supplied for the value.@output :
    ///// value ::
    ///// The value matching the above key, if it exists.@note :
    ///// The values returned are not pointers into the internal structures of
    ///// the face, but are 'fresh' copies, so that the memory containing them
    ///// belongs to the calling application.  This also enforces the
    ///// 'read-only' nature of these values, i.e., this function cannot be
    ///// used to manipulate the face.`value` is a void pointer because the values returned can be of
    ///// various types.If either `value` is `NULL` or `value_len` is too small, just the
    ///// required memory size for the requested entry is returned.The `idx` parameter is used, not only to retrieve elements of, for
    ///// example, the FontMatrix or FontBBox, but also to retrieve name keys
    ///// from the CharStrings dictionary, and the charstrings themselves.  It
    ///// is ignored for atomic values.`PS_DICT_BLUE_SCALE` returns a value that is scaled up by 1000.  To
    ///// get the value as in the font stream, you need to divide by 65536000.0
    ///// (to remove the FT_Fixed scale, and the x1000 scale).IMPORTANT: Only key/value pairs read by the FreeType interpreter can
    ///// be retrieved.  So, for example, PostScript procedures such as NP, ND,
    ///// and RD are not available.  Arbitrary keys are, obviously, not be
    ///// available either.If the font's format is not PostScript-based, this function returns
    ///// the `FT_Err_Invalid_Argument` error code.@since :
    ///// 2.4.8
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,PS_Dict_Keys,uint,nint,CLong,CLong> FT_Get_PS_Font_Value = (delegate* <FT_Face,PS_Dict_Keys,uint,nint,CLong,CLong>)NativeLibrary.GetExport(Handle, "FT_Get_PS_Font_Value");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// A type-less pointer to the table.  This will be `NULL` in case of
    ///// error, or if the corresponding table was not found **OR** loaded from
    ///// the file.</returns>
    ///// <remarks>
    ///// :FT_Get_Sfnt_Table@description :
    ///// Return a pointer to a given SFNT table stored within a face.@input :
    ///// face ::
    ///// A handle to the source.tag ::
    ///// The index of the SFNT table.Use a typecast according to `tag` to access the structure elements.@note :
    ///// The table is owned by the face object and disappears with it.This function is only useful to access SFNT tables that are loaded by
    ///// the sfnt, truetype, and opentype drivers.  See @FT _Sfnt_Tag for a
    ///// list.@example :
    ///// Here is an example demonstrating access to the 'vhea' table.```
    ///// TT_VertHeader*  vert_header;vert_header =
    ///// (TT_VertHeader*)FT_Get_Sfnt_Table( face, FT_SFNT_VHEA );
    ///// ```
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,FT_Sfnt_Tag,nint> FT_Get_Sfnt_Table = (delegate* <FT_Face,FT_Sfnt_Tag,nint>)NativeLibrary.GetExport(Handle, "FT_Get_Sfnt_Table");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Load_Sfnt_Table@description :
    ///// Load any SFNT font table into client memory.@input :
    ///// face ::
    ///// A handle to the source face.tag ::
    ///// The four-byte tag of the table to load.  Use value~0 if you want to
    ///// access the whole font file.  Otherwise, you can use one of the
    ///// definitions found in the @FT _TRUETYPE_TAGS_H file, or forge a new
    ///// one with @FT _MAKE_TAG.offset ::
    ///// The starting offset in the table (or file if tag~==~0).@output :
    ///// buffer ::
    ///// The target buffer address.  The client must ensure that the memory
    ///// array is big enough to hold the data.@inout :
    ///// length ::
    ///// If the `length` parameter is `NULL`, try to load the whole table.
    ///// Return an error code if it fails.Else, if `*length` is~0, exit immediately while returning the
    ///// table's (or file) full size in it.Else the number of bytes to read from the table or file, from the
    ///// starting offset.@note :
    ///// If you need to determine the table's length you should first call this
    ///// function with `*length` set to~0, as in the following example:```
    ///// CULong  length = 0;error = FT_Load_Sfnt_Table( face, tag, 0, NULL, 
    ///// &amp;length
    ///// );
    ///// if ( error ) { ... table does not exist ... }buffer = malloc( length );
    ///// if ( buffer == NULL ) { ... not enough memory ... }error = FT_Load_Sfnt_Table( face, tag, 0, buffer, 
    ///// &amp;length
    ///// );
    ///// if ( error ) { ... could not load table ... }
    ///// ```Note that structures like @TT _Header or @TT _OS2 can't be used with
    ///// this function; they are limited to @FT _Get_Sfnt_Table.  Reason is that
    ///// those structures depend on the processor architecture, with varying
    ///// size (e.g. 32bit vs. 64bit) or order (big endian vs. little endian).
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,CULong,CLong,ref byte,ref CULong,FT_Error> _FT_Load_Sfnt_Table = (delegate* <FT_Face,CULong,CLong,ref byte,ref CULong,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Load_Sfnt_Table");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Sfnt_Table_Info@description :
    ///// Return information on an SFNT table.@input :
    ///// face ::
    ///// A handle to the source face.table_index ::
    ///// The index of an SFNT table.  The function returns
    ///// FT_Err_Table_Missing for an invalid value.@inout :
    ///// tag ::
    ///// The name tag of the SFNT table.  If the value is `NULL`,
    ///// `table_index` is ignored, and `length` returns the number of SFNT
    ///// tables in the font.@output :
    ///// length ::
    ///// The length of the SFNT table (or the number of SFNT tables,
    ///// depending on `tag`).@note :
    ///// While parsing fonts, FreeType handles SFNT tables with length zero as
    ///// missing.
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,uint,ref CULong,ref CULong,FT_Error> FT_Sfnt_Table_Info = (delegate* <FT_Face,uint,ref CULong,ref CULong,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Sfnt_Table_Info");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// The language ID of `charmap`.  If `charmap` doesn't belong to an SFNT
    ///// face, just return~0 as the default value.</returns>
    ///// <remarks>
    ///// :FT_Get_CMap_Language_ID@description :
    ///// Return cmap language ID as specified in the OpenType standard.
    ///// Definitions of language ID values are in file @FT _TRUETYPE_IDS_H.@input :
    ///// charmap ::
    ///// The target charmap.For a format~14 cmap (to access Unicode IVS), the return value is
    ///// 0xFFFFFFFF.
    ///// </remarks>

    //public static unsafe delegate* <FT_CharMap,CULong> FT_Get_CMap_Language_ID = (delegate* <FT_CharMap,CULong>)NativeLibrary.GetExport(Handle, "FT_Get_CMap_Language_ID");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// The format of `charmap`.  If `charmap` doesn't belong to an SFNT face,
    ///// return -1.</returns>
    ///// <remarks>
    ///// :FT_Get_CMap_Format@description :
    ///// Return the format of an SFNT 'cmap' table.@input :
    ///// charmap ::
    ///// The target charmap.
    ///// </remarks>

    //public static unsafe delegate* <FT_CharMap,CLong> FT_Get_CMap_Format = (delegate* <FT_CharMap,CLong>)NativeLibrary.GetExport(Handle, "FT_Get_CMap_Format");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Get_BDF_Charset_ID@description :
    ///// Retrieve a BDF font character set identity, according to the BDF
    ///// specification.@input :
    ///// face ::
    ///// A handle to the input face.@output :
    ///// acharset_encoding ::
    ///// Charset encoding, as a C~string, owned by the face.acharset_registry ::
    ///// Charset registry, as a C~string, owned by the face.@note :
    ///// This function only works with BDF faces, returning an error otherwise.
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,out nint,out nint,FT_Error> FT_Get_BDF_Charset_ID = (delegate* <FT_Face,out nint,out nint,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Get_BDF_Charset_ID");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Get_BDF_Property@description :
    ///// Retrieve a BDF property from a BDF or PCF font file.@input :
    ///// face ::
    ///// A handle to the input face.name ::
    ///// The property name.@output :
    ///// aproperty ::
    ///// The property.@note :
    ///// This function works with BDF _and_ PCF fonts.  It returns an error
    ///// otherwise.  It also returns an error if the property is not in the
    ///// font.A 'property' is a either key-value pair within the STARTPROPERTIES
    ///// ... ENDPROPERTIES block of a BDF font or a key-value pair from the
    ///// `info-&gt;props` array within a `FontRec` structure of a PCF font.Integer properties are always stored as 'signed' within PCF fonts;
    ///// consequently, @BDF _PROPERTY_TYPE_CARDINAL is a possible return value
    ///// for BDF fonts only.In case of error, `aproperty-&gt;type` is always set to
    ///// @BDF _PROPERTY_TYPE_NONE.
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,nint,ref BDF_PropertyRec,FT_Error> FT_Get_BDF_Property = (delegate* <FT_Face,nint,ref BDF_PropertyRec,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Get_BDF_Property");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Get_CID_Registry_Ordering_Supplement@description :
    ///// Retrieve the Registry/Ordering/Supplement triple (also known as the
    ///// "R/O/S") from a CID-keyed font.@input :
    ///// face ::
    ///// A handle to the input face.@output :
    ///// registry ::
    ///// The registry, as a C~string, owned by the face.ordering ::
    ///// The ordering, as a C~string, owned by the face.supplement ::
    ///// The supplement.@note :
    ///// This function only works with CID faces, returning an error
    ///// otherwise.@since :
    ///// 2.3.6
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,out nint,out nint,ref int,FT_Error> FT_Get_CID_Registry_Ordering_Supplement = (delegate* <FT_Face,out nint,out nint,ref int,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Get_CID_Registry_Ordering_Supplement");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Get_CID_Is_Internally_CID_Keyed@description :
    ///// Retrieve the type of the input face, CID keyed or not.  In contrast
    ///// to the @FT _IS_CID_KEYED macro this function returns successfully also
    ///// for CID-keyed fonts in an SFNT wrapper.@input :
    ///// face ::
    ///// A handle to the input face.@output :
    ///// is_cid ::
    ///// The type of the face as an @FT _Bool.@note :
    ///// This function only works with CID faces and OpenType fonts, returning
    ///// an error otherwise.@since :
    ///// 2.3.9
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,ref FT_Bool,FT_Error> FT_Get_CID_Is_Internally_CID_Keyed = (delegate* <FT_Face,ref FT_Bool,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Get_CID_Is_Internally_CID_Keyed");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Get_CID_From_Glyph_Index@description :
    ///// Retrieve the CID of the input glyph index.@input :
    ///// face ::
    ///// A handle to the input face.glyph_index ::
    ///// The input glyph index.@output :
    ///// cid ::
    ///// The CID as an @FT _UInt.@note :
    ///// This function only works with CID faces and OpenType fonts, returning
    ///// an error otherwise.@since :
    ///// 2.3.9
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,uint,ref uint,FT_Error> FT_Get_CID_From_Glyph_Index = (delegate* <FT_Face,uint,ref uint,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Get_CID_From_Glyph_Index");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Stream_OpenGzip@description :
    ///// Open a new stream to parse gzip-compressed font files.  This is mainly
    ///// used to support the compressed `*.pcf.gz` fonts that come with
    ///// XFree86.@input :
    ///// stream ::
    ///// The target embedding stream.source ::
    ///// The source stream.@note :
    ///// The source stream must be opened _before_ calling this function.Calling the internal function `FT_Stream_Close` on the new stream will
    ///// **not** call `FT_Stream_Close` on the source stream.  None of the
    ///// stream objects will be released to the heap.This function may return `FT_Err_Unimplemented_Feature` if your build
    ///// of FreeType was not compiled with zlib support.
    ///// </remarks>

    //public static unsafe delegate* <FT_Stream,FT_Stream,FT_Error> FT_Stream_OpenGzip = (delegate* <FT_Stream,FT_Stream,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Stream_OpenGzip");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Gzip_Uncompress@description :
    ///// Decompress a zipped input buffer into an output buffer.  This function
    ///// is modeled after zlib's `uncompress` function.@input :
    ///// memory ::
    ///// A FreeType memory handle.input ::
    ///// The input buffer.input_len ::
    ///// The length of the input buffer.@output :
    ///// output ::
    ///// The output buffer.@inout :
    ///// output_len ::
    ///// Before calling the function, this is the total size of the output
    ///// buffer, which must be large enough to hold the entire uncompressed
    ///// data (so the size of the uncompressed data must be known in
    ///// advance).  After calling the function, `output_len` is the size of
    ///// the used data in `output`.@note :
    ///// This function may return `FT_Err_Unimplemented_Feature` if your build
    ///// of FreeType was not compiled with zlib support.@since :
    ///// 2.5.1
    ///// </remarks>

    //public static unsafe delegate* <FT_Memory,ref byte,ref CULong,ref byte,CULong,FT_Error> FT_Gzip_Uncompress = (delegate* <FT_Memory,ref byte,ref CULong,ref byte,CULong,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Gzip_Uncompress");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Stream_OpenLZW@description :
    ///// Open a new stream to parse LZW-compressed font files.  This is mainly
    ///// used to support the compressed `*.pcf.Z` fonts that come with XFree86.@input :
    ///// stream ::
    ///// The target embedding stream.source ::
    ///// The source stream.@note :
    ///// The source stream must be opened _before_ calling this function.Calling the internal function `FT_Stream_Close` on the new stream will
    ///// **not** call `FT_Stream_Close` on the source stream.  None of the
    ///// stream objects will be released to the heap.This function may return `FT_Err_Unimplemented_Feature` if your build
    ///// of FreeType was not compiled with LZW support.
    ///// </remarks>

    //public static unsafe delegate* <FT_Stream,FT_Stream,FT_Error> FT_Stream_OpenLZW = (delegate* <FT_Stream,FT_Stream,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Stream_OpenLZW");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Stream_OpenBzip2@description :
    ///// Open a new stream to parse bzip2-compressed font files.  This is
    ///// mainly used to support the compressed `*.pcf.bz2` fonts that come with
    ///// XFree86.@input :
    ///// stream ::
    ///// The target embedding stream.source ::
    ///// The source stream.@note :
    ///// The source stream must be opened _before_ calling this function.Calling the internal function `FT_Stream_Close` on the new stream will
    ///// **not** call `FT_Stream_Close` on the source stream.  None of the
    ///// stream objects will be released to the heap.This function may return `FT_Err_Unimplemented_Feature` if your build
    ///// of FreeType was not compiled with bzip2 support.
    ///// </remarks>

    //public static unsafe delegate* <FT_Stream,FT_Stream,FT_Error> FT_Stream_OpenBzip2 = (delegate* <FT_Stream,FT_Stream,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Stream_OpenBzip2");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Get_WinFNT_Header@description :
    ///// Retrieve a Windows FNT font info header.@input :
    ///// face ::
    ///// A handle to the input face.@output :
    ///// aheader ::
    ///// The WinFNT header.@note :
    ///// This function only works with Windows FNT faces, returning an error
    ///// otherwise.
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,ref FT_WinFNT_HeaderRec,FT_Error> FT_Get_WinFNT_Header = (delegate* <FT_Face,ref FT_WinFNT_HeaderRec,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Get_WinFNT_Header");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Palette_Data_Get@description :
    ///// Retrieve the face's color palette data.@input :
    ///// face ::
    ///// The source face handle.@output :
    ///// apalette ::
    ///// A pointer to an @FT _Palette_Data structure.@note :
    ///// All arrays in the returned @FT _Palette_Data structure are read-only.This function always returns an error if the config macro
    ///// `TT_CONFIG_OPTION_COLOR_LAYERS` is not defined in `ftoption.h`.@since :
    ///// 2.10
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,ref FT_Palette_Data,FT_Error> FT_Palette_Data_Get = (delegate* <FT_Face,ref FT_Palette_Data,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Palette_Data_Get");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Palette_Select@description :
    ///// This function has two purposes.(1) It activates a palette for rendering color glyphs, and(2) it retrieves all (unmodified) color entries of this palette.  This
    ///// function returns a read-write array, which means that a calling
    ///// application can modify the palette entries on demand.A corollary of (2) is that calling the function, then modifying some
    ///// values, then calling the function again with the same arguments resets
    ///// all color entries to the original 'CPAL' values; all user modifications
    ///// are lost.@input :
    ///// face ::
    ///// The source face handle.palette_index ::
    ///// The palette index.@output :
    ///// apalette ::
    ///// An array of color entries for a palette with index `palette_index`,
    ///// having `num_palette_entries` elements (as found in the
    ///// `FT_Palette_Data` structure).  If `apalette` is set to `NULL`, no
    ///// array gets returned (and no color entries can be modified).In case the font doesn't support color palettes, `NULL` is returned.@note :
    ///// The array pointed to by `apalette_entries` is owned and managed by
    ///// FreeType.This function always returns an error if the config macro
    ///// `TT_CONFIG_OPTION_COLOR_LAYERS` is not defined in `ftoption.h`.@since :
    ///// 2.10
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,ushort,out nint,FT_Error> FT_Palette_Select = (delegate* <FT_Face,ushort,out nint,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Palette_Select");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Palette_Set_Foreground_Color@description :
    ///// 'COLR' uses palette index 0xFFFF to indicate a 'text foreground
    ///// color'.  This function sets this value.@input :
    ///// face ::
    ///// The source face handle.foreground_color ::
    ///// An `FT_Color` structure to define the text foreground color.@note :
    ///// If this function isn't called, the text foreground color is set to
    ///// white opaque (BGRA value 0xFFFFFFFF) if
    ///// @FT _PALETTE_FOR_DARK_BACKGROUND is present for the current palette,
    ///// and black opaque (BGRA value 0x000000FF) otherwise, including the case
    ///// that no palette types are available in the 'CPAL' table.This function always returns an error if the config macro
    ///// `TT_CONFIG_OPTION_COLOR_LAYERS` is not defined in `ftoption.h`.@since :
    ///// 2.10
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,FT_Color,FT_Error> FT_Palette_Set_Foreground_Color = (delegate* <FT_Face,FT_Color,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Palette_Set_Foreground_Color");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// Value~1 if everything is OK.  If there are no more layers (or if there
    ///// are no layers at all), value~0 gets returned.  In case of an error,
    ///// value~0 is returned also.</returns>
    ///// <remarks>
    ///// :FT_Get_Color_Glyph_Layer@description :
    ///// This is an interface to the 'COLR' table in OpenType fonts to
    ///// iteratively retrieve the colored glyph layers associated with the
    ///// current glyph slot.https://docs.microsoft.com/en-us/typography/opentype/spec/colrThe glyph layer data for a given glyph index, if present, provides an
    ///// alternative, multi-color glyph representation: Instead of rendering
    ///// the outline or bitmap with the given glyph index, glyphs with the
    ///// indices and colors returned by this function are rendered layer by
    ///// layer.The returned elements are ordered in the z~direction from bottom to
    ///// top; the 'n'th element should be rendered with the associated palette
    ///// color and blended on top of the already rendered layers (elements 0,
    ///// 1, ..., n-1).@input :
    ///// face ::
    ///// A handle to the parent face object.base_glyph ::
    ///// The glyph index the colored glyph layers are associated with.@inout :
    ///// iterator ::
    ///// An @FT _LayerIterator object.  For the first call you should set
    ///// `iterator-&gt;p` to `NULL`.  For all following calls, simply use the
    ///// same object again.@output :
    ///// aglyph_index ::
    ///// The glyph index of the current layer.acolor_index ::
    ///// The color index into the font face's color palette of the current
    ///// layer.  The value 0xFFFF is special; it doesn't reference a palette
    ///// entry but indicates that the text foreground color should be used
    ///// instead (to be set up by the application outside of FreeType).The color palette can be retrieved with @FT _Palette_Select.@note :
    ///// This function is necessary if you want to handle glyph layers by
    ///// yourself.  In particular, functions that operate with @FT _GlyphRec
    ///// objects (like @FT _Get_Glyph or @FT _Glyph_To_Bitmap) don't have access
    ///// to this information.Note that @FT _Render_Glyph is able to handle colored glyph layers
    ///// automatically if the @FT _LOAD_COLOR flag is passed to a previous call
    ///// to @FT _Load_Glyph.  [This is an experimental feature.]@example :
    ///// ```
    ///// FT_Color*         palette;
    ///// FT_LayerIterator  iterator;FT_Bool  have_layers;
    ///// uint  layer_glyph_index;
    ///// uint  layer_color_index;error = FT_Palette_Select( face, palette_index, 
    ///// &amp;palette
    ///// );
    ///// if ( error )
    ///// palette = NULL;iterator.p  = NULL;
    ///// have_layers = FT_Get_Color_Glyph_Layer( face,
    ///// glyph_index,
    ///// &amp;layer
    ///// _glyph_index,
    ///// &amp;layer
    ///// _color_index,
    ///// &amp;iterator
    ///// );if ( palette 
    ///// &amp;
    ///// &amp;
    ///// have_layers )
    ///// {
    ///// do
    ///// {
    ///// FT_Color  layer_color;if ( layer_color_index == 0xFFFF )
    ///// layer_color = text_foreground_color;
    ///// else
    ///// layer_color = palette[layer_color_index];// Load and render glyph `layer_glyph_index', then
    ///// // blend resulting pixmap (using color `layer_color')
    ///// // with previously created pixmaps.} while ( FT_Get_Color_Glyph_Layer( face,
    ///// glyph_index,
    ///// &amp;layer
    ///// _glyph_index,
    ///// &amp;layer
    ///// _color_index,
    ///// &amp;iterator
    ///// ) );
    ///// }
    ///// ```
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,uint,ref uint,ref uint,ref FT_LayerIterator,FT_Bool> FT_Get_Color_Glyph_Layer = (delegate* <FT_Face,uint,ref uint,ref uint,ref FT_LayerIterator,FT_Bool>)NativeLibrary.GetExport(Handle, "FT_Get_Color_Glyph_Layer");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// Value~1 if everything is OK.  If no color glyph is found, or the root
    ///// paint could not be retrieved, value~0 gets returned.  In case of an
    ///// error, value~0 is returned also.</returns>
    ///// <remarks>
    ///// :FT_Get_Color_Glyph_Paint@description :
    ///// This is the starting point and interface to color gradient
    ///// information in a 'COLR' v1 table in OpenType fonts to recursively
    ///// retrieve the paint tables for the directed acyclic graph of a colored
    ///// glyph, given a glyph ID.https://github.com/googlefonts/colr-gradients-specIn a 'COLR' v1 font, each color glyph defines a directed acyclic
    ///// graph of nested paint tables, such as `PaintGlyph`, `PaintSolid`,
    ///// `PaintLinearGradient`, `PaintRadialGradient`, and so on.  Using this
    ///// function and specifying a glyph ID, one retrieves the root paint
    ///// table for this glyph ID.This function allows control whether an initial root transform is
    ///// returned to configure scaling, transform, and translation correctly
    ///// on the client's graphics context.  The initial root transform is
    ///// computed and returned according to the values configured for @FT _Size
    ///// and @FT _Set_Transform on the @FT _Face object, see below for details
    ///// of the `root_transform` parameter.  This has implications for a
    ///// client 'COLR' v1 implementation: When this function returns an
    ///// initially computed root transform, at the time of executing the
    ///// @FT _PaintGlyph operation, the contours should be retrieved using
    ///// @FT _Load_Glyph at unscaled, untransformed size.  This is because the
    ///// root transform applied to the graphics context will take care of
    ///// correct scaling.Alternatively, to allow hinting of contours, at the time of executing
    ///// @FT _Load_Glyph, the current graphics context transformation matrix
    ///// can be decomposed into a scaling matrix and a remainder, and
    ///// @FT _Load_Glyph can be used to retrieve the contours at scaled size.
    ///// Care must then be taken to blit or clip to the graphics context with
    ///// taking this remainder transformation into account.@input :
    ///// face ::
    ///// A handle to the parent face object.base_glyph ::
    ///// The glyph index for which to retrieve the root paint table.root_transform ::
    ///// Specifies whether an initially computed root is returned by the
    ///// @FT _PaintTransform operation to account for the activated size
    ///// (see @FT _Activate_Size) and the configured transform and translate
    ///// (see @FT _Set_Transform).This root transform is returned before nodes of the glyph graph of
    ///// the font are returned.  Subsequent @FT _COLR_Paint structures
    ///// contain unscaled and untransformed values.  The inserted root
    ///// transform enables the client application to apply an initial
    ///// transform to its graphics context.  When executing subsequent
    ///// FT_COLR_Paint operations, values from @FT _COLR_Paint operations
    ///// will ultimately be correctly scaled because of the root transform
    ///// applied to the graphics context.  Use
    ///// @FT _COLOR_INCLUDE_ROOT_TRANSFORM to include the root transform, use
    ///// @FT _COLOR_NO_ROOT_TRANSFORM to not include it.  The latter may be
    ///// useful when traversing the 'COLR' v1 glyph graph and reaching a
    ///// @FT _PaintColrGlyph.  When recursing into @FT _PaintColrGlyph and
    ///// painting that inline, no additional root transform is needed as it
    ///// has already been applied to the graphics context at the beginning
    ///// of drawing this glyph.@output :
    ///// paint ::
    ///// The @FT _OpaquePaint object that references the actual paint table.The respective actual @FT _COLR_Paint object is retrieved via
    ///// @FT _Get_Paint.@since :
    ///// 2.11 -- **currently experimental only!**  There might be changes
    ///// without retaining backward compatibility of both the API and ABI.
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,uint,FT_Color_Root_Transform,ref FT_OpaquePaint,FT_Bool> FT_Get_Color_Glyph_Paint = (delegate* <FT_Face,uint,FT_Color_Root_Transform,ref FT_OpaquePaint,FT_Bool>)NativeLibrary.GetExport(Handle, "FT_Get_Color_Glyph_Paint");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// Value~1 if a clip box is found.  If no clip box is found or an error
    ///// occured, value~0 is returned.</returns>
    ///// <remarks>
    ///// :FT_Get_Color_Glyph_ClipBox@description :
    ///// Search for a 'COLR' v1 clip box for the specified `base_glyph` and
    ///// fill the `clip_box` parameter with the 'COLR' v1 'ClipBox' information
    ///// if one is found.@input :
    ///// face ::
    ///// A handle to the parent face object.base_glyph ::
    ///// The glyph index for which to retrieve the clip box.@output :
    ///// clip_box ::
    ///// The clip box for the requested `base_glyph` if one is found.  The
    ///// clip box is computed taking scale and transformations configured on
    ///// the @FT _Face into account.  @FT _ClipBox contains @FT _Vector values
    ///// in 26.6 format.@note :
    ///// To retrieve the clip box in font units, reset scale to units-per-em
    ///// and remove transforms configured using @FT _Set_Transform.@since :
    ///// 2.12 -- **currently experimental only!**  There might be changes
    ///// without retaining backward compatibility of both the API and ABI.
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,uint,ref FT_ClipBox,FT_Bool> FT_Get_Color_Glyph_ClipBox = (delegate* <FT_Face,uint,ref FT_ClipBox,FT_Bool>)NativeLibrary.GetExport(Handle, "FT_Get_Color_Glyph_ClipBox");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// Value~1 if everything is OK.  Value~0 gets returned when the paint
    ///// object can not be retrieved or any other error occurs.</returns>
    ///// <remarks>
    ///// :FT_Get_Paint_Layers@description :
    ///// Access the layers of a `PaintColrLayers` table.If the root paint of a color glyph, or a nested paint of a 'COLR'
    ///// glyph is a `PaintColrLayers` table, this function retrieves the
    ///// layers of the `PaintColrLayers` table.The @FT _PaintColrLayers object contains an @FT _LayerIterator, which
    ///// is used here to iterate over the layers.  Each layer is returned as
    ///// an @FT _OpaquePaint object, which then can be used with @FT _Get_Paint
    ///// to retrieve the actual paint object.@input :
    ///// face ::
    ///// A handle to the parent face object.@inout :
    ///// iterator ::
    ///// The @FT _LayerIterator from an @FT _PaintColrLayers object, for which
    ///// the layers are to be retrieved.  The internal state of the iterator
    ///// is incremented after one call to this function for retrieving one
    ///// layer.@output :
    ///// paint ::
    ///// The @FT _OpaquePaint object that references the actual paint table.
    ///// The respective actual @FT _COLR_Paint object is retrieved via
    ///// @FT _Get_Paint.@since :
    ///// 2.11 -- **currently experimental only!**  There might be changes
    ///// without retaining backward compatibility of both the API and ABI.
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,ref FT_LayerIterator,ref FT_OpaquePaint,FT_Bool> FT_Get_Paint_Layers = (delegate* <FT_Face,ref FT_LayerIterator,ref FT_OpaquePaint,FT_Bool>)NativeLibrary.GetExport(Handle, "FT_Get_Paint_Layers");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// Value~1 if everything is OK.  If there are no more color stops,
    ///// value~0 gets returned.  In case of an error, value~0 is returned
    ///// also.</returns>
    ///// <remarks>
    ///// :FT_Get_Colorline_Stops@description :
    ///// This is an interface to color gradient information in a 'COLR' v1
    ///// table in OpenType fonts to iteratively retrieve the gradient and
    ///// solid fill information for colored glyph layers for a specified glyph
    ///// ID.https://github.com/googlefonts/colr-gradients-spec@input :
    ///// face ::
    ///// A handle to the parent face object.@inout :
    ///// iterator ::
    ///// The retrieved @FT _ColorStopIterator, configured on an @FT _ColorLine,
    ///// which in turn got retrieved via paint information in
    ///// @FT _PaintLinearGradient or @FT _PaintRadialGradient.@output :
    ///// color_stop ::
    ///// Color index and alpha value for the retrieved color stop.@since :
    ///// 2.11 -- **currently experimental only!**  There might be changes
    ///// without retaining backward compatibility of both the API and ABI.
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,ref FT_ColorStop,ref FT_ColorStopIterator,FT_Bool> FT_Get_Colorline_Stops = (delegate* <FT_Face,ref FT_ColorStop,ref FT_ColorStopIterator,FT_Bool>)NativeLibrary.GetExport(Handle, "FT_Get_Colorline_Stops");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// Value~1 if everything is OK.  Value~0 if no details can be found for
    ///// this paint or any other error occured.</returns>
    ///// <remarks>
    ///// :FT_Get_Paint@description :
    ///// Access the details of a paint using an @FT _OpaquePaint opaque paint
    ///// object, which internally stores the offset to the respective `Paint`
    ///// object in the 'COLR' table.@input :
    ///// face ::
    ///// A handle to the parent face object.opaque_paint ::
    ///// The opaque paint object for which the underlying @FT _COLR_Paint
    ///// data is to be retrieved.@output :
    ///// paint ::
    ///// The specific @FT _COLR_Paint object containing information coming
    ///// from one of the font's `Paint*` tables.@since :
    ///// 2.11 -- **currently experimental only!**  There might be changes
    ///// without retaining backward compatibility of both the API and ABI.
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,FT_OpaquePaint,ref FT_COLR_Paint,FT_Bool> FT_Get_Paint = (delegate* <FT_Face,FT_OpaquePaint,ref FT_COLR_Paint,FT_Bool>)NativeLibrary.GetExport(Handle, "FT_Get_Paint");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <remarks>
    ///// :FT_Bitmap_Init@description :
    ///// Initialize a pointer to an @FT _Bitmap structure.@inout :
    ///// abitmap ::
    ///// A pointer to the bitmap structure.@note :
    ///// A deprecated name for the same function is `FT_Bitmap_New`.
    ///// </remarks>

    //public static unsafe delegate* <ref FT_Bitmap,void> FT_Bitmap_Init = (delegate* <ref FT_Bitmap,void>)NativeLibrary.GetExport(Handle, "FT_Bitmap_Init");

    ///// <summary>
    ///// deprecated
    ///// </summary>

    //public static unsafe delegate* <ref FT_Bitmap,void> FT_Bitmap_New = (delegate* <ref FT_Bitmap,void>)NativeLibrary.GetExport(Handle, "FT_Bitmap_New");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Bitmap_Copy@description :
    ///// Copy a bitmap into another one.@input :
    ///// library ::
    ///// A handle to a library object.source ::
    ///// A handle to the source bitmap.@output :
    ///// target ::
    ///// A handle to the target bitmap.@note :
    ///// `source-&gt;buffer` and `target-&gt;buffer` must neither be equal nor
    ///// overlap.
    ///// </remarks>

    //public static unsafe delegate* <FT_Library,ref FT_Bitmap,ref FT_Bitmap,FT_Error> FT_Bitmap_Copy = (delegate* <FT_Library,ref FT_Bitmap,ref FT_Bitmap,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Bitmap_Copy");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Bitmap_Embolden@description :
    ///// Embolden a bitmap.  The new bitmap will be about `xStrength` pixels
    ///// wider and `yStrength` pixels higher.  The left and bottom borders are
    ///// kept unchanged.@input :
    ///// library ::
    ///// A handle to a library object.xStrength ::
    ///// How strong the glyph is emboldened horizontally.  Expressed in 26.6
    ///// pixel format.yStrength ::
    ///// How strong the glyph is emboldened vertically.  Expressed in 26.6
    ///// pixel format.@inout :
    ///// bitmap ::
    ///// A handle to the target bitmap.@note :
    ///// The current implementation restricts `xStrength` to be less than or
    ///// equal to~8 if bitmap is of pixel_mode @FT _PIXEL_MODE_MONO.If you want to embolden the bitmap owned by a @FT _GlyphSlotRec, you
    ///// should call @FT _GlyphSlot_Own_Bitmap on the slot first.Bitmaps in @FT _PIXEL_MODE_GRAY2 and @FT _PIXEL_MODE_GRAY
    ///// @
    ///// format are
    ///// converted to @FT _PIXEL_MODE_GRAY format (i.e., 8bpp).
    ///// </remarks>

    //public static unsafe delegate* <FT_Library,ref FT_Bitmap,FT_Pos,FT_Pos,FT_Error> FT_Bitmap_Embolden = (delegate* <FT_Library,ref FT_Bitmap,FT_Pos,FT_Pos,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Bitmap_Embolden");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Bitmap_Convert@description :
    ///// Convert a bitmap object with depth 1bpp, 2bpp, 4bpp, 8bpp or 32bpp to
    ///// a bitmap object with depth 8bpp, making the number of used bytes per
    ///// line (a.k.a. the 'pitch') a multiple of `alignment`.@input :
    ///// library ::
    ///// A handle to a library object.source ::
    ///// The source bitmap.alignment ::
    ///// The pitch of the bitmap is a multiple of this argument.  Common
    ///// values are 1, 2, or 4.@output :
    ///// target ::
    ///// The target bitmap.@note :
    ///// It is possible to call @FT _Bitmap_Convert multiple times without
    ///// calling @FT _Bitmap_Done (the memory is simply reallocated).Use @FT _Bitmap_Done to finally remove the bitmap object.The `library` argument is taken to have access to FreeType's memory
    ///// handling functions.`source-&gt;buffer` and `target-&gt;buffer` must neither be equal nor
    ///// overlap.
    ///// </remarks>

    //public static unsafe delegate* <FT_Library,ref FT_Bitmap,ref FT_Bitmap,int,FT_Error> FT_Bitmap_Convert = (delegate* <FT_Library,ref FT_Bitmap,ref FT_Bitmap,int,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Bitmap_Convert");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Bitmap_Blend@description :
    ///// Blend a bitmap onto another bitmap, using a given color.@input :
    ///// library ::
    ///// A handle to a library object.source ::
    ///// The source bitmap, which can have any @FT _Pixel_Mode format.source_offset ::
    ///// The offset vector to the upper left corner of the source bitmap in
    ///// 26.6 pixel format.  It should represent an integer offset; the
    ///// function will set the lowest six bits to zero to enforce that.color ::
    ///// The color used to draw `source` onto `target`.@inout :
    ///// target ::
    ///// A handle to an `FT_Bitmap` object.  It should be either initialized
    ///// as empty with a call to @FT _Bitmap_Init, or it should be of type
    ///// @FT _PIXEL_MODE_BGRA.atarget_offset ::
    ///// The offset vector to the upper left corner of the target bitmap in
    ///// 26.6 pixel format.  It should represent an integer offset; the
    ///// function will set the lowest six bits to zero to enforce that.@note :
    ///// This function doesn't perform clipping.The bitmap in `target` gets allocated or reallocated as needed; the
    ///// vector `atarget_offset` is updated accordingly.In case of allocation or reallocation, the bitmap's pitch is set to
    ///// `4 * width`.  Both `source` and `target` must have the same bitmap
    ///// flow (as indicated by the sign of the `pitch` field).`source-&gt;buffer` and `target-&gt;buffer` must neither be equal nor
    ///// overlap.@since :
    ///// 2.10
    ///// </remarks>

    //public static unsafe delegate* <FT_Library,ref FT_Bitmap,FT_Vector,ref FT_Bitmap,ref FT_Vector,FT_Color,FT_Error> FT_Bitmap_Blend = (delegate* <FT_Library,ref FT_Bitmap,FT_Vector,ref FT_Bitmap,ref FT_Vector,FT_Color,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Bitmap_Blend");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_GlyphSlot_Own_Bitmap@description :
    ///// Make sure that a glyph slot owns `slot-&gt;bitmap`.@input :
    ///// slot ::
    ///// The glyph slot.@note :
    ///// This function is to be used in combination with @FT _Bitmap_Embolden.
    ///// </remarks>

    //public static unsafe delegate* <FT_GlyphSlot,FT_Error> FT_GlyphSlot_Own_Bitmap = (delegate* <FT_GlyphSlot,FT_Error>)NativeLibrary.GetExport(Handle, "FT_GlyphSlot_Own_Bitmap");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Bitmap_Done@description :
    ///// Destroy a bitmap object initialized with @FT _Bitmap_Init.@input :
    ///// library ::
    ///// A handle to a library object.bitmap ::
    ///// The bitmap object to be freed.@note :
    ///// The `library` argument is taken to have access to FreeType's memory
    ///// handling functions.
    ///// </remarks>

    //public static unsafe delegate* <FT_Library,ref FT_Bitmap,FT_Error> FT_Bitmap_Done = (delegate* <FT_Library,ref FT_Bitmap,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Bitmap_Done");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Outline_Get_BBox@description :
    ///// Compute the exact bounding box of an outline.  This is slower than
    ///// computing the control box.  However, it uses an advanced algorithm
    ///// that returns _very_ quickly when the two boxes coincide.  Otherwise,
    ///// the outline Bezier arcs are traversed to extract their extrema.@input :
    ///// outline ::
    ///// A pointer to the source outline.@output :
    ///// abbox ::
    ///// The outline's exact bounding box.@note :
    ///// If the font is tricky and the glyph has been loaded with
    ///// @FT _LOAD_NO_SCALE, the resulting BBox is meaningless.  To get
    ///// reasonable values for the BBox it is necessary to load the glyph at a
    ///// large ppem value (so that the hinting instructions can properly shift
    ///// and scale the subglyphs), then extracting the BBox, which can be
    ///// eventually converted back to font units.
    ///// </remarks>

    //public static unsafe delegate* <ref FT_Outline,ref FT_BBox,FT_Error> FT_Outline_Get_BBox = (delegate* <ref FT_Outline,ref FT_BBox,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Outline_Get_BBox");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FTC_Manager_New@description :
    ///// Create a new cache manager.@input :
    ///// library ::
    ///// The parent FreeType library handle to use.max_faces ::
    ///// Maximum number of opened @FT _Face objects managed by this cache
    ///// instance.  Use~0 for defaults.max_sizes ::
    ///// Maximum number of opened @FT _Size objects managed by this cache
    ///// instance.  Use~0 for defaults.max_bytes ::
    ///// Maximum number of bytes to use for cached data nodes.  Use~0 for
    ///// defaults.  Note that this value does not account for managed
    ///// @FT _Face and @FT _Size objects.requester ::
    ///// An application-provided callback used to translate face IDs into
    ///// real @FT _Face objects.req_data ::
    ///// A generic pointer that is passed to the requester each time it is
    ///// called (see @FTC _Face_Requester).@output :
    ///// amanager ::
    ///// A handle to a new manager object.  0~in case of failure.
    ///// </remarks>

    //public static unsafe delegate* <FT_Library,uint,uint,CULong,FTC_Face_Requester,FT_Pointer,ref FTC_Manager,FT_Error> FTC_Manager_New = (delegate* <FT_Library,uint,uint,CULong,FTC_Face_Requester,FT_Pointer,ref FTC_Manager,FT_Error>)NativeLibrary.GetExport(Handle, "FTC_Manager_New");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <remarks>
    ///// :FTC_Manager_Reset@description :
    ///// Empty a given cache manager.  This simply gets rid of all the
    ///// currently cached @FT _Face and @FT _Size objects within the manager.@inout :
    ///// manager ::
    ///// A handle to the manager.
    ///// </remarks>

    //public static unsafe delegate* <FTC_Manager,void> FTC_Manager_Reset = (delegate* <FTC_Manager,void>)NativeLibrary.GetExport(Handle, "FTC_Manager_Reset");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <remarks>
    ///// :FTC_Manager_Done@description :
    ///// Destroy a given manager after emptying it.@input :
    ///// manager ::
    ///// A handle to the target cache manager object.
    ///// </remarks>

    //public static unsafe delegate* <FTC_Manager,void> FTC_Manager_Done = (delegate* <FTC_Manager,void>)NativeLibrary.GetExport(Handle, "FTC_Manager_Done");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FTC_Manager_LookupFace@description :
    ///// Retrieve the @FT _Face object that corresponds to a given face ID
    ///// through a cache manager.@input :
    ///// manager ::
    ///// A handle to the cache manager.face_id ::
    ///// The ID of the face object.@output :
    ///// aface ::
    ///// A handle to the face object.@note :
    ///// The returned @FT _Face object is always owned by the manager.  You
    ///// should never try to discard it yourself.The @FT _Face object doesn't necessarily have a current size object
    ///// (i.e., face-&gt;size can be~0).  If you need a specific 'font size', use
    ///// @FTC _Manager_LookupSize instead.Never change the face's transformation matrix (i.e., never call the
    ///// @FT _Set_Transform function) on a returned face!  If you need to
    ///// transform glyphs, do it yourself after glyph loading.When you perform a lookup, out-of-memory errors are detected _within_
    ///// the lookup and force incremental flushes of the cache until enough
    ///// memory is released for the lookup to succeed.If a lookup fails with `FT_Err_Out_Of_Memory` the cache has already
    ///// been completely flushed, and still no memory was available for the
    ///// operation.
    ///// </remarks>

    //public static unsafe delegate* <FTC_Manager,FTC_FaceID,ref FT_Face,FT_Error> FTC_Manager_LookupFace = (delegate* <FTC_Manager,FTC_FaceID,ref FT_Face,FT_Error>)NativeLibrary.GetExport(Handle, "FTC_Manager_LookupFace");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FTC_Manager_LookupSize@description :
    ///// Retrieve the @FT _Size object that corresponds to a given
    ///// @FTC _ScalerRec pointer through a cache manager.@input :
    ///// manager ::
    ///// A handle to the cache manager.scaler ::
    ///// A scaler handle.@output :
    ///// asize ::
    ///// A handle to the size object.@note :
    ///// The returned @FT _Size object is always owned by the manager.  You
    ///// should never try to discard it by yourself.You can access the parent @FT _Face object simply as `size-&gt;face` if
    ///// you need it.  Note that this object is also owned by the manager.@note :
    ///// When you perform a lookup, out-of-memory errors are detected _within_
    ///// the lookup and force incremental flushes of the cache until enough
    ///// memory is released for the lookup to succeed.If a lookup fails with `FT_Err_Out_Of_Memory` the cache has already
    ///// been completely flushed, and still no memory is available for the
    ///// operation.
    ///// </remarks>

    //public static unsafe delegate* <FTC_Manager,FTC_Scaler,ref FT_Size,FT_Error> FTC_Manager_LookupSize = (delegate* <FTC_Manager,FTC_Scaler,ref FT_Size,FT_Error>)NativeLibrary.GetExport(Handle, "FTC_Manager_LookupSize");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <remarks>
    ///// :FTC_Node_Unref@description :
    ///// Decrement a cache node's internal reference count.  When the count
    ///// reaches 0, it is not destroyed but becomes eligible for subsequent
    ///// cache flushes.@input :
    ///// node ::
    ///// The cache node handle.manager ::
    ///// The cache manager handle.
    ///// </remarks>

    //public static unsafe delegate* <FTC_Node,FTC_Manager,void> FTC_Node_Unref = (delegate* <FTC_Node,FTC_Manager,void>)NativeLibrary.GetExport(Handle, "FTC_Node_Unref");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <remarks>
    ///// :FTC_Manager_RemoveFaceID@description :
    ///// A special function used to indicate to the cache manager that a given
    ///// @FTC _FaceID is no longer valid, either because its content changed, or
    ///// because it was deallocated or uninstalled.@input :
    ///// manager ::
    ///// The cache manager handle.face_id ::
    ///// The @FTC _FaceID to be removed.@note :
    ///// This function flushes all nodes from the cache corresponding to this
    ///// `face_id`, with the exception of nodes with a non-null reference
    ///// count.Such nodes are however modified internally so as to never appear in
    ///// later lookups with the same `face_id` value, and to be immediately
    ///// destroyed when released by all their users.
    ///// </remarks>

    //public static unsafe delegate* <FTC_Manager,FTC_FaceID,void> FTC_Manager_RemoveFaceID = (delegate* <FTC_Manager,FTC_FaceID,void>)NativeLibrary.GetExport(Handle, "FTC_Manager_RemoveFaceID");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FTC_CMapCache_New@description :
    ///// Create a new charmap cache.@input :
    ///// manager ::
    ///// A handle to the cache manager.@output :
    ///// acache ::
    ///// A new cache handle.  `NULL` in case of error.@note :
    ///// Like all other caches, this one will be destroyed with the cache
    ///// manager.
    ///// </remarks>

    //public static unsafe delegate* <FTC_Manager,ref FTC_CMapCache,FT_Error> FTC_CMapCache_New = (delegate* <FTC_Manager,ref FTC_CMapCache,FT_Error>)NativeLibrary.GetExport(Handle, "FTC_CMapCache_New");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// Glyph index.  0~means 'no glyph'.</returns>
    ///// <remarks>
    ///// :FTC_CMapCache_Lookup@description :
    ///// Translate a character code into a glyph index, using the charmap
    ///// cache.@input :
    ///// cache ::
    ///// A charmap cache handle.face_id ::
    ///// The source face ID.cmap_index ::
    ///// The index of the charmap in the source face.  Any negative value
    ///// means to use the cache @FT _Face's default charmap.char_code ::
    ///// The character code (in the corresponding charmap).
    ///// </remarks>

    //public static unsafe delegate* <FTC_CMapCache,FTC_FaceID,int,uint,uint> FTC_CMapCache_Lookup = (delegate* <FTC_CMapCache,FTC_FaceID,int,uint,uint>)NativeLibrary.GetExport(Handle, "FTC_CMapCache_Lookup");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FTC_ImageCache_New@description :
    ///// Create a new glyph image cache.@input :
    ///// manager ::
    ///// The parent manager for the image cache.@output :
    ///// acache ::
    ///// A handle to the new glyph image cache object.
    ///// </remarks>

    //public static unsafe delegate* <FTC_Manager,ref FTC_ImageCache,FT_Error> FTC_ImageCache_New = (delegate* <FTC_Manager,ref FTC_ImageCache,FT_Error>)NativeLibrary.GetExport(Handle, "FTC_ImageCache_New");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FTC_ImageCache_Lookup@description :
    ///// Retrieve a given glyph image from a glyph image cache.@input :
    ///// cache ::
    ///// A handle to the source glyph image cache.type ::
    ///// A pointer to a glyph image type descriptor.gindex ::
    ///// The glyph index to retrieve.@output :
    ///// aglyph ::
    ///// The corresponding @FT _Glyph object.  0~in case of failure.anode ::
    ///// Used to return the address of the corresponding cache node after
    ///// incrementing its reference count (see note below).@note :
    ///// The returned glyph is owned and managed by the glyph image cache.
    ///// Never try to transform or discard it manually!  You can however create
    ///// a copy with @FT _Glyph_Copy and modify the new one.If `anode` is _not_ `NULL`, it receives the address of the cache node
    ///// containing the glyph image, after increasing its reference count.
    ///// This ensures that the node (as well as the @FT _Glyph) will always be
    ///// kept in the cache until you call @FTC _Node_Unref to 'release' it.If `anode` is `NULL`, the cache node is left unchanged, which means
    ///// that the @FT _Glyph could be flushed out of the cache on the next call
    ///// to one of the caching sub-system APIs.  Don't assume that it is
    ///// persistent!
    ///// </remarks>

    //public static unsafe delegate* <FTC_ImageCache,FTC_ImageType,uint,ref FT_Glyph,ref FTC_Node,FT_Error> FTC_ImageCache_Lookup = (delegate* <FTC_ImageCache,FTC_ImageType,uint,ref FT_Glyph,ref FTC_Node,FT_Error>)NativeLibrary.GetExport(Handle, "FTC_ImageCache_Lookup");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FTC_ImageCache_LookupScaler@description :
    ///// A variant of @FTC _ImageCache_Lookup that uses an @FTC _ScalerRec to
    ///// specify the face ID and its size.@input :
    ///// cache ::
    ///// A handle to the source glyph image cache.scaler ::
    ///// A pointer to a scaler descriptor.load_flags ::
    ///// The corresponding load flags.gindex ::
    ///// The glyph index to retrieve.@output :
    ///// aglyph ::
    ///// The corresponding @FT _Glyph object.  0~in case of failure.anode ::
    ///// Used to return the address of the corresponding cache node after
    ///// incrementing its reference count (see note below).@note :
    ///// The returned glyph is owned and managed by the glyph image cache.
    ///// Never try to transform or discard it manually!  You can however create
    ///// a copy with @FT _Glyph_Copy and modify the new one.If `anode` is _not_ `NULL`, it receives the address of the cache node
    ///// containing the glyph image, after increasing its reference count.
    ///// This ensures that the node (as well as the @FT _Glyph) will always be
    ///// kept in the cache until you call @FTC _Node_Unref to 'release' it.If `anode` is `NULL`, the cache node is left unchanged, which means
    ///// that the @FT _Glyph could be flushed out of the cache on the next call
    ///// to one of the caching sub-system APIs.  Don't assume that it is
    ///// persistent!Calls to @FT _Set_Char_Size and friends have no effect on cached
    ///// glyphs; you should always use the FreeType cache API instead.
    ///// </remarks>

    //public static unsafe delegate* <FTC_ImageCache,FTC_Scaler,CULong,uint,ref FT_Glyph,ref FTC_Node,FT_Error> FTC_ImageCache_LookupScaler = (delegate* <FTC_ImageCache,FTC_Scaler,CULong,uint,ref FT_Glyph,ref FTC_Node,FT_Error>)NativeLibrary.GetExport(Handle, "FTC_ImageCache_LookupScaler");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FTC_SBitCache_New@description :
    ///// Create a new cache to store small glyph bitmaps.@input :
    ///// manager ::
    ///// A handle to the source cache manager.@output :
    ///// acache ::
    ///// A handle to the new sbit cache.  `NULL` in case of error.
    ///// </remarks>

    //public static unsafe delegate* <FTC_Manager,ref FTC_SBitCache,FT_Error> FTC_SBitCache_New = (delegate* <FTC_Manager,ref FTC_SBitCache,FT_Error>)NativeLibrary.GetExport(Handle, "FTC_SBitCache_New");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FTC_SBitCache_Lookup@description :
    ///// Look up a given small glyph bitmap in a given sbit cache and 'lock' it
    ///// to prevent its flushing from the cache until needed.@input :
    ///// cache ::
    ///// A handle to the source sbit cache.type ::
    ///// A pointer to the glyph image type descriptor.gindex ::
    ///// The glyph index.@output :
    ///// sbit ::
    ///// A handle to a small bitmap descriptor.anode ::
    ///// Used to return the address of the corresponding cache node after
    ///// incrementing its reference count (see note below).@note :
    ///// The small bitmap descriptor and its bit buffer are owned by the cache
    ///// and should never be freed by the application.  They might as well
    ///// disappear from memory on the next cache lookup, so don't treat them as
    ///// persistent data.The descriptor's `buffer` field is set to~0 to indicate a missing
    ///// glyph bitmap.If `anode` is _not_ `NULL`, it receives the address of the cache node
    ///// containing the bitmap, after increasing its reference count.  This
    ///// ensures that the node (as well as the image) will always be kept in
    ///// the cache until you call @FTC _Node_Unref to 'release' it.If `anode` is `NULL`, the cache node is left unchanged, which means
    ///// that the bitmap could be flushed out of the cache on the next call to
    ///// one of the caching sub-system APIs.  Don't assume that it is
    ///// persistent!
    ///// </remarks>

    //public static unsafe delegate* <FTC_SBitCache,FTC_ImageType,uint,ref FTC_SBit,ref FTC_Node,FT_Error> FTC_SBitCache_Lookup = (delegate* <FTC_SBitCache,FTC_ImageType,uint,ref FTC_SBit,ref FTC_Node,FT_Error>)NativeLibrary.GetExport(Handle, "FTC_SBitCache_Lookup");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FTC_SBitCache_LookupScaler@description :
    ///// A variant of @FTC _SBitCache_Lookup that uses an @FTC _ScalerRec to
    ///// specify the face ID and its size.@input :
    ///// cache ::
    ///// A handle to the source sbit cache.scaler ::
    ///// A pointer to the scaler descriptor.load_flags ::
    ///// The corresponding load flags.gindex ::
    ///// The glyph index.@output :
    ///// sbit ::
    ///// A handle to a small bitmap descriptor.anode ::
    ///// Used to return the address of the corresponding cache node after
    ///// incrementing its reference count (see note below).@note :
    ///// The small bitmap descriptor and its bit buffer are owned by the cache
    ///// and should never be freed by the application.  They might as well
    ///// disappear from memory on the next cache lookup, so don't treat them as
    ///// persistent data.The descriptor's `buffer` field is set to~0 to indicate a missing
    ///// glyph bitmap.If `anode` is _not_ `NULL`, it receives the address of the cache node
    ///// containing the bitmap, after increasing its reference count.  This
    ///// ensures that the node (as well as the image) will always be kept in
    ///// the cache until you call @FTC _Node_Unref to 'release' it.If `anode` is `NULL`, the cache node is left unchanged, which means
    ///// that the bitmap could be flushed out of the cache on the next call to
    ///// one of the caching sub-system APIs.  Don't assume that it is
    ///// persistent!
    ///// </remarks>

    //public static unsafe delegate* <FTC_SBitCache,FTC_Scaler,CULong,uint,ref FTC_SBit,ref FTC_Node,FT_Error> FTC_SBitCache_LookupScaler = (delegate* <FTC_SBitCache,FTC_Scaler,CULong,uint,ref FTC_SBit,ref FTC_Node,FT_Error>)NativeLibrary.GetExport(Handle, "FTC_SBitCache_LookupScaler");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Get_Multi_Master@description :
    ///// Retrieve a variation descriptor of a given Adobe MM font.This function can't be used with TrueType GX or OpenType variation
    ///// fonts.@input :
    ///// face ::
    ///// A handle to the source face.@output :
    ///// amaster ::
    ///// The Multiple Masters descriptor.
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,ref FT_Multi_Master,FT_Error> FT_Get_Multi_Master = (delegate* <FT_Face,ref FT_Multi_Master,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Get_Multi_Master");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Get_MM_Var@description :
    ///// Retrieve a variation descriptor for a given font.This function works with all supported variation formats.@input :
    ///// face ::
    ///// A handle to the source face.@output :
    ///// amaster ::
    ///// The variation descriptor.  Allocates a data structure, which the
    ///// user must deallocate with a call to @FT _Done_MM_Var after use.
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,out nint,FT_Error> FT_Get_MM_Var = (delegate* <FT_Face,out nint,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Get_MM_Var");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Done_MM_Var@description :
    ///// Free the memory allocated by @FT _Get_MM_Var.@input :
    ///// library ::
    ///// A handle of the face's parent library object that was used in the
    ///// call to @FT _Get_MM_Var to create `amaster`.
    ///// </remarks>

    //public static unsafe delegate* <FT_Library,ref FT_MM_Var,FT_Error> FT_Done_MM_Var = (delegate* <FT_Library,ref FT_MM_Var,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Done_MM_Var");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Set_MM_Design_Coordinates@description :
    ///// For Adobe MM fonts, choose an interpolated font design through design
    ///// coordinates.This function can't be used with TrueType GX or OpenType variation
    ///// fonts.@inout :
    ///// face ::
    ///// A handle to the source face.@input :
    ///// num_coords ::
    ///// The number of available design coordinates.  If it is larger than
    ///// the number of axes, ignore the excess values.  If it is smaller than
    ///// the number of axes, use default values for the remaining axes.coords ::
    ///// An array of design coordinates.@note :
    ///// [Since 2.8.1] To reset all axes to the default values, call the
    ///// function with `num_coords` set to zero and `coords` set to `NULL`.[Since 2.9] If `num_coords` is larger than zero, this function sets
    ///// the @FT _FACE_FLAG_VARIATION bit in @FT _Face's `face_flags` field
    ///// (i.e., @FT _IS_VARIATION will return true).  If `num_coords` is zero,
    ///// this bit flag gets unset.
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,uint,ref CLong,FT_Error> FT_Set_MM_Design_Coordinates = (delegate* <FT_Face,uint,ref CLong,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Set_MM_Design_Coordinates");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Set_Var_Design_Coordinates@description :
    ///// Choose an interpolated font design through design coordinates.This function works with all supported variation formats.@inout :
    ///// face ::
    ///// A handle to the source face.@input :
    ///// num_coords ::
    ///// The number of available design coordinates.  If it is larger than
    ///// the number of axes, ignore the excess values.  If it is smaller than
    ///// the number of axes, use default values for the remaining axes.coords ::
    ///// An array of design coordinates.@note :
    ///// [Since 2.8.1] To reset all axes to the default values, call the
    ///// function with `num_coords` set to zero and `coords` set to `NULL`.
    ///// [Since 2.9] 'Default values' means the currently selected named
    ///// instance (or the base font if no named instance is selected).[Since 2.9] If `num_coords` is larger than zero, this function sets
    ///// the @FT _FACE_FLAG_VARIATION bit in @FT _Face's `face_flags` field
    ///// (i.e., @FT _IS_VARIATION will return true).  If `num_coords` is zero,
    ///// this bit flag gets unset.
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,uint,ref FT_Fixed,FT_Error> FT_Set_Var_Design_Coordinates = (delegate* <FT_Face,uint,ref FT_Fixed,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Set_Var_Design_Coordinates");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Get_Var_Design_Coordinates@description :
    ///// Get the design coordinates of the currently selected interpolated
    ///// font.This function works with all supported variation formats.@input :
    ///// face ::
    ///// A handle to the source face.num_coords ::
    ///// The number of design coordinates to retrieve.  If it is larger than
    ///// the number of axes, set the excess values to~0.@output :
    ///// coords ::
    ///// The design coordinates array.@since :
    ///// 2.7.1
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,uint,ref FT_Fixed,FT_Error> FT_Get_Var_Design_Coordinates = (delegate* <FT_Face,uint,ref FT_Fixed,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Get_Var_Design_Coordinates");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Set_MM_Blend_Coordinates@description :
    ///// Choose an interpolated font design through normalized blend
    ///// coordinates.This function works with all supported variation formats.@inout :
    ///// face ::
    ///// A handle to the source face.@input :
    ///// num_coords ::
    ///// The number of available design coordinates.  If it is larger than
    ///// the number of axes, ignore the excess values.  If it is smaller than
    ///// the number of axes, use default values for the remaining axes.coords ::
    ///// The design coordinates array (each element must be between 0 and 1.0
    ///// for Adobe MM fonts, and between -1.0 and 1.0 for TrueType GX and
    ///// OpenType variation fonts).@note :
    ///// [Since 2.8.1] To reset all axes to the default values, call the
    ///// function with `num_coords` set to zero and `coords` set to `NULL`.
    ///// [Since 2.9] 'Default values' means the currently selected named
    ///// instance (or the base font if no named instance is selected).[Since 2.9] If `num_coords` is larger than zero, this function sets
    ///// the @FT _FACE_FLAG_VARIATION bit in @FT _Face's `face_flags` field
    ///// (i.e., @FT _IS_VARIATION will return true).  If `num_coords` is zero,
    ///// this bit flag gets unset.
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,uint,ref FT_Fixed,FT_Error> FT_Set_MM_Blend_Coordinates = (delegate* <FT_Face,uint,ref FT_Fixed,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Set_MM_Blend_Coordinates");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Get_MM_Blend_Coordinates@description :
    ///// Get the normalized blend coordinates of the currently selected
    ///// interpolated font.This function works with all supported variation formats.@input :
    ///// face ::
    ///// A handle to the source face.num_coords ::
    ///// The number of normalized blend coordinates to retrieve.  If it is
    ///// larger than the number of axes, set the excess values to~0.5 for
    ///// Adobe MM fonts, and to~0 for TrueType GX and OpenType variation
    ///// fonts.@output :
    ///// coords ::
    ///// The normalized blend coordinates array.@since :
    ///// 2.7.1
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,uint,ref FT_Fixed,FT_Error> FT_Get_MM_Blend_Coordinates = (delegate* <FT_Face,uint,ref FT_Fixed,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Get_MM_Blend_Coordinates");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <remarks>
    ///// :FT_Set_Var_Blend_Coordinates@description :
    ///// This is another name of @FT _Set_MM_Blend_Coordinates.
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,uint,ref FT_Fixed,FT_Error> FT_Set_Var_Blend_Coordinates = (delegate* <FT_Face,uint,ref FT_Fixed,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Set_Var_Blend_Coordinates");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <remarks>
    ///// :FT_Get_Var_Blend_Coordinates@description :
    ///// This is another name of @FT _Get_MM_Blend_Coordinates.@since :
    ///// 2.7.1
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,uint,ref FT_Fixed,FT_Error> FT_Get_Var_Blend_Coordinates = (delegate* <FT_Face,uint,ref FT_Fixed,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Get_Var_Blend_Coordinates");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Set_MM_WeightVector@description :
    ///// For Adobe MM fonts, choose an interpolated font design by directly
    ///// setting the weight vector.This function can't be used with TrueType GX or OpenType variation
    ///// fonts.@inout :
    ///// face ::
    ///// A handle to the source face.@input :
    ///// len ::
    ///// The length of the weight vector array.  If it is larger than the
    ///// number of designs, the extra values are ignored.  If it is less than
    ///// the number of designs, the remaining values are set to zero.weightvector ::
    ///// An array representing the weight vector.@note :
    ///// Adobe Multiple Master fonts limit the number of designs, and thus the
    ///// length of the weight vector to~16.If `len` is zero and `weightvector` is `NULL`, the weight vector array
    ///// is reset to the default values.The Adobe documentation also states that the values in the
    ///// WeightVector array must total 1.0 +/-~0.001.  In practice this does
    ///// not seem to be enforced, so is not enforced here, either.@since :
    ///// 2.10
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,uint,ref FT_Fixed,FT_Error> FT_Set_MM_WeightVector = (delegate* <FT_Face,uint,ref FT_Fixed,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Set_MM_WeightVector");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Get_MM_WeightVector@description :
    ///// For Adobe MM fonts, retrieve the current weight vector of the font.This function can't be used with TrueType GX or OpenType variation
    ///// fonts.@inout :
    ///// face ::
    ///// A handle to the source face.len ::
    ///// A pointer to the size of the array to be filled.  If the size of the
    ///// array is less than the number of designs, `FT_Err_Invalid_Argument`
    ///// is returned, and `len` is set to the required size (the number of
    ///// designs).  If the size of the array is greater than the number of
    ///// designs, the remaining entries are set to~0.  On successful
    ///// completion, `len` is set to the number of designs (i.e., the number
    ///// of values written to the array).@output :
    ///// weightvector ::
    ///// An array to be filled.@note :
    ///// Adobe Multiple Master fonts limit the number of designs, and thus the
    ///// length of the WeightVector to~16.@since :
    ///// 2.10
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,ref uint,ref FT_Fixed,FT_Error> FT_Get_MM_WeightVector = (delegate* <FT_Face,ref uint,ref FT_Fixed,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Get_MM_WeightVector");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Get_Var_Axis_Flags@description :
    ///// Get the 'flags' field of an OpenType Variation Axis Record.Not meaningful for Adobe MM fonts (`*flags` is always zero).@input :
    ///// master ::
    ///// The variation descriptor.axis_index ::
    ///// The index of the requested variation axis.@output :
    ///// flags ::
    ///// The 'flags' field.  See @FT _VAR_AXIS_FLAG_XXX for possible values.@since :
    ///// 2.8.1
    ///// </remarks>

    //public static unsafe delegate* <ref FT_MM_Var,uint,ref uint,FT_Error> FT_Get_Var_Axis_Flags = (delegate* <ref FT_MM_Var,uint,ref uint,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Get_Var_Axis_Flags");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Set_Named_Instance@description :
    ///// Set or change the current named instance.@input :
    ///// face ::
    ///// A handle to the source face.instance_index ::
    ///// The index of the requested instance, starting with value 1.  If set
    ///// to value 0, FreeType switches to font access without a named
    ///// instance.@note :
    ///// The function uses the value of `instance_index` to set bits 16-30 of
    ///// the face's `face_index` field.  It also resets any variation applied
    ///// to the font, and the @FT _FACE_FLAG_VARIATION bit of the face's
    ///// `face_flags` field gets reset to zero (i.e., @FT _IS_VARIATION will
    ///// return false).For Adobe MM fonts (which don't have named instances) this function
    ///// simply resets the current face to the default instance.@since :
    ///// 2.9
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,uint,FT_Error> FT_Set_Named_Instance = (delegate* <FT_Face,uint,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Set_Named_Instance");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// The number of strings in the 'name' table.</returns>
    ///// <remarks>
    ///// :FT_Get_Sfnt_Name_Count@description :
    ///// Retrieve the number of name strings in the SFNT 'name' table.@input :
    ///// face ::
    ///// A handle to the source face.@note :
    ///// This function always returns an error if the config macro
    ///// `TT_CONFIG_OPTION_SFNT_NAMES` is not defined in `ftoption.h`.
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,uint> FT_Get_Sfnt_Name_Count = (delegate* <FT_Face,uint>)NativeLibrary.GetExport(Handle, "FT_Get_Sfnt_Name_Count");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Get_Sfnt_Name@description :
    ///// Retrieve a string of the SFNT 'name' table for a given index.@input :
    ///// face ::
    ///// A handle to the source face.idx ::
    ///// The index of the 'name' string.@output :
    ///// aname ::
    ///// The indexed @FT _SfntName structure.@note :
    ///// The `string` array returned in the `aname` structure is not
    ///// null-terminated.  Note that you don't have to deallocate `string` by
    ///// yourself; FreeType takes care of it if you call @FT _Done_Face.Use @FT _Get_Sfnt_Name_Count to get the total number of available
    ///// 'name' table entries, then do a loop until you get the right platform,
    ///// encoding, and name ID.'name' table format~1 entries can use language tags also, see
    ///// @FT _Get_Sfnt_LangTag.This function always returns an error if the config macro
    ///// `TT_CONFIG_OPTION_SFNT_NAMES` is not defined in `ftoption.h`.
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,uint,ref FT_SfntName,FT_Error> FT_Get_Sfnt_Name = (delegate* <FT_Face,uint,ref FT_SfntName,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Get_Sfnt_Name");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Get_Sfnt_LangTag@description :
    ///// Retrieve the language tag associated with a language ID of an SFNT
    ///// 'name' table entry.@input :
    ///// face ::
    ///// A handle to the source face.langID ::
    ///// The language ID, as returned by @FT _Get_Sfnt_Name.  This is always a
    ///// value larger than 0x8000.@output :
    ///// alangTag ::
    ///// The language tag associated with the 'name' table entry's language
    ///// ID.@note :
    ///// The `string` array returned in the `alangTag` structure is not
    ///// null-terminated.  Note that you don't have to deallocate `string` by
    ///// yourself; FreeType takes care of it if you call @FT _Done_Face.Only 'name' table format~1 supports language tags.  For format~0
    ///// tables, this function always returns FT_Err_Invalid_Table.  For
    ///// invalid format~1 language ID values, FT_Err_Invalid_Argument is
    ///// returned.This function always returns an error if the config macro
    ///// `TT_CONFIG_OPTION_SFNT_NAMES` is not defined in `ftoption.h`.@since :
    ///// 2.8
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,uint,ref FT_SfntLangTag,FT_Error> FT_Get_Sfnt_LangTag = (delegate* <FT_Face,uint,ref FT_SfntLangTag,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Get_Sfnt_LangTag");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_OpenType_Validate@description :
    ///// Validate various OpenType tables to assure that all offsets and
    ///// indices are valid.  The idea is that a higher-level library that
    ///// actually does the text layout can access those tables without error
    ///// checking (which can be quite time consuming).@input :
    ///// face ::
    ///// A handle to the input face.validation_flags ::
    ///// A bit field that specifies the tables to be validated.  See
    ///// @FT _VALIDATE_OTXXX for possible values.@output :
    ///// BASE_table ::
    ///// A pointer to the BASE table.GDEF_table ::
    ///// A pointer to the GDEF table.GPOS_table ::
    ///// A pointer to the GPOS table.GSUB_table ::
    ///// A pointer to the GSUB table.JSTF_table ::
    ///// A pointer to the JSTF table.@note :
    ///// This function only works with OpenType fonts, returning an error
    ///// otherwise.After use, the application should deallocate the five tables with
    ///// @FT _OpenType_Free.  A `NULL` value indicates that the table either
    ///// doesn't exist in the font, or the application hasn't asked for
    ///// validation.
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,uint,ref FT_Bytes,ref FT_Bytes,ref FT_Bytes,ref FT_Bytes,ref FT_Bytes,FT_Error> FT_OpenType_Validate = (delegate* <FT_Face,uint,ref FT_Bytes,ref FT_Bytes,ref FT_Bytes,ref FT_Bytes,ref FT_Bytes,FT_Error>)NativeLibrary.GetExport(Handle, "FT_OpenType_Validate");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <remarks>
    ///// :FT_OpenType_Free@description :
    ///// Free the buffer allocated by OpenType validator.@input :
    ///// face ::
    ///// A handle to the input face.table ::
    ///// The pointer to the buffer that is allocated by
    ///// @FT _OpenType_Validate.@note :
    ///// This function must be used to free the buffer allocated by
    ///// @FT _OpenType_Validate only.
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,FT_Bytes,void> FT_OpenType_Free = (delegate* <FT_Face,FT_Bytes,void>)NativeLibrary.GetExport(Handle, "FT_OpenType_Free");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_TrueTypeGX_Validate@description :
    ///// Validate various TrueTypeGX tables to assure that all offsets and
    ///// indices are valid.  The idea is that a higher-level library that
    ///// actually does the text layout can access those tables without error
    ///// checking (which can be quite time consuming).@input :
    ///// face ::
    ///// A handle to the input face.validation_flags ::
    ///// A bit field that specifies the tables to be validated.  See
    ///// @FT _VALIDATE_GXXXX for possible values.table_length ::
    ///// The size of the `tables` array.  Normally, @FT _VALIDATE_GX_LENGTH
    ///// should be passed.@output :
    ///// tables ::
    ///// The array where all validated sfnt tables are stored.  The array
    ///// itself must be allocated by a client.@note :
    ///// This function only works with TrueTypeGX fonts, returning an error
    ///// otherwise.After use, the application should deallocate the buffers pointed to by
    ///// each `tables` element, by calling @FT _TrueTypeGX_Free.  A `NULL` value
    ///// indicates that the table either doesn't exist in the font, the
    ///// application hasn't asked for validation, or the validator doesn't have
    ///// the ability to validate the sfnt table.
    ///// </remarks>
    //public static unsafe delegate* <FT_Face, uint, byte*/*[FT_VALIDATE_GX_LENGTH]*/, uint, FT_Error> FT_TrueTypeGX_Validate = (delegate* <FT_Face, uint, byte*/*[FT_VALIDATE_GX_LENGTH]*/, uint, FT_Error>)NativeLibrary.GetExport(Handle, "FT_TrueTypeGX_Validate");


    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <remarks>
    ///// :FT_TrueTypeGX_Free@description :
    ///// Free the buffer allocated by TrueTypeGX validator.@input :
    ///// face ::
    ///// A handle to the input face.table ::
    ///// The pointer to the buffer allocated by @FT _TrueTypeGX_Validate.@note :
    ///// This function must be used to free the buffer allocated by
    ///// @FT _TrueTypeGX_Validate only.
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,FT_Bytes,void> FT_TrueTypeGX_Free = (delegate* <FT_Face,FT_Bytes,void>)NativeLibrary.GetExport(Handle, "FT_TrueTypeGX_Free");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_ClassicKern_Validate@description :
    ///// Validate classic (16-bit format) kern table to assure that the
    ///// offsets and indices are valid.  The idea is that a higher-level
    ///// library that actually does the text layout can access those tables
    ///// without error checking (which can be quite time consuming).The 'kern' table validator in @FT _TrueTypeGX_Validate deals with both
    ///// the new 32-bit format and the classic 16-bit format, while
    ///// FT_ClassicKern_Validate only supports the classic 16-bit format.@input :
    ///// face ::
    ///// A handle to the input face.validation_flags ::
    ///// A bit field that specifies the dialect to be validated.  See
    ///// @FT _VALIDATE_CKERNXXX for possible values.@output :
    ///// ckern_table ::
    ///// A pointer to the kern table.@note :
    ///// After use, the application should deallocate the buffers pointed to by
    ///// `ckern_table`, by calling @FT _ClassicKern_Free.  A `NULL` value
    ///// indicates that the table doesn't exist in the font.
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,uint,ref FT_Bytes,FT_Error> FT_ClassicKern_Validate = (delegate* <FT_Face,uint,ref FT_Bytes,FT_Error>)NativeLibrary.GetExport(Handle, "FT_ClassicKern_Validate");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <remarks>
    ///// :FT_ClassicKern_Free@description :
    ///// Free the buffer allocated by classic Kern validator.@input :
    ///// face ::
    ///// A handle to the input face.table ::
    ///// The pointer to the buffer that is allocated by
    ///// @FT _ClassicKern_Validate.@note :
    ///// This function must be used to free the buffer allocated by
    ///// @FT _ClassicKern_Validate only.
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,FT_Bytes,void> FT_ClassicKern_Free = (delegate* <FT_Face,FT_Bytes,void>)NativeLibrary.GetExport(Handle, "FT_ClassicKern_Free");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Get_PFR_Metrics@description :
    ///// Return the outline and metrics resolutions of a given PFR face.@input :
    ///// face ::
    ///// Handle to the input face.  It can be a non-PFR face.@output :
    ///// aoutline_resolution ::
    ///// Outline resolution.  This is equivalent to `face-&gt;units_per_EM` for
    ///// non-PFR fonts.  Optional (parameter can be `NULL`).ametrics_resolution ::
    ///// Metrics resolution.  This is equivalent to `outline_resolution` for
    ///// non-PFR fonts.  Optional (parameter can be `NULL`).ametrics_x_scale ::
    ///// A 16.16 fixed-point number used to scale distance expressed in
    ///// metrics units to device subpixels.  This is equivalent to
    ///// `face-&gt;size-&gt;x_scale`, but for metrics only.  Optional (parameter
    ///// can be `NULL`).ametrics_y_scale ::
    ///// Same as `ametrics_x_scale` but for the vertical direction.
    ///// optional (parameter can be `NULL`).@note :
    ///// If the input face is not a PFR, this function will return an error.
    ///// However, in all cases, it will return valid values.
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,ref uint,ref uint,ref FT_Fixed,ref FT_Fixed,FT_Error> FT_Get_PFR_Metrics = (delegate* <FT_Face,ref uint,ref uint,ref FT_Fixed,ref FT_Fixed,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Get_PFR_Metrics");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Get_PFR_Kerning@description :
    ///// Return the kerning pair corresponding to two glyphs in a PFR face.
    ///// The distance is expressed in metrics units, unlike the result of
    ///// @FT _Get_Kerning.@input :
    ///// face ::
    ///// A handle to the input face.left ::
    ///// Index of the left glyph.right ::
    ///// Index of the right glyph.@output :
    ///// avector ::
    ///// A kerning vector.@note :
    ///// This function always return distances in original PFR metrics units.
    ///// This is unlike @FT _Get_Kerning with the @FT _KERNING_UNSCALED mode,
    ///// which always returns distances converted to outline units.You can use the value of the `x_scale` and `y_scale` parameters
    ///// returned by @FT _Get_PFR_Metrics to scale these to device subpixels.
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,uint,uint,ref FT_Vector,FT_Error> FT_Get_PFR_Kerning = (delegate* <FT_Face,uint,uint,ref FT_Vector,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Get_PFR_Kerning");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Get_PFR_Advance@description :
    ///// Return a given glyph advance, expressed in original metrics units,
    ///// from a PFR font.@input :
    ///// face ::
    ///// A handle to the input face.gindex ::
    ///// The glyph index.@output :
    ///// aadvance ::
    ///// The glyph advance in metrics units.@note :
    ///// You can use the `x_scale` or `y_scale` results of @FT _Get_PFR_Metrics
    ///// to convert the advance to device subpixels (i.e., 1/64th of pixels).
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,uint,ref FT_Pos,FT_Error> FT_Get_PFR_Advance = (delegate* <FT_Face,uint,ref FT_Pos,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Get_PFR_Advance");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// The border index.  @FT _STROKER_BORDER_RIGHT for empty or invalid
    ///// outlines.</returns>
    ///// <remarks>
    ///// :FT_Outline_GetInsideBorder@description :
    ///// Retrieve the @FT _StrokerBorder value corresponding to the 'inside'
    ///// borders of a given outline.@input :
    ///// outline ::
    ///// The source outline handle.
    ///// </remarks>

    //public static unsafe delegate* <ref FT_Outline,FT_StrokerBorder> FT_Outline_GetInsideBorder = (delegate* <ref FT_Outline,FT_StrokerBorder>)NativeLibrary.GetExport(Handle, "FT_Outline_GetInsideBorder");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// The border index.  @FT _STROKER_BORDER_LEFT for empty or invalid
    ///// outlines.</returns>
    ///// <remarks>
    ///// :FT_Outline_GetOutsideBorder@description :
    ///// Retrieve the @FT _StrokerBorder value corresponding to the 'outside'
    ///// borders of a given outline.@input :
    ///// outline ::
    ///// The source outline handle.
    ///// </remarks>

    //public static unsafe delegate* <ref FT_Outline,FT_StrokerBorder> FT_Outline_GetOutsideBorder = (delegate* <ref FT_Outline,FT_StrokerBorder>)NativeLibrary.GetExport(Handle, "FT_Outline_GetOutsideBorder");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Stroker_New@description :
    ///// Create a new stroker object.@input :
    ///// library ::
    ///// FreeType library handle.@output :
    ///// astroker ::
    ///// A new stroker object handle.  `NULL` in case of error.
    ///// </remarks>

    //public static unsafe delegate* <FT_Library,ref FT_Stroker,FT_Error> FT_Stroker_New = (delegate* <FT_Library,ref FT_Stroker,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Stroker_New");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <remarks>
    ///// :FT_Stroker_Set@description :
    ///// Reset a stroker object's attributes.@input :
    ///// stroker ::
    ///// The target stroker handle.radius ::
    ///// The border radius.line_cap ::
    ///// The line cap style.line_join ::
    ///// The line join style.miter_limit ::
    ///// The maximum reciprocal sine of half-angle at the miter join,
    ///// expressed as 16.16 fixed point value.@note :
    ///// The `radius` is expressed in the same units as the outline
    ///// coordinates.The `miter_limit` multiplied by the `radius` gives the maximum size
    ///// of a miter spike, at which it is clipped for
    ///// @FT _STROKER_LINEJOIN_MITER_VARIABLE or replaced with a bevel join for
    ///// @FT _STROKER_LINEJOIN_MITER_FIXED.This function calls @FT _Stroker_Rewind automatically.
    ///// </remarks>

    //public static unsafe delegate* <FT_Stroker,FT_Fixed,FT_Stroker_LineCap,FT_Stroker_LineJoin,FT_Fixed,void> FT_Stroker_Set = (delegate* <FT_Stroker,FT_Fixed,FT_Stroker_LineCap,FT_Stroker_LineJoin,FT_Fixed,void>)NativeLibrary.GetExport(Handle, "FT_Stroker_Set");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <remarks>
    ///// :FT_Stroker_Rewind@description :
    ///// Reset a stroker object without changing its attributes.  You should
    ///// call this function before beginning a new series of calls to
    ///// @FT _Stroker_BeginSubPath or @FT _Stroker_EndSubPath.@input :
    ///// stroker ::
    ///// The target stroker handle.
    ///// </remarks>

    //public static unsafe delegate* <FT_Stroker,void> FT_Stroker_Rewind = (delegate* <FT_Stroker,void>)NativeLibrary.GetExport(Handle, "FT_Stroker_Rewind");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Stroker_ParseOutline@description :
    ///// A convenience function used to parse a whole outline with the stroker.
    ///// The resulting outline(s) can be retrieved later by functions like
    ///// @FT _Stroker_GetCounts and @FT _Stroker_Export.@input :
    ///// stroker ::
    ///// The target stroker handle.outline ::
    ///// The source outline.opened ::
    ///// A boolean.  If~1, the outline is treated as an open path instead of
    ///// a closed one.@note :
    ///// If `opened` is~0 (the default), the outline is treated as a closed
    ///// path, and the stroker generates two distinct 'border' outlines.If `opened` is~1, the outline is processed as an open path, and the
    ///// stroker generates a single 'stroke' outline.This function calls @FT _Stroker_Rewind automatically.
    ///// </remarks>

    //public static unsafe delegate* <FT_Stroker,ref FT_Outline,FT_Bool,FT_Error> FT_Stroker_ParseOutline = (delegate* <FT_Stroker,ref FT_Outline,FT_Bool,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Stroker_ParseOutline");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Stroker_BeginSubPath@description :
    ///// Start a new sub-path in the stroker.@input :
    ///// stroker ::
    ///// The target stroker handle.to ::
    ///// A pointer to the start vector.open ::
    ///// A boolean.  If~1, the sub-path is treated as an open one.@note :
    ///// This function is useful when you need to stroke a path that is not
    ///// stored as an @FT _Outline object.
    ///// </remarks>

    //public static unsafe delegate* <FT_Stroker,ref FT_Vector,FT_Bool,FT_Error> FT_Stroker_BeginSubPath = (delegate* <FT_Stroker,ref FT_Vector,FT_Bool,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Stroker_BeginSubPath");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Stroker_EndSubPath@description :
    ///// Close the current sub-path in the stroker.@input :
    ///// stroker ::
    ///// The target stroker handle.@note :
    ///// You should call this function after @FT _Stroker_BeginSubPath.  If the
    ///// subpath was not 'opened', this function 'draws' a single line segment
    ///// to the start position when needed.
    ///// </remarks>

    //public static unsafe delegate* <FT_Stroker,FT_Error> FT_Stroker_EndSubPath = (delegate* <FT_Stroker,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Stroker_EndSubPath");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Stroker_LineTo@description :
    ///// 'Draw' a single line segment in the stroker's current sub-path, from
    ///// the last position.@input :
    ///// stroker ::
    ///// The target stroker handle.to ::
    ///// A pointer to the destination point.@note :
    ///// You should call this function between @FT _Stroker_BeginSubPath and
    ///// @FT _Stroker_EndSubPath.
    ///// </remarks>

    //public static unsafe delegate* <FT_Stroker,ref FT_Vector,FT_Error> FT_Stroker_LineTo = (delegate* <FT_Stroker,ref FT_Vector,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Stroker_LineTo");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Stroker_ConicTo@description :
    ///// 'Draw' a single quadratic Bezier in the stroker's current sub-path,
    ///// from the last position.@input :
    ///// stroker ::
    ///// The target stroker handle.control ::
    ///// A pointer to a Bezier control point.to ::
    ///// A pointer to the destination point.@note :
    ///// You should call this function between @FT _Stroker_BeginSubPath and
    ///// @FT _Stroker_EndSubPath.
    ///// </remarks>

    //public static unsafe delegate* <FT_Stroker,ref FT_Vector,ref FT_Vector,FT_Error> FT_Stroker_ConicTo = (delegate* <FT_Stroker,ref FT_Vector,ref FT_Vector,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Stroker_ConicTo");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Stroker_CubicTo@description :
    ///// 'Draw' a single cubic Bezier in the stroker's current sub-path, from
    ///// the last position.@input :
    ///// stroker ::
    ///// The target stroker handle.control1 ::
    ///// A pointer to the first Bezier control point.control2 ::
    ///// A pointer to second Bezier control point.to ::
    ///// A pointer to the destination point.@note :
    ///// You should call this function between @FT _Stroker_BeginSubPath and
    ///// @FT _Stroker_EndSubPath.
    ///// </remarks>

    //public static unsafe delegate* <FT_Stroker,ref FT_Vector,ref FT_Vector,ref FT_Vector,FT_Error> FT_Stroker_CubicTo = (delegate* <FT_Stroker,ref FT_Vector,ref FT_Vector,ref FT_Vector,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Stroker_CubicTo");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Stroker_GetBorderCounts@description :
    ///// Call this function once you have finished parsing your paths with the
    ///// stroker.  It returns the number of points and contours necessary to
    ///// export one of the 'border' or 'stroke' outlines generated by the
    ///// stroker.@input :
    ///// stroker ::
    ///// The target stroker handle.border ::
    ///// The border index.@output :
    ///// anum_points ::
    ///// The number of points.anum_contours ::
    ///// The number of contours.@note :
    ///// When an outline, or a sub-path, is 'closed', the stroker generates two
    ///// independent 'border' outlines, named 'left' and 'right'.When the outline, or a sub-path, is 'opened', the stroker merges the
    ///// 'border' outlines with caps.  The 'left' border receives all points,
    ///// while the 'right' border becomes empty.Use the function @FT _Stroker_GetCounts instead if you want to retrieve
    ///// the counts associated to both borders.
    ///// </remarks>

    //public static unsafe delegate* <FT_Stroker,FT_StrokerBorder,ref uint,ref uint,FT_Error> FT_Stroker_GetBorderCounts = (delegate* <FT_Stroker,FT_StrokerBorder,ref uint,ref uint,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Stroker_GetBorderCounts");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <remarks>
    ///// :FT_Stroker_ExportBorder@description :
    ///// Call this function after @FT _Stroker_GetBorderCounts to export the
    ///// corresponding border to your own @FT _Outline structure.Note that this function appends the border points and contours to your
    ///// outline, but does not try to resize its arrays.@input :
    ///// stroker ::
    ///// The target stroker handle.border ::
    ///// The border index.outline ::
    ///// The target outline handle.@note :
    ///// Always call this function after @FT _Stroker_GetBorderCounts to get
    ///// sure that there is enough room in your @FT _Outline object to receive
    ///// all new data.When an outline, or a sub-path, is 'closed', the stroker generates two
    ///// independent 'border' outlines, named 'left' and 'right'.When the outline, or a sub-path, is 'opened', the stroker merges the
    ///// 'border' outlines with caps.  The 'left' border receives all points,
    ///// while the 'right' border becomes empty.Use the function @FT _Stroker_Export instead if you want to retrieve
    ///// all borders at once.
    ///// </remarks>

    //public static unsafe delegate* <FT_Stroker,FT_StrokerBorder,ref FT_Outline,void> FT_Stroker_ExportBorder = (delegate* <FT_Stroker,FT_StrokerBorder,ref FT_Outline,void>)NativeLibrary.GetExport(Handle, "FT_Stroker_ExportBorder");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Stroker_GetCounts@description :
    ///// Call this function once you have finished parsing your paths with the
    ///// stroker.  It returns the number of points and contours necessary to
    ///// export all points/borders from the stroked outline/path.@input :
    ///// stroker ::
    ///// The target stroker handle.@output :
    ///// anum_points ::
    ///// The number of points.anum_contours ::
    ///// The number of contours.
    ///// </remarks>

    //public static unsafe delegate* <FT_Stroker,ref uint,ref uint,FT_Error> FT_Stroker_GetCounts = (delegate* <FT_Stroker,ref uint,ref uint,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Stroker_GetCounts");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <remarks>
    ///// :FT_Stroker_Export@description :
    ///// Call this function after @FT _Stroker_GetBorderCounts to export all
    ///// borders to your own @FT _Outline structure.Note that this function appends the border points and contours to your
    ///// outline, but does not try to resize its arrays.@input :
    ///// stroker ::
    ///// The target stroker handle.outline ::
    ///// The target outline handle.
    ///// </remarks>

    //public static unsafe delegate* <FT_Stroker,ref FT_Outline,void> FT_Stroker_Export = (delegate* <FT_Stroker,ref FT_Outline,void>)NativeLibrary.GetExport(Handle, "FT_Stroker_Export");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <remarks>
    ///// :FT_Stroker_Done@description :
    ///// Destroy a stroker object.@input :
    ///// stroker ::
    ///// A stroker handle.  Can be `NULL`.
    ///// </remarks>

    //public static unsafe delegate* <FT_Stroker,void> FT_Stroker_Done = (delegate* <FT_Stroker,void>)NativeLibrary.GetExport(Handle, "FT_Stroker_Done");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Glyph_Stroke@description :
    ///// Stroke a given outline glyph object with a given stroker.@inout :
    ///// pglyph ::
    ///// Source glyph handle on input, new glyph handle on output.@input :
    ///// stroker ::
    ///// A stroker handle.destroy ::
    ///// A Boolean.  If~1, the source glyph object is destroyed on success.@note :
    ///// The source glyph is untouched in case of error.Adding stroke may yield a significantly wider and taller glyph
    ///// depending on how large of a radius was used to stroke the glyph.  You
    ///// may need to manually adjust horizontal and vertical advance amounts to
    ///// account for this added size.
    ///// </remarks>

    //public static unsafe delegate* <ref FT_Glyph,FT_Stroker,FT_Bool,FT_Error> FT_Glyph_Stroke = (delegate* <ref FT_Glyph,FT_Stroker,FT_Bool,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Glyph_Stroke");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Glyph_StrokeBorder@description :
    ///// Stroke a given outline glyph object with a given stroker, but only
    ///// return either its inside or outside border.@inout :
    ///// pglyph ::
    ///// Source glyph handle on input, new glyph handle on output.@input :
    ///// stroker ::
    ///// A stroker handle.inside ::
    ///// A Boolean.  If~1, return the inside border, otherwise the outside
    ///// border.destroy ::
    ///// A Boolean.  If~1, the source glyph object is destroyed on success.@note :
    ///// The source glyph is untouched in case of error.Adding stroke may yield a significantly wider and taller glyph
    ///// depending on how large of a radius was used to stroke the glyph.  You
    ///// may need to manually adjust horizontal and vertical advance amounts to
    ///// account for this added size.
    ///// </remarks>

    //public static unsafe delegate* <ref FT_Glyph,FT_Stroker,FT_Bool,FT_Bool,FT_Error> FT_Glyph_StrokeBorder = (delegate* <ref FT_Glyph,FT_Stroker,FT_Bool,FT_Bool,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Glyph_StrokeBorder");

    ///// <summary>
    ///// Embolden a glyph by a 'reasonable' value (which is highly a matter of
    ///// </summary>
    ///// <remarks>
    ///// taste).  This function is actually a convenience function, providinga wrapper for @FT _Outline_Embolden and @FT _Bitmap_Embolden.For emboldened outlines the height, width, and advance metrics areincreased by the strength of the emboldening -- this even affectsmono-width fonts!You can also call @FT _Outline_Get_CBox to get precise values.
    ///// </remarks>

    //public static unsafe delegate* <FT_GlyphSlot,void> FT_GlyphSlot_Embolden = (delegate* <FT_GlyphSlot,void>)NativeLibrary.GetExport(Handle, "FT_GlyphSlot_Embolden");

    ///// <summary>
    ///// Slant an outline glyph to the right by about 12 degrees.
    ///// </summary>

    //public static unsafe delegate* <FT_GlyphSlot,void> FT_GlyphSlot_Oblique = (delegate* <FT_GlyphSlot,void>)NativeLibrary.GetExport(Handle, "FT_GlyphSlot_Oblique");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// Font format string.  `NULL` in case of error.</returns>
    ///// <remarks>
    ///// :FT_Get_Font_Format@description :
    ///// Return a string describing the format of a given face.  Possible values
    ///// are 'TrueType', 'Type~1', 'BDF', 'PCF', 'Type~42', 'CID~Type~1', 'CFF',
    ///// 'PFR', and 'Windows~FNT'.The return value is suitable to be used as an X11 FONT_PROPERTY.@input :
    ///// face ::
    ///// Input face handle.@note :
    ///// A deprecated name for the same function is `FT_Get_X11_Font_Format`.
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,nint> FT_Get_Font_Format = (delegate* <FT_Face,nint>)NativeLibrary.GetExport(Handle, "FT_Get_Font_Format");

    ///// <summary>
    ///// deprecated
    ///// </summary>

    //public static unsafe delegate* <FT_Face,nint> FT_Get_X11_Font_Format = (delegate* <FT_Face,nint>)NativeLibrary.GetExport(Handle, "FT_Get_X11_Font_Format");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// The sinus value.</returns>
    ///// <remarks>
    ///// :FT_Sin@description :
    ///// Return the sinus of a given angle in fixed-point format.@input :
    ///// angle ::
    ///// The input angle.@note :
    ///// If you need both the sinus and cosinus for a given angle, use the
    ///// function @FT _Vector_Unit.
    ///// </remarks>

    //public static unsafe delegate* <FT_Angle,FT_Fixed> FT_Sin = (delegate* <FT_Angle,FT_Fixed>)NativeLibrary.GetExport(Handle, "FT_Sin");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// The cosinus value.</returns>
    ///// <remarks>
    ///// :FT_Cos@description :
    ///// Return the cosinus of a given angle in fixed-point format.@input :
    ///// angle ::
    ///// The input angle.@note :
    ///// If you need both the sinus and cosinus for a given angle, use the
    ///// function @FT _Vector_Unit.
    ///// </remarks>

    //public static unsafe delegate* <FT_Angle,FT_Fixed> FT_Cos = (delegate* <FT_Angle,FT_Fixed>)NativeLibrary.GetExport(Handle, "FT_Cos");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// The tangent value.</returns>
    ///// <remarks>
    ///// :FT_Tan@description :
    ///// Return the tangent of a given angle in fixed-point format.@input :
    ///// angle ::
    ///// The input angle.
    ///// </remarks>

    //public static unsafe delegate* <FT_Angle,FT_Fixed> FT_Tan = (delegate* <FT_Angle,FT_Fixed>)NativeLibrary.GetExport(Handle, "FT_Tan");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// The arc-tangent value (i.e. angle).</returns>
    ///// <remarks>
    ///// :FT_Atan2@description :
    ///// Return the arc-tangent corresponding to a given vector (x,y) in the 2d
    ///// plane.@input :
    ///// x ::
    ///// The horizontal vector coordinate.y ::
    ///// The vertical vector coordinate.
    ///// </remarks>

    //public static unsafe delegate* <FT_Fixed,FT_Fixed,FT_Angle> FT_Atan2 = (delegate* <FT_Fixed,FT_Fixed,FT_Angle>)NativeLibrary.GetExport(Handle, "FT_Atan2");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// Constrained value of `angle2-angle1`.</returns>
    ///// <remarks>
    ///// :FT_Angle_Diff@description :
    ///// Return the difference between two angles.  The result is always
    ///// constrained to the ]-PI..PI] interval.@input :
    ///// angle1 ::
    ///// First angle.angle2 ::
    ///// Second angle.
    ///// </remarks>

    //public static unsafe delegate* <FT_Angle,FT_Angle,FT_Angle> FT_Angle_Diff = (delegate* <FT_Angle,FT_Angle,FT_Angle>)NativeLibrary.GetExport(Handle, "FT_Angle_Diff");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <remarks>
    ///// :FT_Vector_Unit@description :
    ///// Return the unit vector corresponding to a given angle.  After the
    ///// call, the value of `vec.x` will be `cos(angle)`, and the value of
    ///// `vec.y` will be `sin(angle)`.This function is useful to retrieve both the sinus and cosinus of a
    ///// given angle quickly.@output :
    ///// vec ::
    ///// The address of target vector.@input :
    ///// angle ::
    ///// The input angle.
    ///// </remarks>

    //public static unsafe delegate* <ref FT_Vector,FT_Angle,void> FT_Vector_Unit = (delegate* <ref FT_Vector,FT_Angle,void>)NativeLibrary.GetExport(Handle, "FT_Vector_Unit");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <remarks>
    ///// :FT_Vector_Rotate@description :
    ///// Rotate a vector by a given angle.@inout :
    ///// vec ::
    ///// The address of target vector.@input :
    ///// angle ::
    ///// The input angle.
    ///// </remarks>

    //public static unsafe delegate* <ref FT_Vector,FT_Angle,void> FT_Vector_Rotate = (delegate* <ref FT_Vector,FT_Angle,void>)NativeLibrary.GetExport(Handle, "FT_Vector_Rotate");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// The vector length, expressed in the same units that the original
    ///// vector coordinates.</returns>
    ///// <remarks>
    ///// :FT_Vector_Length@description :
    ///// Return the length of a given vector.@input :
    ///// vec ::
    ///// The address of target vector.
    ///// </remarks>

    //public static unsafe delegate* <ref FT_Vector,FT_Fixed> FT_Vector_Length = (delegate* <ref FT_Vector,FT_Fixed>)NativeLibrary.GetExport(Handle, "FT_Vector_Length");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <remarks>
    ///// :FT_Vector_Polarize@description :
    ///// Compute both the length and angle of a given vector.@input :
    ///// vec ::
    ///// The address of source vector.@output :
    ///// length ::
    ///// The vector length.angle ::
    ///// The vector angle.
    ///// </remarks>

    //public static unsafe delegate* <ref FT_Vector,ref FT_Fixed,ref FT_Angle,void> FT_Vector_Polarize = (delegate* <ref FT_Vector,ref FT_Fixed,ref FT_Angle,void>)NativeLibrary.GetExport(Handle, "FT_Vector_Polarize");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <remarks>
    ///// :FT_Vector_From_Polar@description :
    ///// Compute vector coordinates from a length and angle.@output :
    ///// vec ::
    ///// The address of source vector.@input :
    ///// length ::
    ///// The vector length.angle ::
    ///// The vector angle.
    ///// </remarks>

    //public static unsafe delegate* <ref FT_Vector,FT_Fixed,FT_Angle,void> FT_Vector_From_Polar = (delegate* <ref FT_Vector,FT_Fixed,FT_Angle,void>)NativeLibrary.GetExport(Handle, "FT_Vector_From_Polar");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Library_SetLcdFilter@description :
    ///// This function is used to change filter applied to LCD decimated
    ///// bitmaps, like the ones used when calling @FT _Render_Glyph with
    ///// @FT _RENDER_MODE_LCD or @FT _RENDER_MODE_LCD_V.@input :
    ///// library ::
    ///// A handle to the target library instance.filter ::
    ///// The filter type.You can use @FT _LCD_FILTER_NONE here to disable this feature, or
    ///// @FT _LCD_FILTER_DEFAULT to use a default filter that should work well
    ///// on most LCD screens.@note :
    ///// Since 2.10.3 the LCD filtering is enabled with @FT _LCD_FILTER_DEFAULT.
    ///// It is no longer necessary to call this function explicitly except
    ///// to choose a different filter or disable filtering altogether with
    ///// @FT _LCD_FILTER_NONE.This function does nothing but returns `FT_Err_Unimplemented_Feature`
    ///// if the configuration macro `FT_CONFIG_OPTION_SUBPIXEL_RENDERING` is
    ///// not defined in your build of the library.@since :
    ///// 2.3.0
    ///// </remarks>

    //public static unsafe delegate* <FT_Library,FT_LcdFilter,FT_Error> FT_Library_SetLcdFilter = (delegate* <FT_Library,FT_LcdFilter,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Library_SetLcdFilter");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Library_SetLcdFilterWeights@description :
    ///// This function can be used to enable LCD filter with custom weights,
    ///// instead of using presets in @FT _Library_SetLcdFilter.@input :
    ///// library ::
    ///// A handle to the target library instance.weights ::
    ///// A pointer to an array; the function copies the first five bytes and
    ///// uses them to specify the filter weights in 1/256th units.@note :
    ///// This function does nothing but returns `FT_Err_Unimplemented_Feature`
    ///// if the configuration macro `FT_CONFIG_OPTION_SUBPIXEL_RENDERING` is
    ///// not defined in your build of the library.LCD filter weights can also be set per face using @FT _Face_Properties
    ///// with @FT _PARAM_TAG_LCD_FILTER_WEIGHTS.@since :
    ///// 2.4.0
    ///// </remarks>

    //public static unsafe delegate* <FT_Library,nint,FT_Error> FT_Library_SetLcdFilterWeights = (delegate* <FT_Library,nint,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Library_SetLcdFilterWeights");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0~means success.</returns>
    ///// <remarks>
    ///// :FT_Library_SetLcdGeometry@description :
    ///// This function can be used to modify default positions of color
    ///// subpixels, which controls Harmony LCD rendering.@input :
    ///// library ::
    ///// A handle to the target library instance.sub ::
    ///// A pointer to an array of 3 vectors in 26.6 fractional pixel format;
    ///// the function modifies the default values, see the note below.@note :
    ///// Subpixel geometry examples:- {{-21, 0}, {0, 0}, {21, 0}} is the default, corresponding to 3 color
    ///// stripes shifted by a third of a pixel. This could be an RGB panel.- {{21, 0}, {0, 0}, {-21, 0}} looks the same as the default but can
    ///// specify a BGR panel instead, while keeping the bitmap in the same
    ///// RGB888 format.- {{0, 21}, {0, 0}, {0, -21}} is the vertical RGB, but the bitmap
    ///// stays RGB888 as a result.- {{-11, 16}, {-11, -16}, {22, 0}} is a certain PenTile arrangement.This function does nothing and returns `FT_Err_Unimplemented_Feature`
    ///// in the context of ClearType-style subpixel rendering when
    ///// `FT_CONFIG_OPTION_SUBPIXEL_RENDERING` is defined in your build of the
    ///// library.@since :
    ///// 2.10.0
    ///// </remarks>

    //public static unsafe delegate* <FT_Library,FT_Vector*/*[3]*/,FT_Error> FT_Library_SetLcdGeometry = (delegate* <FT_Library,FT_Vector*/*[3]*/,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Library_SetLcdGeometry");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// Bit flags (see @FT _GASP_XXX), or @FT _GASP_NO_TABLE if there is no
    ///// 'gasp' table in the face.</returns>
    ///// <remarks>
    ///// :FT_Get_Gasp@description :
    ///// For a TrueType or OpenType font file, return the rasterizer behaviour
    ///// flags from the font's 'gasp' table corresponding to a given character
    ///// pixel size.@input :
    ///// face ::
    ///// The source face handle.ppem ::
    ///// The vertical character pixel size.@note :
    ///// If you want to use the MM functionality of OpenType variation fonts
    ///// (i.e., using @FT _Set_Var_Design_Coordinates and friends), call this
    ///// function **after** setting an instance since the return values can
    ///// change.@since :
    ///// 2.3.0
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,uint,int> FT_Get_Gasp = (delegate* <FT_Face,uint,int>)NativeLibrary.GetExport(Handle, "FT_Get_Gasp");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0 means success.</returns>
    ///// <remarks>
    ///// :FT_Get_Advance@description :
    ///// Retrieve the advance value of a given glyph outline in an @FT _Face.@input :
    ///// face ::
    ///// The source @FT _Face handle.gindex ::
    ///// The glyph index.load_flags ::
    ///// A set of bit flags similar to those used when calling
    ///// @FT _Load_Glyph, used to determine what kind of advances you need.@output :
    ///// padvance ::
    ///// The advance value.  If scaling is performed (based on the value of
    ///// `load_flags`), the advance value is in 16.16 format.  Otherwise, it
    ///// is in font units.If @FT _LOAD_VERTICAL_LAYOUT is set, this is the vertical advance
    ///// corresponding to a vertical layout.  Otherwise, it is the horizontal
    ///// advance in a horizontal layout.@note :
    ///// This function may fail if you use @FT _ADVANCE_FLAG_FAST_ONLY and if
    ///// the corresponding font backend doesn't have a quick way to retrieve
    ///// the advances.A scaled advance is returned in 16.16 format but isn't transformed by
    ///// the affine transformation specified by @FT _Set_Transform.
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,uint,int,ref FT_Fixed,FT_Error> FT_Get_Advance = (delegate* <FT_Face,uint,int,ref FT_Fixed,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Get_Advance");

    ///// <summary>
    ///// ************************************************************************
    ///// </summary>
    ///// <returns>:
    ///// FreeType error code.  0 means success.</returns>
    ///// <remarks>
    ///// :FT_Get_Advances@description :
    ///// Retrieve the advance values of several glyph outlines in an @FT _Face.@input :
    ///// face ::
    ///// The source @FT _Face handle.start ::
    ///// The first glyph index.count ::
    ///// The number of advance values you want to retrieve.load_flags ::
    ///// A set of bit flags similar to those used when calling
    ///// @FT _Load_Glyph.@output :
    ///// padvance ::
    ///// The advance values.  This array, to be provided by the caller, must
    ///// contain at least `count` elements.If scaling is performed (based on the value of `load_flags`), the
    ///// advance values are in 16.16 format.  Otherwise, they are in font
    ///// units.If @FT _LOAD_VERTICAL_LAYOUT is set, these are the vertical advances
    ///// corresponding to a vertical layout.  Otherwise, they are the
    ///// horizontal advances in a horizontal layout.@note :
    ///// This function may fail if you use @FT _ADVANCE_FLAG_FAST_ONLY and if
    ///// the corresponding font backend doesn't have a quick way to retrieve
    ///// the advances.Scaled advances are returned in 16.16 format but aren't transformed by
    ///// the affine transformation specified by @FT _Set_Transform.
    ///// </remarks>

    //public static unsafe delegate* <FT_Face,uint,uint,int,ref FT_Fixed,FT_Error> FT_Get_Advances = (delegate* <FT_Face,uint,uint,int,ref FT_Fixed,FT_Error>)NativeLibrary.GetExport(Handle, "FT_Get_Advances");
}