//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Vulkan
//{
//    public sealed class PhysicalDevice
//    {
//        private Instance _instance;

//        public Instance Instance
//        {
//            get
//            {
//                return _instance;
//            }
//            set
//            {
//                _instance = value;
//            }
//        }

//        private VkPhysicalDevice _handle;

//        public VkPhysicalDevice Handle
//        {
//            get
//            {
//                return _handle;
//            }
//            set
//            {
//                _handle = value;
//            }
//        }

//        private VkPhysicalDeviceFeatures _features;

//        public VkPhysicalDeviceFeatures Features
//        {
//            get
//            {
//                return _features;
//            }
//            set
//            {
//                _features = value;
//            }
//        }

//        private VkPhysicalDeviceProperties _properties;

//        public VkPhysicalDeviceProperties Properties
//        {
//            get
//            {
//                return _properties;
//            }
//            set
//            {
//                _properties = value;
//            }
//        }

//        private VkPhysicalDeviceMemoryProperties _memoryProperties;

//        public VkPhysicalDeviceMemoryProperties MemoryProperties
//        {
//            get
//            {
//                return _memoryProperties;
//            }
//            set
//            {
//                _memoryProperties = value;
//            }
//        }

//        private VkQueueFamilyProperties[] _queueFamilyProperties;

//        public VkQueueFamilyProperties[] QueueFamilyProperties
//        {
//            get
//            {
//                return _queueFamilyProperties;
//            }
//            set
//            {
//                _queueFamilyProperties = value;
//            }
//        }

//        public VkPhysicalDeviceFeatures _requestedFeatures;

//        public VkPhysicalDeviceFeatures RequestedFeatures
//        {
//            get
//            {
//                return _requestedFeatures;
//            }
//            set
//            {
//                _requestedFeatures = value;
//            }
//        }

//        public nint _lastRequestedExtensionFeature;

//        //private Dictionary<VkStructureType, void> _extensionFeatures;

//        private bool _highPriorityGraphicsQueue;

//        public PhysicalDevice(Instance instance, VkPhysicalDevice physical_device)
//        {
//            unsafe
//            {
//                Instance = instance;
//                Handle   = physical_device;

//                Api.GetPhysicalDeviceFeatures(physical_device, out _features);
//                Api.GetPhysicalDeviceProperties(physical_device, out _properties);
//                Api.GetPhysicalDeviceMemoryProperties(physical_device, out _memoryProperties);
                
//                QueueFamilyProperties = Api.GetPhysicalDeviceQueueFamilyProperties(physical_device);
//            }
//        }

//    }
//}
