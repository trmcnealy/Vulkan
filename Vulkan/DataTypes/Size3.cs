using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan;

[StructLayout(LayoutKind.Explicit)]
public struct Size3
{
    [FieldOffset(0)]
    private float _width;

    [FieldOffset(sizeof(float))]
    private float _height;

    [FieldOffset(sizeof(float) * 2)]
    private float _depth;


    public float Width
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get { return _width; }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { _width = value; }
    }

    public float Height
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get { return _height; }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { _height = value; }
    }

    public float Depth
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get { return _depth; }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set { _depth = value; }
    }

    public Size3(float width,
                  float height,
                  float depth)
    {
        _width  = width;
        _height = height;
        _depth  = depth;
    }
}
