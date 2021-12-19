using System;
using System.Runtime.InteropServices;

namespace FreeType;

/// <summary>
/// ************************************************************************
/// </summary>
/// <remarks>
/// :FT_Encoding@description :
/// An enumeration to specify character sets supported by charmaps.  Used
/// in the @FT _Select_Charmap API function.@note :
/// Despite the name, this enumeration lists specific character
/// repertories (i.e., charsets), and not text encoding methods (e.g.,
/// UTF-8, UTF-16, etc.).Other encodings might be defined in the future.@values :
/// FT_ENCODING_NONE ::
/// The encoding value~0 is reserved for all formats except BDF, PCF,
/// and Windows FNT; see below for more information.FT_ENCODING_UNICODE ::
/// The Unicode character set.  This value covers all versions of the
/// Unicode repertoire, including ASCII and Latin-1.  Most fonts include
/// a Unicode charmap, but not all of them.For example, if you want to access Unicode value U+1F028 (and the
/// font contains it), use value 0x1F028 as the input value for
/// @FT _Get_Char_Index.FT_ENCODING_MS_SYMBOL ::
/// Microsoft Symbol encoding, used to encode mathematical symbols and
/// wingdings.  For more information, see
/// 'https://www.microsoft.com/typography/otspec/recom.htm#non-standard-symbol-fonts',
/// 'http://www.kostis.net/charsets/symbol.htm', and
/// 'http://www.kostis.net/charsets/wingding.htm'.This encoding uses character codes from the PUA (Private Unicode
/// Area) in the range U+F020-U+F0FF.FT_ENCODING_SJIS ::
/// Shift JIS encoding for Japanese.  More info at
/// 'https://en.wikipedia.org/wiki/Shift_JIS'.  See note on multi-byte
/// encodings below.FT_ENCODING_PRC ::
/// Corresponds to encoding systems mainly for Simplified Chinese as
/// used in People's Republic of China (PRC).  The encoding layout is
/// based on GB~2312 and its supersets GBK and GB~18030.FT_ENCODING_BIG5 ::
/// Corresponds to an encoding system for Traditional Chinese as used in
/// Taiwan and Hong Kong.FT_ENCODING_WANSUNG ::
/// Corresponds to the Korean encoding system known as Extended Wansung
/// (MS Windows code page 949).  For more information see
/// 'https://www.unicode.org/Public/MAPPINGS/VENDORS/MICSFT/WindowsBestFit/bestfit949.txt'.FT_ENCODING_JOHAB ::
/// The Korean standard character set (KS~C 5601-1992), which
/// corresponds to MS Windows code page 1361.  This character set
/// includes all possible Hangul character combinations.FT_ENCODING_ADOBE_LATIN_1 ::
/// Corresponds to a Latin-1 encoding as defined in a Type~1 PostScript
/// font.  It is limited to 256 character codes.FT_ENCODING_ADOBE_STANDARD ::
/// Adobe Standard encoding, as found in Type~1, CFF, and OpenType/CFF
/// fonts.  It is limited to 256 character codes.FT_ENCODING_ADOBE_EXPERT ::
/// Adobe Expert encoding, as found in Type~1, CFF, and OpenType/CFF
/// fonts.  It is limited to 256 character codes.FT_ENCODING_ADOBE_CUSTOM ::
/// Corresponds to a custom encoding, as found in Type~1, CFF, and
/// OpenType/CFF fonts.  It is limited to 256 character codes.FT_ENCODING_APPLE_ROMAN ::
/// Apple roman encoding.  Many TrueType and OpenType fonts contain a
/// charmap for this 8-bit encoding, since older versions of Mac OS are
/// able to use it.FT_ENCODING_OLD_LATIN_2 ::
/// This value is deprecated and was neither used nor reported by
/// FreeType.  Don't use or test for it.FT_ENCODING_MS_SJIS ::
/// Same as FT_ENCODING_SJIS.  Deprecated.FT_ENCODING_MS_GB2312 ::
/// Same as FT_ENCODING_PRC.  Deprecated.FT_ENCODING_MS_BIG5 ::
/// Same as FT_ENCODING_BIG5.  Deprecated.FT_ENCODING_MS_WANSUNG ::
/// Same as FT_ENCODING_WANSUNG.  Deprecated.FT_ENCODING_MS_JOHAB ::
/// Same as FT_ENCODING_JOHAB.  Deprecated.@note :
/// When loading a font, FreeType makes a Unicode charmap active if
/// possible (either if the font provides such a charmap, or if FreeType
/// can synthesize one from PostScript glyph name dictionaries; in either
/// case, the charmap is tagged with `FT_ENCODING_UNICODE`).  If such a
/// charmap is synthesized, it is placed at the first position of the
/// charmap array.All other encodings are considered legacy and tagged only if
/// explicitly defined in the font file.  Otherwise, `FT_ENCODING_NONE` is
/// used.`FT_ENCODING_NONE` is set by the BDF and PCF drivers if the charmap is
/// neither Unicode nor ISO-8859-1 (otherwise it is set to
/// `FT_ENCODING_UNICODE`).  Use @FT _Get_BDF_Charset_ID to find out which
/// encoding is really present.  If, for example, the `cs_registry` field
/// is 'KOI8' and the `cs_encoding` field is 'R', the font is encoded in
/// KOI8-R.`FT_ENCODING_NONE` is always set (with a single exception) by the
/// winfonts driver.  Use @FT _Get_WinFNT_Header and examine the `charset`
/// field of the @FT _WinFNT_HeaderRec structure to find out which encoding
/// is really present.  For example, @FT _WinFNT_ID_CP1251 (204) means
/// Windows code page 1251 (for Russian).`FT_ENCODING_NONE` is set if `platform_id` is @TT _PLATFORM_MACINTOSH
/// and `encoding_id` is not `TT_MAC_ID_ROMAN` (otherwise it is set to
/// `FT_ENCODING_APPLE_ROMAN`).If `platform_id` is @TT _PLATFORM_MACINTOSH, use the function
/// @FT _Get_CMap_Language_ID to query the Mac language ID that may be
/// needed to be able to distinguish Apple encoding variants.  Seehttps://www.unicode.org/Public/MAPPINGS/VENDORS/APPLE/Readme.txtto get an idea how to do that.  Basically, if the language ID is~0,
/// don't use it, otherwise subtract 1 from the language ID.  Then examine
/// `encoding_id`.  If, for example, `encoding_id` is `TT_MAC_ID_ROMAN`
/// and the language ID (minus~1) is `TT_MAC_LANGID_GREEK`, it is the
/// Greek encoding, not Roman.  `TT_MAC_ID_ARABIC` with
/// `TT_MAC_LANGID_FARSI` means the Farsi variant the Arabic encoding.
/// </remarks>
[Flags]
public enum FT_Encoding : uint
{
    FT_ENCODING_NONE           = unchecked(((uint)0             << 24) | ((uint)0             << 16) | ((uint)0             << 8) | 0),
    FT_ENCODING_MS_SYMBOL      = unchecked(((uint)((byte)('s')) << 24) | ((uint)((byte)('y')) << 16) | ((uint)((byte)('m')) << 8) | (byte)('b')),
    FT_ENCODING_UNICODE        = unchecked(((uint)((byte)('u')) << 24) | ((uint)((byte)('n')) << 16) | ((uint)((byte)('i')) << 8) | (byte)('c')),
    FT_ENCODING_SJIS           = unchecked(((uint)((byte)('s')) << 24) | ((uint)((byte)('j')) << 16) | ((uint)((byte)('i')) << 8) | (byte)('s')),
    FT_ENCODING_PRC            = unchecked(((uint)((byte)('g')) << 24) | ((uint)((byte)('b')) << 16) | ((uint)((byte)(' ')) << 8) | (byte)(' ')),
    FT_ENCODING_BIG5           = unchecked(((uint)((byte)('b')) << 24) | ((uint)((byte)('i')) << 16) | ((uint)((byte)('g')) << 8) | (byte)('5')),
    FT_ENCODING_WANSUNG        = unchecked(((uint)((byte)('w')) << 24) | ((uint)((byte)('a')) << 16) | ((uint)((byte)('n')) << 8) | (byte)('s')),
    FT_ENCODING_JOHAB          = unchecked(((uint)((byte)('j')) << 24) | ((uint)((byte)('o')) << 16) | ((uint)((byte)('h')) << 8) | (byte)('a')),
    FT_ENCODING_GB2312         = FT_ENCODING_PRC,
    FT_ENCODING_MS_SJIS        = FT_ENCODING_SJIS,
    FT_ENCODING_MS_GB2312      = FT_ENCODING_PRC,
    FT_ENCODING_MS_BIG5        = FT_ENCODING_BIG5,
    FT_ENCODING_MS_WANSUNG     = FT_ENCODING_WANSUNG,
    FT_ENCODING_MS_JOHAB       = FT_ENCODING_JOHAB,
    FT_ENCODING_ADOBE_STANDARD = unchecked(((uint)((byte)('A')) << 24) | ((uint)((byte)('D')) << 16) | ((uint)((byte)('O')) << 8) | (byte)('B')),
    FT_ENCODING_ADOBE_EXPERT   = unchecked(((uint)((byte)('A')) << 24) | ((uint)((byte)('D')) << 16) | ((uint)((byte)('B')) << 8) | (byte)('E')),
    FT_ENCODING_ADOBE_CUSTOM   = unchecked(((uint)((byte)('A')) << 24) | ((uint)((byte)('D')) << 16) | ((uint)((byte)('B')) << 8) | (byte)('C')),
    FT_ENCODING_ADOBE_LATIN_1  = unchecked(((uint)((byte)('l')) << 24) | ((uint)((byte)('a')) << 16) | ((uint)((byte)('t')) << 8) | (byte)('1')),
    FT_ENCODING_OLD_LATIN_2    = unchecked(((uint)((byte)('l')) << 24) | ((uint)((byte)('a')) << 16) | ((uint)((byte)('t')) << 8) | (byte)('2')),
    FT_ENCODING_APPLE_ROMAN = unchecked(((uint)((byte)('a')) << 24) | ((uint)((byte)('r')) << 16) | ((uint)((byte)('m')) << 8) | (byte)('n')),
}