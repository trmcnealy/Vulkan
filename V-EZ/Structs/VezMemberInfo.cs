using System;
using System.Runtime.InteropServices;
using Vulkan;

namespace VEZ;

[StructLayout(LayoutKind.Sequential)]
public struct VezMemberInfo
{
    public VezBaseType baseType;
            
    public uint offset;
            
    public uint size;
            
    public uint vecSize;
            
    public uint columns;
            
    public uint arraySize;
            
    public utf8string name;
            
    public nint pNext;
            
    public nint pMembers;
}