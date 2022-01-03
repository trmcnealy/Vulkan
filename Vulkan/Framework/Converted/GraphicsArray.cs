namespace Vulkan.Framework;

public sealed class GraphicsArray
{
    public static readonly GraphicsArray Null = new();

    public DataType type       { get; set; }
    public uint     components  { get; set; } // number of components, ie 2 for vec2, 3 for dvec3, etc.
    public ulong    item_size   { get; set; }
    public uint     item_count  { get; set; }
    public ulong    buffer_size { get; set; }
    public nint     data        { get; set; }

    // 3D arrays
    public uint     ndims { get; set; } // 1, 2, or 3
    public Vector3U shape { get; set; } // only for 3D arrays

    private GraphicsArray()
    {
    }

    public GraphicsArray(nint data)
    {
        this.data = data;
    }

    public GraphicsArray(DataType type,
                         uint     components,
                         ulong    itemSize,
                         uint     itemCount,
                         ulong    bufferSize,
                         uint     ndims,
                         Vector3U shape)
    {
        this.type       = type;
        this.components = components;
        item_size       = itemSize;
        item_count      = itemCount;
        buffer_size     = bufferSize;
        this.ndims      = ndims;
        this.shape      = shape;
    }
}