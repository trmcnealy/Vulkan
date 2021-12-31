namespace Vulkan.Framework;

public enum GraphicsType
{
    NONE,
    POINT,

    LINE,
    LINE_STRIP,
    TRIANGLE,
    TRIANGLE_STRIP,
    TRIANGLE_FAN,

    MARKER,

    SEGMENT,
    ARROW,
    PATH,
    TEXT,

    IMAGE,
    IMAGE_CMAP,

    VOLUME_SLICE,
    MESH,

    FAKE_SPHERE,
    VOLUME,

    COUNT,
    CUSTOM
}