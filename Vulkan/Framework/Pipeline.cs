namespace Vulkan.Framework;

public class Pipeline
{
    protected Device Device;

    protected VkPipeline Handle = 0;

    protected PipelineState State = new PipelineState();
}
