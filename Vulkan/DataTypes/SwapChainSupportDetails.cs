using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Vulkan
{
    public sealed class SwapChainSupportDetails
    {
        private VkSurfaceCapabilitiesKHR _surfaceCapabilities;
        private VkSurfaceFormatKHR _surfaceFormat;
        private VkPresentModeKHR _presentMode;

        public ref VkSurfaceCapabilitiesKHR SurfaceCapabilities
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return ref _surfaceCapabilities;
            }
        }

        public ref VkSurfaceFormatKHR SurfaceFormat
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return ref _surfaceFormat;
            }
        }

        public ref VkPresentModeKHR PresentMode
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return ref _presentMode;
            }
        }

        public SwapChainSupportDetails()
        {
        }

        public SwapChainSupportDetails(VkSurfaceCapabilitiesKHR surfaceCapabilities, VkSurfaceFormatKHR surfaceFormat, VkPresentModeKHR presentMode)
        {
            _surfaceCapabilities = surfaceCapabilities;
            _surfaceFormat = surfaceFormat;
            _presentMode = presentMode;
        }
    }
}
