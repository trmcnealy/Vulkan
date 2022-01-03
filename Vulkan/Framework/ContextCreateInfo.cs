using System;
using System.Collections.Generic;
using System.Diagnostics;

using static Vulkan.Enums;

namespace Vulkan.Framework
{
    public sealed class ContextCreateInfo
    {
        public sealed class Entry
        {
            public utf8string Name           { get; set; }
            public bool       Optional       { get; set; }
            public nuint      pFeatureStruct { get; set; }
            public uint       Version        { get; set; }

            public Entry()
            {
                Name           = utf8string.Null;
                Optional       = false;
                pFeatureStruct = 0;
                Version        = 0;
            }

            public Entry(utf8string entryName,
                         bool       isOptional)
            {
                Name           = entryName;
                Optional       = isOptional;
                pFeatureStruct = 0;
                Version        = 0;
            }

            public Entry(utf8string entryName,
                         bool       isOptional,
                         nuint      pointerFeatureStruct)
            {
                Name           = entryName;
                Optional       = isOptional;
                pFeatureStruct = pointerFeatureStruct;
                Version        = 0;
            }

            public Entry(utf8string entryName,
                         bool       isOptional,
                         nuint      pointerFeatureStruct,
                         uint       checkVersion)
            {
                Name           = entryName;
                Optional       = isOptional;
                pFeatureStruct = pointerFeatureStruct;
                Version        = checkVersion;
            }
        }

        public sealed class QueueSetup
        {
            public VkQueueFlagBits RequiredFlagBits { get; set; }
            public uint            Count            { get; set; }
            public float           Priority         { get; set; }

            public QueueSetup()
            {
                RequiredFlagBits = VkQueueFlagBits.Graphics;
                Count            = 0;
                Priority         = 1.0f;
            }
        }

        public static readonly VkQueueFlagBits DefaultQueueGCT    = VkQueueFlagBits.Graphics | VkQueueFlagBits.Compute | VkQueueFlagBits.Transfer;
        public static readonly float           DefaultPriorityGCT = 1.0f;
        public static readonly VkQueueFlagBits DefaultQueueT      = VkQueueFlagBits.Transfer;
        public static readonly float           DefaultPriorityT   = 1.0f;
        public static readonly VkQueueFlagBits DefaultQueueC      = VkQueueFlagBits.Compute;
        public static readonly float           DefaultPriorityC   = 1.0f;

        public Version ApiVersion
        {
            get
            {
                return Api.ApiVersion;
            }
        }

        public utf8string        AppEngine                 { get; set; }
        public utf8string        AppTitle                  { get; set; }
        public bool              UseDeviceGroups           { get; set; }
        public bool              DisableRobustBufferAccess { get; set; }
        public bool              VerboseCompatibleDevices  { get; set; }
        public bool              VerboseUsed               { get; set; }
        public bool              VerboseAvailable          { get; set; }
        public uint              CompatibleDeviceIndex     { get; set; }
        public Array<Entry>      InstanceLayers            { get; set; }
        public Array<Entry>      InstanceExtensions        { get; set; }
        public Array<Entry>      DeviceExtensions          { get; set; }
        public Array<QueueSetup> RequestedQueues           { get; set; }
        public nuint             DeviceCreateInfoExt       { get; set; }
        public nuint             InstanceCreateInfoExt     { get; set; }


        public ContextCreateInfo()
        {
            AppEngine                 = "Vulkan.Framework";
            AppTitle                  = "Vulkan.Framework";
            UseDeviceGroups           = false;
            DisableRobustBufferAccess = true;
            VerboseCompatibleDevices  = true;
            VerboseUsed               = true;
            VerboseAvailable          = true;
            CompatibleDeviceIndex     = 0;
            InstanceLayers            = new();
            InstanceExtensions        = new();
            DeviceExtensions          = new();
            RequestedQueues           = new();
            DeviceCreateInfoExt       = 0;
            InstanceCreateInfoExt     = 0;

            RequestedQueues.Add(new QueueSetup()
            {
                RequiredFlagBits = DefaultQueueGCT,
                Count            = 1,
                Priority         = DefaultPriorityGCT
            });

            RequestedQueues.Add(new QueueSetup()
            {
                RequiredFlagBits = DefaultQueueT,
                Count            = 1,
                Priority         = DefaultPriorityT
            });

            RequestedQueues.Add(new QueueSetup()
            {
                RequiredFlagBits = DefaultQueueC,
                Count            = 1,
                Priority         = DefaultPriorityC
            });
        }


        public ContextCreateInfo(VkQueueFlagBits defaultQueueGCT,
                                 float           defaultPriorityGCT,
                                 VkQueueFlagBits defaultQueueT,
                                 float           defaultPriorityT,
                                 VkQueueFlagBits defaultQueueC,
                                 float           defaultPriorityC,
                                 bool            bUseValidation = false)
            : this()
        {
            RequestedQueues.Add(new QueueSetup()
            {
                RequiredFlagBits = defaultQueueGCT,
                Count            = 1,
                Priority         = defaultPriorityGCT
            });

            RequestedQueues.Add(new QueueSetup()
            {
                RequiredFlagBits = defaultQueueT,
                Count            = 1,
                Priority         = defaultPriorityT
            });

            RequestedQueues.Add(new QueueSetup()
            {
                RequiredFlagBits = defaultQueueC,
                Count            = 1,
                Priority         = defaultPriorityC
            });

            if(Debugger.IsAttached)
            {
                if(bUseValidation)
                {
                    InstanceLayers.Add(new Entry(ExtensionNames.VK_LAYER_KHRONOS_VALIDATION, true));
                }
            }
        }

        public void SetVersion(Version version)
        {
            Debug.Assert(ApiVersion == version, "Only one version 1.2.189.2 is currently supported.");
        }

        public void AddInstanceExtension(utf8string name,
                                         bool       optional = false)
        {
            InstanceExtensions.Add(new Entry(name, optional));
        }

        public void AddInstanceLayer(utf8string name,
                                     bool       optional = false)
        {
            InstanceLayers.Add(new Entry(name, optional));
        }

        public void AddDeviceExtension(utf8string name,
                                       bool       optional       = false,
                                       nuint      pFeatureStruct = 0,
                                       uint       version        = 0)
        {
            DeviceExtensions.Add(new Entry(name, optional, pFeatureStruct, version));
        }

        public void RemoveInstanceExtension(utf8string name)
        {
            for(int i = 0; i < InstanceExtensions.Count; i++)
            {
                if(utf8string.Compare(InstanceExtensions[i].Name, name) == 0)
                {
                    InstanceExtensions.RemoveAt(i);
                }
            }
        }

        public void RemoveInstanceLayer(utf8string name)
        {
            for(int i = 0; i < InstanceLayers.Count; i++)
            {
                if(utf8string.Compare(InstanceLayers[i].Name, name) == 0)
                {
                    InstanceLayers.RemoveAt(i);
                }
            }
        }

        public void RemoveDeviceExtension(utf8string name)
        {
            for(int i = 0; i < DeviceExtensions.Count; i++)
            {
                if(utf8string.Compare(DeviceExtensions[i].Name, name) == 0)
                {
                    DeviceExtensions.RemoveAt(i);
                }
            }
        }

        public void AddRequestedQueue(VkQueueFlagBits flags,
                                      uint            count    = 1,
                                      float           priority = 1.0f)
        {
            RequestedQueues.Add(new QueueSetup()
            {
                RequiredFlagBits = flags,
                Count            = count,
                Priority         = priority
            });
        }
    }
}
