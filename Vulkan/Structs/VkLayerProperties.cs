using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkLayerProperties
    {
        [NativeTypeName("char [256]")]
        public utf8string<Const.UInt256> LayerName;

        [NativeTypeName("uint32_t")]
        public uint SpecVersion;

        [NativeTypeName("uint32_t")]
        public uint ImplementationVersion;

        [NativeTypeName("char [256]")]
        public utf8string<Const.UInt256> Description;

        public override string? ToString()
        {
            //fixed(sbyte* layerNamePtr = LayerName)
            //fixed(sbyte* DescriptionPtr = Description)
            {
                //utf8string layerName   = new utf8string(layerNamePtr);
                //utf8string description = new utf8string(DescriptionPtr);

                return $"{LayerName} {Description}";
            }
        }
    }
}
