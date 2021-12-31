using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vulkan.Framework
{

    [AttributeUsage(AttributeTargets.Struct, Inherited = false, AllowMultiple = false)]
    public sealed class PushConstantAttribute : Attribute
    {
        public VkShaderStageFlagBits StageFlags { get; set; }
        public uint                  Offset    { get; set; }
        public uint                  Size      { get; set; }

        
        public PushConstantAttribute(VkShaderStageFlagBits stageFlags,
                                     uint                  size)
        {
            StageFlags = stageFlags;
            Offset     = 0;
            Size       = size;
        }
        public PushConstantAttribute(VkShaderStageFlagBits stageFlags,
                                     uint                  offset,
                                     uint                  size)
        {
            StageFlags = stageFlags;
            Offset     = offset;
            Size       = size;
        }

        public VkPushConstantRange GetPushConstantRange()
        {
            return new()
            {
                StageFlags = StageFlags,
                Offset     = Offset,
                Size       = Size
            };
        }
    }


    //void dvz_slots_create(DvzSlots* slots)
    //{
    //    create_descriptor_set_layout(slots->gpu->device, slots->slot_count, slots->types, &slots->dset_layout);
    //
    //    VkPushConstantRange push_constants[DVZ_MAX_PUSH_CONSTANTS] = {0};
    //
    //    for (uint32_t i = 0; i < slots->push_count; i++)
    //    {
    //        push_constants[i].offset     = slots->push_offsets[i];
    //        push_constants[i].size       = slots->push_sizes[i];
    //        push_constants[i].stageFlags = slots->push_shaders[i];
    //    }
    //
    //    create_pipeline_layout(slots->gpu->device,  slots->push_count, push_constants, &slots->dset_layout, &slots->pipeline_layout);
    //
    //    dvz_obj_created(&slots->obj);
    //}
}
