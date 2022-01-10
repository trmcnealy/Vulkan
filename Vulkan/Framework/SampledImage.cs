namespace Vulkan.Framework;

public class SampledImage
{
    private readonly ImageView    _ImageView;
    private          uint         _TargetAttachment = new uint();
    private          RenderTarget _RenderTarget;
    private          Sampler      _Sampler;
    private          bool         _IsDepthResolve;
}
