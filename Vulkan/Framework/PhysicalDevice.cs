using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vulkan.Framework
{
    public class PhysicalDevice
    {
        private Instance _Instance;

        private VkPhysicalDevice _Handle;

        private VkPhysicalDeviceFeatures _Features;

        private VkPhysicalDeviceProperties _Properties;

        private VkPhysicalDeviceMemoryProperties _MemoryProperties;

        private Array<VkQueueFamilyProperties> _QueueFamilyProperties;

        private VkPhysicalDeviceFeatures _RequestedFeatures;

        private nint _LastRequestedExtensionFeature;

        private Dictionary<VkStructureType, nuint> _ExtensionFeatures;

        private bool _HighPriorityGraphicsQueue;

        public PhysicalDevice(Instance         instance,
                              VkPhysicalDevice physical_device)
        {
            unsafe
            {
                _Instance = instance;
                _Handle   = physical_device;

                Api.GetPhysicalDeviceFeatures(physical_device, out _Features);

                Api.GetPhysicalDeviceProperties(physical_device, out _Properties);

                Api.GetPhysicalDeviceMemoryProperties(physical_device, out _MemoryProperties);


                _QueueFamilyProperties = physical_device.GetPhysicalDeviceQueueFamilyProperties();


                _ExtensionFeatures = new Dictionary<VkStructureType, nuint>();
            }
        }


        public Instance GetInstance()
        {
            return _Instance;
        }


        public Bool32 IsPresentSupported(VkSurfaceKHR surface,
                                         uint         queue_family_index)
        {
            Bool32 present_supported = false;

            if(surface != 0)
            {
                unsafe
                {
                    VkResult err = Api.GetPhysicalDeviceSurfaceSupportKHR(_Handle, queue_family_index, surface, out present_supported);

                    if(err != VkResult.Success)
                    {
                        VulkanException.Throw($"Detected Vulkan error: {err}");
                    }
                }
            }

            return present_supported;
        }

        public VkFormatProperties GetFormatProperties(VkFormat format)
        {
            VkFormatProperties format_properties = _Handle.GetPhysicalDeviceFormatProperties(format);

            return format_properties;
        }

        public VkPhysicalDevice GetHandle()
        {
            return _Handle;
        }

        public VkPhysicalDeviceFeatures GetFeatures()
        {
            return _Features;
        }

        public VkPhysicalDeviceProperties GetProperties()
        {
            return _Properties;
        }

        public VkPhysicalDeviceMemoryProperties GetMemoryProperties()
        {
            return _MemoryProperties;
        }

        public Array<VkQueueFamilyProperties> GetQueueFamilyProperties()
        {
            return _QueueFamilyProperties;
        }

        public VkPhysicalDeviceFeatures GetRequestedFeatures()
        {
            return _RequestedFeatures;
        }

        public VkPhysicalDeviceFeatures GetMutableRequestedFeatures()
        {
            return _RequestedFeatures;
        }

        public nint GetExtensionFeatureChain()
        {
            return _LastRequestedExtensionFeature;
        }

        public T RequestExtensionFeatures<T>(VkStructureType type)
        {
            if(!_Instance.IsEnabled(ExtensionNames.VK_KHR_GET_PHYSICAL_DEVICE_PROPERTIES_2))
            {
                throw new System.Exception("Couldn't request feature from device as " + new utf8string(VK_KHR_GET_PHYSICAL_DEVICE_PROPERTIES_2) + " isn't enabled!");
            }

            var extension_features_it = _ExtensionFeatures.find(type);
            if(extension_features_it != _ExtensionFeatures.end())
            {
                return (T)extension_features_it.second.get();
            }

            VkPhysicalDeviceFeatures2KHR physical_device_features = new VkPhysicalDeviceFeatures2KHR(VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FEATURES_2_KHR);
            T                            extension                = new T(type);
            physical_device_features.pNext = extension;
            vkGetPhysicalDeviceFeatures2KHR(_Handle, physical_device_features);

            _ExtensionFeatures.insert({
                type, new T(extension)
            });

            var extension_ptr = (T)(_ExtensionFeatures[type].get());

            if(_LastRequestedExtensionFeature != null)
            {
                extension_ptr.pNext = _LastRequestedExtensionFeature;
            }

            _LastRequestedExtensionFeature = extension_ptr;

            return extension_ptr;
        }

        public void SetHighPriorityGraphicsQueueEnable(bool enable)
        {
            _HighPriorityGraphicsQueue = enable;
        }

        public bool HasHighPriorityGraphicsQueue()
        {
            return _HighPriorityGraphicsQueue;
        }
    }
}
