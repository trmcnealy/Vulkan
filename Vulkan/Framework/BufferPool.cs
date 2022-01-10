using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vulkan.Framework
{
    public class BufferAllocation
    {
        public BufferAllocation(Buffer buffer,
                                uint   size,
                                uint   offset)
        {
            this._Buffer     = buffer;
            this._Size       = size;
            this._BaseOffset = offset;
        }

        public void Update(Array<byte> data,
                           uint        offset = 0)
        {
            if(offset + data.Count <= _Size != null)
            {
                _Buffer.update(data, GlobalMembers.ToU32(_BaseOffset) + offset);
            }
            else
            {
                throw new Exception("Ignore buffer allocation update");
            }
        }

        public void Update<T>(in T value,
                              uint offset = 0)
        {
            Update(GlobalMembers.ToBytes(value), offset);
        }

        public bool Empty()
        {
            return _Size == 0 || _Buffer == null;
        }

        public uint GetSize()
        {
            return _Size;
        }

        public uint GetOffset()
        {
            return _BaseOffset;
        }

        public Buffer GetBuffer()
        {
            return _Buffer;
        }

        private Buffer _Buffer = new Buffer(null);

        private uint _BaseOffset = new uint();

        private uint _Size = new uint();
    }

    public class BufferBlock
    {
        public BufferBlock(Device                device,
                           uint                  size,
                           VkBufferUsageFlagBits usage,
                           VmaMemoryUsage        memory_usage)
        {
            this._Buffer = new Buffer(device, size, usage, memory_usage);
            if(usage == VK_BUFFER_USAGE_UNIFORM_BUFFER_BIT)
            {
                _Alignment = device.GetGpu().GetProperties().limits.minUniformBufferOffsetAlignment;
            }
            else if(usage == VK_BUFFER_USAGE_STORAGE_BUFFER_BIT)
            {
                _Alignment = device.GetGpu().GetProperties().limits.minStorageBufferOffsetAlignment;
            }
            else if(usage == VK_BUFFER_USAGE_UNIFORM_TEXEL_BUFFER_BIT)
            {
                _Alignment = device.GetGpu().GetProperties().limits.minTexelBufferOffsetAlignment;
            }
            else if(usage == VK_BUFFER_USAGE_INDEX_BUFFER_BIT || usage == VK_BUFFER_USAGE_VERTEX_BUFFER_BIT || usage == VK_BUFFER_USAGE_INDIRECT_BUFFER_BIT)
            {
                _Alignment = 16;
            }
            else
            {
                throw new System.Exception("Usage not recognised");
            }
        }

        public BufferAllocation Allocate(uint allocate_size)
        {
            var aligned_offset = (_Offset + _Alignment - 1) & ~(_Alignment - 1);

            if(aligned_offset + allocate_size > _Buffer.GetSize() != null)
            {
                return BufferAllocation{
                }
                ;
            }

            _Offset = aligned_offset + allocate_size;
            return BufferAllocation{
                _Buffer, allocate_size, aligned_offset
            }
            ;
        }

        public uint GetSize()
        {
            return _Buffer.GetSize();
        }

        public void Reset()
        {
            _Offset = 0;
        }

        private Buffer _Buffer = new Buffer();

        private uint _Alignment = new uint();

        private uint _Offset = new uint();
    }


    public class BufferPool
    {
        private Device _Device;

        private Array<BufferBlock> _BufferBlocks = new Array<BufferBlock>();

        private uint _BlockSize = new uint();

        private VkBufferUsageFlagBits _Usage = new VkBufferUsageFlagBits();

        private VmaMemoryUsage _MemoryUsage = new VmaMemoryUsage();

        private uint _ActiveBufferBlockCount = new uint();
    }
}
