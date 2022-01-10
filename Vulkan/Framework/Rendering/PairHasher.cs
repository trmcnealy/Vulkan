namespace Vulkan.Framework;

/**
 * @brief An utility struct for hashing pairs.
 */
public class PairHasher
{
    public nint Operator ()<TPair>(in TPair pair)
    {
        std::Hash <decltype(pair.first) > hash1
        {
        };
        std::Hash <decltype(pair.second) > hash2
        {
        };
        return hash1(pair.first) * 43 + pair.second;
    }
}