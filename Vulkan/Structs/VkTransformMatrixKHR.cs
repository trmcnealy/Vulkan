using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkTransformMatrixKHR
    {
        [NativeTypeName("float [3][4]")] public fixed float Matrix[3 * 4];
    }
}
