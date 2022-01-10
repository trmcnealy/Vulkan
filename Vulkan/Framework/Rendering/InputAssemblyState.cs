namespace Vulkan.Framework;

public class InputAssemblyState
{
    public VkPrimitiveTopology Topology = new VkPrimitiveTopology(VK_PRIMITIVE_TOPOLOGY_TRIANGLE_LIST);

    public Bool32 PrimitiveRestartEnable = new Bool32(false);
}