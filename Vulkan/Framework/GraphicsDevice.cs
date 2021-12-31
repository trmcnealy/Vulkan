using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vulkan.Framework
{
    public sealed class GraphicsDevice
    {
        public static readonly GraphicsDevice Null = new();

        public uint                             Index                  { get; set; }
        public utf8string                       Name                   { get; set; }
        public VkDevice                         Device                 { get; set; }
        public VkPhysicalDevice                 PhysicalDevice         { get; set; }
        public VkPhysicalDeviceProperties       DeviceProperties       { get; set; }
        public VkPhysicalDeviceFeatures         DeviceFeatures         { get; set; }
        public VkPhysicalDeviceFeatures         RequestedFatures       { get; set; }
        public VkPhysicalDeviceMemoryProperties DeviceMemoryProperties { get; set; }
        public ulong                            VRAM                   { get; set; }
        public DeviceQueues                     Queues                 { get; set; }
        public Array<VkPresentModeKHR>          PresentModes           { get; set; }
        public VkDescriptorPool                 DescriptorPool         { get; set; }


        private GraphicsDevice()
        {
            Queues       = DeviceQueues.Null;
            PresentModes = Array.Empty<VkPresentModeKHR>();
        }

        public GraphicsDevice(VkDevice device)
        {
            Device       = device;
            PresentModes = new();
            Queues       = DeviceQueues.Null;
        }

        public GraphicsDevice(uint       index,
                              utf8string name,
                              VkDevice   device)
        {
            Index        = index;
            Name         = name;
            Device       = device;
            PresentModes = new();
            Queues       = DeviceQueues.Null;
        }
    }
}
