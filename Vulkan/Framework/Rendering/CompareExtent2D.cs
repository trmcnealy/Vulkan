namespace Vulkan.Framework
{
//namespace
    public class CompareExtent2D
    {
        public bool Operator ()(in VkExtent2D lhs, in VkExtent2D rhs)
        {
            return !(lhs.width == rhs.width && lhs.height == rhs.height) && (lhs.width < rhs.width && lhs.height < rhs.height);
        }
    }

}