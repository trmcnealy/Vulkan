namespace Vulkan
{
    public enum VkPrimitiveTopology : uint
    {
        PointList                  = 0,
        LineList                   = 1,
        LineStrip                  = 2,
        TriangleList               = 3,
        TriangleStrip              = 4,
        TriangleFan                = 5,
        LineListWithAdjacency      = 6,
        LineStripWithAdjacency     = 7,
        TriangleListWithAdjacency  = 8,
        TriangleStripWithAdjacency = 9,
        PatchList                  = 10,
        MaxEnumFlag                = 0x7FFFFFFF
    }
}
