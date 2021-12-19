//using System;
//using System.Collections.Generic;

//using static Vulkan.Enums;
//using static Vulkan.ExtensionNames;

//namespace Vulkan
//{
//    public class VulkanException : Exception
//    {
//        public VkResult Result {get; set;}

//        public VulkanException(VkResult result, string msg = "Vulkan error") : base(msg+result.ToString())
//        {
//            Result=result;
//        }
//    }

//    public sealed class Instance //: IDisposable
//    {
//        private VkInstance _handle;

//        private readonly utf8string[] _enabledExtensions;


//        private List<PhysicalDevice> _gpus;




//        //public Instance(utf8string                    application_name,
//        //                Dictionary<utf8cstring, bool> required_extensions,
//        //                List<utf8cstring>             required_validation_layers,
//        //                bool                          headless,
//        //                uint                          api_version)
//        //{
//        //    unsafe
//        //    {
//        //        VkExtensionProperties[] available_instance_extensions = Api.EnumerateInstanceExtensionProperties();

//        //        _enabledExtensions = new utf8string[]
//        //        {
//        //            VK_KHR_SURFACE,
//        //            VK_KHR_WIN32_SURFACE
//        //        };


//        //        List<VkLayerProperties> supported_validation_layers = new List<VkLayerProperties>(instance_layer_count);


//        //        List<char > requested_validation_layers = new List<char >(required_validation_layers);



//        //        VkApplicationInfo app_info = new()
//        //        {
//        //            SType            = VkStructureType.ApplicationInfo,
//        //            PApplicationName = application_name,
//        //            ApiVersion       = Api.ApiVersion
//        //        };

//        //        VkInstanceCreateInfo instanceCreateInfo = new()
//        //        {
//        //            SType                 = VkStructureType.InstanceCreateInfo,
//        //            EnabledExtensionNames = _enabledExtensions,
//        //            PApplicationInfo      = &app_info
//        //        };

//        //        VkInstanceCreateInfo instance_info = new VkInstanceCreateInfo(VK_STRUCTURE_TYPE_INSTANCE_CREATE_INFO);

//        //        instance_info.pApplicationInfo = app_info;

//        //        instance_info.enabledExtensionCount   = Vkb.GlobalMembers.ToU32(_enabledExtensions.Count);
//        //        instance_info.ppEnabledExtensionNames = _enabledExtensions.data();

//        //        instance_info.enabledLayerCount   = Vkb.GlobalMembers.ToU32(requested_validation_layers.Count);
//        //        instance_info.ppEnabledLayerNames = requested_validation_layers.data();


//        //        result = vkCreateInstance(instance_info, null, _handle);

//        //        if (result != VK_SUCCESS)
//        //        {
//        //            throw new VulkanException(result, "Could not create Vulkan instance");
//        //        }

//        //        _handle = new VkInstance(ref instanceCreateInfo);


//        //        QueryGpus();
//        //    }
//        //}

//        //public Instance(VkInstance instance)
//        //{
//        //    this._handle = instance;

//        //    if (_handle != VkInstance.Null)
//        //    {
//        //        QueryGpus();
//        //    }
//        //    else
//        //    {
//        //        throw new System.Exception("Instance not valid");
//        //    }
//        //}

//        //public void Dispose()
//        //{
//        //    if (_handle != VK_NULL_HANDLE)
//        //    {
//        //        vkDestroyInstance(_handle, null);
//        //    }
//        //}

//        //public void QueryGpus()
//        //{
//        //    uint physical_device_count = new uint();
//        //    do
//        //    {
//        //        VkResult err = vkEnumeratePhysicalDevices(_handle, physical_device_count, null);
//        //        if (err != null)
//        //        {
//        //            (...) spdlog.error("[{}:{}] {}", ((char)__FILE__ + ROOT_PATH_SIZE), __LINE__, fmt.format(__VA_ARGS__));
//        //            ("Detected Vulkan error: {}", Vkb.GlobalMembers.ToString(new VkResult(err)));
//        //            abort();
//        //        }
//        //    } while (false);

//        //    if (physical_device_count < 1)
//        //    {
//        //        throw new System.Exception("Couldn't find a physical device that supports Vulkan.");
//        //    }

//        //    List<VkPhysicalDevice> physical_devices = new List<VkPhysicalDevice>();
//        //    physical_devices.Resize(physical_device_count);
//        //    do
//        //    {
//        //        VkResult err = vkEnumeratePhysicalDevices(_handle, physical_device_count, physical_devices.data());
//        //        if (err != null)
//        //        {
//        //            (...) spdlog.error("[{}:{}] {}", ((char)__FILE__ + ROOT_PATH_SIZE), __LINE__, fmt.format(__VA_ARGS__));
//        //            ("Detected Vulkan error: {}", Vkb.GlobalMembers.ToString(new VkResult(err)));
//        //            abort();
//        //        }
//        //    } while (false);

//        //    foreach (var physical_device in physical_devices)
//        //    {
//        //        _gpus.Add(std::make_unique<PhysicalDevice>(this, physical_device));
//        //    }
//        //}

//        //public PhysicalDevice GetSuitableGpu(VkSurfaceKHR surface)
//        //{
//        //    foreach (var gpu in _gpus)
//        //    {
//        //        if (gpu.get_properties().deviceType == VK_PHYSICAL_DEVICE_TYPE_DISCRETE_GPU)
//        //        {
//        //            nint queue_count = gpu.get_queue_family_properties().size();
//        //            for (uint queue_idx = 0; (nint)queue_idx < queue_count; queue_idx++)
//        //            {
//        //                if (gpu.is_present_supported(surface, queue_idx))
//        //                {
//        //                    return new std::unique_ptr<PhysicalDevice>(gpu);
//        //                }
//        //            }
//        //        }
//        //    }

//        //    (...) spdlog.warn(__VA_ARGS__);
//        //    ("Couldn't find a discrete physical device, picking default GPU");

//        //    return new std::unique_ptr<PhysicalDevice>(_gpus[0]);
//        //}

//        //public PhysicalDevice GetFirstGpu()
//        //{

//        //    foreach (var gpu in _gpus)
//        //    {
//        //        if (gpu.get_properties().deviceType == VK_PHYSICAL_DEVICE_TYPE_DISCRETE_GPU)
//        //        {
//        //            return new std::unique_ptr<PhysicalDevice>(gpu);
//        //        }
//        //    }

//        //    (...) spdlog.warn(__VA_ARGS__);
//        //    ("Couldn't find a discrete physical device, picking default GPU");
//        //    return new std::unique_ptr<PhysicalDevice>(_gpus[0]);
//        //}

//        //public bool IsEnabled(string extension)
//        //{
//        //    return _enabledExtensions.Exists((string enabled_extension) =>
//        //    {
//        //        return strcmp(extension, enabled_extension) == 0;
//        //    });
//        //}

//        //public VkInstance GetHandle()
//        //{
//        //    return new VkInstance(_handle);
//        //}

//        //public List< char > GetExtensions()
//        //{
//        //    return new List<char >(_enabledExtensions);
//        //}


//    }
//}
