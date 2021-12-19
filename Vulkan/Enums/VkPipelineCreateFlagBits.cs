using System;

namespace Vulkan
{
    [Flags]
    public enum VkPipelineCreateFlagBits : uint
    {
        DisableOptimization                     = 0x00000001,
        AllowDerivatives                        = 0x00000002,
        Derivative                              = 0x00000004,
        ViewIndexFromDeviceIndex                = 0x00000008,
        DispatchBase                            = 0x00000010,
        RayracingNoNullAnyHitShaders            = 0x00004000,
        RayracingNoNullClosestHitShaders        = 0x00008000,
        RayracingNoNullMissShaders              = 0x00010000,
        RayracingNoNullIntersectionShaders      = 0x00020000,
        RayracingSkipriangles                   = 0x00001000,
        RayracingSkipAabbs                      = 0x00002000,
        RayracingShaderGroupHandleCaptureReplay = 0x00080000,
        DeferCompile                            = 0x00000020,
        CaptureStatistics                       = 0x00000040,
        CaptureInternalRepresentations          = 0x00000080,
        IndirectBindable                        = 0x00040000,
        Library                                 = 0x00000800,
        FailOnPipelineCompileRequired           = 0x00000100,
        EarlyReturnOnFailure                    = 0x00000200,
        RayracingAllowMotion                    = 0x00100000,
        MaxEnumFlag                             = 0x7FFFFFFF
    }
}
