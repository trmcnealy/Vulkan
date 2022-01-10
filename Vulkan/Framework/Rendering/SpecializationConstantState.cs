using System.Collections.Generic;

namespace Vulkan.Framework;

/// Helper class to create specialization constants for a Vulkan pipeline. The state tracks a pipeline globally, and not per shader. Two shaders using the same constant_id will have the same data.
public class SpecializationConstantState
{
    public void Reset()
    {
        if (_Dirty)
        {
            _SpecializationConstantState.Clear();
        }

        _Dirty = false;
    }

    public bool IsDirty()
    {
        return _Dirty;
    }

    public void ClearDirty()
    {
        _Dirty = false;
    }

//    void SetConstant<T>(uint32_t constant_id, @in T data);

    public void SetConstant<T>(uint constant_id, Array<byte> value)
    {
        var data = _SpecializationConstantState.find(constant_id);

        if (data != _SpecializationConstantState.end() && data.second == value)
        {
            return;
        }

        _Dirty = true;

        _SpecializationConstantState[constant_id] = value;
    }

    public void SetSpecializationConstantState(Dictionary<uint, Array<byte>> state)
    {
        _SpecializationConstantState = state;
    }

    public Dictionary<uint, Array<byte>> GetSpecializationConstantState()
    {
        return _SpecializationConstantState;
    }

    private bool _Dirty = false;
    // Map tracking state of the Specialization Constants
    private Dictionary<uint, Array<byte>> _SpecializationConstantState = new Dictionary<uint, Array<byte>>();
}