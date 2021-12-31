using System;
using System.Runtime.InteropServices;
using Vulkan;

namespace VEZ;

[StructLayout(LayoutKind.Sequential)]
public struct VezPipelineResource
{
    public VkShaderStageFlagBits stages;
            
    public VezPipelineResourceType resourceType;
            
    public VezBaseType baseType;
            
    public VkAccessFlagBits access;
            
    public uint set;
            
    public uint binding;
            
    public uint location;
            
    public uint inputAttachmentIndex;
            
    public uint vecSize;
            
    public uint columns;
            
    public uint arraySize;
            
    public uint offset;
            
    public uint size;
            
    public utf8string name;
            
    public nint pMembers;
}