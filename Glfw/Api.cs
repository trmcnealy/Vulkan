
// ReSharper disable InconsistentNaming

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using Vulkan;

namespace Glfw
{
    public static partial class Api
    {
        //public const           string DLL_NAME       = "glfw";
        //public const           string DLL_EXACT_NAME = "glfw3.dll";
        
        public static readonly string DLL_NAME;
        public static readonly nint   Handle;


        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        static unsafe Api()
        {
            Handle = DllMap.MapAndLoad("glfw");

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                DLL_NAME = "libglfw.so.3";
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                DLL_NAME = "libglfw.3.dylib";
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                DLL_NAME = "glfw3.dll";
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.FreeBSD))
            {
                DLL_NAME = "glfw3";
            }
            else
            {
                DLL_NAME = "glfw";
            }

            Handle = DllMap.MapAndLoad(DLL_NAME);



            /*delegate*<int>*/
            Init = (delegate*unmanaged<int>)NativeLibrary.GetExport(Handle, "glfwInit");
            /*delegate*<void>*/
            Terminate = (delegate*<void>)NativeLibrary.GetExport(Handle, "glfwTerminate");
            /*delegate*<int, int, void>*/
            InitHint = (delegate*<int, int, void>)NativeLibrary.GetExport(Handle, "glfwInitHint");
            /*delegate*<ref int, ref int, ref int, void>*/
            GetVersion = (delegate*<ref int, ref int, ref int, void>)NativeLibrary.GetExport(Handle, "glfwGetVersion");
            /*delegate*<nint>*/
            GetVersionString = (delegate*<nint>)NativeLibrary.GetExport(Handle, "glfwGetVersionString");
            /*delegate*<out nint, int>*/
            GetError = (delegate*<out nint, int>)NativeLibrary.GetExport(Handle, "glfwGetError");
            /*delegate*<GLFWerrorfun, GLFWerrorfun>*/
            SetErrorCallback = (delegate*<GLFWerrorfun, GLFWerrorfun>)NativeLibrary.GetExport(Handle, "glfwSetErrorCallback");
            /*delegate*<ref int, nint>*/
            GetMonitors = (delegate*<ref int, nint>)NativeLibrary.GetExport(Handle, "glfwGetMonitors");
            /*delegate*<GLFWmonitor>*/
            GetPrimaryMonitor = (delegate*<GLFWmonitor>)NativeLibrary.GetExport(Handle, "glfwGetPrimaryMonitor");
            /*delegate*<GLFWmonitor, ref int, ref int, void>*/
            GetMonitorPos = (delegate*<GLFWmonitor, ref int, ref int, void>)NativeLibrary.GetExport(Handle, "glfwGetMonitorPos");
            /*delegate*<GLFWmonitor, ref int, ref int, ref int, ref int, void>*/
            GetMonitorWorkarea = (delegate*<GLFWmonitor, ref int, ref int, ref int, ref int, void>)NativeLibrary.GetExport(Handle, "glfwGetMonitorWorkarea");
            /*delegate*<GLFWmonitor, ref int, ref int, void>*/
            GetMonitorPhysicalSize = (delegate*<GLFWmonitor, ref int, ref int, void>)NativeLibrary.GetExport(Handle, "glfwGetMonitorPhysicalSize");
            /*delegate*<GLFWmonitor, ref float, ref float, void>*/
            GetMonitorContentScale = (delegate*<GLFWmonitor, ref float, ref float, void>)NativeLibrary.GetExport(Handle, "glfwGetMonitorContentScale");
            /*delegate*<GLFWmonitor, nint>*/
            GetMonitorName = (delegate*<GLFWmonitor, nint>)NativeLibrary.GetExport(Handle, "glfwGetMonitorName");
            /*delegate*<GLFWmonitor, nint, void>*/
            SetMonitorUserPointer = (delegate*<GLFWmonitor, nint, void>)NativeLibrary.GetExport(Handle, "glfwSetMonitorUserPointer");
            /*delegate*<GLFWmonitor, nint>*/
            GetMonitorUserPointer = (delegate*<GLFWmonitor, nint>)NativeLibrary.GetExport(Handle, "glfwGetMonitorUserPointer");
            /*delegate*<GLFWmonitorfun, GLFWmonitorfun>*/
            SetMonitorCallback = (delegate*<GLFWmonitorfun, GLFWmonitorfun>)NativeLibrary.GetExport(Handle, "glfwSetMonitorCallback");
            /*delegate*<GLFWmonitor, ref int, ref readonly GLFWvidmode>*/
            GetVideoModes = (delegate*<GLFWmonitor, ref int, ref readonly GLFWvidmode>)NativeLibrary.GetExport(Handle, "glfwGetVideoModes");
            /*delegate*<GLFWmonitor, ref readonly GLFWvidmode>*/
            GetVideoMode = (delegate*<GLFWmonitor, ref readonly GLFWvidmode>)NativeLibrary.GetExport(Handle, "glfwGetVideoMode");
            /*delegate*<GLFWmonitor, float, void>*/
            SetGamma = (delegate*<GLFWmonitor, float, void>)NativeLibrary.GetExport(Handle, "glfwSetGamma");
            /*delegate*<GLFWmonitor, ref readonly GLFWgammaramp>*/
            GetGammaRamp = (delegate*<GLFWmonitor, ref readonly GLFWgammaramp>)NativeLibrary.GetExport(Handle, "glfwGetGammaRamp");
            /*delegate*<GLFWmonitor, in GLFWgammaramp, void>*/
            SetGammaRamp = (delegate*<GLFWmonitor, in GLFWgammaramp, void>)NativeLibrary.GetExport(Handle, "glfwSetGammaRamp");
            /*delegate*<void>*/
            DefaultWindowHints = (delegate*<void>)NativeLibrary.GetExport(Handle, "glfwDefaultWindowHints");
            /*delegate*<int, int, void>*/
            WindowHint = (delegate*<int, int, void>)NativeLibrary.GetExport(Handle, "glfwWindowHint");
            /*delegate*<int, nint, void>*/
            WindowHintString = (delegate*<int, nint, void>)NativeLibrary.GetExport(Handle, "glfwWindowHintString");
            /*delegate*<int, int, nint, GLFWmonitor, GLFWwindow, GLFWwindow>*/
            CreateWindow = (delegate*<int, int, utf8cstring, GLFWmonitor, GLFWwindow, GLFWwindow>)NativeLibrary.GetExport(Handle, "glfwCreateWindow");
            /*delegate*<GLFWwindow, void>*/
            DestroyWindow = (delegate*<GLFWwindow, void>)NativeLibrary.GetExport(Handle, "glfwDestroyWindow");
            /*delegate*<GLFWwindow, int>*/
            WindowShouldClose = (delegate*<GLFWwindow, int>)NativeLibrary.GetExport(Handle, "glfwWindowShouldClose");
            /*delegate*<GLFWwindow, int, void>*/
            SetWindowShouldClose = (delegate*<GLFWwindow, int, void>)NativeLibrary.GetExport(Handle, "glfwSetWindowShouldClose");
            /*delegate*<GLFWwindow, nint, void>*/
            SetWindowTitle = (delegate*<GLFWwindow, nint, void>)NativeLibrary.GetExport(Handle, "glfwSetWindowTitle");
            /*delegate*<GLFWwindow, int, in GLFWimage, void>*/
            SetWindowIcon = (delegate*<GLFWwindow, int, in GLFWimage, void>)NativeLibrary.GetExport(Handle, "glfwSetWindowIcon");
            /*delegate*<GLFWwindow, ref int, ref int, void>*/
            GetWindowPos = (delegate*<GLFWwindow, ref int, ref int, void>)NativeLibrary.GetExport(Handle, "glfwGetWindowPos");
            /*delegate*<GLFWwindow, int, int, void>*/
            SetWindowPos = (delegate*<GLFWwindow, int, int, void>)NativeLibrary.GetExport(Handle, "glfwSetWindowPos");
            /*delegate*<GLFWwindow, ref int, ref int, void>*/
            GetWindowSize = (delegate*<GLFWwindow, ref int, ref int, void>)NativeLibrary.GetExport(Handle, "glfwGetWindowSize");
            /*delegate*<GLFWwindow, int, int, int, int, void>*/
            SetWindowSizeLimits = (delegate*<GLFWwindow, int, int, int, int, void>)NativeLibrary.GetExport(Handle, "glfwSetWindowSizeLimits");
            /*delegate*<GLFWwindow, int, int, void>*/
            SetWindowAspectRatio = (delegate*<GLFWwindow, int, int, void>)NativeLibrary.GetExport(Handle, "glfwSetWindowAspectRatio");
            /*delegate*<GLFWwindow, int, int, void>*/
            SetWindowSize = (delegate*<GLFWwindow, int, int, void>)NativeLibrary.GetExport(Handle, "glfwSetWindowSize");
            /*delegate*<GLFWwindow, ref int, ref int, void>*/
            GetFramebufferSize = (delegate*<GLFWwindow, out int, out int, void>)NativeLibrary.GetExport(Handle, "glfwGetFramebufferSize");
            /*delegate*<GLFWwindow, ref int, ref int, ref int, ref int, void>*/
            GetWindowFrameSize = (delegate*<GLFWwindow, ref int, ref int, ref int, ref int, void>)NativeLibrary.GetExport(Handle, "glfwGetWindowFrameSize");
            /*delegate*<GLFWwindow, ref float, ref float, void>*/
            GetWindowContentScale = (delegate*<GLFWwindow, ref float, ref float, void>)NativeLibrary.GetExport(Handle, "glfwGetWindowContentScale");
            /*delegate*<GLFWwindow, float>*/
            GetWindowOpacity = (delegate*<GLFWwindow, float>)NativeLibrary.GetExport(Handle, "glfwGetWindowOpacity");
            /*delegate*<GLFWwindow, float, void>*/
            SetWindowOpacity = (delegate*<GLFWwindow, float, void>)NativeLibrary.GetExport(Handle, "glfwSetWindowOpacity");
            /*delegate*<GLFWwindow, void>*/
            IconifyWindow = (delegate*<GLFWwindow, void>)NativeLibrary.GetExport(Handle, "glfwIconifyWindow");
            /*delegate*<GLFWwindow, void>*/
            RestoreWindow = (delegate*<GLFWwindow, void>)NativeLibrary.GetExport(Handle, "glfwRestoreWindow");
            /*delegate*<GLFWwindow, void>*/
            MaximizeWindow = (delegate*<GLFWwindow, void>)NativeLibrary.GetExport(Handle, "glfwMaximizeWindow");
            /*delegate*<GLFWwindow, void>*/
            ShowWindow = (delegate*<GLFWwindow, void>)NativeLibrary.GetExport(Handle, "glfwShowWindow");
            /*delegate*<GLFWwindow, void>*/
            HideWindow = (delegate*<GLFWwindow, void>)NativeLibrary.GetExport(Handle, "glfwHideWindow");
            /*delegate*<GLFWwindow, void>*/
            FocusWindow = (delegate*<GLFWwindow, void>)NativeLibrary.GetExport(Handle, "glfwFocusWindow");
            /*delegate*<GLFWwindow, void>*/
            RequestWindowAttention = (delegate*<GLFWwindow, void>)NativeLibrary.GetExport(Handle, "glfwRequestWindowAttention");
            /*delegate*<GLFWwindow, GLFWmonitor>*/
            GetWindowMonitor = (delegate*<GLFWwindow, GLFWmonitor>)NativeLibrary.GetExport(Handle, "glfwGetWindowMonitor");
            /*delegate*<GLFWwindow, GLFWmonitor, int, int, int, int, int, void>*/
            SetWindowMonitor = (delegate*<GLFWwindow, GLFWmonitor, int, int, int, int, int, void>)NativeLibrary.GetExport(Handle, "glfwSetWindowMonitor");
            /*delegate*<GLFWwindow, int, int>*/
            GetWindowAttrib = (delegate*<GLFWwindow, int, int>)NativeLibrary.GetExport(Handle, "glfwGetWindowAttrib");
            /*delegate*<GLFWwindow, int, int, void>*/
            SetWindowAttrib = (delegate*<GLFWwindow, int, int, void>)NativeLibrary.GetExport(Handle, "glfwSetWindowAttrib");
            /*delegate*<GLFWwindow, nint, void>*/
            SetWindowUserPointer = (delegate*<GLFWwindow, nint, void>)NativeLibrary.GetExport(Handle, "glfwSetWindowUserPointer");
            /*delegate*<GLFWwindow, nint>*/
            GetWindowUserPointer = (delegate*<GLFWwindow, nint>)NativeLibrary.GetExport(Handle, "glfwGetWindowUserPointer");
            /*delegate*<GLFWwindow, GLFWwindowposfun, GLFWwindowposfun>*/
            SetWindowPosCallback = (delegate*<GLFWwindow, GLFWwindowposfun, GLFWwindowposfun>)NativeLibrary.GetExport(Handle, "glfwSetWindowPosCallback");
            /*delegate*<GLFWwindow, GLFWwindowsizefun, GLFWwindowsizefun>*/
            SetWindowSizeCallback = (delegate*<GLFWwindow, GLFWwindowsizefun, GLFWwindowsizefun>)NativeLibrary.GetExport(Handle, "glfwSetWindowSizeCallback");
            /*delegate*<GLFWwindow, GLFWwindowclosefun, GLFWwindowclosefun>*/
            SetWindowCloseCallback = (delegate*<GLFWwindow, GLFWwindowclosefun, GLFWwindowclosefun>)NativeLibrary.GetExport(Handle, "glfwSetWindowCloseCallback");
            /*delegate*<GLFWwindow, GLFWwindowrefreshfun, GLFWwindowrefreshfun>*/
            SetWindowRefreshCallback = (delegate*<GLFWwindow, GLFWwindowrefreshfun, GLFWwindowrefreshfun>)NativeLibrary.GetExport(Handle, "glfwSetWindowRefreshCallback");
            /*delegate*<GLFWwindow, GLFWwindowfocusfun, GLFWwindowfocusfun>*/
            SetWindowFocusCallback = (delegate*<GLFWwindow, GLFWwindowfocusfun, GLFWwindowfocusfun>)NativeLibrary.GetExport(Handle, "glfwSetWindowFocusCallback");
            /*delegate*<GLFWwindow, GLFWwindowiconifyfun, GLFWwindowiconifyfun>*/
            SetWindowIconifyCallback = (delegate*<GLFWwindow, GLFWwindowiconifyfun, GLFWwindowiconifyfun>)NativeLibrary.GetExport(Handle, "glfwSetWindowIconifyCallback");
            /*delegate*<GLFWwindow, GLFWwindowmaximizefun, GLFWwindowmaximizefun>*/
            SetWindowMaximizeCallback = (delegate*<GLFWwindow, GLFWwindowmaximizefun, GLFWwindowmaximizefun>)NativeLibrary.GetExport(Handle, "glfwSetWindowMaximizeCallback");
            /*delegate*<GLFWwindow, GLFWframebuffersizefun, GLFWframebuffersizefun>*/
            SetFramebufferSizeCallback = (delegate*<GLFWwindow, GLFWframebuffersizefun, GLFWframebuffersizefun>)NativeLibrary.GetExport(Handle, "glfwSetFramebufferSizeCallback");
            /*delegate*<GLFWwindow, GLFWwindowcontentscalefun, GLFWwindowcontentscalefun>*/
            SetWindowContentScaleCallback = (delegate*<GLFWwindow, GLFWwindowcontentscalefun, GLFWwindowcontentscalefun>)NativeLibrary.GetExport(Handle, "glfwSetWindowContentScaleCallback");
            /*delegate*<void>*/
            PollEvents = (delegate*<void>)NativeLibrary.GetExport(Handle, "glfwPollEvents");
            /*delegate*<void>*/
            WaitEvents = (delegate*<void>)NativeLibrary.GetExport(Handle, "glfwWaitEvents");
            /*delegate*<double, void>*/
            WaitEventsTimeout = (delegate*<double, void>)NativeLibrary.GetExport(Handle, "glfwWaitEventsTimeout");
            /*delegate*<void>*/
            PostEmptyEvent = (delegate*<void>)NativeLibrary.GetExport(Handle, "glfwPostEmptyEvent");
            /*delegate*<GLFWwindow, int, int>*/
            GetInputMode = (delegate*<GLFWwindow, int, int>)NativeLibrary.GetExport(Handle, "glfwGetInputMode");
            /*delegate*<GLFWwindow, int, int, void>*/
            SetInputMode = (delegate*<GLFWwindow, int, int, void>)NativeLibrary.GetExport(Handle, "glfwSetInputMode");
            /*delegate*<int>*/
            RawMouseMotionSupported = (delegate*<int>)NativeLibrary.GetExport(Handle, "glfwRawMouseMotionSupported");
            /*delegate*<int, int, nint>*/
            GetKeyName = (delegate*<int, int, nint>)NativeLibrary.GetExport(Handle, "glfwGetKeyName");
            /*delegate*<int, int>*/
            GetKeyScancode = (delegate*<int, int>)NativeLibrary.GetExport(Handle, "glfwGetKeyScancode");
            /*delegate*<GLFWwindow, int, int>*/
            GetKey = (delegate*<GLFWwindow, int, int>)NativeLibrary.GetExport(Handle, "glfwGetKey");
            /*delegate*<GLFWwindow, int, int>*/
            GetMouseButton = (delegate*<GLFWwindow, int, int>)NativeLibrary.GetExport(Handle, "glfwGetMouseButton");
            /*delegate*<GLFWwindow, ref double, ref double, void>*/
            GetCursorPos = (delegate*<GLFWwindow, ref double, ref double, void>)NativeLibrary.GetExport(Handle, "glfwGetCursorPos");
            /*delegate*<GLFWwindow, double, double, void>*/
            SetCursorPos = (delegate*<GLFWwindow, double, double, void>)NativeLibrary.GetExport(Handle, "glfwSetCursorPos");
            /*delegate*<in GLFWimage, int, int, GLFWcursor>*/
            CreateCursor = (delegate*<in GLFWimage, int, int, GLFWcursor>)NativeLibrary.GetExport(Handle, "glfwCreateCursor");
            /*delegate*<int, GLFWcursor>*/
            CreateStandardCursor = (delegate*<int, GLFWcursor>)NativeLibrary.GetExport(Handle, "glfwCreateStandardCursor");
            /*delegate*<GLFWcursor, void>*/
            DestroyCursor = (delegate*<GLFWcursor, void>)NativeLibrary.GetExport(Handle, "glfwDestroyCursor");
            /*delegate*<GLFWwindow, GLFWcursor, void>*/
            SetCursor = (delegate*<GLFWwindow, GLFWcursor, void>)NativeLibrary.GetExport(Handle, "glfwSetCursor");
            /*delegate*<GLFWwindow, GLFWkeyfun, GLFWkeyfun>*/
            SetKeyCallback = (delegate*<GLFWwindow, GLFWkeyfun, GLFWkeyfun>)NativeLibrary.GetExport(Handle, "glfwSetKeyCallback");
            /*delegate*<GLFWwindow, GLFWcharfun, GLFWcharfun>*/
            SetCharCallback = (delegate*<GLFWwindow, GLFWcharfun, GLFWcharfun>)NativeLibrary.GetExport(Handle, "glfwSetCharCallback");
            /*delegate*<GLFWwindow, GLFWcharmodsfun, GLFWcharmodsfun>*/
            SetCharModsCallback = (delegate*<GLFWwindow, GLFWcharmodsfun, GLFWcharmodsfun>)NativeLibrary.GetExport(Handle, "glfwSetCharModsCallback");
            /*delegate*<GLFWwindow, GLFWmousebuttonfun, GLFWmousebuttonfun>*/
            SetMouseButtonCallback = (delegate*<GLFWwindow, GLFWmousebuttonfun, GLFWmousebuttonfun>)NativeLibrary.GetExport(Handle, "glfwSetMouseButtonCallback");
            /*delegate*<GLFWwindow, GLFWcursorposfun, GLFWcursorposfun>*/
            SetCursorPosCallback = (delegate*<GLFWwindow, GLFWcursorposfun, GLFWcursorposfun>)NativeLibrary.GetExport(Handle, "glfwSetCursorPosCallback");
            /*delegate*<GLFWwindow, GLFWcursorenterfun, GLFWcursorenterfun>*/
            SetCursorEnterCallback = (delegate*<GLFWwindow, GLFWcursorenterfun, GLFWcursorenterfun>)NativeLibrary.GetExport(Handle, "glfwSetCursorEnterCallback");
            /*delegate*<GLFWwindow, GLFWscrollfun, GLFWscrollfun>*/
            SetScrollCallback = (delegate*<GLFWwindow, GLFWscrollfun, GLFWscrollfun>)NativeLibrary.GetExport(Handle, "glfwSetScrollCallback");
            /*delegate*<GLFWwindow, GLFWdropfun, GLFWdropfun>*/
            SetDropCallback = (delegate*<GLFWwindow, GLFWdropfun, GLFWdropfun>)NativeLibrary.GetExport(Handle, "glfwSetDropCallback");
            /*delegate*<int, int>*/
            JoystickPresent = (delegate*<int, int>)NativeLibrary.GetExport(Handle, "glfwJoystickPresent");
            /*delegate*<int, ref int, nint>*/
            GetJoystickButtons = (delegate*<int, ref int, nint>)NativeLibrary.GetExport(Handle, "glfwGetJoystickButtons");
            /*delegate*<int, ref int, nint>*/
            GetJoystickHats = (delegate*<int, ref int, nint>)NativeLibrary.GetExport(Handle, "glfwGetJoystickHats");
            /*delegate*<int, nint>*/
            GetJoystickName = (delegate*<int, nint>)NativeLibrary.GetExport(Handle, "glfwGetJoystickName");
            /*delegate*<int, nint>*/
            GetJoystickGUID = (delegate*<int, nint>)NativeLibrary.GetExport(Handle, "glfwGetJoystickGUID");
            /*delegate*<int, nint, void>*/
            SetJoystickUserPointer = (delegate*<int, nint, void>)NativeLibrary.GetExport(Handle, "glfwSetJoystickUserPointer");
            /*delegate*<int, nint>*/
            GetJoystickUserPointer = (delegate*<int, nint>)NativeLibrary.GetExport(Handle, "glfwGetJoystickUserPointer");
            /*delegate*<int, int>*/
            JoystickIsGamepad = (delegate*<int, int>)NativeLibrary.GetExport(Handle, "glfwJoystickIsGamepad");
            /*delegate*<GLFWjoystickfun, GLFWjoystickfun>*/
            SetJoystickCallback = (delegate*<GLFWjoystickfun, GLFWjoystickfun>)NativeLibrary.GetExport(Handle, "glfwSetJoystickCallback");
            /*delegate*<nint, int>*/
            UpdateGamepadMappings = (delegate*<nint, int>)NativeLibrary.GetExport(Handle, "glfwUpdateGamepadMappings");
            /*delegate*<int, nint>*/
            GetGamepadName = (delegate*<int, nint>)NativeLibrary.GetExport(Handle, "glfwGetGamepadName");
            /*delegate*<int, ref GLFWgamepadstate, int>*/
            GetGamepadState = (delegate*<int, ref GLFWgamepadstate, int>)NativeLibrary.GetExport(Handle, "glfwGetGamepadState");
            /*delegate*<GLFWwindow, nint, void>*/
            SetClipboardString = (delegate*<GLFWwindow, nint, void>)NativeLibrary.GetExport(Handle, "glfwSetClipboardString");
            /*delegate*<GLFWwindow, nint>*/
            GetClipboardString = (delegate*<GLFWwindow, nint>)NativeLibrary.GetExport(Handle, "glfwGetClipboardString");
            /*delegate*<double>*/
            GetTime = (delegate*<double>)NativeLibrary.GetExport(Handle, "glfwGetTime");
            /*delegate*<double, void>*/
            SetTime = (delegate*<double, void>)NativeLibrary.GetExport(Handle, "glfwSetTime");
            /*delegate*<ulong>*/
            GetTimerValue = (delegate*<ulong>)NativeLibrary.GetExport(Handle, "glfwGetTimerValue");
            /*delegate*<ulong>*/
            GetTimerFrequency = (delegate*<ulong>)NativeLibrary.GetExport(Handle, "glfwGetTimerFrequency");
            /*delegate*<GLFWwindow, void>*/
            MakeContextCurrent = (delegate*<GLFWwindow, void>)NativeLibrary.GetExport(Handle, "glfwMakeContextCurrent");
            /*delegate*<GLFWwindow>*/
            GetCurrentContext = (delegate*<GLFWwindow>)NativeLibrary.GetExport(Handle, "glfwGetCurrentContext");
            /*delegate*<GLFWwindow, void>*/
            SwapBuffers = (delegate*<GLFWwindow, void>)NativeLibrary.GetExport(Handle, "glfwSwapBuffers");
            /*delegate*<int, void>*/
            SwapInterval = (delegate*<int, void>)NativeLibrary.GetExport(Handle, "glfwSwapInterval");
            /*delegate*<nint, int>*/
            ExtensionSupported = (delegate*<nint, int>)NativeLibrary.GetExport(Handle, "glfwExtensionSupported");
            /*delegate*<nint, GLFWglproc>*/
            GetProcAddress = (delegate*<nint, GLFWglproc>)NativeLibrary.GetExport(Handle, "glfwGetProcAddress");
            /*delegate*<int>*/
            VulkanSupported = (delegate*<int>)NativeLibrary.GetExport(Handle, "glfwVulkanSupported");
            /*delegate*<ref uint, nint>*/
            GetRequiredInstanceExtensions = (delegate*<out uint, utf8string*>)NativeLibrary.GetExport(Handle, "glfwGetRequiredInstanceExtensions");
            /*delegate*<GLFWmonitor, nint>*/
            GetWin32Adapter = (delegate*<GLFWmonitor, nint>)NativeLibrary.GetExport(Handle, "glfwGetWin32Adapter");
            /*delegate*<GLFWmonitor, nint>*/
            GetWin32Monitor = (delegate*<GLFWmonitor, nint>)NativeLibrary.GetExport(Handle, "glfwGetWin32Monitor");
            /*delegate*<GLFWwindow, nint>*/
            GetWin32Window = (delegate*<GLFWwindow, nint>)NativeLibrary.GetExport(Handle, "glfwGetWin32Window");
            /*delegate*<GLFWwindow, nint>*/
            GetWGLContext = (delegate*<GLFWwindow, nint>)NativeLibrary.GetExport(Handle, "glfwGetWGLContext");

            int init = Init();

            if(init != 1)
            {
                throw new Exception("glfw failed to Init()");
            }

            SetErrorCallback(ErrorCallback);
        }


        public static unsafe void ErrorCallback(int error_code, utf8string description)
        {
            throw new Exception($"glfw error {error_code} " + description.ToString());
        }


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void GLFWglproc();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void GLFWvkproc();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void GLFWerrorfun(int        error_code,
                                          utf8string description);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void GLFWwindowposfun(GLFWwindow arg0,
                                              int        arg1,
                                              int        arg2);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void GLFWwindowsizefun(GLFWwindow arg0,
                                               int        arg1,
                                               int        arg2);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void GLFWwindowclosefun(GLFWwindow arg0);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void GLFWwindowrefreshfun(GLFWwindow arg0);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void GLFWwindowfocusfun(GLFWwindow arg0,
                                                int        arg1);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void GLFWwindowiconifyfun(GLFWwindow arg0,
                                                  int        arg1);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void GLFWwindowmaximizefun(GLFWwindow arg0,
                                                   int        arg1);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void GLFWframebuffersizefun(GLFWwindow arg0,
                                                    int        arg1,
                                                    int        arg2);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void GLFWwindowcontentscalefun(GLFWwindow arg0,
                                                       float      arg1,
                                                       float      arg2);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void GLFWmousebuttonfun(GLFWwindow arg0,
                                                int        arg1,
                                                int        arg2,
                                                int        arg3);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void GLFWcursorposfun(GLFWwindow arg0,
                                              double     arg1,
                                              double     arg2);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void GLFWcursorenterfun(GLFWwindow arg0,
                                                int        arg1);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void GLFWscrollfun(GLFWwindow arg0,
                                           double     arg1,
                                           double     arg2);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void GLFWkeyfun(GLFWwindow arg0,
                                        int        arg1,
                                        int        arg2,
                                        int        arg3,
                                        int        arg4);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void GLFWcharfun(GLFWwindow arg0,
                                         uint       arg1);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void GLFWcharmodsfun(GLFWwindow arg0,
                                             uint       arg1,
                                             int        arg2);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void GLFWdropfun(GLFWwindow                                arg0,
                                         int                                       arg1,
                                         [MarshalAs(UnmanagedType.LPArray)] nint[] arg2);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void GLFWmonitorfun(GLFWmonitor arg0,
                                            int         arg1);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void GLFWjoystickfun(int arg0,
                                             int arg1);

        public static unsafe delegate*unmanaged<int>                                                              Init;                          //= (delegate*<int>)NativeLibrary.GetExport(Handle,                                                              "glfwInit");
        public static unsafe delegate*<void>                                                             Terminate;                     //= (delegate*<void>)NativeLibrary.GetExport(Handle,                                                             "glfwTerminate");
        public static unsafe delegate*<int, int, void>                                                   InitHint;                      //= (delegate*<int, int, void>)NativeLibrary.GetExport(Handle,                                                   "glfwInitHint");
        public static unsafe delegate*<ref int, ref int, ref int, void>                                  GetVersion;                    //= (delegate*<ref int, ref int, ref int, void>)NativeLibrary.GetExport(Handle,                                  "glfwGetVersion");
        public static unsafe delegate*<nint>                                                             GetVersionString;              //= (delegate*<nint>)NativeLibrary.GetExport(Handle,                                                             "glfwGetVersionString");
        public static unsafe delegate*<out nint, int>                                                    GetError;                      //= (delegate*<out nint, int>)NativeLibrary.GetExport(Handle,                                                    "glfwGetError");
        public static unsafe delegate*<GLFWerrorfun, GLFWerrorfun>                                       SetErrorCallback;              //= (delegate*<GLFWerrorfun, GLFWerrorfun>)NativeLibrary.GetExport(Handle,                                       "glfwSetErrorCallback");
        public static unsafe delegate*<ref int, nint>                                                    GetMonitors;                   //= (delegate*<ref int, nint>)NativeLibrary.GetExport(Handle,                                                    "glfwGetMonitors");
        public static unsafe delegate*<GLFWmonitor>                                                      GetPrimaryMonitor;             //= (delegate*<GLFWmonitor>)NativeLibrary.GetExport(Handle,                                                      "glfwGetPrimaryMonitor");
        public static unsafe delegate*<GLFWmonitor, ref int, ref int, void>                              GetMonitorPos;                 //= (delegate*<GLFWmonitor, ref int, ref int, void>)NativeLibrary.GetExport(Handle,                              "glfwGetMonitorPos");
        public static unsafe delegate*<GLFWmonitor, ref int, ref int, ref int, ref int, void>            GetMonitorWorkarea;            //= (delegate*<GLFWmonitor, ref int, ref int, ref int, ref int, void>)NativeLibrary.GetExport(Handle,            "glfwGetMonitorWorkarea");
        public static unsafe delegate*<GLFWmonitor, ref int, ref int, void>                              GetMonitorPhysicalSize;        //= (delegate*<GLFWmonitor, ref int, ref int, void>)NativeLibrary.GetExport(Handle,                              "glfwGetMonitorPhysicalSize");
        public static unsafe delegate*<GLFWmonitor, ref float, ref float, void>                          GetMonitorContentScale;        //= (delegate*<GLFWmonitor, ref float, ref float, void>)NativeLibrary.GetExport(Handle,                          "glfwGetMonitorContentScale");
        public static unsafe delegate*<GLFWmonitor, nint>                                                GetMonitorName;                //= (delegate*<GLFWmonitor, nint>)NativeLibrary.GetExport(Handle,                                                "glfwGetMonitorName");
        public static unsafe delegate*<GLFWmonitor, nint, void>                                          SetMonitorUserPointer;         //= (delegate*<GLFWmonitor, nint, void>)NativeLibrary.GetExport(Handle,                                          "glfwSetMonitorUserPointer");
        public static unsafe delegate*<GLFWmonitor, nint>                                                GetMonitorUserPointer;         //= (delegate*<GLFWmonitor, nint>)NativeLibrary.GetExport(Handle,                                                "glfwGetMonitorUserPointer");
        public static unsafe delegate*<GLFWmonitorfun, GLFWmonitorfun>                                   SetMonitorCallback;            //= (delegate*<GLFWmonitorfun, GLFWmonitorfun>)NativeLibrary.GetExport(Handle,                                   "glfwSetMonitorCallback");
        public static unsafe delegate*<GLFWmonitor, ref int, ref readonly GLFWvidmode>                   GetVideoModes;                 //= (delegate*<GLFWmonitor, ref int, ref readonly GLFWvidmode>)NativeLibrary.GetExport(Handle,                   "glfwGetVideoModes");
        public static unsafe delegate*<GLFWmonitor, ref readonly GLFWvidmode>                            GetVideoMode;                  //= (delegate*<GLFWmonitor, ref readonly GLFWvidmode>)NativeLibrary.GetExport(Handle,                            "glfwGetVideoMode");
        public static unsafe delegate*<GLFWmonitor, float, void>                                         SetGamma;                      //= (delegate*<GLFWmonitor, float, void>)NativeLibrary.GetExport(Handle,                                         "glfwSetGamma");
        public static unsafe delegate*<GLFWmonitor, ref readonly GLFWgammaramp>                          GetGammaRamp;                  //= (delegate*<GLFWmonitor, ref readonly GLFWgammaramp>)NativeLibrary.GetExport(Handle,                          "glfwGetGammaRamp");
        public static unsafe delegate*<GLFWmonitor, in GLFWgammaramp, void>                              SetGammaRamp;                  //= (delegate*<GLFWmonitor, in GLFWgammaramp, void>)NativeLibrary.GetExport(Handle,                              "glfwSetGammaRamp");
        public static unsafe delegate*<void>                                                             DefaultWindowHints;            //= (delegate*<void>)NativeLibrary.GetExport(Handle,                                                             "glfwDefaultWindowHints");
        public static unsafe delegate*<int, int, void>                                                   WindowHint;                    //= (delegate*<int, int, void>)NativeLibrary.GetExport(Handle,                                                   "glfwWindowHint");
        public static unsafe delegate*<int, nint, void>                                                  WindowHintString;              //= (delegate*<int, nint, void>)NativeLibrary.GetExport(Handle,                                                  "glfwWindowHintString");
        public static unsafe delegate*<int, int, utf8cstring, GLFWmonitor, GLFWwindow, GLFWwindow>        CreateWindow;                  //= (delegate*<int, int, nint, GLFWmonitor, GLFWwindow, GLFWwindow>)NativeLibrary.GetExport(Handle,              "glfwCreateWindow");
        public static unsafe delegate*<GLFWwindow, void>                                                 DestroyWindow;                 //= (delegate*<GLFWwindow, void>)NativeLibrary.GetExport(Handle,                                                 "glfwDestroyWindow");
        public static unsafe delegate*<GLFWwindow, int>                                                  WindowShouldClose;             //= (delegate*<GLFWwindow, int>)NativeLibrary.GetExport(Handle,                                                  "glfwWindowShouldClose");
        public static unsafe delegate*<GLFWwindow, int, void>                                            SetWindowShouldClose;          //= (delegate*<GLFWwindow, int, void>)NativeLibrary.GetExport(Handle,                                            "glfwSetWindowShouldClose");
        public static unsafe delegate*<GLFWwindow, nint, void>                                           SetWindowTitle;                //= (delegate*<GLFWwindow, nint, void>)NativeLibrary.GetExport(Handle,                                           "glfwSetWindowTitle");
        public static unsafe delegate*<GLFWwindow, int, in GLFWimage, void>                              SetWindowIcon;                 //= (delegate*<GLFWwindow, int, in GLFWimage, void>)NativeLibrary.GetExport(Handle,                              "glfwSetWindowIcon");
        public static unsafe delegate*<GLFWwindow, ref int, ref int, void>                               GetWindowPos;                  //= (delegate*<GLFWwindow, ref int, ref int, void>)NativeLibrary.GetExport(Handle,                               "glfwGetWindowPos");
        public static unsafe delegate*<GLFWwindow, int, int, void>                                       SetWindowPos;                  //= (delegate*<GLFWwindow, int, int, void>)NativeLibrary.GetExport(Handle,                                       "glfwSetWindowPos");
        public static unsafe delegate*<GLFWwindow, ref int, ref int, void>                               GetWindowSize;                 //= (delegate*<GLFWwindow, ref int, ref int, void>)NativeLibrary.GetExport(Handle,                               "glfwGetWindowSize");
        public static unsafe delegate*<GLFWwindow, int, int, int, int, void>                             SetWindowSizeLimits;           //= (delegate*<GLFWwindow, int, int, int, int, void>)NativeLibrary.GetExport(Handle,                             "glfwSetWindowSizeLimits");
        public static unsafe delegate*<GLFWwindow, int, int, void>                                       SetWindowAspectRatio;          //= (delegate*<GLFWwindow, int, int, void>)NativeLibrary.GetExport(Handle,                                       "glfwSetWindowAspectRatio");
        public static unsafe delegate*<GLFWwindow, int, int, void>                                       SetWindowSize;                 //= (delegate*<GLFWwindow, int, int, void>)NativeLibrary.GetExport(Handle,                                       "glfwSetWindowSize");
        public static unsafe delegate*<GLFWwindow, out int, out int, void>                               GetFramebufferSize;            //= (delegate*<GLFWwindow, ref int, ref int, void>)NativeLibrary.GetExport(Handle,                               "glfwGetFramebufferSize");
        public static unsafe delegate*<GLFWwindow, ref int, ref int, ref int, ref int, void>             GetWindowFrameSize;            //= (delegate*<GLFWwindow, ref int, ref int, ref int, ref int, void>)NativeLibrary.GetExport(Handle,             "glfwGetWindowFrameSize");
        public static unsafe delegate*<GLFWwindow, ref float, ref float, void>                           GetWindowContentScale;         //= (delegate*<GLFWwindow, ref float, ref float, void>)NativeLibrary.GetExport(Handle,                           "glfwGetWindowContentScale");
        public static unsafe delegate*<GLFWwindow, float>                                                GetWindowOpacity;              //= (delegate*<GLFWwindow, float>)NativeLibrary.GetExport(Handle,                                                "glfwGetWindowOpacity");
        public static unsafe delegate*<GLFWwindow, float, void>                                          SetWindowOpacity;              //= (delegate*<GLFWwindow, float, void>)NativeLibrary.GetExport(Handle,                                          "glfwSetWindowOpacity");
        public static unsafe delegate*<GLFWwindow, void>                                                 IconifyWindow;                 //= (delegate*<GLFWwindow, void>)NativeLibrary.GetExport(Handle,                                                 "glfwIconifyWindow");
        public static unsafe delegate*<GLFWwindow, void>                                                 RestoreWindow;                 //= (delegate*<GLFWwindow, void>)NativeLibrary.GetExport(Handle,                                                 "glfwRestoreWindow");
        public static unsafe delegate*<GLFWwindow, void>                                                 MaximizeWindow;                //= (delegate*<GLFWwindow, void>)NativeLibrary.GetExport(Handle,                                                 "glfwMaximizeWindow");
        public static unsafe delegate*<GLFWwindow, void>                                                 ShowWindow;                    //= (delegate*<GLFWwindow, void>)NativeLibrary.GetExport(Handle,                                                 "glfwShowWindow");
        public static unsafe delegate*<GLFWwindow, void>                                                 HideWindow;                    //= (delegate*<GLFWwindow, void>)NativeLibrary.GetExport(Handle,                                                 "glfwHideWindow");
        public static unsafe delegate*<GLFWwindow, void>                                                 FocusWindow;                   //= (delegate*<GLFWwindow, void>)NativeLibrary.GetExport(Handle,                                                 "glfwFocusWindow");
        public static unsafe delegate*<GLFWwindow, void>                                                 RequestWindowAttention;        //= (delegate*<GLFWwindow, void>)NativeLibrary.GetExport(Handle,                                                 "glfwRequestWindowAttention");
        public static unsafe delegate*<GLFWwindow, GLFWmonitor>                                          GetWindowMonitor;              //= (delegate*<GLFWwindow, GLFWmonitor>)NativeLibrary.GetExport(Handle,                                          "glfwGetWindowMonitor");
        public static unsafe delegate*<GLFWwindow, GLFWmonitor, int, int, int, int, int, void>           SetWindowMonitor;              //= (delegate*<GLFWwindow, GLFWmonitor, int, int, int, int, int, void>)NativeLibrary.GetExport(Handle,           "glfwSetWindowMonitor");
        public static unsafe delegate*<GLFWwindow, int, int>                                             GetWindowAttrib;               //= (delegate*<GLFWwindow, int, int>)NativeLibrary.GetExport(Handle,                                             "glfwGetWindowAttrib");
        public static unsafe delegate*<GLFWwindow, int, int, void>                                       SetWindowAttrib;               //= (delegate*<GLFWwindow, int, int, void>)NativeLibrary.GetExport(Handle,                                       "glfwSetWindowAttrib");
        public static unsafe delegate*<GLFWwindow, nint, void>                                           SetWindowUserPointer;          //= (delegate*<GLFWwindow, nint, void>)NativeLibrary.GetExport(Handle,                                           "glfwSetWindowUserPointer");
        public static unsafe delegate*<GLFWwindow, nint>                                                 GetWindowUserPointer;          //= (delegate*<GLFWwindow, nint>)NativeLibrary.GetExport(Handle,                                                 "glfwGetWindowUserPointer");
        public static unsafe delegate*<GLFWwindow, GLFWwindowposfun, GLFWwindowposfun>                   SetWindowPosCallback;          //= (delegate*<GLFWwindow, GLFWwindowposfun, GLFWwindowposfun>)NativeLibrary.GetExport(Handle,                   "glfwSetWindowPosCallback");
        public static unsafe delegate*<GLFWwindow, GLFWwindowsizefun, GLFWwindowsizefun>                 SetWindowSizeCallback;         //= (delegate*<GLFWwindow, GLFWwindowsizefun, GLFWwindowsizefun>)NativeLibrary.GetExport(Handle,                 "glfwSetWindowSizeCallback");
        public static unsafe delegate*<GLFWwindow, GLFWwindowclosefun, GLFWwindowclosefun>               SetWindowCloseCallback;        //= (delegate*<GLFWwindow, GLFWwindowclosefun, GLFWwindowclosefun>)NativeLibrary.GetExport(Handle,               "glfwSetWindowCloseCallback");
        public static unsafe delegate*<GLFWwindow, GLFWwindowrefreshfun, GLFWwindowrefreshfun>           SetWindowRefreshCallback;      //= (delegate*<GLFWwindow, GLFWwindowrefreshfun, GLFWwindowrefreshfun>)NativeLibrary.GetExport(Handle,           "glfwSetWindowRefreshCallback");
        public static unsafe delegate*<GLFWwindow, GLFWwindowfocusfun, GLFWwindowfocusfun>               SetWindowFocusCallback;        //= (delegate*<GLFWwindow, GLFWwindowfocusfun, GLFWwindowfocusfun>)NativeLibrary.GetExport(Handle,               "glfwSetWindowFocusCallback");
        public static unsafe delegate*<GLFWwindow, GLFWwindowiconifyfun, GLFWwindowiconifyfun>           SetWindowIconifyCallback;      //= (delegate*<GLFWwindow, GLFWwindowiconifyfun, GLFWwindowiconifyfun>)NativeLibrary.GetExport(Handle,           "glfwSetWindowIconifyCallback");
        public static unsafe delegate*<GLFWwindow, GLFWwindowmaximizefun, GLFWwindowmaximizefun>         SetWindowMaximizeCallback;     //= (delegate*<GLFWwindow, GLFWwindowmaximizefun, GLFWwindowmaximizefun>)NativeLibrary.GetExport(Handle,         "glfwSetWindowMaximizeCallback");
        public static unsafe delegate*<GLFWwindow, GLFWframebuffersizefun, GLFWframebuffersizefun>       SetFramebufferSizeCallback;    //= (delegate*<GLFWwindow, GLFWframebuffersizefun, GLFWframebuffersizefun>)NativeLibrary.GetExport(Handle,       "glfwSetFramebufferSizeCallback");
        public static unsafe delegate*<GLFWwindow, GLFWwindowcontentscalefun, GLFWwindowcontentscalefun> SetWindowContentScaleCallback; //= (delegate*<GLFWwindow, GLFWwindowcontentscalefun, GLFWwindowcontentscalefun>)NativeLibrary.GetExport(Handle, "glfwSetWindowContentScaleCallback");
        public static unsafe delegate*<void>                                                             PollEvents;                    //= (delegate*<void>)NativeLibrary.GetExport(Handle,                                                             "glfwPollEvents");
        public static unsafe delegate*<void>                                                             WaitEvents;                    //= (delegate*<void>)NativeLibrary.GetExport(Handle,                                                             "glfwWaitEvents");
        public static unsafe delegate*<double, void>                                                     WaitEventsTimeout;             //= (delegate*<double, void>)NativeLibrary.GetExport(Handle,                                                     "glfwWaitEventsTimeout");
        public static unsafe delegate*<void>                                                             PostEmptyEvent;                //= (delegate*<void>)NativeLibrary.GetExport(Handle,                                                             "glfwPostEmptyEvent");
        public static unsafe delegate*<GLFWwindow, int, int>                                             GetInputMode;                  //= (delegate*<GLFWwindow, int, int>)NativeLibrary.GetExport(Handle,                                             "glfwGetInputMode");
        public static unsafe delegate*<GLFWwindow, int, int, void>                                       SetInputMode;                  //= (delegate*<GLFWwindow, int, int, void>)NativeLibrary.GetExport(Handle,                                       "glfwSetInputMode");
        public static unsafe delegate*<int>                                                              RawMouseMotionSupported;       //= (delegate*<int>)NativeLibrary.GetExport(Handle,                                                              "glfwRawMouseMotionSupported");
        public static unsafe delegate*<int, int, nint>                                                   GetKeyName;                    //= (delegate*<int, int, nint>)NativeLibrary.GetExport(Handle,                                                   "glfwGetKeyName");
        public static unsafe delegate*<int, int>                                                         GetKeyScancode;                //= (delegate*<int, int>)NativeLibrary.GetExport(Handle,                                                         "glfwGetKeyScancode");
        public static unsafe delegate*<GLFWwindow, int, int>                                             GetKey;                        //= (delegate*<GLFWwindow, int, int>)NativeLibrary.GetExport(Handle,                                             "glfwGetKey");
        public static unsafe delegate*<GLFWwindow, int, int>                                             GetMouseButton;                //= (delegate*<GLFWwindow, int, int>)NativeLibrary.GetExport(Handle,                                             "glfwGetMouseButton");
        public static unsafe delegate*<GLFWwindow, ref double, ref double, void>                         GetCursorPos;                  //= (delegate*<GLFWwindow, ref double, ref double, void>)NativeLibrary.GetExport(Handle,                         "glfwGetCursorPos");
        public static unsafe delegate*<GLFWwindow, double, double, void>                                 SetCursorPos;                  //= (delegate*<GLFWwindow, double, double, void>)NativeLibrary.GetExport(Handle,                                 "glfwSetCursorPos");
        public static unsafe delegate*<in GLFWimage, int, int, GLFWcursor>                               CreateCursor;                  //= (delegate*<in GLFWimage, int, int, GLFWcursor>)NativeLibrary.GetExport(Handle,                               "glfwCreateCursor");
        public static unsafe delegate*<int, GLFWcursor>                                                  CreateStandardCursor;          //= (delegate*<int, GLFWcursor>)NativeLibrary.GetExport(Handle,                                                  "glfwCreateStandardCursor");
        public static unsafe delegate*<GLFWcursor, void>                                                 DestroyCursor;                 //= (delegate*<GLFWcursor, void>)NativeLibrary.GetExport(Handle,                                                 "glfwDestroyCursor");
        public static unsafe delegate*<GLFWwindow, GLFWcursor, void>                                     SetCursor;                     //= (delegate*<GLFWwindow, GLFWcursor, void>)NativeLibrary.GetExport(Handle,                                     "glfwSetCursor");
        public static unsafe delegate*<GLFWwindow, GLFWkeyfun, GLFWkeyfun>                               SetKeyCallback;                //= (delegate*<GLFWwindow, GLFWkeyfun, GLFWkeyfun>)NativeLibrary.GetExport(Handle,                               "glfwSetKeyCallback");
        public static unsafe delegate*<GLFWwindow, GLFWcharfun, GLFWcharfun>                             SetCharCallback;               //= (delegate*<GLFWwindow, GLFWcharfun, GLFWcharfun>)NativeLibrary.GetExport(Handle,                             "glfwSetCharCallback");
        public static unsafe delegate*<GLFWwindow, GLFWcharmodsfun, GLFWcharmodsfun>                     SetCharModsCallback;           //= (delegate*<GLFWwindow, GLFWcharmodsfun, GLFWcharmodsfun>)NativeLibrary.GetExport(Handle,                     "glfwSetCharModsCallback");
        public static unsafe delegate*<GLFWwindow, GLFWmousebuttonfun, GLFWmousebuttonfun>               SetMouseButtonCallback;        //= (delegate*<GLFWwindow, GLFWmousebuttonfun, GLFWmousebuttonfun>)NativeLibrary.GetExport(Handle,               "glfwSetMouseButtonCallback");
        public static unsafe delegate*<GLFWwindow, GLFWcursorposfun, GLFWcursorposfun>                   SetCursorPosCallback;          //= (delegate*<GLFWwindow, GLFWcursorposfun, GLFWcursorposfun>)NativeLibrary.GetExport(Handle,                   "glfwSetCursorPosCallback");
        public static unsafe delegate*<GLFWwindow, GLFWcursorenterfun, GLFWcursorenterfun>               SetCursorEnterCallback;        //= (delegate*<GLFWwindow, GLFWcursorenterfun, GLFWcursorenterfun>)NativeLibrary.GetExport(Handle,               "glfwSetCursorEnterCallback");
        public static unsafe delegate*<GLFWwindow, GLFWscrollfun, GLFWscrollfun>                         SetScrollCallback;             //= (delegate*<GLFWwindow, GLFWscrollfun, GLFWscrollfun>)NativeLibrary.GetExport(Handle,                         "glfwSetScrollCallback");
        public static unsafe delegate*<GLFWwindow, GLFWdropfun, GLFWdropfun>                             SetDropCallback;               //= (delegate*<GLFWwindow, GLFWdropfun, GLFWdropfun>)NativeLibrary.GetExport(Handle,                             "glfwSetDropCallback");
        public static unsafe delegate*<int, int>                                                         JoystickPresent;               //= (delegate*<int, int>)NativeLibrary.GetExport(Handle,                                                         "glfwJoystickPresent");
        public static unsafe delegate*<int, ref int, nint>                                               GetJoystickButtons;            //= (delegate*<int, ref int, nint>)NativeLibrary.GetExport(Handle,                                               "glfwGetJoystickButtons");
        public static unsafe delegate*<int, ref int, nint>                                               GetJoystickHats;               //= (delegate*<int, ref int, nint>)NativeLibrary.GetExport(Handle,                                               "glfwGetJoystickHats");
        public static unsafe delegate*<int, nint>                                                        GetJoystickName;               //= (delegate*<int, nint>)NativeLibrary.GetExport(Handle,                                                        "glfwGetJoystickName");
        public static unsafe delegate*<int, nint>                                                        GetJoystickGUID;               //= (delegate*<int, nint>)NativeLibrary.GetExport(Handle,                                                        "glfwGetJoystickGUID");
        public static unsafe delegate*<int, nint, void>                                                  SetJoystickUserPointer;        //= (delegate*<int, nint, void>)NativeLibrary.GetExport(Handle,                                                  "glfwSetJoystickUserPointer");
        public static unsafe delegate*<int, nint>                                                        GetJoystickUserPointer;        //= (delegate*<int, nint>)NativeLibrary.GetExport(Handle,                                                        "glfwGetJoystickUserPointer");
        public static unsafe delegate*<int, int>                                                         JoystickIsGamepad;             //= (delegate*<int, int>)NativeLibrary.GetExport(Handle,                                                         "glfwJoystickIsGamepad");
        public static unsafe delegate*<GLFWjoystickfun, GLFWjoystickfun>                                 SetJoystickCallback;           //= (delegate*<GLFWjoystickfun, GLFWjoystickfun>)NativeLibrary.GetExport(Handle,                                 "glfwSetJoystickCallback");
        public static unsafe delegate*<nint, int>                                                        UpdateGamepadMappings;         //= (delegate*<nint, int>)NativeLibrary.GetExport(Handle,                                                        "glfwUpdateGamepadMappings");
        public static unsafe delegate*<int, nint>                                                        GetGamepadName;                //= (delegate*<int, nint>)NativeLibrary.GetExport(Handle,                                                        "glfwGetGamepadName");
        public static unsafe delegate*<int, ref GLFWgamepadstate, int>                                   GetGamepadState;               //= (delegate*<int, ref GLFWgamepadstate, int>)NativeLibrary.GetExport(Handle,                                   "glfwGetGamepadState");
        public static unsafe delegate*<GLFWwindow, nint, void>                                           SetClipboardString;            //= (delegate*<GLFWwindow, nint, void>)NativeLibrary.GetExport(Handle,                                           "glfwSetClipboardString");
        public static unsafe delegate*<GLFWwindow, nint>                                                 GetClipboardString;            //= (delegate*<GLFWwindow, nint>)NativeLibrary.GetExport(Handle,                                                 "glfwGetClipboardString");
        public static unsafe delegate*<double>                                                           GetTime;                       //= (delegate*<double>)NativeLibrary.GetExport(Handle,                                                           "glfwGetTime");
        public static unsafe delegate*<double, void>                                                     SetTime;                       //= (delegate*<double, void>)NativeLibrary.GetExport(Handle,                                                     "glfwSetTime");
        public static unsafe delegate*<ulong>                                                            GetTimerValue;                 //= (delegate*<ulong>)NativeLibrary.GetExport(Handle,                                                            "glfwGetTimerValue");
        public static unsafe delegate*<ulong>                                                            GetTimerFrequency;             //= (delegate*<ulong>)NativeLibrary.GetExport(Handle,                                                            "glfwGetTimerFrequency");
        public static unsafe delegate*<GLFWwindow, void>                                                 MakeContextCurrent;            //= (delegate*<GLFWwindow, void>)NativeLibrary.GetExport(Handle,                                                 "glfwMakeContextCurrent");
        public static unsafe delegate*<GLFWwindow>                                                       GetCurrentContext;             //= (delegate*<GLFWwindow>)NativeLibrary.GetExport(Handle,                                                       "glfwGetCurrentContext");
        public static unsafe delegate*<GLFWwindow, void>                                                 SwapBuffers;                   //= (delegate*<GLFWwindow, void>)NativeLibrary.GetExport(Handle,                                                 "glfwSwapBuffers");
        public static unsafe delegate*<int, void>                                                        SwapInterval;                  //= (delegate*<int, void>)NativeLibrary.GetExport(Handle,                                                        "glfwSwapInterval");
        public static unsafe delegate*<nint, int>                                                        ExtensionSupported;            //= (delegate*<nint, int>)NativeLibrary.GetExport(Handle,                                                        "glfwExtensionSupported");
        public static unsafe delegate*<nint, GLFWglproc>                                                 GetProcAddress;                //= (delegate*<nint, GLFWglproc>)NativeLibrary.GetExport(Handle,                                                 "glfwGetProcAddress");
        public static unsafe delegate*<int>                                                              VulkanSupported;               //= (delegate*<int>)NativeLibrary.GetExport(Handle,                                                              "glfwVulkanSupported");
        public static unsafe delegate*<out uint, utf8string*>                                            GetRequiredInstanceExtensions; //= (delegate*<ref uint, nint>)NativeLibrary.GetExport(Handle,                                                   "glfwGetRequiredInstanceExtensions");
        public static unsafe delegate*<GLFWmonitor, nint>                                                GetWin32Adapter;               //= (delegate*<GLFWmonitor, nint>)NativeLibrary.GetExport(Handle,                                                "glfwGetWin32Adapter");
        public static unsafe delegate*<GLFWmonitor, nint>                                                GetWin32Monitor;               //= (delegate*<GLFWmonitor, nint>)NativeLibrary.GetExport(Handle,                                                "glfwGetWin32Monitor");
        public static unsafe delegate*<GLFWwindow, nint>                                                 GetWin32Window;                //= (delegate*<GLFWwindow, nint>)NativeLibrary.GetExport(Handle,                                                 "glfwGetWin32Window");
        public static unsafe delegate*<GLFWwindow, nint>                                                 GetWGLContext;                 //= (delegate*<GLFWwindow, nint>)NativeLibrary.GetExport(Handle,                                                 "glfwGetWGLContext");
        
    }
}
