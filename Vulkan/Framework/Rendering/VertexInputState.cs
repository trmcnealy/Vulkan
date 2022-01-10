namespace Vulkan.Framework
{
public class VertexInputState
{
    public Array<VkVertexInputBindingDescription> Bindings = new Array<VkVertexInputBindingDescription>();

    public Array<VkVertexInputAttributeDescription> Attributes = new Array<VkVertexInputAttributeDescription>();
}
} // namespace vkb



namespace Vulkan.Framework
{
    //public partial class GlobalMembers
    //{
    //    public static void SpecializationConstantState.set_constant(uint    constant_id,
    //                                                                in bool data)
    //    {
    //        SetConstant(constant_id, ToBytes((uint)data));
    //    }

    //    public static bool Operator == (in VkVertexInputAttributeDescription lhs, in VkVertexInputAttributeDescription rhs)
    //    {
    //        return std::tie(lhs.binding, lhs.format, lhs.location, lhs.offset) == std::tie(rhs.binding, rhs.format, rhs.location, rhs.offset);
    //    }

    //    public static bool Operator == (in VkVertexInputBindingDescription lhs, in VkVertexInputBindingDescription rhs)
    //    {
    //        return std::tie(lhs.binding, lhs.inputRate, lhs.stride) == std::tie(rhs.binding, rhs.inputRate, rhs.stride);
    //    }

    //    public static bool Operator == (ColorBlendAttachmentState lhs, ColorBlendAttachmentState rhs)
    //    {
    //        return std::tie(lhs.AlphaBlendOp, lhs.BlendEnable, lhs.ColorBlendOp, lhs.ColorWriteMask, lhs.DstAlphaBlendFactor, lhs.DstColorBlendFactor, lhs.SrcAlphaBlendFactor, lhs.SrcColorBlendFactor) ==
    //               std::tie(rhs.AlphaBlendOp, rhs.BlendEnable, rhs.ColorBlendOp, rhs.ColorWriteMask, rhs.DstAlphaBlendFactor, rhs.DstColorBlendFactor, rhs.SrcAlphaBlendFactor, rhs.SrcColorBlendFactor);
    //    }

    //    public static bool Operator != (StencilOpState lhs, StencilOpState rhs)
    //    {
    //        return std::tie(lhs.CompareOp, lhs.DepthFailOp, lhs.FailOp, lhs.PassOp) != std::tie(rhs.CompareOp, rhs.DepthFailOp, rhs.FailOp, rhs.PassOp);
    //    }

    //    public static bool Operator != (VertexInputState lhs, VertexInputState rhs)
    //    {
    //        return lhs.Attributes != rhs.Attributes || lhs.Bindings != rhs.Bindings;
    //    }

    //    public static bool Operator != (InputAssemblyState lhs, InputAssemblyState rhs)
    //    {
    //        return std::tie(lhs.PrimitiveRestartEnable, lhs.Topology) != std::tie(rhs.PrimitiveRestartEnable, rhs.Topology);
    //    }

    //    public static bool Operator != (RasterizationState lhs, RasterizationState rhs)
    //    {
    //        return std::tie(lhs.CullMode, lhs.DepthBiasEnable, lhs.DepthClampEnable, lhs.FrontFace, lhs.FrontFace, lhs.PolygonMode, lhs.RasterizerDiscardEnable) !=
    //               std::tie(rhs.CullMode, rhs.DepthBiasEnable, rhs.DepthClampEnable, rhs.FrontFace, rhs.FrontFace, rhs.PolygonMode, rhs.RasterizerDiscardEnable);
    //    }

    //    public static bool Operator != (ViewportState lhs, ViewportState rhs)
    //    {
    //        return lhs.ViewportCount != rhs.ViewportCount || lhs.ScissorCount != rhs.ScissorCount;
    //    }

    //    public static bool Operator != (MultisampleState lhs, MultisampleState rhs)
    //    {
    //        return std::tie(lhs.AlphaToCoverageEnable, lhs.AlphaToOneEnable, lhs.MinSampleShading, lhs.RasterizationSamples, lhs.SampleMask, lhs.SampleShadingEnable) !=
    //               std::tie(rhs.AlphaToCoverageEnable, rhs.AlphaToOneEnable, rhs.MinSampleShading, rhs.RasterizationSamples, rhs.SampleMask, rhs.SampleShadingEnable);
    //    }

    //    public static bool Operator != (DepthStencilState lhs, DepthStencilState rhs)
    //    {
    //        return std::tie(lhs.DepthBoundsTestEnable, lhs.DepthCompareOp, lhs.DepthTestEnable, lhs.DepthWriteEnable, lhs.StencilTestEnable) !=
    //               std::tie(rhs.DepthBoundsTestEnable, rhs.DepthCompareOp, rhs.DepthTestEnable, rhs.DepthWriteEnable, rhs.StencilTestEnable) || lhs.Back != rhs.Back || lhs.Front != rhs.Front;
    //    }

    //    public static bool Operator != (ColorBlendState lhs, ColorBlendState rhs)
    //    {
    //        return std::tie(lhs.logic_op, lhs.logic_op_enable) != std::tie(rhs.logic_op, rhs.logic_op_enable) || lhs.attachments.size() != rhs.attachments.size() || !std::equal(lhs.attachments.begin(), lhs.attachments.end(), rhs.attachments.begin(),
    //                                                                                                                                                                             (ColorBlendAttachmentState lhs,
    //                                                                                                                                                                              ColorBlendAttachmentState rhs) =>
    //                                                                                                                                                                             {
    //                                                                                                                                                                                 return lhs == rhs;
    //                                                                                                                                                                             });
    //    }
    //}
}