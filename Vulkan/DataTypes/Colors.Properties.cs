using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace Vulkan
{
    public static partial class Colors
    {
        
        public static ref readonly Color4 IndianRed
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _indian_red; }
        }

        public static ref readonly Color4 Crimson
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _crimson; }
        }

        public static ref readonly Color4 Lightpink
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _lightpink; }
        }

        public static ref readonly Color4 Lightpink1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _lightpink_1; }
        }

        public static ref readonly Color4 Lightpink2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _lightpink_2; }
        }

        public static ref readonly Color4 Lightpink3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _lightpink_3; }
        }

        public static ref readonly Color4 Lightpink4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _lightpink_4; }
        }

        public static ref readonly Color4 Pink
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _pink; }
        }

        public static ref readonly Color4 Pink1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _pink_1; }
        }

        public static ref readonly Color4 Pink2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _pink_2; }
        }

        public static ref readonly Color4 Pink3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _pink_3; }
        }

        public static ref readonly Color4 Pink4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _pink_4; }
        }

        public static ref readonly Color4 Palevioletred
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _palevioletred; }
        }

        public static ref readonly Color4 Palevioletred1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _palevioletred_1; }
        }

        public static ref readonly Color4 Palevioletred2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _palevioletred_2; }
        }

        public static ref readonly Color4 Palevioletred3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _palevioletred_3; }
        }

        public static ref readonly Color4 Palevioletred4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _palevioletred_4; }
        }

        public static ref readonly Color4 Lavenderblush1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _lavenderblush; }
        }

        public static ref readonly Color4 Lavenderblush2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _lavenderblush_2; }
        }

        public static ref readonly Color4 Lavenderblush3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _lavenderblush_3; }
        }

        public static ref readonly Color4 Lavenderblush4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _lavenderblush_4; }
        }

        public static ref readonly Color4 Violetred1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _violetred_1; }
        }

        public static ref readonly Color4 Violetred2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _violetred_2; }
        }

        public static ref readonly Color4 Violetred3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _violetred_3; }
        }

        public static ref readonly Color4 Violetred4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _violetred_4; }
        }

        public static ref readonly Color4 Hotpink
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _hotpink; }
        }

        public static ref readonly Color4 Hotpink1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _hotpink_1; }
        }

        public static ref readonly Color4 Hotpink2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _hotpink_2; }
        }

        public static ref readonly Color4 Hotpink3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _hotpink_3; }
        }

        public static ref readonly Color4 Hotpink4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _hotpink_4; }
        }

        public static ref readonly Color4 Raspberry
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _raspberry; }
        }

        public static ref readonly Color4 Deeppink1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _deeppink; }
        }

        public static ref readonly Color4 Deeppink2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _deeppink_2; }
        }

        public static ref readonly Color4 Deeppink3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _deeppink_3; }
        }

        public static ref readonly Color4 Deeppink4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _deeppink_4; }
        }

        public static ref readonly Color4 Maroon1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _maroon_1; }
        }

        public static ref readonly Color4 Maroon2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _maroon_2; }
        }

        public static ref readonly Color4 Maroon3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _maroon_3; }
        }

        public static ref readonly Color4 Maroon4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _maroon_4; }
        }

        public static ref readonly Color4 Mediumvioletred
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _mediumvioletred; }
        }

        public static ref readonly Color4 Violetred
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _violetred; }
        }

        public static ref readonly Color4 Orchid
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _orchid; }
        }

        public static ref readonly Color4 Orchid1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _orchid_1; }
        }

        public static ref readonly Color4 Orchid2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _orchid_2; }
        }

        public static ref readonly Color4 Orchid3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _orchid_3; }
        }

        public static ref readonly Color4 Orchid4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _orchid_4; }
        }

        public static ref readonly Color4 Thistle
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _thistle; }
        }

        public static ref readonly Color4 Thistle1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _thistle_1; }
        }

        public static ref readonly Color4 Thistle2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _thistle_2; }
        }

        public static ref readonly Color4 Thistle3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _thistle_3; }
        }

        public static ref readonly Color4 Thistle4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _thistle_4; }
        }

        public static ref readonly Color4 Plum1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _plum_1; }
        }

        public static ref readonly Color4 Plum2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _plum_2; }
        }

        public static ref readonly Color4 Plum3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _plum_3; }
        }

        public static ref readonly Color4 Plum4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _plum_4; }
        }

        public static ref readonly Color4 Plum
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _plum; }
        }

        public static ref readonly Color4 Violet
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _violet; }
        }

        public static ref readonly Color4 Magenta
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _fuchsia; }
        }

        public static ref readonly Color4 Magenta2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _magenta_2; }
        }

        public static ref readonly Color4 Magenta3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _magenta_3; }
        }

        public static ref readonly Color4 Magenta4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _darkmagenta; }
        }

        public static ref readonly Color4 Purple
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _purple; }
        }

        public static ref readonly Color4 Mediumorchid
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _mediumorchid; }
        }

        public static ref readonly Color4 Mediumorchid1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _mediumorchid_1; }
        }

        public static ref readonly Color4 Mediumorchid2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _mediumorchid_2; }
        }

        public static ref readonly Color4 Mediumorchid3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _mediumorchid_3; }
        }

        public static ref readonly Color4 Mediumorchid4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _mediumorchid_4; }
        }

        public static ref readonly Color4 Darkviolet
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _darkviolet; }
        }

        public static ref readonly Color4 Darkorchid
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _darkorchid; }
        }

        public static ref readonly Color4 Darkorchid1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _darkorchid_1; }
        }

        public static ref readonly Color4 Darkorchid2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _darkorchid_2; }
        }

        public static ref readonly Color4 Darkorchid3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _darkorchid_3; }
        }

        public static ref readonly Color4 Darkorchid4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _darkorchid_4; }
        }

        public static ref readonly Color4 Indigo
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _indigo; }
        }

        public static ref readonly Color4 Blueviolet
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _blueviolet; }
        }

        public static ref readonly Color4 Purple1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _purple_1; }
        }

        public static ref readonly Color4 Purple2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _purple_2; }
        }

        public static ref readonly Color4 Purple3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _purple_3; }
        }

        public static ref readonly Color4 Purple4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _purple_4; }
        }

        public static ref readonly Color4 Mediumpurple
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _mediumpurple; }
        }

        public static ref readonly Color4 Mediumpurple1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _mediumpurple_1; }
        }

        public static ref readonly Color4 Mediumpurple2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _mediumpurple_2; }
        }

        public static ref readonly Color4 Mediumpurple3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _mediumpurple_3; }
        }

        public static ref readonly Color4 Mediumpurple4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _mediumpurple_4; }
        }

        public static ref readonly Color4 Darkslateblue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _darkslateblue; }
        }

        public static ref readonly Color4 Lightslateblue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _lightslateblue; }
        }

        public static ref readonly Color4 Mediumslateblue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _mediumslateblue; }
        }

        public static ref readonly Color4 Slateblue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _slateblue; }
        }

        public static ref readonly Color4 Slateblue1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _slateblue_1; }
        }

        public static ref readonly Color4 Slateblue2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _slateblue_2; }
        }

        public static ref readonly Color4 Slateblue3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _slateblue_3; }
        }

        public static ref readonly Color4 Slateblue4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _slateblue_4; }
        }

        public static ref readonly Color4 Ghostwhite
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _ghostwhite; }
        }

        public static ref readonly Color4 Lavender
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _lavender; }
        }

        public static ref readonly Color4 Blue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _blue; }
        }

        public static ref readonly Color4 Blue2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _blue_2; }
        }

        public static ref readonly Color4 Blue3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _mediumblue; }
        }

        public static ref readonly Color4 Blue4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _darkblue; }
        }

        public static ref readonly Color4 Navy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _navy; }
        }

        public static ref readonly Color4 Midnightblue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _midnightblue; }
        }

        public static ref readonly Color4 Cobalt
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _cobalt; }
        }

        public static ref readonly Color4 Royalblue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _royalblue; }
        }

        public static ref readonly Color4 Royalblue1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _royalblue_1; }
        }

        public static ref readonly Color4 Royalblue2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _royalblue_2; }
        }

        public static ref readonly Color4 Royalblue3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _royalblue_3; }
        }

        public static ref readonly Color4 Royalblue4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _royalblue_4; }
        }

        public static ref readonly Color4 Cornflowerblue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _cornflowerblue; }
        }

        public static ref readonly Color4 Lightsteelblue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _lightsteelblue; }
        }

        public static ref readonly Color4 Lightsteelblue1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _lightsteelblue_1; }
        }

        public static ref readonly Color4 Lightsteelblue2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _lightsteelblue_2; }
        }

        public static ref readonly Color4 Lightsteelblue3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _lightsteelblue_3; }
        }

        public static ref readonly Color4 Lightsteelblue4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _lightsteelblue_4; }
        }

        public static ref readonly Color4 Lightslategray
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _lightslategray; }
        }

        public static ref readonly Color4 Slategray
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _slategray; }
        }

        public static ref readonly Color4 Slategray1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _slategray_1; }
        }

        public static ref readonly Color4 Slategray2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _slategray_2; }
        }

        public static ref readonly Color4 Slategray3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _slategray_3; }
        }

        public static ref readonly Color4 Slategray4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _slategray_4; }
        }

        public static ref readonly Color4 Dodgerblue1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _dodgerblue; }
        }

        public static ref readonly Color4 Dodgerblue2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _dodgerblue_2; }
        }

        public static ref readonly Color4 Dodgerblue3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _dodgerblue_3; }
        }

        public static ref readonly Color4 Dodgerblue4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _dodgerblue_4; }
        }

        public static ref readonly Color4 Aliceblue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _aliceblue; }
        }

        public static ref readonly Color4 Steelblue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _steelblue; }
        }

        public static ref readonly Color4 Steelblue1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _steelblue_1; }
        }

        public static ref readonly Color4 Steelblue2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _steelblue_2; }
        }

        public static ref readonly Color4 Steelblue3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _steelblue_3; }
        }

        public static ref readonly Color4 Steelblue4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _steelblue_4; }
        }

        public static ref readonly Color4 Lightskyblue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _lightskyblue; }
        }

        public static ref readonly Color4 Lightskyblue1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _lightskyblue_1; }
        }

        public static ref readonly Color4 Lightskyblue2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _lightskyblue_2; }
        }

        public static ref readonly Color4 Lightskyblue3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _lightskyblue_3; }
        }

        public static ref readonly Color4 Lightskyblue4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _lightskyblue_4; }
        }

        public static ref readonly Color4 Skyblue1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _skyblue_1; }
        }

        public static ref readonly Color4 Skyblue2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _skyblue_2; }
        }

        public static ref readonly Color4 Skyblue3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _skyblue_3; }
        }

        public static ref readonly Color4 Skyblue4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _skyblue_4; }
        }

        public static ref readonly Color4 Skyblue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _skyblue; }
        }

        public static ref readonly Color4 Deepskyblue1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _deepskyblue; }
        }

        public static ref readonly Color4 Deepskyblue2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _deepskyblue_2; }
        }

        public static ref readonly Color4 Deepskyblue3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _deepskyblue_3; }
        }

        public static ref readonly Color4 Deepskyblue4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _deepskyblue_4; }
        }

        public static ref readonly Color4 Peacock
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _peacock; }
        }

        public static ref readonly Color4 Lightblue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _lightblue; }
        }

        public static ref readonly Color4 Lightblue1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _lightblue_1; }
        }

        public static ref readonly Color4 Lightblue2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _lightblue_2; }
        }

        public static ref readonly Color4 Lightblue3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _lightblue_3; }
        }

        public static ref readonly Color4 Lightblue4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _lightblue_4; }
        }

        public static ref readonly Color4 Powderblue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _powderblue; }
        }

        public static ref readonly Color4 Cadetblue1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _cadetblue_1; }
        }

        public static ref readonly Color4 Cadetblue2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _cadetblue_2; }
        }

        public static ref readonly Color4 Cadetblue3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _cadetblue_3; }
        }

        public static ref readonly Color4 Cadetblue4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _cadetblue_4; }
        }

        public static ref readonly Color4 Turquoise1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _turquoise_1; }
        }

        public static ref readonly Color4 Turquoise2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _turquoise_2; }
        }

        public static ref readonly Color4 Turquoise3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _turquoise_3; }
        }

        public static ref readonly Color4 Turquoise4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _turquoise_4; }
        }

        public static ref readonly Color4 Cadetblue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _cadetblue; }
        }

        public static ref readonly Color4 Darkturquoise
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _darkturquoise; }
        }

        public static ref readonly Color4 Azure1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _azure; }
        }

        public static ref readonly Color4 Azure2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _azure_2; }
        }

        public static ref readonly Color4 Azure3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _azure_3; }
        }

        public static ref readonly Color4 Azure4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _azure_4; }
        }

        public static ref readonly Color4 Lightcyan1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _lightcyan; }
        }

        public static ref readonly Color4 Lightcyan2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _lightcyan_2; }
        }

        public static ref readonly Color4 Lightcyan3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _lightcyan_3; }
        }

        public static ref readonly Color4 Lightcyan4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _lightcyan_4; }
        }

        public static ref readonly Color4 Paleturquoise1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _paleturquoise_1; }
        }

        public static ref readonly Color4 Paleturquoise2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _paleturquoise_2; }
        }

        public static ref readonly Color4 Paleturquoise3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _paleturquoise_3; }
        }

        public static ref readonly Color4 Paleturquoise4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _paleturquoise_4; }
        }

        public static ref readonly Color4 Darkslategray
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _darkslategray; }
        }

        public static ref readonly Color4 Darkslategray1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _darkslategray_1; }
        }

        public static ref readonly Color4 Darkslategray2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _darkslategray_2; }
        }

        public static ref readonly Color4 Darkslategray3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _darkslategray_3; }
        }

        public static ref readonly Color4 Darkslategray4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _darkslategray_4; }
        }

        public static ref readonly Color4 Aqua
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _aqua; }
        }

        public static ref readonly Color4 Cyan2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _cyan_2; }
        }

        public static ref readonly Color4 Cyan3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _cyan_3; }
        }

        public static ref readonly Color4 Cyan4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _darkcyan; }
        }

        public static ref readonly Color4 Teal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _teal; }
        }

        public static ref readonly Color4 Mediumturquoise
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _mediumturquoise; }
        }

        public static ref readonly Color4 Lightseagreen
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _lightseagreen; }
        }

        public static ref readonly Color4 Manganeseblue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _manganeseblue; }
        }

        public static ref readonly Color4 Turquoise
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _turquoise; }
        }

        public static ref readonly Color4 Coldgrey
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _coldgrey; }
        }

        public static ref readonly Color4 Turquoiseblue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _turquoiseblue; }
        }

        public static ref readonly Color4 Aquamarine
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _aquamarine; }
        }

        public static ref readonly Color4 Aquamarine2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _aquamarine_2; }
        }

        public static ref readonly Color4 Aquamarine3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _aquamarine_3; }
        }

        public static ref readonly Color4 Aquamarine4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _aquamarine_4; }
        }

        public static ref readonly Color4 Mediumspringgreen
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _mediumspringgreen; }
        }

        public static ref readonly Color4 Mintcream
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _mintcream; }
        }

        public static ref readonly Color4 Springgreen
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _springgreen; }
        }

        public static ref readonly Color4 Springgreen1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _springgreen_1; }
        }

        public static ref readonly Color4 Springgreen2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _springgreen_2; }
        }

        public static ref readonly Color4 Springgreen3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _springgreen_3; }
        }

        public static ref readonly Color4 Mediumseagreen
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _mediumseagreen; }
        }

        public static ref readonly Color4 Seagreen1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _seagreen_1; }
        }

        public static ref readonly Color4 Seagreen2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _seagreen_2; }
        }

        public static ref readonly Color4 Seagreen3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _seagreen_3; }
        }

        public static ref readonly Color4 Seagreen4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _seagreen_4; }
        }

        public static ref readonly Color4 Emeraldgreen
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _emeraldgreen; }
        }

        public static ref readonly Color4 Mint
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _mint; }
        }

        public static ref readonly Color4 Cobaltgreen
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _cobaltgreen; }
        }

        public static ref readonly Color4 Honeydew1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _honeydew_1; }
        }

        public static ref readonly Color4 Honeydew2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _honeydew_2; }
        }

        public static ref readonly Color4 Honeydew3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _honeydew_3; }
        }

        public static ref readonly Color4 Honeydew4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _honeydew_4; }
        }

        public static ref readonly Color4 Darkseagreen
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _darkseagreen; }
        }

        public static ref readonly Color4 Darkseagreen1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _darkseagreen_1; }
        }

        public static ref readonly Color4 Darkseagreen2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _darkseagreen_2; }
        }

        public static ref readonly Color4 Darkseagreen3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _darkseagreen_3; }
        }

        public static ref readonly Color4 Darkseagreen4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _darkseagreen_4; }
        }

        public static ref readonly Color4 Palegreen
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _palegreen; }
        }

        public static ref readonly Color4 Palegreen1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _palegreen_1; }
        }

        public static ref readonly Color4 Palegreen2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _palegreen_2; }
        }

        public static ref readonly Color4 Palegreen3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _palegreen_3; }
        }

        public static ref readonly Color4 Palegreen4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _palegreen_4; }
        }

        public static ref readonly Color4 Limegreen
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _limegreen; }
        }

        public static ref readonly Color4 Forestgreen
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _forestgreen; }
        }

        public static ref readonly Color4 Green
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _green; }
        }

        public static ref readonly Color4 Green1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _green_1; }
        }

        public static ref readonly Color4 Green2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _green_2; }
        }

        public static ref readonly Color4 Green3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _green_3; }
        }

        public static ref readonly Color4 Green4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _green_4; }
        }

        public static ref readonly Color4 Darkgreen
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _darkgreen; }
        }

        public static ref readonly Color4 Sapgreen
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _sapgreen; }
        }

        public static ref readonly Color4 Lawngreen
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _lawngreen; }
        }

        public static ref readonly Color4 Chartreuse1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _chartreuse_1; }
        }

        public static ref readonly Color4 Chartreuse2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _chartreuse_2; }
        }

        public static ref readonly Color4 Chartreuse3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _chartreuse_3; }
        }

        public static ref readonly Color4 Chartreuse4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _chartreuse_4; }
        }

        public static ref readonly Color4 Greenyellow
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _greenyellow; }
        }

        public static ref readonly Color4 Darkolivegreen1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _darkolivegreen_1; }
        }

        public static ref readonly Color4 Darkolivegreen2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _darkolivegreen_2; }
        }

        public static ref readonly Color4 Darkolivegreen3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _darkolivegreen_3; }
        }

        public static ref readonly Color4 Darkolivegreen4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _darkolivegreen_4; }
        }

        public static ref readonly Color4 Darkolivegreen
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _darkolivegreen; }
        }

        public static ref readonly Color4 Olivedrab
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _olivedrab; }
        }

        public static ref readonly Color4 Olivedrab1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _olivedrab_1; }
        }

        public static ref readonly Color4 Olivedrab2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _olivedrab_2; }
        }

        public static ref readonly Color4 Olivedrab3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _olivedrab_3; }
        }

        public static ref readonly Color4 Olivedrab4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _olivedrab_4; }
        }

        public static ref readonly Color4 Ivory1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _ivory_1; }
        }

        public static ref readonly Color4 Ivory2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _ivory_2; }
        }

        public static ref readonly Color4 Ivory3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _ivory_3; }
        }

        public static ref readonly Color4 Ivory4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _ivory_4; }
        }

        public static ref readonly Color4 Beige
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _beige; }
        }

        public static ref readonly Color4 Lightyellow1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _lightyellow_1; }
        }

        public static ref readonly Color4 Lightyellow2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _lightyellow_2; }
        }

        public static ref readonly Color4 Lightyellow3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _lightyellow_3; }
        }

        public static ref readonly Color4 Lightyellow4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _lightyellow_4; }
        }

        public static ref readonly Color4 Lightgoldenrodyellow
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _lightgoldenrodyellow; }
        }

        public static ref readonly Color4 Yellow1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _yellow_1; }
        }

        public static ref readonly Color4 Yellow2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _yellow_2; }
        }

        public static ref readonly Color4 Yellow3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _yellow_3; }
        }

        public static ref readonly Color4 Yellow4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _yellow_4; }
        }

        public static ref readonly Color4 Warmgrey
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _warmgrey; }
        }

        public static ref readonly Color4 Olive
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _olive; }
        }

        public static ref readonly Color4 Darkkhaki
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _darkkhaki; }
        }

        public static ref readonly Color4 Khaki1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _khaki_1; }
        }

        public static ref readonly Color4 Khaki2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _khaki_2; }
        }

        public static ref readonly Color4 Khaki3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _khaki_3; }
        }

        public static ref readonly Color4 Khaki4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _khaki_4; }
        }

        public static ref readonly Color4 Khaki
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _khaki; }
        }

        public static ref readonly Color4 Palegoldenrod
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _palegoldenrod; }
        }

        public static ref readonly Color4 Lemonchiffon1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _lemonchiffon_1; }
        }

        public static ref readonly Color4 Lemonchiffon2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _lemonchiffon_2; }
        }

        public static ref readonly Color4 Lemonchiffon3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _lemonchiffon_3; }
        }

        public static ref readonly Color4 Lemonchiffon4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _lemonchiffon_4; }
        }

        public static ref readonly Color4 Lightgoldenrod1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _lightgoldenrod_1; }
        }

        public static ref readonly Color4 Lightgoldenrod2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _lightgoldenrod_2; }
        }

        public static ref readonly Color4 Lightgoldenrod3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _lightgoldenrod_3; }
        }

        public static ref readonly Color4 Lightgoldenrod4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _lightgoldenrod_4; }
        }

        public static ref readonly Color4 Banana
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _banana; }
        }

        public static ref readonly Color4 Gold1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gold_1; }
        }

        public static ref readonly Color4 Gold2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gold_2; }
        }

        public static ref readonly Color4 Gold3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gold_3; }
        }

        public static ref readonly Color4 Gold4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gold_4; }
        }

        public static ref readonly Color4 Cornsilk1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _cornsilk_1; }
        }

        public static ref readonly Color4 Cornsilk2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _cornsilk_2; }
        }

        public static ref readonly Color4 Cornsilk3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _cornsilk_3; }
        }

        public static ref readonly Color4 Cornsilk4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _cornsilk_4; }
        }

        public static ref readonly Color4 Goldenrod
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _goldenrod; }
        }

        public static ref readonly Color4 Goldenrod1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _goldenrod_1; }
        }

        public static ref readonly Color4 Goldenrod2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _goldenrod_2; }
        }

        public static ref readonly Color4 Goldenrod3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _goldenrod_3; }
        }

        public static ref readonly Color4 Goldenrod4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _goldenrod_4; }
        }

        public static ref readonly Color4 Darkgoldenrod
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _darkgoldenrod; }
        }

        public static ref readonly Color4 Darkgoldenrod1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _darkgoldenrod_1; }
        }

        public static ref readonly Color4 Darkgoldenrod2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _darkgoldenrod_2; }
        }

        public static ref readonly Color4 Darkgoldenrod3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _darkgoldenrod_3; }
        }

        public static ref readonly Color4 Darkgoldenrod4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _darkgoldenrod_4; }
        }

        public static ref readonly Color4 Orange1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _orange_1; }
        }

        public static ref readonly Color4 Orange2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _orange_2; }
        }

        public static ref readonly Color4 Orange3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _orange_3; }
        }

        public static ref readonly Color4 Orange4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _orange_4; }
        }

        public static ref readonly Color4 Floralwhite
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _floralwhite; }
        }

        public static ref readonly Color4 Oldlace
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _oldlace; }
        }

        public static ref readonly Color4 Wheat
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _wheat; }
        }

        public static ref readonly Color4 Wheat1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _wheat_1; }
        }

        public static ref readonly Color4 Wheat2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _wheat_2; }
        }

        public static ref readonly Color4 Wheat3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _wheat_3; }
        }

        public static ref readonly Color4 Wheat4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _wheat_4; }
        }

        public static ref readonly Color4 Moccasin
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _moccasin; }
        }

        public static ref readonly Color4 Papayawhip
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _papayawhip; }
        }

        public static ref readonly Color4 Blanchedalmond
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _blanchedalmond; }
        }

        public static ref readonly Color4 Navajowhite1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _navajowhite_1; }
        }

        public static ref readonly Color4 Navajowhite2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _navajowhite_2; }
        }

        public static ref readonly Color4 Navajowhite3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _navajowhite_3; }
        }

        public static ref readonly Color4 Navajowhite4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _navajowhite_4; }
        }

        public static ref readonly Color4 Eggshell
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _eggshell; }
        }

        public static ref readonly Color4 Tan
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _tan; }
        }

        public static ref readonly Color4 Brick
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _brick; }
        }

        public static ref readonly Color4 Cadmiumyellow
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _cadmiumyellow; }
        }

        public static ref readonly Color4 Antiquewhite
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _antiquewhite; }
        }

        public static ref readonly Color4 Antiquewhite1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _antiquewhite_1; }
        }

        public static ref readonly Color4 Antiquewhite2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _antiquewhite_2; }
        }

        public static ref readonly Color4 Antiquewhite3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _antiquewhite_3; }
        }

        public static ref readonly Color4 Antiquewhite4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _antiquewhite_4; }
        }

        public static ref readonly Color4 Burlywood
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _burlywood; }
        }

        public static ref readonly Color4 Burlywood1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _burlywood_1; }
        }

        public static ref readonly Color4 Burlywood2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _burlywood_2; }
        }

        public static ref readonly Color4 Burlywood3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _burlywood_3; }
        }

        public static ref readonly Color4 Burlywood4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _burlywood_4; }
        }

        public static ref readonly Color4 Bisque1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _bisque_1; }
        }

        public static ref readonly Color4 Bisque2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _bisque_2; }
        }

        public static ref readonly Color4 Bisque3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _bisque_3; }
        }

        public static ref readonly Color4 Bisque4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _bisque_4; }
        }

        public static ref readonly Color4 Melon
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _melon; }
        }

        public static ref readonly Color4 Carrot
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _carrot; }
        }

        public static ref readonly Color4 Darkorange
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _darkorange; }
        }

        public static ref readonly Color4 Darkorange1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _darkorange_1; }
        }

        public static ref readonly Color4 Darkorange2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _darkorange_2; }
        }

        public static ref readonly Color4 Darkorange3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _darkorange_3; }
        }

        public static ref readonly Color4 Darkorange4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _darkorange_4; }
        }

        public static ref readonly Color4 Orange
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _orange; }
        }

        public static ref readonly Color4 Tan1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _tan_1; }
        }

        public static ref readonly Color4 Tan2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _tan_2; }
        }

        public static ref readonly Color4 Tan3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _tan_3; }
        }

        public static ref readonly Color4 Tan4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _tan_4; }
        }

        public static ref readonly Color4 Linen
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _linen; }
        }

        public static ref readonly Color4 Peachpuff1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _peachpuff_1; }
        }

        public static ref readonly Color4 Peachpuff2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _peachpuff_2; }
        }

        public static ref readonly Color4 Peachpuff3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _peachpuff_3; }
        }

        public static ref readonly Color4 Peachpuff4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _peachpuff_4; }
        }

        public static ref readonly Color4 Seashell1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _seashell_1; }
        }

        public static ref readonly Color4 Seashell2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _seashell_2; }
        }

        public static ref readonly Color4 Seashell3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _seashell_3; }
        }

        public static ref readonly Color4 Seashell4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _seashell_4; }
        }

        public static ref readonly Color4 Sandybrown
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _sandybrown; }
        }

        public static ref readonly Color4 Rawsienna
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _rawsienna; }
        }

        public static ref readonly Color4 Chocolate
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _chocolate; }
        }

        public static ref readonly Color4 Chocolate1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _chocolate_1; }
        }

        public static ref readonly Color4 Chocolate2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _chocolate_2; }
        }

        public static ref readonly Color4 Chocolate3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _chocolate_3; }
        }

        public static ref readonly Color4 Chocolate4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _chocolate_4; }
        }

        public static ref readonly Color4 Ivoryblack
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _ivoryblack; }
        }

        public static ref readonly Color4 Flesh
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _flesh; }
        }

        public static ref readonly Color4 Cadmiumorange
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _cadmiumorange; }
        }

        public static ref readonly Color4 Burntsienna
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _burntsienna; }
        }

        public static ref readonly Color4 Sienna
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _sienna; }
        }

        public static ref readonly Color4 Sienna1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _sienna_1; }
        }

        public static ref readonly Color4 Sienna2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _sienna_2; }
        }

        public static ref readonly Color4 Sienna3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _sienna_3; }
        }

        public static ref readonly Color4 Sienna4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _sienna_4; }
        }

        public static ref readonly Color4 Lightsalmon1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _lightsalmon_1; }
        }

        public static ref readonly Color4 Lightsalmon2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _lightsalmon_2; }
        }

        public static ref readonly Color4 Lightsalmon3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _lightsalmon_3; }
        }

        public static ref readonly Color4 Lightsalmon4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _lightsalmon_4; }
        }

        public static ref readonly Color4 Coral
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _coral; }
        }

        public static ref readonly Color4 Orangered1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _orangered_1; }
        }

        public static ref readonly Color4 Orangered2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _orangered_2; }
        }

        public static ref readonly Color4 Orangered3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _orangered_3; }
        }

        public static ref readonly Color4 Orangered4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _orangered_4; }
        }

        public static ref readonly Color4 Sepia
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _sepia; }
        }

        public static ref readonly Color4 Darksalmon
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _darksalmon; }
        }

        public static ref readonly Color4 Salmon1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _salmon_1; }
        }

        public static ref readonly Color4 Salmon2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _salmon_2; }
        }

        public static ref readonly Color4 Salmon3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _salmon_3; }
        }

        public static ref readonly Color4 Salmon4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _salmon_4; }
        }

        public static ref readonly Color4 Coral1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _coral_1; }
        }

        public static ref readonly Color4 Coral2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _coral_2; }
        }

        public static ref readonly Color4 Coral3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _coral_3; }
        }

        public static ref readonly Color4 Coral4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _coral_4; }
        }

        public static ref readonly Color4 Burntumber
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _burntumber; }
        }

        public static ref readonly Color4 Tomato1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _tomato_1; }
        }

        public static ref readonly Color4 Tomato2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _tomato_2; }
        }

        public static ref readonly Color4 Tomato3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _tomato_3; }
        }

        public static ref readonly Color4 Tomato4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _tomato_4; }
        }

        public static ref readonly Color4 Salmon
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _salmon; }
        }

        public static ref readonly Color4 Mistyrose1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _mistyrose_1; }
        }

        public static ref readonly Color4 Mistyrose2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _mistyrose_2; }
        }

        public static ref readonly Color4 Mistyrose3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _mistyrose_3; }
        }

        public static ref readonly Color4 Mistyrose4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _mistyrose_4; }
        }

        public static ref readonly Color4 Snow1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _snow_1; }
        }

        public static ref readonly Color4 Snow2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _snow_2; }
        }

        public static ref readonly Color4 Snow3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _snow_3; }
        }

        public static ref readonly Color4 Snow4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _snow_4; }
        }

        public static ref readonly Color4 Rosybrown
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _rosybrown; }
        }

        public static ref readonly Color4 Rosybrown1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _rosybrown_1; }
        }

        public static ref readonly Color4 Rosybrown2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _rosybrown_2; }
        }

        public static ref readonly Color4 Rosybrown3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _rosybrown_3; }
        }

        public static ref readonly Color4 Rosybrown4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _rosybrown_4; }
        }

        public static ref readonly Color4 Lightcoral
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _lightcoral; }
        }

        public static ref readonly Color4 Indianred
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _indianred; }
        }

        public static ref readonly Color4 Indianred1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _indianred_1; }
        }

        public static ref readonly Color4 Indianred2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _indianred_2; }
        }

        public static ref readonly Color4 Indianred4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _indianred_4; }
        }

        public static ref readonly Color4 Indianred3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _indianred_3; }
        }

        public static ref readonly Color4 Brown
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _brown; }
        }

        public static ref readonly Color4 Brown1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _brown_1; }
        }

        public static ref readonly Color4 Brown2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _brown_2; }
        }

        public static ref readonly Color4 Brown3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _brown_3; }
        }

        public static ref readonly Color4 Brown4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _brown_4; }
        }

        public static ref readonly Color4 Firebrick
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _firebrick; }
        }

        public static ref readonly Color4 Firebrick1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _firebrick_1; }
        }

        public static ref readonly Color4 Firebrick2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _firebrick_2; }
        }

        public static ref readonly Color4 Firebrick3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _firebrick_3; }
        }

        public static ref readonly Color4 Firebrick4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _firebrick_4; }
        }

        public static ref readonly Color4 Red
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _red_1; }
        }

        public static ref readonly Color4 Red2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _red_2; }
        }

        public static ref readonly Color4 Red3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _red_3; }
        }

        public static ref readonly Color4 Red4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _red_4; }
        }

        public static ref readonly Color4 Maroon
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _maroon; }
        }

        public static ref readonly Color4 SgiBeet
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _sgi_beet; }
        }

        public static ref readonly Color4 SgiSlateblue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _sgi_slateblue; }
        }

        public static ref readonly Color4 SgiLightblue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _sgi_lightblue; }
        }

        public static ref readonly Color4 SgiTeal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _sgi_teal; }
        }

        public static ref readonly Color4 SgiChartreuse
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _sgi_chartreuse; }
        }

        public static ref readonly Color4 SgiOlivedrab
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _sgi_olivedrab; }
        }

        public static ref readonly Color4 SgiBrightgray
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _sgi_brightgray; }
        }

        public static ref readonly Color4 SgiSalmon
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _sgi_salmon; }
        }

        public static ref readonly Color4 SgiDarkgray
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _sgi_darkgray; }
        }

        public static ref readonly Color4 SgiGray12
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _sgi_gray_12; }
        }

        public static ref readonly Color4 SgiGray16
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _sgi_gray_16; }
        }

        public static ref readonly Color4 SgiGray32
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _sgi_gray_32; }
        }

        public static ref readonly Color4 SgiGray36
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _sgi_gray_36; }
        }

        public static ref readonly Color4 SgiGray52
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _sgi_gray_52; }
        }

        public static ref readonly Color4 SgiGray56
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _sgi_gray_56; }
        }

        public static ref readonly Color4 SgiLightgray
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _sgi_lightgray; }
        }

        public static ref readonly Color4 SgiGray72
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _sgi_gray_72; }
        }

        public static ref readonly Color4 SgiGray76
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _sgi_gray_76; }
        }

        public static ref readonly Color4 SgiGray92
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _sgi_gray_92; }
        }

        public static ref readonly Color4 SgiGray96
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _sgi_gray_96; }
        }

        public static ref readonly Color4 White
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _white; }
        }

        public static ref readonly Color4 WhiteSmoke
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _white_smoke; }
        }

        public static ref readonly Color4 Gainsboro
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gainsboro; }
        }

        public static ref readonly Color4 Lightgrey
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _lightgrey; }
        }

        public static ref readonly Color4 Silver
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _silver; }
        }

        public static ref readonly Color4 Darkgray
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _darkgray; }
        }

        public static ref readonly Color4 Gray
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray; }
        }

        public static ref readonly Color4 Dimgray
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _dimgray; }
        }

        public static ref readonly Color4 Black
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _black; }
        }

        public static ref readonly Color4 Gray99
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_99; }
        }

        public static ref readonly Color4 Gray98
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_98; }
        }

        public static ref readonly Color4 Gray97
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_97; }
        }

        public static ref readonly Color4 Gray96
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_96; }
        }

        public static ref readonly Color4 Gray95
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_95; }
        }

        public static ref readonly Color4 Gray94
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_94; }
        }

        public static ref readonly Color4 Gray93
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_93; }
        }

        public static ref readonly Color4 Gray92
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_92; }
        }

        public static ref readonly Color4 Gray91
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_91; }
        }

        public static ref readonly Color4 Gray90
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_90; }
        }

        public static ref readonly Color4 Gray89
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_89; }
        }

        public static ref readonly Color4 Gray88
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_88; }
        }

        public static ref readonly Color4 Gray87
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_87; }
        }

        public static ref readonly Color4 Gray86
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_86; }
        }

        public static ref readonly Color4 Gray85
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_85; }
        }

        public static ref readonly Color4 Gray84
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_84; }
        }

        public static ref readonly Color4 Gray83
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_83; }
        }

        public static ref readonly Color4 Gray82
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_82; }
        }

        public static ref readonly Color4 Gray81
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_81; }
        }

        public static ref readonly Color4 Gray80
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_80; }
        }

        public static ref readonly Color4 Gray79
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_79; }
        }

        public static ref readonly Color4 Gray78
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_78; }
        }

        public static ref readonly Color4 Gray77
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_77; }
        }

        public static ref readonly Color4 Gray76
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_76; }
        }

        public static ref readonly Color4 Gray75
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_75; }
        }

        public static ref readonly Color4 Gray74
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_74; }
        }

        public static ref readonly Color4 Gray73
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_73; }
        }

        public static ref readonly Color4 Gray72
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_72; }
        }

        public static ref readonly Color4 Gray71
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_71; }
        }

        public static ref readonly Color4 Gray70
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_70; }
        }

        public static ref readonly Color4 Gray69
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_69; }
        }

        public static ref readonly Color4 Gray68
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_68; }
        }

        public static ref readonly Color4 Gray67
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_67; }
        }

        public static ref readonly Color4 Gray66
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_66; }
        }

        public static ref readonly Color4 Gray65
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_65; }
        }

        public static ref readonly Color4 Gray64
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_64; }
        }

        public static ref readonly Color4 Gray63
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_63; }
        }

        public static ref readonly Color4 Gray62
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_62; }
        }

        public static ref readonly Color4 Gray61
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_61; }
        }

        public static ref readonly Color4 Gray60
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_60; }
        }

        public static ref readonly Color4 Gray59
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_59; }
        }

        public static ref readonly Color4 Gray58
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_58; }
        }

        public static ref readonly Color4 Gray57
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_57; }
        }

        public static ref readonly Color4 Gray56
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_56; }
        }

        public static ref readonly Color4 Gray55
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_55; }
        }

        public static ref readonly Color4 Gray54
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_54; }
        }

        public static ref readonly Color4 Gray53
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_53; }
        }

        public static ref readonly Color4 Gray52
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_52; }
        }

        public static ref readonly Color4 Gray51
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_51; }
        }

        public static ref readonly Color4 Gray50
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_50; }
        }

        public static ref readonly Color4 Gray49
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_49; }
        }

        public static ref readonly Color4 Gray48
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_48; }
        }

        public static ref readonly Color4 Gray47
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_47; }
        }

        public static ref readonly Color4 Gray46
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_46; }
        }

        public static ref readonly Color4 Gray45
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_45; }
        }

        public static ref readonly Color4 Gray44
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_44; }
        }

        public static ref readonly Color4 Gray43
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_43; }
        }

        public static ref readonly Color4 Gray42
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_42; }
        }

        public static ref readonly Color4 Gray41
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_41; }
        }

        public static ref readonly Color4 Gray40
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_40; }
        }

        public static ref readonly Color4 Gray39
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_39; }
        }

        public static ref readonly Color4 Gray38
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_38; }
        }

        public static ref readonly Color4 Gray37
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_37; }
        }

        public static ref readonly Color4 Gray36
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_36; }
        }

        public static ref readonly Color4 Gray35
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_35; }
        }

        public static ref readonly Color4 Gray34
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_34; }
        }

        public static ref readonly Color4 Gray33
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_33; }
        }

        public static ref readonly Color4 Gray32
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_32; }
        }

        public static ref readonly Color4 Gray31
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_31; }
        }

        public static ref readonly Color4 Gray30
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_30; }
        }

        public static ref readonly Color4 Gray29
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_29; }
        }

        public static ref readonly Color4 Gray28
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_28; }
        }

        public static ref readonly Color4 Gray27
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_27; }
        }

        public static ref readonly Color4 Gray26
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_26; }
        }

        public static ref readonly Color4 Gray25
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_25; }
        }

        public static ref readonly Color4 Gray24
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_24; }
        }

        public static ref readonly Color4 Gray23
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_23; }
        }

        public static ref readonly Color4 Gray22
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_22; }
        }

        public static ref readonly Color4 Gray21
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_21; }
        }

        public static ref readonly Color4 Gray20
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_20; }
        }

        public static ref readonly Color4 Gray19
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_19; }
        }

        public static ref readonly Color4 Gray18
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_18; }
        }

        public static ref readonly Color4 Gray17
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_17; }
        }

        public static ref readonly Color4 Gray16
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_16; }
        }

        public static ref readonly Color4 Gray15
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_15; }
        }

        public static ref readonly Color4 Gray14
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_14; }
        }

        public static ref readonly Color4 Gray13
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_13; }
        }

        public static ref readonly Color4 Gray12
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_12; }
        }

        public static ref readonly Color4 Gray11
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_11; }
        }

        public static ref readonly Color4 Gray10
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_10; }
        }

        public static ref readonly Color4 Gray9
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_9; }
        }

        public static ref readonly Color4 Gray8
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_8; }
        }

        public static ref readonly Color4 Gray7
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_7; }
        }

        public static ref readonly Color4 Gray6
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_6; }
        }

        public static ref readonly Color4 Gray5
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_5; }
        }

        public static ref readonly Color4 Gray4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_4; }
        }

        public static ref readonly Color4 Gray3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_3; }
        }

        public static ref readonly Color4 Gray2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_2; }
        }

        public static ref readonly Color4 Gray1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _gray_1; }
        }
    }
}
