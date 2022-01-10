using System.Collections.Generic;

namespace Vulkan.Framework;

public class ShaderVariant
{
    private nint _Id = new nint();

    private utf8string _Preamble = "";

    private Array<utf8string> _Processes = new Array<utf8string>();

    private Dictionary<utf8string, nint> _RuntimeArraySizes = new Dictionary<utf8string, nint>();
}
