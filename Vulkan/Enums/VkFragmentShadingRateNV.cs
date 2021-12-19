namespace Vulkan
{
    public enum VkFragmentShadingRateNV : uint
    {
        OneInvocationPerPixel      = 0,
        OneInvocationPer1X2Pixels  = 1,
        OneInvocationPer2X1Pixels  = 4,
        OneInvocationPer2X2Pixels  = 5,
        OneInvocationPer2X4Pixels  = 6,
        OneInvocationPer4X2Pixels  = 9,
        OneInvocationPer4X4Pixels  = 10,
        TwoInvocationsPerPixel     = 11,
        FourInvocationsPerPixel    = 12,
        EightInvocationsPerPixel   = 13,
        SixteenInvocationsPerPixel = 14,
        NoInvocations              = 15,
        MaxEnumFlag                = 0x7FFFFFFF
    }
}
