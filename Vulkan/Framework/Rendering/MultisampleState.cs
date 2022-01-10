namespace Vulkan.Framework;

public class MultisampleState
{
    public VkSampleCountFlagBits RasterizationSamples = new VkSampleCountFlagBits(VK_SAMPLE_COUNT_1_BIT);

    public Bool32 SampleShadingEnable = new Bool32(false);

    public float MinSampleShading = 0.0f;

    public VkSampleMask SampleMask = new VkSampleMask();

    public Bool32 AlphaToCoverageEnable = new Bool32(false);

    public Bool32 AlphaToOneEnable = new Bool32(false);
}