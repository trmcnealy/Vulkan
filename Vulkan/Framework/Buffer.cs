using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vulkan.MemoryAllocator;

namespace Vulkan.Framework
{
    public class Buffer : System.IDisposable
    {
        private Device _Device;

        private VkBuffer _Handle = new VkBuffer(0);

        private VmaAllocation _Allocation = new VmaAllocation(0);

        private VkDeviceMemory _Memory = new VkDeviceMemory(0);

        private uint _Size = new uint();

        private byte _MappedData = new byte(null);

        private bool _Persistent = false;

        private bool _Mapped = false;


        public void Dispose()
        {
        }


        public void Flush()
        {
            vmaFlushAllocation(_Device.GetMemoryAllocator(), _Allocation, 0, _Size);
        }

        public byte Map()
        {
            if (!_Mapped && _MappedData == null)
            {
                do
                {
                    VkResult err = vmaMapMemory(_Device.GetMemoryAllocator(), _Allocation, reinterpret_cast<nint>(_MappedData));
                    if (err != null)
                    {
                        (...) spdlog.error("[{}:{}] {}", ((char)__FILE__ + ROOT_PATH_SIZE), __LINE__, fmt.format(__VA_ARGS__));
                        ("Detected Vulkan error: {}", Vkb.GlobalMembers.ToString(err));
                        abort();
                    }
                } while (false);
                _Mapped = true;
            }
            return _MappedData;
        }

        public void Unmap()
        {
            if (_Mapped)
            {
                vmaUnmapMemory(_Device.GetMemoryAllocator(), _Allocation);
                _MappedData = null;
                _Mapped     = false;
            }
        }

        public void Update(byte data, nint size, nint offset = 0)
    {
        if (_Persistent)
        {
            std::copy(data, data + size, _MappedData + offset);
            Flush();
        }
        else
        {
            Map();
            std::copy(data, data + size, _MappedData + offset);
            Flush();
            Unmap();
        }
    }

    /**
     * @brief Converts any non byte data into bytes and then updates the buffer
     * @param data The data to copy from
     * @param size The amount of bytes to copy
     * @param offset The offset to start the copying into the mapped data
     */
    public void Update(nint data, nint size, nint offset = 0)
    {
        update(reinterpret_cast<const byte>(data), size, offset);
    }

    /**
     * @brief Copies a vector of bytes into the buffer
     * @param data The data vector to upload
     * @param offset The offset to start the copying into the mapped data
     */
    public void Update(Array<byte> data, nint offset = 0)
    {
        update(data.data(), data.Count, offset);
    }

    /**
     * @brief Copies an object as byte data into the buffer
     * @param object The object to convert into byte data
     * @param offset The offset to start the copying into the mapped data
     */
    public void ConvertAndUpdate<T>(in T @object, nint offset = 0)
    {
        update(reinterpret_cast<const byte>(@object), sizeof(T), offset);
    }

    /**
     * @return Return the buffer's device address (note: requires that the buffer has been created with the VK_BUFFER_USAGE_SHADER_DEVICE_ADDRESS_BIT usage fla)
     */
    public ulong GetDeviceAddress()
    {
        VkBufferDeviceAddressInfoKHR buffer_device_address_info = new VkBufferDeviceAddressInfoKHR();
        buffer_device_address_info.sType = VK_STRUCTURE_TYPE_BUFFER_DEVICE_ADDRESS_INFO;
        buffer_device_address_info.buffer = _Handle;
        return vkGetBufferDeviceAddressKHR(_Device.GetHandle(), buffer_device_address_info);
    }
    }
}
