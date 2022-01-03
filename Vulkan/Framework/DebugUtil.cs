using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vulkan.Framework
{
    public sealed class DebugUtil
    {
        private static bool _sEnabled;

        static DebugUtil()
        {
#if DEBUG
            _sEnabled = true;
#else
            _sEnabled = false;
#endif
        }

        private readonly VkDevice _device;

        public DebugUtil(VkDevice device)
        {
            _device = device;
        }

        public static void SetEnabled(bool state)
        {
            _sEnabled = state;
        }

        public void SetObjectName(nuint        @object,
                                  utf8string   name,
                                  VkObjectType t)
        {
            if(_sEnabled)
            {
                VkDebugUtilsObjectNameInfoEXT s = new VkDebugUtilsObjectNameInfoEXT(VkStructureType.DebugUtilsObjectNameInfoExt, 0, t, @object, name);
                //Api.SetDebugUtilsObjectNameEXT(_device, s);
            }
        }

        // clang-format off
        public void SetObjectName(VkBuffer   @object,
                                  utf8string name)
        {
            SetObjectName((nuint)@object, name, VkObjectType.Buffer);
        }

        public void SetObjectName(VkBufferView @object,
                                  utf8string   name)
        {
            SetObjectName((nuint)@object, name, VkObjectType.BufferView);
        }

        public void SetObjectName(VkCommandBuffer @object,
                                  utf8string      name)
        {
            SetObjectName((nuint)@object, name, VkObjectType.CommandBuffer);
        }

        public void SetObjectName(VkCommandPool @object,
                                  utf8string    name)
        {
            SetObjectName((nuint)@object, name, VkObjectType.CommandPool);
        }

        public void SetObjectName(VkDescriptorPool @object,
                                  utf8string       name)
        {
            SetObjectName((nuint)@object, name, VkObjectType.DescriptorPool);
        }

        public void SetObjectName(VkDescriptorSet @object,
                                  utf8string      name)
        {
            SetObjectName((nuint)@object, name, VkObjectType.DescriptorSet);
        }

        public void SetObjectName(VkDescriptorSetLayout @object,
                                  utf8string            name)
        {
            SetObjectName((nuint)@object, name, VkObjectType.DescriptorSetLayout);
        }

        public void SetObjectName(VkDevice   @object,
                                  utf8string name)
        {
            SetObjectName((nuint)@object, name, VkObjectType.Device);
        }

        public void SetObjectName(VkDeviceMemory @object,
                                  utf8string     name)
        {
            SetObjectName((nuint)@object, name, VkObjectType.DeviceMemory);
        }

        public void SetObjectName(VkFramebuffer @object,
                                  utf8string    name)
        {
            SetObjectName((nuint)@object, name, VkObjectType.Framebuffer);
        }

        public void SetObjectName(VkImage    @object,
                                  utf8string name)
        {
            SetObjectName((nuint)@object, name, VkObjectType.Image);
        }

        public void SetObjectName(VkImageView @object,
                                  utf8string  name)
        {
            SetObjectName((nuint)@object, name, VkObjectType.ImageView);
        }

        public void SetObjectName(VkPipeline @object,
                                  utf8string name)
        {
            SetObjectName((nuint)@object, name, VkObjectType.Pipeline);
        }

        public void SetObjectName(VkPipelineLayout @object,
                                  utf8string       name)
        {
            SetObjectName((nuint)@object, name, VkObjectType.PipelineLayout);
        }

        public void SetObjectName(VkQueryPool @object,
                                  utf8string  name)
        {
            SetObjectName((nuint)@object, name, VkObjectType.QueryPool);
        }

        public void SetObjectName(VkQueue    @object,
                                  utf8string name)
        {
            SetObjectName((nuint)@object, name, VkObjectType.Queue);
        }

        public void SetObjectName(VkRenderPass @object,
                                  utf8string   name)
        {
            SetObjectName((nuint)@object, name, VkObjectType.RenderPass);
        }

        public void SetObjectName(VkSampler  @object,
                                  utf8string name)
        {
            SetObjectName((nuint)@object, name, VkObjectType.Sampler);
        }

        public void SetObjectName(VkSemaphore @object,
                                  utf8string  name)
        {
            SetObjectName((nuint)@object, name, VkObjectType.Semaphore);
        }

        public void SetObjectName(VkShaderModule @object,
                                  utf8string     name)
        {
            SetObjectName((nuint)@object, name, VkObjectType.ShaderModule);
        }

        public void SetObjectName(VkSwapchainKHR @object,
                                  utf8string     name)
        {
            SetObjectName((nuint)@object, name, VkObjectType.Swapchain);
        }

        //#if VK_NV_ray_tracing
        //  public void SetObjectName(VkAccelerationStructureNV @object, utf8string name)
        //  {
        //      SetObjectName((nuint)@object, name, VkObjectType.ACCELERATION_STRUCTURE_NV);
        //  }
        //#endif
        //#if VK_KHR_acceleration_structure
        //  public void SetObjectName(VkAccelerationStructureKHR @object, utf8string name)
        //  {
        //      SetObjectName((nuint)@object, name, VkObjectType.ACCELERATION_STRUCTURE_KHR);
        //  }
        //#endif
        //        // clang-format on

        //        //
        //        //---------------------------------------------------------------------------
        //        //
        //        public void BeginLabel(VkCommandBuffer cmdBuf,
        //                               utf8string          label)
        //        {
        //            if(_sEnabled)
        //            {
        //                VkDebugUtilsLabelEXT s = new VkDebugUtilsLabelEXT(VK_STRUCTURE_TYPE_DEBUG_UTILS_LABEL_EXT, null, label, 
        //                {
        //                    1.0f,
        //                    1.0f,
        //                    1.0f,
        //                    1.0f
        //                });
        //                vkCmdBeginDebugUtilsLabelEXT(cmdBuf, s);
        //            }
        //        }

        //        public void EndLabel(VkCommandBuffer cmdBuf)
        //        {
        //            if(_sEnabled)
        //            {
        //                vkCmdEndDebugUtilsLabelEXT(cmdBuf);
        //            }
        //        }

        //        public void InsertLabel(VkCommandBuffer cmdBuf,
        //                                utf8string          label)
        //        {
        //            if(_sEnabled)
        //            {
        //                VkDebugUtilsLabelEXT s = new VkDebugUtilsLabelEXT(VK_STRUCTURE_TYPE_DEBUG_UTILS_LABEL_EXT, null, label, 
        //                {
        //                    1.0f,
        //                    1.0f,
        //                    1.0f,
        //                    1.0f
        //                });
        //                vkCmdInsertDebugUtilsLabelEXT(cmdBuf, s);
        //            }
        //        }

        //        //
        //        // Begin and End Command Label MUST be balanced, this helps as it will always close the opened label
        //        //
        //        public class ScopedCmdLabel : System.IDisposable
        //        {
        //            public ScopedCmdLabel(VkCommandBuffer cmdBuf,
        //                                  utf8string          label)
        //            {
        //                this._mCmdBuf.CopyFrom(cmdBuf);
        //                if(_sEnabled)
        //                {
        //                    VkDebugUtilsLabelEXT s = new VkDebugUtilsLabelEXT(VK_STRUCTURE_TYPE_DEBUG_UTILS_LABEL_EXT, null, label, 
        //                    {
        //                        1.0f,
        //                        1.0f,
        //                        1.0f,
        //                        1.0f
        //                    });
        //                    vkCmdBeginDebugUtilsLabelEXT(cmdBuf, s);
        //                }
        //            }

        //            public void Dispose()
        //            {
        //                if(_sEnabled)
        //                {
        //                    vkCmdEndDebugUtilsLabelEXT(_mCmdBuf);
        //                }
        //            }

        //            public void SetLabel(utf8string label)
        //            {
        //                if(_sEnabled)
        //                {
        //                    VkDebugUtilsLabelEXT s = new VkDebugUtilsLabelEXT(VK_STRUCTURE_TYPE_DEBUG_UTILS_LABEL_EXT, null, label, 
        //                    {
        //                        1.0f,
        //                        1.0f,
        //                        1.0f,
        //                        1.0f
        //                    });
        //                    vkCmdInsertDebugUtilsLabelEXT(_mCmdBuf, s);
        //                }
        //            }

        //            private VkCommandBuffer _mCmdBuf = new VkCommandBuffer();
        //        }

        //        public ScopedCmdLabel ScopeLabel(VkCommandBuffer cmdBuf,
        //                                         utf8string          label)
        //        {
        //            return new ScopedCmdLabel(cmdBuf, label);
        //        }
    }
}
