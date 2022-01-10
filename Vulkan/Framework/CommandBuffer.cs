using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vulkan.Framework
{
    public class CommandBuffer
    {
        public enum ResetMode
        {
            ResetPool,
            ResetIndividually,
            AlwaysAllocate
        }

        public enum State
        {
            Invalid,
            Initial,
            Recording,
            Executable
        }

        public class RenderPassBinding
        {
            public readonly RenderPass RenderPass;

            public readonly Framebuffer Framebuffer;
        }

        public readonly VkCommandBufferLevel Level = new VkCommandBufferLevel();

        private State _State = State.Initial;

        private CommandPool _CommandPool;

        private VkCommandBuffer _Handle = new VkCommandBuffer(0);

        private RenderPassBinding _CurrentRenderPass = new RenderPassBinding();

        private PipelineState _PipelineState = new PipelineState();

        private ResourceBindingState _ResourceBindingState = new ResourceBindingState();

        private Array<byte> _StoredPushConstants = new Array<byte>();

        private uint _MaxPushConstantsSize = new uint();

        private VkExtent2D _LastFramebufferExtent = new VkExtent2D();

        private VkExtent2D _LastRenderAreaExtent = new VkExtent2D();

        // If true, it becomes the responsibility of the caller to update ANY descriptor bindings
        // that contain update after bind, as they wont be implicitly updated
        private bool _UpdateAfterBind = false;

        private Dictionary<uint, DescriptorSetLayout> _DescriptorSetLayoutBindingState = new Dictionary<uint, DescriptorSetLayout>();
    }
}
