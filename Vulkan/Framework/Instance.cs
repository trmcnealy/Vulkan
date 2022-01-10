using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Vulkan.Framework
{
    public class Instance : System.IDisposable
    {
        private VkInstance _Handle;

        private Array<utf8string> _EnabledExtensions;

        private Array<PhysicalDevice> _Gpus;

        public Instance()
        {
        }

        public Instance(utf8string                       application_name,
                        Dictionary<utf8string, bool> required_extensions,
                        Array<utf8string>            required_validation_layers,
                        bool                         headless = false)
        {
            unsafe
            {
                _EnabledExtensions = new Array<utf8string>();
                _Gpus              = new Array<PhysicalDevice>();


                VkExtensionProperties[] available_instance_extensions = Api.EnumerateInstanceExtensionProperties();

                if(Debugger.IsAttached)
                {
                    bool debug_utils = false;

                    foreach(VkExtensionProperties available_extension in available_instance_extensions)
                    {
                        if(available_extension.ExtensionName == ExtensionNames.VK_EXT_DEBUG_UTILS)
                        {
                            debug_utils = true;
                            _EnabledExtensions.Add(ExtensionNames.VK_EXT_DEBUG_UTILS);
                        }
                        else if(available_extension.ExtensionName == ExtensionNames.VK_LAYER_KHRONOS_VALIDATION)
                        {
                            _EnabledExtensions.Add(ExtensionNames.VK_LAYER_KHRONOS_VALIDATION);
                        }
                    }

                    if(!debug_utils)
                    {
                        _EnabledExtensions.Add(ExtensionNames.VK_EXT_DEBUG_REPORT);
                    }
                }


                if(headless)
                {
                    bool headless_extension = false;

                    foreach(VkExtensionProperties available_extension in available_instance_extensions)
                    {
                        if(available_extension.ExtensionName == ExtensionNames.VK_EXT_HEADLESS_SURFACE)
                        {
                            headless_extension = true;
                            _EnabledExtensions.Add(ExtensionNames.VK_EXT_HEADLESS_SURFACE);
                            break;
                        }
                    }

                    if(!headless_extension)
                    {
                        VulkanException.Throw($"{ExtensionNames.VK_EXT_HEADLESS_SURFACE} is not available, disabling swapchain creation");
                    }
                }
                else
                {
                    _EnabledExtensions.Add(ExtensionNames.VK_KHR_SURFACE);
                }

                foreach(VkExtensionProperties available_extension in available_instance_extensions)
                {
                    if(available_extension.ExtensionName == ExtensionNames.VK_KHR_GET_PHYSICAL_DEVICE_PROPERTIES_2)
                    {
                        _EnabledExtensions.Add(ExtensionNames.VK_KHR_GET_PHYSICAL_DEVICE_PROPERTIES_2);
                        break;
                    }
                }

                foreach(KeyValuePair<utf8string, bool> extension in required_extensions)
                {
                    utf8string extension_name        = extension.Key;
                    bool       extension_is_optional = extension.Value;
                    bool       found_extension       = false;

                    foreach(VkExtensionProperties available_extension in available_instance_extensions)
                    {
                        if(available_extension.ExtensionName == extension_name)
                        {
                            found_extension = true;
                            _EnabledExtensions.Add(extension_name);
                            break;
                        }
                    }

                    if(!found_extension && !extension_is_optional)
                    {
                        VulkanException.Throw($"Required instance extension {extension_name} not available, cannot run");
                    }
                }

                VkLayerProperties[] supported_validation_layers = Api.EnumerateInstanceLayerProperties();


                utf8string[] requested_validation_layers = new utf8string[]
                {
                    KhronosLayers.VALIDATION
                };

//#if VKB_VALIDATION_LAYERS
//            // Determine the optimal validation layers to enable that are necessary for useful debugging
//            Array<char > optimal_validation_layers = Vkb.GlobalMembers.GetOptimalValidationLayers(supported_validation_layers);
//            requested_validation_layers.AddRange(optimal_validation_layers);
//#endif

//            if(GlobalMembers.ValidateLayers(requested_validation_layers, supported_validation_layers))
//            {
//                (...) spdlog.info(__VA_ARGS__);
//                ("Enabled Validation Layers:") for(in auto
//            layer :
//                requested_validation_layers)
//                {
//                    (...) spdlog.info(__VA_ARGS__);
//                    ("	\t{}", layer);
//                }
//            }
//            else
//            {
//                throw new System.Exception("Required validation layers are missing.");
//            }

                VkApplicationInfo app_info = Utilities.PreMake<VkApplicationInfo>();
                app_info.PApplicationName = "Vulkan Render";
                app_info.ApiVersion       = Api.ApiVersion.ToVulkanVersion();

                VkInstanceCreateInfo instance_info = Utilities.PreMake<VkInstanceCreateInfo>();
                instance_info.PApplicationInfo      = &app_info;
                instance_info.EnabledExtensionNames = _EnabledExtensions.ToArray();
                instance_info.EnabledLayerNames     = requested_validation_layers;

#if DEBUG || VKB_VALIDATION_LAYERS
                //VkDebugUtilsMessengerCreateInfoEXT debug_utils_create_info  = new VkDebugUtilsMessengerCreateInfoEXT(VK_STRUCTURE_TYPE_DEBUG_UTILS_MESSENGER_CREATE_INFO_EXT);
                //VkDebugReportCallbackCreateInfoEXT debug_report_create_info = new VkDebugReportCallbackCreateInfoEXT(VK_STRUCTURE_TYPE_DEBUG_REPORT_CREATE_INFO_EXT);
                //if(debug_utils)
                //{
                //    debug_utils_create_info.messageSeverity = VK_DEBUG_UTILS_MESSAGE_SEVERITY_ERROR_BIT_EXT  | VK_DEBUG_UTILS_MESSAGE_SEVERITY_WARNING_BIT_EXT;
                //    debug_utils_create_info.messageType     = VK_DEBUG_UTILS_MESSAGE_TYPE_VALIDATION_BIT_EXT | VK_DEBUG_UTILS_MESSAGE_TYPE_PERFORMANCE_BIT_EXT;
                //    debug_utils_create_info.pfnUserCallback = GlobalMembers.debug_utils_messenger_callback;

                //    instance_info.pNext = debug_utils_create_info;
                //}
                //else
                //{
                //    debug_report_create_info.flags       = VK_DEBUG_REPORT_ERROR_BIT_EXT | VK_DEBUG_REPORT_WARNING_BIT_EXT | VK_DEBUG_REPORT_PERFORMANCE_WARNING_BIT_EXT;
                //    debug_report_create_info.pfnCallback = GlobalMembers.debug_callback;

                //    instance_info.pNext = debug_report_create_info;
                //}
#endif

#if (DEBUG || VKB_VALIDATION_LAYERS) && VKB_VALIDATION_LAYERS_GPU_ASSISTED
            //VkValidationFeaturesEXT validation_features_info = new VkValidationFeaturesEXT(VK_STRUCTURE_TYPE_VALIDATION_FEATURES_EXT);
            //if (validation_features)
            //{
            //    VkValidationFeatureEnableEXT[] enable_features = {VK_VALIDATION_FEATURE_ENABLE_GPU_ASSISTED_RESERVE_BINDING_SLOT_EXT, VK_VALIDATION_FEATURE_ENABLE_GPU_ASSISTED_EXT};
            //    validation_features_info.enabledValidationFeatureCount = 2;
            //    validation_features_info.pEnabledValidationFeatures = enable_features;
            //    validation_features_info.pNext = instance_info.pNext;
            //    instance_info.pNext = validation_features_info;
            //}
#endif

                _Handle = new VkInstance(ref instance_info);

#if DEBUG || VKB_VALIDATION_LAYERS
                //if(debug_utils)
                //{
                //    result = vkCreateDebugUtilsMessengerEXT(_Handle, debug_utils_create_info, null, _DebugUtilsMessenger);
                //    if(result != VK_SUCCESS)
                //    {
                //        throw new VulkanException(result, "Could not create debug utils messenger");
                //    }
                //}
                //else
                //{
                //    result = vkCreateDebugReportCallbackEXT(_Handle, debug_report_create_info, null, _DebugReportCallback);
                //    if(result != VK_SUCCESS)
                //    {
                //        throw new VulkanException(result, "Could not create debug report callback");
                //    }
                //}
#endif

                QueryGpus();
            }
        }

        public Instance(VkInstance instance)
        {
            _EnabledExtensions = new Array<utf8string>();
            _Gpus              = new Array<PhysicalDevice>();
            _Handle            = instance;

            if(_Handle != 0)
            {
                QueryGpus();
            }
            else
            {
                VulkanException.Throw("Instance not valid");
            }
        }

        public void Dispose()
        {
#if DEBUG || VKB_VALIDATION_LAYERS
            //if(_DebugUtilsMessenger != 0)
            //{
            //    vkDestroyDebugUtilsMessengerEXT(_Handle, _DebugUtilsMessenger, null);
            //}

            //if(_DebugReportCallback != 0)
            //{
            //    vkDestroyDebugReportCallbackEXT(_Handle, _DebugReportCallback, null);
            //}
#endif

            if(_Handle != 0)
            {
                unsafe
                {
                    Api.DestroyInstance(_Handle, null);
                }
            }
        }

        public void QueryGpus()
        {
            VkPhysicalDevice[] physical_devices = _Handle.EnumeratePhysicalDevices();

            foreach(VkPhysicalDevice physical_device in physical_devices)
            {
                _Gpus.Add(new PhysicalDevice(this, physical_device));
            }
        }

        public PhysicalDevice GetSuitableGpu(VkSurfaceKHR surface)
        {
            foreach(PhysicalDevice gpu in _Gpus)
            {
                if(gpu.GetProperties().DeviceType == VkPhysicalDeviceType.DiscreteGpu)
                {
                    int queue_count = gpu.GetQueueFamilyProperties().Count;

                    for(uint queue_idx = 0; (nint)queue_idx < queue_count; queue_idx++)
                    {
                        if(gpu.IsPresentSupported(surface, queue_idx))
                        {
                            return gpu;
                        }
                    }
                }
            }

            //("Couldn't find a discrete physical device, picking default GPU");
            return _Gpus[0];
        }

        public PhysicalDevice GetFirstGpu()
        {
            foreach(PhysicalDevice gpu in _Gpus)
            {
                if(gpu.GetProperties().DeviceType == VkPhysicalDeviceType.DiscreteGpu)
                {
                    return gpu;
                }
            }

            //("Couldn't find a discrete physical device, picking default GPU");
            return _Gpus[0];
        }

        public bool IsEnabled(utf8string extension)
        {
            return _EnabledExtensions.Exists((utf8string enabled_extension) =>
            {
                return (extension == enabled_extension);
            });
        }

        public VkInstance GetHandle()
        {
            return _Handle;
        }

        public Array<utf8string> GetExtensions()
        {
            return _EnabledExtensions;
        }
    }
}
