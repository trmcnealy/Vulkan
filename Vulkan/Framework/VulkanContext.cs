using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using static Vulkan.Enums;

namespace Vulkan.Framework
{
    public sealed class VulkanContext
    {
        public unsafe struct Features11Old
        {
            public VkPhysicalDeviceMultiviewFeatures              Multiview;
            public VkPhysicalDevice16BitStorageFeatures           T16BitStorage;
            public VkPhysicalDeviceSamplerYcbcrConversionFeatures SamplerYcbcrConversion;
            public VkPhysicalDeviceProtectedMemoryFeatures        ProtectedMemory;
            public VkPhysicalDeviceShaderDrawParametersFeatures   DrawParameters;
            public VkPhysicalDeviceVariablePointersFeatures       VariablePointers;


            public Features11Old()
            {
                Multiview = new()
                {
                    SType = VkStructureType.PhysicalDeviceMultiviewFeatures
                };
                T16BitStorage = new()
                {
                    SType = VkStructureType.PhysicalDevice16BitStorageFeatures
                };
                SamplerYcbcrConversion = new()
                {
                    SType = VkStructureType.PhysicalDeviceSamplerYcbcrConversionFeatures
                };
                ProtectedMemory = new()
                {
                    SType = VkStructureType.PhysicalDeviceProtectedMemoryFeatures
                };
                DrawParameters = new()
                {
                    SType = VkStructureType.PhysicalDeviceShaderDrawParametersFeatures
                };
                VariablePointers = new()
                {
                    SType = VkStructureType.PhysicalDeviceVariablePointersFeatures
                };


                Multiview.PNext              = (nuint)Unsafe.AsPointer(ref T16BitStorage);
                T16BitStorage.PNext          = (nuint)Unsafe.AsPointer(ref SamplerYcbcrConversion);
                SamplerYcbcrConversion.PNext = (nuint)Unsafe.AsPointer(ref ProtectedMemory);
                ProtectedMemory.PNext        = (nuint)Unsafe.AsPointer(ref DrawParameters);
                DrawParameters.PNext         = (nuint)Unsafe.AsPointer(ref VariablePointers);
                VariablePointers.PNext       = 0;
            }

            public void Read(in VkPhysicalDeviceVulkan11Features features11)
            {
                Multiview.Multiview                              = features11.Multiview;
                Multiview.MultiviewGeometryShader                = features11.MultiviewGeometryShader;
                Multiview.MultiviewTessellationShader            = features11.MultiviewTessellationShader;
                T16BitStorage.StorageBuffer16BitAccess           = features11.StorageBuffer16BitAccess;
                T16BitStorage.StorageInputOutput16               = features11.StorageInputOutput16;
                T16BitStorage.StoragePushConstant16              = features11.StoragePushConstant16;
                T16BitStorage.UniformAndStorageBuffer16BitAccess = features11.UniformAndStorageBuffer16BitAccess;
                SamplerYcbcrConversion.SamplerYcbcrConversion    = features11.SamplerYcbcrConversion;
                ProtectedMemory.ProtectedMemory                  = features11.ProtectedMemory;
                DrawParameters.ShaderDrawParameters              = features11.ShaderDrawParameters;
                VariablePointers.VariablePointers                = features11.VariablePointers;
                VariablePointers.VariablePointersStorageBuffer   = features11.VariablePointersStorageBuffer;
            }

            public void Write(ref VkPhysicalDeviceVulkan11Features features11)
            {
                features11.Multiview                          = Multiview.Multiview;
                features11.MultiviewGeometryShader            = Multiview.MultiviewGeometryShader;
                features11.MultiviewTessellationShader        = Multiview.MultiviewTessellationShader;
                features11.StorageBuffer16BitAccess           = T16BitStorage.StorageBuffer16BitAccess;
                features11.StorageInputOutput16               = T16BitStorage.StorageInputOutput16;
                features11.StoragePushConstant16              = T16BitStorage.StoragePushConstant16;
                features11.UniformAndStorageBuffer16BitAccess = T16BitStorage.UniformAndStorageBuffer16BitAccess;
                features11.SamplerYcbcrConversion             = SamplerYcbcrConversion.SamplerYcbcrConversion;
                features11.ProtectedMemory                    = ProtectedMemory.ProtectedMemory;
                features11.ShaderDrawParameters               = DrawParameters.ShaderDrawParameters;
                features11.VariablePointers                   = VariablePointers.VariablePointers;
                features11.VariablePointersStorageBuffer      = VariablePointers.VariablePointersStorageBuffer;
            }
        }

        public unsafe struct Properties11Old
        {
            public VkPhysicalDeviceMaintenance3Properties    Maintenance3;
            public VkPhysicalDeviceIDProperties              DeviceId;
            public VkPhysicalDeviceMultiviewProperties       Multiview;
            public VkPhysicalDeviceProtectedMemoryProperties ProtectedMemory;
            public VkPhysicalDevicePointClippingProperties   PointClipping;
            public VkPhysicalDeviceSubgroupProperties        Subgroup;

            public Properties11Old()
            {
                Maintenance3 = new()
                {
                    SType = VkStructureType.PhysicalDeviceMaintenance3Properties
                };
                DeviceId = new()
                {
                    SType = VkStructureType.PhysicalDeviceIdProperties
                };
                Multiview = new()
                {
                    SType = VkStructureType.PhysicalDeviceMultiviewProperties
                };
                ProtectedMemory = new()
                {
                    SType = VkStructureType.PhysicalDeviceProtectedMemoryProperties
                };
                PointClipping = new()
                {
                    SType = VkStructureType.PhysicalDevicePointClippingProperties
                };
                Subgroup = new()
                {
                    SType = VkStructureType.PhysicalDeviceSubgroupProperties
                };


                Maintenance3.PNext    = (nuint)Unsafe.AsPointer(ref DeviceId);
                DeviceId.PNext        = (nuint)Unsafe.AsPointer(ref Multiview);
                Multiview.PNext       = (nuint)Unsafe.AsPointer(ref ProtectedMemory);
                ProtectedMemory.PNext = (nuint)Unsafe.AsPointer(ref PointClipping);
                PointClipping.PNext   = (nuint)Unsafe.AsPointer(ref Subgroup);
                Subgroup.PNext        = 0;
            }

            public void Write(ref VkPhysicalDeviceVulkan11Properties properties11)
            {
                Api.MemoryCopy(ref properties11.DeviceLuid, ref DeviceId.DeviceLuid, Unsafe.SizeOf<Fixed<byte, Const.UInt16>>());
                Api.MemoryCopy(ref properties11.DeviceUuid, ref DeviceId.DeviceUuid, Unsafe.SizeOf<Fixed<byte, Const.UInt16>>());
                Api.MemoryCopy(ref properties11.DriverUuid, ref DeviceId.DriverUuid, Unsafe.SizeOf<Fixed<byte, Const.UInt8>>());

                properties11.DeviceLuidValid                   = DeviceId.DeviceLuidValid;
                properties11.DeviceNodeMask                    = DeviceId.DeviceNodeMask;
                properties11.SubgroupSize                      = Subgroup.SubgroupSize;
                properties11.SubgroupSupportedStages           = Subgroup.SupportedStages;
                properties11.SubgroupSupportedOperations       = Subgroup.SupportedOperations;
                properties11.SubgroupQuadOperationsInAllStages = Subgroup.QuadOperationsInAllStages;
                properties11.PointClippingBehavior             = PointClipping.PointClippingBehavior;
                properties11.MaxMultiviewViewCount             = Multiview.MaxMultiviewViewCount;
                properties11.MaxMultiviewInstanceIndex         = Multiview.MaxMultiviewInstanceIndex;
                properties11.ProtectedNoFault                  = ProtectedMemory.ProtectedNoFault;
                properties11.MaxPerSetDescriptors              = Maintenance3.MaxPerSetDescriptors;
                properties11.MaxMemoryAllocationSize           = Maintenance3.MaxMemoryAllocationSize;
            }
        }

        public struct PhysicalDeviceInfo
        {
            public VkPhysicalDeviceMemoryProperties   MemoryProperties;
            public Array<VkQueueFamilyProperties>     QueueProperties;
            public VkPhysicalDeviceFeatures           Features10;
            public VkPhysicalDeviceVulkan11Features   Features11;
            public VkPhysicalDeviceVulkan12Features   Features12;
            public VkPhysicalDeviceProperties         Properties10;
            public VkPhysicalDeviceVulkan11Properties Properties11;
            public VkPhysicalDeviceVulkan12Properties Properties12;

            public PhysicalDeviceInfo()
            {
                MemoryProperties = new();
                QueueProperties  = new();
                Features10       = new();
                Features11 = new()
                {
                    SType = VkStructureType.PhysicalDeviceVulkan11Features
                };
                Features12 = new()
                {
                    SType = VkStructureType.PhysicalDeviceVulkan12Features
                };
                Properties10 = new();
                Properties11 = new()
                {
                    SType = VkStructureType.PhysicalDeviceVulkan11Properties
                };
                Properties12 = new()
                {
                    SType = VkStructureType.PhysicalDeviceVulkan12Properties
                };
            }
        }

        public struct Queue
        {
            public VkQueue VkQueue;
            public uint    FamilyIndex;
            public uint    QueueIndex;
            public float   Priority;

            public Queue()
            {
                VkQueue     = VkQueue.Null;
                FamilyIndex = uint.MaxValue;
                QueueIndex  = uint.MaxValue;
                Priority    = 1.0f;
            }

            public static implicit operator VkQueue(Queue queue)
            {
                return queue.VkQueue;
            }

            public static implicit operator uint(Queue queue)
            {
                return queue.FamilyIndex;
            }
        }

        public struct QueueScore
        {
            public uint  Score;
            public uint  FamilyIndex;
            public uint  QueueIndex;
            public float Priority;

            public QueueScore()
            {
                Score       = 0;
                FamilyIndex = uint.MaxValue;
                QueueIndex  = uint.MaxValue;
                Priority    = 1.0f;
            }

            public QueueScore(uint  score,
                              uint  familyIndex,
                              uint  queueIndex,
                              float priority)
            {
                Score       = score;
                FamilyIndex = familyIndex;
                QueueIndex  = queueIndex;
                Priority    = priority;
            }
        }

        public struct VkAnyStruct
        {
            public VkStructureType SType;
            public nuint           PNext;
        }

        public  Version            ApiVersion { get; }
        public  VkInstance         Instance;
        public  VkDevice           Device;
        public  VkPhysicalDevice   PhysicalDevice;
        public  PhysicalDeviceInfo PhysicalInfo;
        public  Queue              QueueGCT;
        public  Queue              QueueT;
        public  Queue              QueueC;
        private Array<QueueScore>  AvailableQueues        { get; set; }
        private Array<utf8string>  UsedInstanceLayers     { get; set; }
        private Array<utf8string>  UsedInstanceExtensions { get; set; }
        private Array<utf8string>  UsedDeviceExtensions   { get; set; }

        private unsafe delegate*<VkInstance, VkDebugUtilsMessengerCreateInfoEXT*, VkAllocationCallbacks*, VkDebugUtilsMessengerEXT, VkResult> CreateDebugUtilsMessengerEXT  = null;
        private unsafe delegate*<VkInstance, VkDebugUtilsMessengerEXT, VkAllocationCallbacks*, void>                                          DestroyDebugUtilsMessengerEXT = null;
        private        VkDebugUtilsMessengerEXT                                                                                               DbgMessenger                  = VkDebugUtilsMessengerEXT.Null;

        private HashSet<int> DbgIgnoreMessages { get; set; }

        public VulkanContext(ContextCreateInfo info)
        {
            ApiVersion = Api.ApiVersion;

            AvailableQueues        = new();
            UsedInstanceLayers     = new();
            UsedInstanceExtensions = new();
            UsedDeviceExtensions   = new();

            DbgIgnoreMessages = new();

            PhysicalInfo = new();

            if(!InitInstance(info))
            {
                //return false;
            }

            Array<uint> compatibleDevices = GetCompatibleDevices(info);

            if(compatibleDevices.Count == 0)
            {
                Debug.Assert(false, "No compatible device found");
                //return false;
            }

            InitDevice(compatibleDevices[(int)info.CompatibleDeviceIndex], info);

            //CreateDebugUtilsMessengerEXT  = mCreateDebugUtilsMessengerExt;
            //DestroyDebugUtilsMessengerEXT = mDestroyDebugUtilsMessengerExt;
            //DbgMessenger                  = mDbgMessenger;
        }

        public void InitQueueList(Array<QueueScore> list,
                                  uint[]            maxFamilyCounts,
                                  float[]           priorities,
                                  uint              maxQueueCount)
        {
            VkQueueFamilyProperties queueFamily;
            QueueScore              score;

            bool select_qIMax         = maxFamilyCounts.Length != 0;
            bool select_prioritiesMax = priorities.Length      != 0;

            for(uint qF = 0; qF < PhysicalInfo.QueueProperties.Count; ++qF)
            {
                queueFamily = PhysicalInfo.QueueProperties[qF];

                score = new QueueScore(0, qF, 0, 1.0f);

                for(uint i = 0; i < 32; i++)
                {
                    if((((uint)queueFamily.QueueFlags) & (1 << (int)i)) != 0)
                    {
                        score.Score++;
                    }
                }

                for(uint qI = 0; qI < (select_qIMax ? maxFamilyCounts[qF] : queueFamily.QueueCount); ++qI)
                {
                    score.QueueIndex = qI;

                    if(select_prioritiesMax)
                    {
                        score.Priority = priorities[qF * maxQueueCount + qI];
                    }

                    list.Add(score);
                }
            }


            IComparer<QueueScore> comparer = Comparer<QueueScore>.Create((QueueScore lhs,
                                                                          QueueScore rhs) =>
            {
                if(lhs.Score < rhs.Score)
                {
                    return -1;
                }

                if(lhs.Score > rhs.Score)
                {
                    return 1;
                }

                if(lhs.Priority > rhs.Priority)
                {
                    return -1;
                }

                if(lhs.Priority < rhs.Priority)
                {
                    return 1;
                }

                if(lhs.QueueIndex > rhs.QueueIndex)
                {
                    return -1;
                }

                if(lhs.QueueIndex < rhs.QueueIndex)
                {
                    return 1;
                }

                return 0;
            });

            list.Sort(comparer);
        }

        public QueueScore RemoveQueueListItem(Array<QueueScore> list,
                                              VkQueueFlagBits   needFlagBits,
                                              float             priority)
        {
            QueueScore              score;
            VkQueueFamilyProperties family;

            for(int q = 0; q < list.Count; ++q)
            {
                score  = list[q];
                family = PhysicalInfo.QueueProperties[(int)score.FamilyIndex];

                if((family.QueueFlags & needFlagBits) == needFlagBits && (Math.Abs(score.Priority - priority) < float.Epsilon))
                {
                    QueueScore queue = score;

                    queue.FamilyIndex = score.FamilyIndex;

                    queue.QueueIndex = score.QueueIndex;

                    list.RemoveAt(q);

                    return queue;
                }
            }

            return new QueueScore();
        }

        public Queue CreateQueue(VkQueueFlagBits requiredFlagBits,
                                 utf8string      debugName,
                                 float           priority = 1.0f)
        {
            if(requiredFlagBits == VkQueueFlagBits.Unknown || AvailableQueues.Count == 0)
            {
                return new Queue();
            }

            QueueScore score = RemoveQueueListItem(AvailableQueues, requiredFlagBits, priority);

            if(score.Score == 0)
            {
                return new Queue();
            }

            DebugUtil debugUtil = new(Device);

            Queue queue = new()
            {
                FamilyIndex = score.FamilyIndex,
                QueueIndex  = score.QueueIndex,
                Priority    = score.Priority
            };
            queue.VkQueue = Device.GetDeviceQueue(queue.FamilyIndex, queue.QueueIndex);

            debugUtil.SetObjectName(queue.VkQueue, debugName);

            return queue;
        }

        public static implicit operator VkDevice(VulkanContext context)
        {
            return context.Device;
        }

        public void Deinit()
        {
            if(Device != VkDevice.Null)
            {
                VkResult result = Device.DeviceWaitIdle();

                Api.Check(result);

                Device.Dispose(VkInstance.Null, VkDevice.Null);
            }

            //if (DestroyDebugUtilsMessengerEXT != null)
            //{
            //    destroyDebugUtilsMessengerEXT(Instance, DbgMessenger, null);
            //}

            if(Instance != VkInstance.Null)
            {
                Instance.Dispose(VkInstance.Null, VkDevice.Null);
            }

            UsedInstanceExtensions.Clear();
            UsedInstanceLayers.Clear();
            UsedDeviceExtensions.Clear();

            //CreateDebugUtilsMessengerEXT = null;
            //DestroyDebugUtilsMessengerEXT = null;
            //DbgMessenger = null;

            //DebugUtil.setEnabled(false);
        }

        public bool InitInstance(ContextCreateInfo info)
        {
            unsafe
            {
                VkApplicationInfo applicationInfo = new()
                {
                    SType            = VkStructureType.ApplicationInfo,
                    PApplicationName = info.AppTitle,
                    PEngineName      = info.AppEngine,
                    ApiVersion       = Api.MAKE_VERSION(info.ApiVersion.Major, info.ApiVersion.Minor, 0)
                };

                if(info.VerboseUsed)
                {
                    uint     version = 0;
                    VkResult result  = Api.EnumerateInstanceVersion(ref version);
                    Api.Check(result);
                    Debug.Write($"_______________\n");
                    Debug.Write($"Vulkan Version:\n");
                    Debug.Write($" - available:  {Api.GET_VERSION_MAJOR(version)}.{Api.GET_VERSION_MINOR(version)}.{Api.GET_VERSION_PATCH(version)}\n");
                    Debug.Write($" - requesting: {info.ApiVersion.Major}.{info.ApiVersion.Minor}.{0}\n");
                }

                {
                    Array<VkLayerProperties> layerProperties = GetInstanceLayers();

                    if(FillFilteredNameArray(UsedInstanceLayers, layerProperties, info.InstanceLayers) != VkResult.Success)
                    {
                        return false;
                    }

                    if(info.VerboseAvailable)
                    {
                        Debug.Write($"___________________________\n");
                        Debug.Write($"Available Instance Layers :\n");
                        foreach(VkLayerProperties it in layerProperties)
                        {
                            Debug.Write($"{it.LayerName} (v. {Api.GET_VERSION_MAJOR(it.SpecVersion)}.{Api.GET_VERSION_MINOR(it.SpecVersion)}.{Api.GET_VERSION_PATCH(it.SpecVersion)} {it.ImplementationVersion}) : {it.Description}\n");
                        }
                    }
                }

                {
                    Array<VkExtensionProperties> extensionProperties = GetInstanceExtensions();

                    Array<nuint> featureStructs = new();

                    if(FillFilteredNameArray(UsedInstanceExtensions, extensionProperties, info.InstanceExtensions, featureStructs) != VkResult.Success)
                    {
                        return false;
                    }

                    if(info.VerboseAvailable)
                    {
                        Debug.Write($"\n");
                        Debug.Write($"Available Instance Extensions :\n");
                        foreach(VkExtensionProperties it in extensionProperties)
                        {
                            Debug.Write($"{it.ExtensionName} (v. {it.SpecVersion})\n");
                        }
                    }
                }

                if(info.VerboseUsed)
                {
                    Debug.Write($"______________________\n");
                    Debug.Write($"Used Instance Layers :\n");
                    foreach(utf8string it in UsedInstanceLayers)
                    {
                        Debug.Write($"{it}\n");
                    }

                    Debug.Write($"\n");
                    Debug.Write($"Used Instance Extensions :\n");
                    foreach(utf8string it in UsedInstanceExtensions)
                    {
                        Debug.Write($"{it}\n");
                    }
                }

                Array<utf8string> usedInstanceLayers     = new();
                Array<utf8string> usedInstanceExtensions = new();

                foreach(utf8string it in UsedInstanceExtensions)
                {
                    usedInstanceExtensions.Add(it);
                }

                foreach(utf8string it in UsedInstanceLayers)
                {
                    usedInstanceLayers.Add(it);
                }

                VkInstanceCreateInfo instanceCreateInfo = new()
                {
                    SType                 = VkStructureType.InstanceCreateInfo,
                    PApplicationInfo      = &applicationInfo,
                    EnabledExtensionNames = usedInstanceExtensions.ToArray(),
                    EnabledLayerNames     = usedInstanceLayers.ToArray(),
                    PNext                 = info.InstanceCreateInfoExt
                };

                Instance = new(ref instanceCreateInfo);

                foreach(utf8string it in usedInstanceExtensions)
                {
                    if(utf8string.Compare(it, ExtensionNames.VK_EXT_DEBUG_UTILS_EXTENSION_NAME) == 0)
                    {
                        InitDebugUtils();
                        break;
                    }
                }

                return true;
            }
        }

        public bool InitDevice(uint              deviceIndex,
                               ContextCreateInfo info)
        {
            unsafe
            {
                Debug.Assert(Instance != null);

                VkPhysicalDeviceGroupProperties physicalGroup = new();

                if(info.UseDeviceGroups)
                {
                    Array<VkPhysicalDeviceGroupProperties> groups = GetPhysicalDeviceGroups();

                    Debug.Assert(deviceIndex < (uint)groups.Count);

                    physicalGroup = groups[deviceIndex];

                    PhysicalDevice = physicalGroup.PhysicalDevices[0];
                }
                else
                {
                    Array<VkPhysicalDevice> physicalDevices = GetPhysicalDevices();

                    Debug.Assert(deviceIndex < (uint)physicalDevices.Count);

                    PhysicalDevice = physicalDevices[deviceIndex];
                }

                InitPhysicalInfo(PhysicalInfo, PhysicalDevice, info.ApiVersion);

                Array<VkDeviceQueueCreateInfo> queueCreateInfos = new();
                Array<float>                   priorities       = new();

                {
                    Array<QueueScore> queueScoresTemp = new();

                    uint maxQueueCount = 0;

                    foreach(VkQueueFamilyProperties it in PhysicalInfo.QueueProperties)
                    {
                        maxQueueCount = Math.Max(maxQueueCount, it.QueueCount);
                    }

                    priorities.Resize(PhysicalInfo.QueueProperties.Count * (int)maxQueueCount);

                    InitQueueList(queueScoresTemp, Array.Empty<uint>(), Array.Empty<float>(), 0);

                    Array<uint> queueFamilyCounts = new(PhysicalInfo.QueueProperties.Count);

                    foreach(ContextCreateInfo.QueueSetup it in info.RequestedQueues)
                    {
                        for(uint i = 0; i < it.Count; i++)
                        {
                            QueueScore queue = RemoveQueueListItem(queueScoresTemp, it.RequiredFlagBits, 1.0f);
                            if(queue.Score == 0)
                            {
                                Debug.Write($"could not setup requested queue configuration\n");
                                return false;
                            }

                            priorities[queue.FamilyIndex * maxQueueCount + queueFamilyCounts[queue.FamilyIndex]] = it.Priority;
                            queueFamilyCounts[queue.FamilyIndex]++;
                        }
                    }

                    for(uint i = 0; i < PhysicalInfo.QueueProperties.Count; ++i)
                    {
                        if(queueFamilyCounts[i] != 0)
                        {
                            VkDeviceQueueCreateInfo queueInfo = new()
                            {
                                SType            = VkStructureType.DeviceQueueCreateInfo,
                                QueueFamilyIndex = i,
                                QueueCount       = queueFamilyCounts[i],
                                QueuePriorities  = priorities.ToArray()[0..(int)(i * maxQueueCount)] // + 
                            };

                            queueCreateInfos.Add(queueInfo);
                        }
                    }

                    InitQueueList(AvailableQueues, queueFamilyCounts.ToArray(), priorities.ToArray(), maxQueueCount);
                }

                VkDeviceCreateInfo deviceCreateInfo = new()
                {
                    SType            = VkStructureType.DeviceCreateInfo,
                    QueueCreateInfos = queueCreateInfos.ToArray()
                };

                VkPhysicalDeviceFeatures2 features2 = new()
                {
                    SType = VkStructureType.PhysicalDeviceFeatures2
                };

                Features11Old features11old  = new();
                Array<nuint>  featureStructs = new();

                features2.Features = PhysicalInfo.Features10;
                features11old.Read(PhysicalInfo.Features11);

                if(info.ApiVersion.Major == 1 && info.ApiVersion.Minor == 1)
                {
                    unsafe
                    {
                        features2.PNext = (nuint)Unsafe.AsPointer(ref features11old.Multiview);
                    }
                }
                else if(info.ApiVersion.Major == 1 && info.ApiVersion.Minor >= 2)
                {
                    unsafe
                    {
                        features2.PNext               = (nuint)Unsafe.AsPointer(ref PhysicalInfo.Features11);
                        PhysicalInfo.Features11.PNext = (nuint)Unsafe.AsPointer(ref PhysicalInfo.Features12);
                        PhysicalInfo.Features12.PNext = 0;
                    }
                }

                Array<VkExtensionProperties> extensionProperties = GetDeviceExtensions(PhysicalDevice);

                if(info.VerboseAvailable)
                {
                    Debug.Write($"_____________________________\n");
                    Debug.Write($"Available Device Extensions :\n");

                    foreach(VkExtensionProperties it in extensionProperties)
                    {
                        Debug.Write($"{it.ExtensionName} (v. {it.SpecVersion})\n");
                    }
                }

                if(FillFilteredNameArray(UsedDeviceExtensions, extensionProperties, info.DeviceExtensions, featureStructs) != VkResult.Success)
                {
                    Deinit();
                    return false;
                }

                if(info.VerboseUsed)
                {
                    Debug.Write($"________________________\n");
                    Debug.Write($"Used Device Extensions :\n");
                    foreach(utf8string it in UsedDeviceExtensions)
                    {
                        Debug.Write($"{it}\n");
                    }

                    Debug.Write($"\n");
                }

                if(featureStructs.Count > 0)
                {
                    unsafe
                    {
                        VkAnyStruct* header;

                        for(uint i = 0; i < featureStructs.Count; i++)
                        {
                            header = (VkAnyStruct*)Unsafe.AsPointer(ref featureStructs.Ref(i));

                            header->PNext = (i < featureStructs.Count - 1) ? featureStructs[i + 1] : 0;
                        }

                        VkAnyStruct* lastCoreFeature = (VkAnyStruct*)Unsafe.AsPointer(ref features2);

                        while(lastCoreFeature->PNext != 0)
                        {
                            lastCoreFeature = (VkAnyStruct*)lastCoreFeature->PNext;
                        }

                        lastCoreFeature->PNext = featureStructs[0];

                        Api.GetPhysicalDeviceFeatures2(PhysicalDevice, ref features2);
                    }
                }

                if(info.DisableRobustBufferAccess)
                {
                    features2.Features.RobustBufferAccess = false;
                }

                Array<utf8string> usedDeviceExtensions = new();

                foreach(utf8string it in UsedDeviceExtensions)
                {
                    usedDeviceExtensions.Add(it);
                }

                deviceCreateInfo.EnabledExtensionCount = (uint)usedDeviceExtensions.Count;
                deviceCreateInfo.EnabledExtensionNames = usedDeviceExtensions.ToArray();
                //deviceCreateInfo.PEnabledFeatures = null;
                deviceCreateInfo.PNext = (nuint)Unsafe.AsPointer(ref features2);

                VkDeviceGroupDeviceCreateInfo deviceGroupCreateInfo = new()
                {
                    SType = VkStructureType.DeviceGroupDeviceCreateInfo
                };

                if(info.UseDeviceGroups)
                {
                    deviceGroupCreateInfo.PNext               = deviceCreateInfo.PNext;
                    deviceGroupCreateInfo.PhysicalDeviceCount = physicalGroup.PhysicalDeviceCount;
                    deviceGroupCreateInfo.PPhysicalDevices    = (VkPhysicalDevice*)Unsafe.AsPointer(ref physicalGroup.PhysicalDevices.E0);
                    deviceCreateInfo.PNext                    = (nuint)Unsafe.AsPointer(ref deviceGroupCreateInfo);
                }

                VkAnyStruct* deviceCreateChain = null;

                if(info.DeviceCreateInfoExt != 0)
                {
                    deviceCreateChain = (VkAnyStruct*)info.DeviceCreateInfoExt;

                    while(deviceCreateChain->PNext != 0)
                    {
                        deviceCreateChain = (VkAnyStruct*)deviceCreateChain->PNext;
                    }

                    deviceCreateChain->PNext = deviceCreateInfo.PNext;
                    deviceCreateInfo.PNext   = info.DeviceCreateInfoExt;
                }

                Device = new VkDevice(PhysicalDevice, ref deviceCreateInfo);

                if(deviceCreateChain != null)
                {
                    deviceCreateChain->PNext = 0;
                }

                if(Device.Handle == 0)
                {
                    Deinit();
                    return false;
                }

                //load_VK_EXTENSIONS(Instance, vkGetInstanceProcAddr, Device, vkGetDeviceProcAddr);
                //DebugUtil.setEnabled(HasDebugUtils());

                QueueGCT = CreateQueue(ContextCreateInfo.DefaultQueueGCT, "queueGCT", ContextCreateInfo.DefaultPriorityGCT);
                QueueC   = CreateQueue(ContextCreateInfo.DefaultQueueC,   "queueC",   ContextCreateInfo.DefaultPriorityC);
                QueueT   = CreateQueue(ContextCreateInfo.DefaultQueueT,   "queueT",   ContextCreateInfo.DefaultPriorityT);

                return true;
            }
        }

        public Array<uint> GetCompatibleDevices(ContextCreateInfo info)
        {
            Debug.Assert(Instance != null);
            Array<uint>                            compatibleDevices = new();
            Array<VkPhysicalDeviceGroupProperties> groups            = new();
            Array<VkPhysicalDevice>                physicalDevices   = new();

            uint nbElems;

            if(info.UseDeviceGroups)
            {
                groups  = new Array<VkPhysicalDeviceGroupProperties>(GetPhysicalDeviceGroups());
                nbElems = (uint)groups.Count;
            }
            else
            {
                physicalDevices = new Array<VkPhysicalDevice>(GetPhysicalDevices());
                nbElems         = (uint)physicalDevices.Count;
            }

            if(info.VerboseCompatibleDevices)
            {
                Debug.Write($"____________________\n");
                Debug.Write($"Compatible Devices :\n");
            }

            uint compatible = 0;

            for(uint elemId = 0; elemId < nbElems; elemId++)
            {
                VkPhysicalDevice physicalDevice = info.UseDeviceGroups ? groups[elemId].PhysicalDevices[0] : physicalDevices[elemId];

                if(HasMandatoryExtensions(new VkPhysicalDevice(physicalDevice), info, info.VerboseCompatibleDevices))
                {
                    compatibleDevices.Add(elemId);

                    if(info.VerboseCompatibleDevices)
                    {
                        unsafe
                        {
                            Api.GetPhysicalDeviceProperties(physicalDevice, out VkPhysicalDeviceProperties props);

                            Debug.Write($"{compatible}: {props.DeviceName}\n");

                            compatible++;
                        }
                    }
                }
                else if(info.VerboseCompatibleDevices)
                {
                    unsafe
                    {
                        Api.GetPhysicalDeviceProperties(physicalDevice, out VkPhysicalDeviceProperties props);

                        Debug.Write($"Skipping physical device {props.DeviceName}\n");
                    }
                }
            }

            if(info.VerboseCompatibleDevices)
            {
                Debug.Write($"Physical devices found : {compatible}");

                if(compatible > 0)
                {
                    Debug.Write($"{compatible}\n");
                }
                else
                {
                    Debug.Write($"OMG... NONE !!{compatible}\n");
                }
            }

            return new Array<uint>(compatibleDevices);
        }

        public Array<VkPhysicalDevice> GetPhysicalDevices()
        {
            return new Array<VkPhysicalDevice>(Instance.EnumeratePhysicalDevices());
        }

        public Array<VkPhysicalDeviceGroupProperties> GetPhysicalDeviceGroups()
        {
            return new Array<VkPhysicalDeviceGroupProperties>(Instance.EnumeratePhysicalDeviceGroups());
        }

        public Array<VkExtensionProperties> GetInstanceExtensions()
        {
            return new Array<VkExtensionProperties>(Api.EnumerateInstanceExtensionProperties());
        }

        public Array<VkLayerProperties> GetInstanceLayers()
        {
            return new Array<VkLayerProperties>(Api.EnumerateInstanceLayerProperties());
        }

        public Array<VkExtensionProperties> GetDeviceExtensions(VkPhysicalDevice physicalDevice)
        {
            return new Array<VkExtensionProperties>(physicalDevice.EnumerateDeviceExtensionProperties());
        }


        public bool HasMandatoryExtensions(VkPhysicalDevice  physicalDevice,
                                           ContextCreateInfo info,
                                           bool              bVerbose)
        {
            Array<VkExtensionProperties> extensionProperties = Api.EnumerateDeviceExtensionProperties(physicalDevice);

            return CheckEntryArray(extensionProperties, info.DeviceExtensions, bVerbose);
        }

        public bool SetGCTQueueWithPresent(VkSurfaceKHR surface)
        {
            unsafe
            {
                Api.GetPhysicalDeviceSurfaceSupportKHR(PhysicalDevice, QueueGCT.FamilyIndex, surface, out Bool32 supportsPresent);

                return supportsPresent;
            }
        }

        public bool HasDeviceExtension(utf8string name)
        {
            foreach(utf8string it in UsedDeviceExtensions)
            {
                if(utf8string.Compare(name, it) == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public bool HasInstanceExtension(utf8string name)
        {
            foreach(utf8string it in UsedInstanceExtensions)
            {
                if(utf8string.Compare(name, it) == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public void IgnoreDebugMessage(int msgID)
        {
            DbgIgnoreMessages.Add(msgID);
        }


        //private static unsafe void PnextChainPushFront(void* mainStruct,
        //                                               void* newStruct)
        //{
        //    ((VkAnyStruct*)newStruct)->PNext = ((VkAnyStruct*)mainStruct)->PNext;

        //    ((VkAnyStruct*)mainStruct)->PNext = newStruct;
        //}

        //private static unsafe void PnextChainPushBack<MainT, NewT>(MainT* mainStruct,
        //                                                           NewT*  newStruct)
        //    where MainT : unmanaged
        //    where NewT : unmanaged
        //{
        //    VkAnyStruct* lastStruct = (VkAnyStruct*)mainStruct;
        //    while(lastStruct->PNext != nullptr)
        //    {
        //        lastStruct = (VkAnyStruct*)lastStruct->PNext;
        //    }

        //    lastStruct->PNext = newStruct;
        //}

        private static Bool32 DebugMessengerCallback(VkDebugUtilsMessageSeverityFlagBitsEXT messageSeverity,
                                                     VkDebugUtilsMessageTypeFlagBitsEXT     messageType,
                                                     VkDebugUtilsMessengerCallbackDataEXT   callbackData,
                                                     object                                 userData)
        {
#if false
            Context ctx = reinterpret_cast<Context>(userData);

            if (ctx.DbgIgnoreMessages.find(callbackData.messageIdNumber) != ctx.DbgIgnoreMessages.end())
            {
            return VK_FALSE;
            }


            int level = LOGLEVEL_INFO;

            if (messageSeverity & VK_DEBUG_UTILS_MESSAGE_SEVERITY_VERBOSE_BIT_EXT != null)
            {
            nvprintfLevel(level, "VERBOSE: {} \n --> {}\n", callbackData.pMessageIdName, callbackData.pMessage);
            }
            else if (messageSeverity & VK_DEBUG_UTILS_MESSAGE_SEVERITY_INFO_BIT_EXT)
            {
            nvprintfLevel(level, "INFO: {} \n --> {}\n", callbackData.pMessageIdName, callbackData.pMessage);
            }
            else if (messageSeverity & VK_DEBUG_UTILS_MESSAGE_SEVERITY_WARNING_BIT_EXT)
            {
            level = LOGLEVEL_WARNING;
            nvprintfLevel(level, "WARNING: {} \n --> {}\n", callbackData.pMessageIdName, callbackData.pMessage);
            }
            else if (messageSeverity & VK_DEBUG_UTILS_MESSAGE_SEVERITY_ERROR_BIT_EXT)
            {
            level = LOGLEVEL_ERROR;
            nvprintfLevel(level, "ERROR: {} \n --> {}\n", callbackData.pMessageIdName, callbackData.pMessage);
            }
            else if (messageType & VK_DEBUG_UTILS_MESSAGE_TYPE_GENERAL_BIT_EXT)
            {
            nvprintfLevel(level, "GENERAL: {} \n --> {}\n", callbackData.pMessageIdName, callbackData.pMessage);
            }
            else
            {
            nvprintfLevel(level, "{} \n --> {}\n", callbackData.pMessageIdName, callbackData.pMessage);
            }


        //
        //  if(callbackData->objectCount > 0)
        //  {
        //    for(uint32_t object = 0; object < callbackData->objectCount; ++object)
        //    {
        //      std::utf8string otype = ObjectTypeToString(callbackData->pObjects[object].objectType);
        //      Debug.Write($" Object[{}] - Type {}, Value %p, Name \"{}\"\n", object, otype.c_str(),
        //           (void*)(callbackData->pObjects[object].objectHandle), callbackData->pObjects[object].pObjectName);
        //    }
        //  }
        //  if(callbackData->cmdBufLabelCount > 0)
        //  {
        //    for(uint32_t label = 0; label < callbackData->cmdBufLabelCount; ++label)
        //    {
        //      Debug.Write($" Label[{}] - {} { %f, %f, %f, %f}\n", label, callbackData->pCmdBufLabels[label].pLabelName,
        //           callbackData->pCmdBufLabels[label].color[0], callbackData->pCmdBufLabels[label].color[1],
        //           callbackData->pCmdBufLabels[label].color[2], callbackData->pCmdBufLabels[label].color[3]);
        //    }
#endif
            return false;
        }


        private void InitDebugUtils()
        {
            //CreateDebugUtilsMessengerEXT = (PFN_vkCreateDebugUtilsMessengerEXT)vkGetInstanceProcAddr(Instance, "vkCreateDebugUtilsMessengerEXT"));
            //DestroyDebugUtilsMessengerEXT = (PFN_vkDestroyDebugUtilsMessengerEXT)vkGetInstanceProcAddr(Instance, "vkDestroyDebugUtilsMessengerEXT"));

            //if (CreateDebugUtilsMessengerEXT != null)
            //{
            //    VkDebugUtilsMessengerCreateInfoEXT dbg_messenger_create_info = new(VK_STRUCTURE_TYPE_DEBUG_UTILS_MESSENGER_CREATE_INFO_EXT);
            //    dbg_messenger_create_info.messageSeverity = VK_DEBUG_UTILS_MESSAGE_SEVERITY_INFO_BIT_EXT | VK_DEBUG_UTILS_MESSAGE_SEVERITY_WARNING_BIT_EXT | VK_DEBUG_UTILS_MESSAGE_SEVERITY_ERROR_BIT_EXT;   
            //    dbg_messenger_create_info.messageType = VK_DEBUG_UTILS_MESSAGE_TYPE_GENERAL_BIT_EXT | VK_DEBUG_UTILS_MESSAGE_TYPE_VALIDATION_BIT_EXT | VK_DEBUG_UTILS_MESSAGE_TYPE_PERFORMANCE_BIT_EXT;   
            //    dbg_messenger_create_info.pfnUserCallback = debugMessengerCallback;
            //    dbg_messenger_create_info.pUserData = this;

            //    VkResult result = createDebugUtilsMessengerEXT(Instance, dbg_messenger_create_info, null, DbgMessenger);
            //}
        }

        private bool HasDebugUtils()
        {
            unsafe
            {
                return CreateDebugUtilsMessengerEXT != null;
            }
        }

        private VkResult FillFilteredNameArray(Array<utf8string>              used,
                                               Array<VkLayerProperties>       properties,
                                               Array<ContextCreateInfo.Entry> requested)
        {
            foreach(ContextCreateInfo.Entry itr in requested)
            {
                bool found = false;
                foreach(VkLayerProperties property in properties)
                {
                    if(utf8string.Compare(itr.Name, property.LayerName) == 0)
                    {
                        found = true;
                        break;
                    }
                }

                if(found)
                {
                    used.Add(itr.Name);
                }
                else if(itr.Optional == false)
                {
                    Debug.Write($"Requiered layer not found: {itr.Name}\n");
                    return VkResult.LayerNotPresent;
                }
            }

            return VkResult.Success;
        }

        private VkResult FillFilteredNameArray(Array<utf8string>              used,
                                               Array<VkExtensionProperties>   properties,
                                               Array<ContextCreateInfo.Entry> requested,
                                               Array<nuint>                   featureStructs)
        {
            foreach(ContextCreateInfo.Entry itr in requested)
            {
                bool found = false;
                foreach(VkExtensionProperties property in properties)
                {
                    if(utf8string.Compare(itr.Name, property.ExtensionName) == 0 && (itr.Version == 0 || itr.Version == property.SpecVersion))
                    {
                        found = true;
                        break;
                    }
                }

                if(found)
                {
                    used.Add(itr.Name);
                    if(itr.pFeatureStruct != 0)
                    {
                        featureStructs.Add(itr.pFeatureStruct);
                    }
                }
                else if(!itr.Optional)
                {
                    Debug.Write($"VK_ERROR_EXTENSION_NOT_PRESENT: {itr.Name} - {itr.Version}\n");
                    return VkResult.ExtensionNotPresent;
                }
            }

            return VkResult.Success;
        }

        private bool CheckEntryArray(Array<VkExtensionProperties>   properties,
                                     Array<ContextCreateInfo.Entry> requested,
                                     bool                           bVerbose)
        {
            foreach(ContextCreateInfo.Entry itr in requested)
            {
                bool found = false;

                foreach(VkExtensionProperties property in properties)
                {
                    if(utf8string.Compare(itr.Name, property.ExtensionName) == 0)
                    {
                        found = true;
                        break;
                    }
                }

                if(!found && !itr.Optional)
                {
                    if(bVerbose)
                    {
                        Debug.Write($"Could NOT locate mandatory extension '{itr.Name}'\n");
                    }

                    return false;
                }
            }

            return true;
        }

        private static void InitPhysicalInfo(PhysicalDeviceInfo info,
                                             VkPhysicalDevice   physicalDevice,
                                             Version            version)
        {
            unsafe
            {
                Api.GetPhysicalDeviceMemoryProperties(physicalDevice, out VkPhysicalDeviceMemoryProperties memoryProperties);

                info.MemoryProperties = memoryProperties;
                info.QueueProperties  = Api.GetPhysicalDeviceQueueFamilyProperties(physicalDevice);

                VkPhysicalDeviceFeatures2 features2 = new()
                {
                    SType = VkStructureType.PhysicalDeviceFeatures2
                };

                VkPhysicalDeviceProperties2 properties2 = new()
                {
                    SType = VkStructureType.PhysicalDeviceProperties2
                };

                Properties11Old properties11old = new();
                Features11Old   features11old   = new();

                if(version.Major == 1 && version.Minor == 1)
                {
                    features2.PNext   = (nuint)Unsafe.AsPointer(ref features11old.Multiview);
                    properties2.PNext = (nuint)Unsafe.AsPointer(ref properties11old.Maintenance3);
                }
                else if(version.Major == 1 && version.Minor >= 2)
                {
                    features2.PNext       = (nuint)Unsafe.AsPointer(ref info.Features11);
                    info.Features11.PNext = (nuint)Unsafe.AsPointer(ref info.Features12);
                    info.Features12.PNext = 0;

                    info.Properties12.DriverId                     = (VkDriverId)VK_DRIVER_ID_NVIDIA_PROPRIETARY;
                    info.Properties12.SupportedDepthResolveModes   = VK_RESOLVE_MODE_MAX_BIT;
                    info.Properties12.SupportedStencilResolveModes = VK_RESOLVE_MODE_MAX_BIT;

                    properties2.PNext       = (nuint)Unsafe.AsPointer(ref info.Properties11);
                    info.Properties11.PNext = (nuint)Unsafe.AsPointer(ref info.Properties12);
                    info.Properties12.PNext = 0;
                }

                Api.GetPhysicalDeviceFeatures2(physicalDevice, ref features2);
                Api.GetPhysicalDeviceProperties2(physicalDevice, ref properties2);

                info.Properties10 = properties2.Properties;
                info.Features10   = features2.Features;

                if(version.Major == 1 && version.Minor == 1)
                {
                    properties11old.Write(ref info.Properties11);
                    features11old.Write(ref info.Features11);
                }
            }
        }


        public static utf8string ObjectTypeToString(VkObjectType value)
        {
            switch(value)
            {
                case VkObjectType.Unknown:
                {
                    return "Unknown";
                }
                case VkObjectType.Instance:
                {
                    return "Instance";
                }
                case VkObjectType.PhysicalDevice:
                {
                    return "PhysicalDevice";
                }
                case VkObjectType.Device:
                {
                    return "Device";
                }
                case VkObjectType.Queue:
                {
                    return "Queue";
                }
                case VkObjectType.Semaphore:
                {
                    return "Semaphore";
                }
                case VkObjectType.CommandBuffer:
                {
                    return "CommandBuffer";
                }
                case VkObjectType.Fence:
                {
                    return "Fence";
                }
                case VkObjectType.DeviceMemory:
                {
                    return "DeviceMemory";
                }
                case VkObjectType.Buffer:
                {
                    return "Buffer";
                }
                case VkObjectType.Image:
                {
                    return "Image";
                }
                case VkObjectType.Event:
                {
                    return "Event";
                }
                case VkObjectType.QueryPool:
                {
                    return "QueryPool";
                }
                case VkObjectType.BufferView:
                {
                    return "BufferView";
                }
                case VkObjectType.ImageView:
                {
                    return "ImageView";
                }
                case VkObjectType.ShaderModule:
                {
                    return "ShaderModule";
                }
                case VkObjectType.PipelineCache:
                {
                    return "PipelineCache";
                }
                case VkObjectType.PipelineLayout:
                {
                    return "PipelineLayout";
                }
                case VkObjectType.RenderPass:
                {
                    return "RenderPass";
                }
                case VkObjectType.Pipeline:
                {
                    return "Pipeline";
                }
                case VkObjectType.DescriptorSetLayout:
                {
                    return "DescriptorSetLayout";
                }
                case VkObjectType.Sampler:
                {
                    return "Sampler";
                }
                case VkObjectType.DescriptorPool:
                {
                    return "DescriptorPool";
                }
                case VkObjectType.DescriptorSet:
                {
                    return "DescriptorSet";
                }
                case VkObjectType.Framebuffer:
                {
                    return "Framebuffer";
                }
                case VkObjectType.CommandPool:
                {
                    return "CommandPool";
                }
                case VkObjectType.SamplerYcbcrConversion:
                {
                    return "SamplerYcbcrConversion";
                }
                case VkObjectType.DescriptorUpdateemplate:
                {
                    return "DescriptorUpdateemplate";
                }
                case VkObjectType.Surface:
                {
                    return "Surface";
                }
                case VkObjectType.Swapchain:
                {
                    return "Swapchain";
                }
                case VkObjectType.Display:
                {
                    return "Display";
                }
                case VkObjectType.DisplayMode:
                {
                    return "DisplayMode";
                }
                case VkObjectType.DebugReportCallback:
                {
                    return "DebugReportCallback";
                }
                case VkObjectType.CuModulex:
                {
                    return "CuModulex";
                }
                case VkObjectType.CuFunctionx:
                {
                    return "CuFunctionx";
                }
                case VkObjectType.DebugUtilsMessenger:
                {
                    return "DebugUtilsMessenger";
                }
                case VkObjectType.AccelerationStructureKhr:
                {
                    return "AccelerationStructureKhr";
                }
                case VkObjectType.ValidationCache:
                {
                    return "ValidationCache";
                }
                case VkObjectType.AccelerationStructureNv:
                {
                    return "AccelerationStructureNv";
                }
                case VkObjectType.PerformanceConfigurationIntel:
                {
                    return "PerformanceConfigurationIntel";
                }
                case VkObjectType.DeferredOperation:
                {
                    return "DeferredOperation";
                }
                case VkObjectType.IndirectCommandsLayout:
                {
                    return "IndirectCommandsLayout";
                }
                case VkObjectType.PrivateDataSlot:
                {
                    return "PrivateDataSlot";
                }
                case VkObjectType.BufferCollectionFuchsia:
                {
                    return "BufferCollectionFuchsia";
                }
//#if VK_NV_device_generated_commands
//                case VkObjectType.INDIRECT_COMMANDS_LAYOUT_NV:
//                return "IndirectCommandsLayoutNV";
//#endif
//                case VkObjectType.DEBUG_UTILS_MESSENGER_EXT:
//                    return "DebugUtilsMessengerEXT";
//                case VkObjectType.VALIDATION_CACHE_EXT:
//                    return "ValidationCacheEXT";
//#if VK_NV_ray_tracing
//                case VkObjectType.ACCELERATION_STRUCTURE_NV:
//                return "AccelerationStructureNV";
//#endif
                default:
                {
                    return "invalid";
                }
            }
        }
    }
}
