
namespace Vulkan
{
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [System.Runtime.Versioning.NonVersionable]
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct VkResult
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        static VkResult()
        {
            Success = new VkResult(SuccessConst);
            NotReady = new VkResult(NotReadyConst);
            Timeout = new VkResult(TimeoutConst);
            EventSet = new VkResult(EventSetConst);
            EventReset = new VkResult(EventResetConst);
            Incomplete = new VkResult(IncompleteConst);
            OutOfHostMemory = new VkResult(OutOfHostMemoryConst);
            OutOfDeviceMemory = new VkResult(OutOfDeviceMemoryConst);
            InitializationFailed = new VkResult(InitializationFailedConst);
            DeviceLost = new VkResult(DeviceLostConst);
            MemoryMapFailed = new VkResult(MemoryMapFailedConst);
            LayerNotPresent = new VkResult(LayerNotPresentConst);
            ExtensionNotPresent = new VkResult(ExtensionNotPresentConst);
            FeatureNotPresent = new VkResult(FeatureNotPresentConst);
            IncompatibleDriver = new VkResult(IncompatibleDriverConst);
            ErrorTooManyObjects = new VkResult(ErrorTooManyObjectsConst);
            FormatNotSupported = new VkResult(FormatNotSupportedConst);
            FragmentedPool = new VkResult(FragmentedPoolConst);
            Unknown = new VkResult(UnknownConst);
            OutOfPoolMemory = new VkResult(OutOfPoolMemoryConst);
            InvalidernalHandle = new VkResult(InvalidernalHandleConst);
            Fragmentation = new VkResult(FragmentationConst);
            InvalidOpaqueCaptureAddress = new VkResult(InvalidOpaqueCaptureAddressConst);
            SurfaceLost = new VkResult(SurfaceLostConst);
            NativeWindowInUse = new VkResult(NativeWindowInUseConst);
            Suboptimal = new VkResult(SuboptimalConst);
            OutOfDate = new VkResult(OutOfDateConst);
            IncompatibleDisplay = new VkResult(IncompatibleDisplayConst);
            ValidationFailed = new VkResult(ValidationFailedConst);
            InvalidShader = new VkResult(InvalidShaderConst);
            InvalidDrmFormatModifierPlaneLayout = new VkResult(InvalidDrmFormatModifierPlaneLayoutConst);
            NotPermitted = new VkResult(NotPermittedConst);
            FullScreenExclusiveModeLost = new VkResult(FullScreenExclusiveModeLostConst);
            ThreadIdle = new VkResult(ThreadIdleConst);
            ThreadDone = new VkResult(ThreadDoneConst);
            OperationDeferred = new VkResult(OperationDeferredConst);
            OperationNotDeferred = new VkResult(OperationNotDeferredConst);
            PipelineCompileRequired = new VkResult(PipelineCompileRequiredConst);
            MaxEnumFlag = new VkResult(MaxEnumFlagConst);

            ValueNames = new Dictionary<VkResult, string>()
            {
                {Success, "Success"},
                {NotReady, "NotReady"},
                {Timeout, "Timeout"},
                {EventSet, "EventSet"},
                {EventReset, "EventReset"},
                {Incomplete, "Incomplete"},
                {OutOfHostMemory, "OutOfHostMemory"},
                {OutOfDeviceMemory, "OutOfDeviceMemory"},
                {InitializationFailed, "InitializationFailed"},
                {DeviceLost, "DeviceLost"},
                {MemoryMapFailed, "MemoryMapFailed"},
                {LayerNotPresent, "LayerNotPresent"},
                {ExtensionNotPresent, "ExtensionNotPresent"},
                {FeatureNotPresent, "FeatureNotPresent"},
                {IncompatibleDriver, "IncompatibleDriver"},
                {ErrorTooManyObjects, "ErrorTooManyObjects"},
                {FormatNotSupported, "FormatNotSupported"},
                {FragmentedPool, "FragmentedPool"},
                {Unknown, "Unknown"},
                {OutOfPoolMemory, "OutOfPoolMemory"},
                {InvalidernalHandle, "InvalidernalHandle"},
                {Fragmentation, "Fragmentation"},
                {InvalidOpaqueCaptureAddress, "InvalidOpaqueCaptureAddress"},
                {SurfaceLost, "SurfaceLost"},
                {NativeWindowInUse, "NativeWindowInUse"},
                {Suboptimal, "Suboptimal"},
                {OutOfDate, "OutOfDate"},
                {IncompatibleDisplay, "IncompatibleDisplay"},
                {ValidationFailed, "ValidationFailed"},
                {InvalidShader, "InvalidShader"},
                {InvalidDrmFormatModifierPlaneLayout, "InvalidDrmFormatModifierPlaneLayout"},
                {NotPermitted, "NotPermitted"},
                {FullScreenExclusiveModeLost, "FullScreenExclusiveModeLost"},
                {ThreadIdle, "ThreadIdle"},
                {ThreadDone, "ThreadDone"},
                {OperationDeferred, "OperationDeferred"},
                {OperationNotDeferred, "OperationNotDeferred"},
                {PipelineCompileRequired, "PipelineCompileRequired"},
                {MaxEnumFlag, "MaxEnumFlag"},
            };

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkResult(int value) { _value = value; }

        private readonly int _value;

        public int Value { [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] get { return _value; } }

        public static readonly Dictionary<VkResult, string> ValueNames;

        public static readonly VkResult Success;
        public const int SuccessConst = 0;

        public static readonly VkResult NotReady;
        public const int NotReadyConst = 1;

        public static readonly VkResult Timeout;
        public const int TimeoutConst = 2;

        public static readonly VkResult EventSet;
        public const int EventSetConst = 3;

        public static readonly VkResult EventReset;
        public const int EventResetConst = 4;

        public static readonly VkResult Incomplete;
        public const int IncompleteConst = 5;

        public static readonly VkResult OutOfHostMemory;
        public const int OutOfHostMemoryConst = -1;

        public static readonly VkResult OutOfDeviceMemory;
        public const int OutOfDeviceMemoryConst = -2;

        public static readonly VkResult InitializationFailed;
        public const int InitializationFailedConst = -3;

        public static readonly VkResult DeviceLost;
        public const int DeviceLostConst = -4;

        public static readonly VkResult MemoryMapFailed;
        public const int MemoryMapFailedConst = -5;

        public static readonly VkResult LayerNotPresent;
        public const int LayerNotPresentConst = -6;

        public static readonly VkResult ExtensionNotPresent;
        public const int ExtensionNotPresentConst = -7;

        public static readonly VkResult FeatureNotPresent;
        public const int FeatureNotPresentConst = -8;

        public static readonly VkResult IncompatibleDriver;
        public const int IncompatibleDriverConst = -9;

        public static readonly VkResult ErrorTooManyObjects;
        public const int ErrorTooManyObjectsConst = -10;

        public static readonly VkResult FormatNotSupported;
        public const int FormatNotSupportedConst = -11;

        public static readonly VkResult FragmentedPool;
        public const int FragmentedPoolConst = -12;

        public static readonly VkResult Unknown;
        public const int UnknownConst = -13;

        public static readonly VkResult OutOfPoolMemory;
        public const int OutOfPoolMemoryConst = -1000069000;

        public static readonly VkResult InvalidernalHandle;
        public const int InvalidernalHandleConst = -1000072003;

        public static readonly VkResult Fragmentation;
        public const int FragmentationConst = -1000161000;

        public static readonly VkResult InvalidOpaqueCaptureAddress;
        public const int InvalidOpaqueCaptureAddressConst = -1000257000;

        public static readonly VkResult SurfaceLost;
        public const int SurfaceLostConst = -1000000000;

        public static readonly VkResult NativeWindowInUse;
        public const int NativeWindowInUseConst = -1000000001;

        public static readonly VkResult Suboptimal;
        public const int SuboptimalConst = 1000001003;

        public static readonly VkResult OutOfDate;
        public const int OutOfDateConst = -1000001004;

        public static readonly VkResult IncompatibleDisplay;
        public const int IncompatibleDisplayConst = -1000003001;

        public static readonly VkResult ValidationFailed;
        public const int ValidationFailedConst = -1000011001;

        public static readonly VkResult InvalidShader;
        public const int InvalidShaderConst = -1000012000;

        public static readonly VkResult InvalidDrmFormatModifierPlaneLayout;
        public const int InvalidDrmFormatModifierPlaneLayoutConst = -1000158000;

        public static readonly VkResult NotPermitted;
        public const int NotPermittedConst = -1000174001;

        public static readonly VkResult FullScreenExclusiveModeLost;
        public const int FullScreenExclusiveModeLostConst = -1000255000;

        public static readonly VkResult ThreadIdle;
        public const int ThreadIdleConst = 1000268000;

        public static readonly VkResult ThreadDone;
        public const int ThreadDoneConst = 1000268001;

        public static readonly VkResult OperationDeferred;
        public const int OperationDeferredConst = 1000268002;

        public static readonly VkResult OperationNotDeferred;
        public const int OperationNotDeferredConst = 1000268003;

        public static readonly VkResult PipelineCompileRequired;
        public const int PipelineCompileRequiredConst = 1000297000;

        public static readonly VkResult MaxEnumFlag;
        public const int MaxEnumFlagConst = 0x7FFFFFFF;

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator int(in VkResult vkresult)
        {
            return vkresult.Value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator VkResult(int value)
        {
            return new VkResult(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static string GetName(in VkResult vkresult)
        {
            return ValueNames[vkresult];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static VkResult operator ~(in VkResult left) { return (VkResult)(~left.Value); }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static VkResult operator <<(in VkResult left, int right) { return (VkResult)(left.Value << right); }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static VkResult operator >>(in VkResult left, int right) { return (VkResult)(left.Value >> right); }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static VkResult operator ^(in VkResult left, in VkResult right) { return (VkResult)(left.Value ^ right.Value); }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static VkResult operator &(in VkResult left, in VkResult right) { return (VkResult)(left.Value & right.Value); }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static VkResult operator |(in VkResult left, in VkResult right) { return (VkResult)(left.Value | right.Value); }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(VkResult other) { return Value == other.Value; }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override bool Equals(object? obj) { return obj is VkResult other && Equals(other); }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override int GetHashCode() { return Value.GetHashCode(); }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkResult left, in VkResult right) { return Equals(left, right); }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkResult left, int right) { return left.Value == right; }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(int left, in VkResult right) { return left == right.Value; }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkResult left, in VkResult right) { return !Equals(left, right); }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkResult left, int right) { return left.Value != right; }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(int left, in VkResult right) { return left != right.Value; }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override string? ToString()
        {
            return ValueNames[this];
        }

    }

}
