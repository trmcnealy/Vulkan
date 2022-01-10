namespace Vulkan.Framework;

public class CommandPool
{
    private Device _Device;

    private VkCommandPool _Handle = new VkCommandPool(0);

    private RenderFrame _RenderFrame = new RenderFrame(null);

    private nint _ThreadIndex = new nint();

    private uint _QueueFamilyIndex = new uint();

    private Array<std::unique_ptr<CommandBuffer>> _PrimaryCommandBuffers = new Array<std::unique_ptr<CommandBuffer>>();

    private uint _ActivePrimaryCommandBufferCount = new uint();

    private Array<std::unique_ptr<CommandBuffer>> _SecondaryCommandBuffers = new Array<std::unique_ptr<CommandBuffer>>();

    private uint _ActiveSecondaryCommandBufferCount = new uint();

    private CommandBuffer.ResetMode _ResetMode = CommandBuffer.ResetMode.ResetPool;
}
