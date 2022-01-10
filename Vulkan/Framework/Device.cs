using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vulkan.Framework
{
    public class Device
    {
        private PhysicalDevice gpu = new in();

        private VkSurfaceKHR _Surface = new VkSurfaceKHR(0);

        private VkDevice _Handle = new VkDevice(0);

        private Array<VkExtensionProperties> _DeviceExtensions = new Array<VkExtensionProperties>();

        private readonly Array<char> _EnabledExtensions = new Array<char>();

        private VmaAllocator _MemoryAllocator = new VmaAllocator(0);

        private Array<Array<Queue>> _Queues = new Array<Array<Queue>>();

        /// A command pool associated to the primary queue
        private std::unique_ptr<CommandPool> _CommandPool = new std::unique_ptr<CommandPool>();

        /// A fence pool associated to the primary queue
        private std::unique_ptr<FencePool> _FencePool = new std::unique_ptr<FencePool>();

        private ResourceCache _ResourceCache = new ResourceCache();
    }
}
