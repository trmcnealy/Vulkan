namespace Vulkan
{
    public enum VkIndirectCommandsTokenTypeNV : uint
    {
        ShaderGroup  = 0,
        StateFlags   = 1,
        IndexBuffer  = 2,
        VertexBuffer = 3,
        PushConstant = 4,
        DrawIndexed  = 5,
        Draw         = 6,
        Drawasks     = 7,
        MaxEnumFlag  = 0x7FFFFFFF
    }
}
