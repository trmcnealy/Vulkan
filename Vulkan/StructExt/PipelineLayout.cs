//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Vulkan
//{
//public class PipelineLayout : System.IDisposable
//{
//    private VkDevice device;

//    private VkPipelineLayout handle;

//    // The shader modules that this pipeline layout uses
//    private List<VkShaderModule > shader_modules;

//    // The shader resources that this pipeline layout uses, indexed by their name
//    private Dictionary<string, ShaderResource> shader_resources;

//    // A map of each set and the resources it owns used by the pipeline layout
//    private Dictionary<uint, List<ShaderResource>> shader_sets;

//    // The different descriptor set layouts for this pipeline layout
//    private List<VkDescriptorSetLayout > descriptor_set_layouts;

//    public PipelineLayout(VkDevice device, in List<VkShaderModule > shader_modules)
//    {
//        this.device = device;
//        this.shader_modules = new List<VkShaderModule >(shader_modules);
//        // Collect and combine all the shader resources from each of the shader modules
//        // Collate them all into a map that is indexed by the name of the resource
//        foreach (VkShaderModule shader_module in shader_modules)
//        {
//            string key;
//            foreach (var shader_resource in shader_module.get_resources())
//            {
//                key = shader_resource.name;

//                // Since 'Input' and 'Output' resources can have the same name, we modify the key string
//                if (shader_resource.type == ShaderResourceType.Input || shader_resource.type == ShaderResourceType.Output)
//                {
//                    key = Convert.ToString(shader_resource.stages) + "_" + key;
//                }

//                if (shader_resources.ContainsKey(key))
//                {
//                    // Append stage flags if resource already exists

//                    VkShaderStageFlagBits stages = shader_resources[key].Stages | shader_resource.stages;

//                    shader_resources[key] = ();
//                }
//                else
//                {
//                    // Create a new entry in the map
//                    shader_resources.Add(key, shader_resource);
//                }
//            }
//        }

//        // Sift through the map of name indexed shader resources
//        // Separate them into their respective sets
//        foreach (KeyValuePair<string, ShaderResource> it in shader_resources)
//        {
//            var shader_resource = it.second;

//            // Find binding by set index in the map.
//            var it2 = shader_sets.find(shader_resource.set);

//            if (it2 != shader_sets.end())
//            {
//                // Add resource to the found set index
//                it2.second.push_back(shader_resource);
//            }
//            else
//            {
//                // Create a new set index and with the first resource
//                shader_sets.Add(shader_resource.set, new List<ShaderResource>({shader_resource}));
//            }
//        }

//        // Create a descriptor set layout for each shader set in the shader modules
//        foreach (KeyValuePair<uint, List<ShaderResource>> shader_set_it in shader_sets)
//        {
//            descriptor_set_layouts.emplace_back(device.get_resource_cache().request_descriptor_set_layout(shader_set_it.first, shader_modules, shader_set_it.second));
//        }

//        // Collect all the descriptor set layout handles, maintaining set order
//        List<VkDescriptorSetLayout> descriptor_set_layout_handles = new List<VkDescriptorSetLayout>();
//        for (uint i = 0; i < descriptor_set_layouts.Count; ++i)
//        {
//            if (descriptor_set_layouts[i] != null)
//            {
//                descriptor_set_layout_handles.Add(descriptor_set_layouts[i].get_handle());
//            }
//            else
//            {
//                descriptor_set_layout_handles.Add(VK_NULL_HANDLE);
//            }
//        }

//        // Collect all the push constant shader resources
//        List<VkPushConstantRange> push_constant_ranges = new List<VkPushConstantRange>();
//        foreach (ShaderResource push_constant_resource in get_resources(ShaderResourceType.PushConstant))
//        {
//            push_constant_ranges.Add(new VkPushConstantRange(push_constant_resource.stages, push_constant_resource.offset, push_constant_resource.size));
//        }

//        VkPipelineLayoutCreateInfo create_info = new VkPipelineLayoutCreateInfo(VK_STRUCTURE_TYPE_PIPELINE_LAYOUT_CREATE_INFO);

//        create_info.setLayoutCount = to_u32(descriptor_set_layout_handles.Count);
//        create_info.pSetLayouts = descriptor_set_layout_handles.data();
//        create_info.pushConstantRangeCount = to_u32(push_constant_ranges.Count);
//        create_info.pPushConstantRanges = push_constant_ranges.data();

//        // Create the Vulkan pipeline layout handle
//        var result = vkCreatePipelineLayout(device.get_handle(), create_info, null, handle);

//        if (result != VK_SUCCESS)
//        {
//            throw VulkanException({result, "Cannot create PipelineLayout"});
//        }
//    }

////	PipelineLayout(const PipelineLayout &) = delete;

//    public PipelineLayout(PipelineLayout && other)
//    {
//        this.device = other.device;
//        this.handle = other.handle;
//        this.shader_modules = std::move(other.shader_modules);
//        this.shader_resources = std::move(other.shader_resources);
//        this.shader_sets = std::move(other.shader_sets);
//        this.descriptor_set_layouts = std::move(other.descriptor_set_layouts);
//        other.handle = VK_NULL_HANDLE;
//    }

//    public void Dispose()
//    {
//        // Destroy pipeline layout
//        if (handle != VK_NULL_HANDLE)
//        {
//            vkDestroyPipelineLayout(device.get_handle(), handle, null);
//        }
//    }
        

//    public VkPipelineLayout get_handle()
//    {
//        return new VkPipelineLayout(handle);
//    }

//    public List<VkShaderModule > get_shader_modules()
//    {
//        return new List<VkShaderModule >(shader_modules);
//    }

//    public List<ShaderResource> get_resources(in ShaderResourceType type = ShaderResourceType.All, VkShaderStageFlagBits stage = VK_SHADER_STAGE_ALL)
//    {
//        List<ShaderResource> found_resources = new List<ShaderResource>();

//        foreach (KeyValuePair<string, ShaderResource> it in shader_resources)
//        {
//            var shader_resource = it.second;

//            if (shader_resource.type == type || type == ShaderResourceType.All)
//            {
//                if (shader_resource.stages == stage || stage == VK_SHADER_STAGE_ALL)
//                {
//                    found_resources.Add(shader_resource);
//                }
//            }
//        }

//        return new List<ShaderResource>(found_resources);
//    }

//    public Dictionary<uint, List<ShaderResource>> get_shader_sets()
//    {
//        return new Dictionary<uint, List<ShaderResource>>(shader_sets);
//    }

//    public bool has_descriptor_set_layout(in uint set_index)
//    {
//        return set_index < descriptor_set_layouts.Count;
//    }

//    public VkDescriptorSetLayout get_descriptor_set_layout(in uint set_index)
//    {
//        foreach (VkDescriptorSetLayout descriptor_set_layout in descriptor_set_layouts)
//        {
//            if (descriptor_set_layout.get_index() == set_index)
//            {
//                return new VkDescriptorSetLayout(descriptor_set_layout);
//            }
//        }
//        throw new System.Exception("Couldn't find descriptor set layout at set index " + Convert.ToString(set_index));
//    }

//    public VkShaderStageFlagBits get_push_constant_range_stage(uint size, uint offset = 0)
//    {
//        VkShaderStageFlagBits stages = 0;

//        foreach (ShaderResource push_constant_resource in get_resources(ShaderResourceType.PushConstant))
//        {
//            if (offset >= push_constant_resource.Offset && offset + size <= push_constant_resource.Offset + push_constant_resource.Size)
//            {
//                stages |= push_constant_resource.Stages;
//            }
//        }

//        return stages;
//    }
//}

//}
