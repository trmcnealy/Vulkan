using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vulkan
{
    public sealed class QueueFamilyIndices
    {
        public uint GraphicsFamily { get; private set;}
        public uint PresentFamily { get; private set;}

        public QueueFamilyIndices(uint graphicsFamily, uint presentFamily)
        {
            GraphicsFamily = graphicsFamily;
            PresentFamily = presentFamily;
        }
    }
}
