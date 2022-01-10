using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vulkan.Framework
{
    public sealed class VulkanException : Exception
    {
        public VulkanException()
        {
        }

        public VulkanException(string? message)
            : base(message)
        {
        }

        public VulkanException(string?    message,
                               Exception? innerException)
            : base(message, innerException)
        {
        }

        public VulkanException(VkResult result)
            : base(result.ToString())
        {
        }

        public VulkanException(VkResult result,
                               string?  message)
            : base(result + ":" + message)
        {
        }

        public VulkanException(VkResult   result,
                               string?    message,
                               Exception? innerException)
            : base(result + ":" + message, innerException)
        {
        }

        public static void Throw()
        {
            throw new VulkanException();
        }

        public static void Throw(string? message)
        {
            throw new VulkanException(message);
        }

        public static void Throw(VkResult result)
        {
            throw new VulkanException(result);
        }

        public static void Throw(VkResult result,
                                 string?  message)
        {
            throw new VulkanException(result, message);
        }
    }
}
