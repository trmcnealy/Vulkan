using System;

namespace Vulkan
{
    [Flags]
    public enum VkPipelineStageFlagBits : uint
    {
        TopOfPipe                     = 0x00000001,
        DrawIndirect                  = 0x00000002,
        VertexInput                   = 0x00000004,
        VertexShader                  = 0x00000008,
        TessellationControlShader     = 0x00000010,
        TessellationEvaluationShader  = 0x00000020,
        GeometryShader                = 0x00000040,
        FragmentShader                = 0x00000080,
        EarlyFragmentests             = 0x00000100,
        LateFragmentests              = 0x00000200,
        ColorAttachmentOutput         = 0x00000400,
        ComputeShader                 = 0x00000800,
        Transfer                      = 0x00001000,
        BottomOfPipe                  = 0x00002000,
        Host                          = 0x00004000,
        AllGraphics                   = 0x00008000,
        AllCommands                   = 0x00010000,
        TransformFeedback             = 0x01000000,
        ConditionalRendering          = 0x00040000,
        AccelerationStructureBuild    = 0x02000000,
        RayracingShader               = 0x00200000,
        TaskShader                    = 0x00080000,
        MeshShader                    = 0x00100000,
        FragmentDensityProcess        = 0x00800000,
        FragmentShadingRateAttachment = 0x00400000,
        CommandPreprocess             = 0x00020000,
        None                          = 0,
        MaxEnumFlag                   = 0x7FFFFFFF
    }
}
