namespace Vulkan.Framework;

public enum DataType
{
    NONE,
    CUSTOM, // used for structured arrays (aka record arrays)
    STR,    // 64 bits, pointer

    CHAR, // 8 bits, unsigned int
    CVEC2,
    CVEC3,
    CVEC4,

    USHORT, // 16 bits, unsigned int
    USVEC2,
    USVEC3,
    USVEC4,

    SHORT, // 16 bits, signed int
    SVEC2,
    SVEC3,
    SVEC4,

    UINT, // 32 bits, unsigned int
    UVEC2,
    UVEC3,
    UVEC4,

    INT, // 32 bits, signed int
    IVEC2,
    IVEC3,
    IVEC4,

    FLOAT, // 32 bits float
    VEC2,
    VEC3,
    VEC4,

    DOUBLE, // 64 bits double
    DVEC2,
    DVEC3,
    DVEC4,

    MAT2, // matrices of floats
    MAT3,
    MAT4
}