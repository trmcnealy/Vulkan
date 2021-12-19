namespace Vulkan
{
    public enum VkShadingRatePaletteEntryNV : uint
    {
        NoInvocations              = 0,
        SixteenInvocationsPerPixel = 1,
        EightInvocationsPerPixel   = 2,
        FourInvocationsPerPixel    = 3,
        TwoInvocationsPerPixel     = 4,
        OneInvocationPerPixel      = 5,
        OneInvocationPer2X1Pixels  = 6,
        OneInvocationPer1X2Pixels  = 7,
        OneInvocationPer2X2Pixels  = 8,
        OneInvocationPer4X2Pixels  = 9,
        OneInvocationPer2X4Pixels  = 10,
        OneInvocationPer4X4Pixels  = 11,
        MaxEnumFlag                = 0x7FFFFFFF
    }
}
