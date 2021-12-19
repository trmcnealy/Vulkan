using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

using Vulkan.Windows;




namespace Cglm
{
    public static partial class Api
    {
        public static readonly string DLL_NAME;

        public static readonly nint Handle;


        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        static unsafe Api()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                DLL_NAME = "libcglm.so.0";
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                DLL_NAME = "libcglm-0.0.0.dylib";
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                DLL_NAME = "cglm-0.dll";
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.FreeBSD))
            {
                DLL_NAME = "libcglm-0";
            }
            else
            {
                DLL_NAME = "cglm";
            }

            Handle = Vulkan.DllMap.MapAndLoad(DLL_NAME);



            glmc_translate_make = (delegate*<mat4, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_translate_make");


            glmc_translate_to = (delegate*<mat4, vec3, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_translate_to");


            glmc_translate = (delegate*<mat4, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_translate");


            glmc_translate_x = (delegate*<mat4, float, void>)NativeLibrary.GetExport(Handle, "glmc_translate_x");


            glmc_translate_y = (delegate*<mat4, float, void>)NativeLibrary.GetExport(Handle, "glmc_translate_y");


            glmc_translate_z = (delegate*<mat4, float, void>)NativeLibrary.GetExport(Handle, "glmc_translate_z");


            glmc_scale_make = (delegate*<mat4, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_scale_make");


            glmc_scale_to = (delegate*<mat4, vec3, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_scale_to");


            glmc_scale = (delegate*<mat4, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_scale");


            glmc_scale_uni = (delegate*<mat4, float, void>)NativeLibrary.GetExport(Handle, "glmc_scale_uni");


            glmc_rotate_x = (delegate*<mat4, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_rotate_x");


            glmc_rotate_y = (delegate*<mat4, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_rotate_y");


            glmc_rotate_z = (delegate*<mat4, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_rotate_z");


            glmc_rotate_make = (delegate*<mat4, float, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_rotate_make");


            glmc_rotate = (delegate*<mat4, float, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_rotate");


            glmc_rotate_at = (delegate*<mat4, vec3, float, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_rotate_at");


            glmc_rotate_atm = (delegate*<mat4, vec3, float, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_rotate_atm");


            glmc_decompose_scalev = (delegate*<mat4, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_decompose_scalev");



            glmc_uniscaled = (delegate*<mat4, Bool>)NativeLibrary.GetExport(Handle, "glmc_uniscaled");


            glmc_decompose_rs = (delegate*<mat4, mat4, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_decompose_rs");


            glmc_decompose = (delegate*<mat4, vec4, mat4, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_decompose");


            glmc_mul = (delegate*<mat4, mat4, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_mul");


            glmc_mul_rot = (delegate*<mat4, mat4, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_mul_rot");


            glmc_inv_tr = (delegate*<mat4, void>)NativeLibrary.GetExport(Handle, "glmc_inv_tr");


            glmc_translate2d_make = (delegate*<mat3, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_translate2d_make");


            glmc_translate2d_to = (delegate*<mat3, vec2, mat3, void>)NativeLibrary.GetExport(Handle, "glmc_translate2d_to");


            glmc_translate2d = (delegate*<mat3, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_translate2d");


            glmc_translate2d_x = (delegate*<mat3, float, void>)NativeLibrary.GetExport(Handle, "glmc_translate2d_x");


            glmc_translate2d_y = (delegate*<mat3, float, void>)NativeLibrary.GetExport(Handle, "glmc_translate2d_y");


            glmc_scale2d_to = (delegate*<mat3, vec2, mat3, void>)NativeLibrary.GetExport(Handle, "glmc_scale2d_to");


            glmc_scale2d_make = (delegate*<mat3, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_scale2d_make");


            glmc_scale2d = (delegate*<mat3, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_scale2d");


            glmc_scale2d_uni = (delegate*<mat3, float, void>)NativeLibrary.GetExport(Handle, "glmc_scale2d_uni");


            glmc_rotate2d_make = (delegate*<mat3, float, void>)NativeLibrary.GetExport(Handle, "glmc_rotate2d_make");


            glmc_rotate2d = (delegate*<mat3, float, void>)NativeLibrary.GetExport(Handle, "glmc_rotate2d");


            glmc_rotate2d_to = (delegate*<mat3, float, mat3, void>)NativeLibrary.GetExport(Handle, "glmc_rotate2d_to");


            glmc_bezier = (delegate*<float, float, float, float, float, float>)NativeLibrary.GetExport(Handle, "glmc_bezier");


            glmc_hermite = (delegate*<float, float, float, float, float, float>)NativeLibrary.GetExport(Handle, "glmc_hermite");


            glmc_decasteljau = (delegate*<float, float, float, float, float, float>)NativeLibrary.GetExport(Handle, "glmc_decasteljau");


            glmc_aabb_transform = (delegate*<vec3*, mat4, vec3*, void>)NativeLibrary.GetExport(Handle, "glmc_aabb_transform");
            glmc_aabb_merge = (delegate*<vec3*, vec3*, vec3*, void>)NativeLibrary.GetExport(Handle, "glmc_aabb_merge");
            glmc_aabb_crop = (delegate*<vec3*, vec3*, vec3*, void>)NativeLibrary.GetExport(Handle, "glmc_aabb_crop");
            glmc_aabb_crop_until = (delegate*<vec3*, vec3*, vec3*, vec3*, void>)NativeLibrary.GetExport(Handle, "glmc_aabb_crop_until");
            glmc_aabb_frustum = (delegate*<vec3*, vec4*, bool>)NativeLibrary.GetExport(Handle, "glmc_aabb_frustum");
            glmc_aabb_invalidate = (delegate*<vec3*, void>)NativeLibrary.GetExport(Handle, "glmc_aabb_invalidate");
            glmc_aabb_isvalid = (delegate*<vec3*, Bool>)NativeLibrary.GetExport(Handle, "glmc_aabb_isvalid");
            glmc_aabb_size = (delegate*<vec3*, float>)NativeLibrary.GetExport(Handle, "glmc_aabb_size");
            glmc_aabb_radius = (delegate*<vec3*, float>)NativeLibrary.GetExport(Handle, "glmc_aabb_radius");
            glmc_aabb_center = (delegate*<vec3*, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_aabb_center");
            glmc_aabb_aabb = (delegate*<vec3*, vec3*, Bool>)NativeLibrary.GetExport(Handle, "glmc_aabb_aabb");
            glmc_aabb_point = (delegate*<vec3*, vec3, Bool>)NativeLibrary.GetExport(Handle, "glmc_aabb_point");
            glmc_aabb_contains = (delegate*<vec3*, vec3*, Bool>)NativeLibrary.GetExport(Handle, "glmc_aabb_contains");
            glmc_aabb_sphere = (delegate*<vec3*, vec4, Bool>)NativeLibrary.GetExport(Handle, "glmc_aabb_sphere");




            glmc_frustum = (delegate*<float, float, float, float, float, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_frustum");


            glmc_ortho = (delegate*<float, float, float, float, float, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho");


            glmc_ortho_aabb = (delegate*<vec3*, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_aabb");


            glmc_ortho_aabb_p = (delegate*<vec3*, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_aabb_p");


            glmc_ortho_aabb_pz = (delegate*<vec3*, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_aabb_pz");


            glmc_ortho_default = (delegate*<float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_default");


            glmc_ortho_default_s = (delegate*<float, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_default_s");


            glmc_perspective = (delegate*<float, float, float, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_perspective");


            glmc_persp_move_far = (delegate*<mat4, float, void>)NativeLibrary.GetExport(Handle, "glmc_persp_move_far");


            glmc_perspective_default = (delegate*<float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_perspective_default");


            glmc_perspective_resize = (delegate*<float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_perspective_resize");


            glmc_lookat = (delegate*<vec3, vec3, vec3, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_lookat");


            glmc_look = (delegate*<vec3, vec3, vec3, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_look");


            glmc_look_anyup = (delegate*<vec3, vec3, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_look_anyup");


            glmc_persp_decomp = (delegate*<mat4, float*, float*, float*, float*, float*, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp");


            glmc_persp_decompv = (delegate*<mat4, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decompv");


            glmc_persp_decomp_x = (delegate*<mat4, float*, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_x");


            glmc_persp_decomp_y = (delegate*<mat4, float*, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_y");


            glmc_persp_decomp_z = (delegate*<mat4, float*, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_z");


            glmc_persp_decomp_far = (delegate*<mat4, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_far");


            glmc_persp_decomp_near = (delegate*<mat4, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_near");


            glmc_persp_fovy = (delegate*<mat4, float>)NativeLibrary.GetExport(Handle, "glmc_persp_fovy");


            glmc_persp_aspect = (delegate*<mat4, float>)NativeLibrary.GetExport(Handle, "glmc_persp_aspect");


            glmc_persp_sizes = (delegate*<mat4, float, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_persp_sizes");


            glmc_smc = (delegate*<float, mat4, vec4, float>)NativeLibrary.GetExport(Handle, "glmc_smc");


            glmc_ease_linear = (delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_linear");


            glmc_ease_sine_in = (delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_sine_in");


            glmc_ease_sine_out = (delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_sine_out");


            glmc_ease_sine_inout = (delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_sine_inout");


            glmc_ease_quad_in = (delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_quad_in");


            glmc_ease_quad_out = (delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_quad_out");


            glmc_ease_quad_inout = (delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_quad_inout");


            glmc_ease_cubic_in = (delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_cubic_in");


            glmc_ease_cubic_out = (delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_cubic_out");


            glmc_ease_cubic_inout = (delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_cubic_inout");


            glmc_ease_quart_in = (delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_quart_in");


            glmc_ease_quart_out = (delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_quart_out");


            glmc_ease_quart_inout = (delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_quart_inout");


            glmc_ease_quint_in = (delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_quint_in");


            glmc_ease_quint_out = (delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_quint_out");


            glmc_ease_quint_inout = (delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_quint_inout");


            glmc_ease_exp_in = (delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_exp_in");


            glmc_ease_exp_out = (delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_exp_out");


            glmc_ease_exp_inout = (delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_exp_inout");


            glmc_ease_circ_in = (delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_circ_in");


            glmc_ease_circ_out = (delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_circ_out");


            glmc_ease_circ_inout = (delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_circ_inout");


            glmc_ease_back_in = (delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_back_in");


            glmc_ease_back_out = (delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_back_out");


            glmc_ease_back_inout = (delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_back_inout");


            glmc_ease_elast_in = (delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_elast_in");


            glmc_ease_elast_out = (delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_elast_out");


            glmc_ease_elast_inout = (delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_elast_inout");


            glmc_ease_bounce_out = (delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_bounce_out");


            glmc_ease_bounce_in = (delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_bounce_in");


            glmc_ease_bounce_inout = (delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_bounce_inout");


            glmc_euler_angles = (delegate*<mat4, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_euler_angles");


            glmc_euler = (delegate*<vec3, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_euler");


            glmc_euler_xyz = (delegate*<vec3, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_euler_xyz");


            glmc_euler_zyx = (delegate*<vec3, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_euler_zyx");


            glmc_euler_zxy = (delegate*<vec3, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_euler_zxy");


            glmc_euler_xzy = (delegate*<vec3, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_euler_xzy");


            glmc_euler_yzx = (delegate*<vec3, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_euler_yzx");


            glmc_euler_yxz = (delegate*<vec3, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_euler_yxz");


            glmc_euler_by_order = (delegate*<vec3, glm_euler_seq, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_euler_by_order");




            glmc_frustum_planes = (delegate*<mat4, vec4*, void>)NativeLibrary.GetExport(Handle, "glmc_frustum_planes");
            glmc_frustum_corners = (delegate*<mat4, vec4*, void>)NativeLibrary.GetExport(Handle, "glmc_frustum_corners");
            glmc_frustum_center = (delegate*<vec4*, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_frustum_center");
            glmc_frustum_box = (delegate*<vec4*, mat4, vec3*, void>)NativeLibrary.GetExport(Handle, "glmc_frustum_box");
            glmc_frustum_corners_at = (delegate*<vec4*, float, float, vec4*, void>)NativeLibrary.GetExport(Handle, "glmc_frustum_corners_at");


            glmc_mat4_print = (delegate*<mat4, _iobuf*, void>)NativeLibrary.GetExport(Handle, "glmc_mat4_print");



            glmc_mat3_print = (delegate*<mat3, _iobuf*, void>)NativeLibrary.GetExport(Handle, "glmc_mat3_print");


            glmc_vec4_print = (delegate*<vec4, _iobuf*, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_print");


            glmc_vec3_print = (delegate*<vec3, _iobuf*, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_print");


            glmc_versor_print = (delegate*<versor, _iobuf*, void>)NativeLibrary.GetExport(Handle, "glmc_versor_print");


            glmc_mat2_copy = (delegate*<mat2, mat2, void>)NativeLibrary.GetExport(Handle, "glmc_mat2_copy");


            glmc_mat2_identity = (delegate*<mat2, void>)NativeLibrary.GetExport(Handle, "glmc_mat2_identity");


            glmc_mat2_identity_array = (delegate*<mat2*, nuint, void>)NativeLibrary.GetExport(Handle, "glmc_mat2_identity_array");



            glmc_mat2_zero = (delegate*<mat2, void>)NativeLibrary.GetExport(Handle, "glmc_mat2_zero");


            glmc_mat2_mul = (delegate*<mat2, mat2, mat2, void>)NativeLibrary.GetExport(Handle, "glmc_mat2_mul");


            glmc_mat2_transpose_to = (delegate*<mat2, mat2, void>)NativeLibrary.GetExport(Handle, "glmc_mat2_transpose_to");


            glmc_mat2_transpose = (delegate*<mat2, void>)NativeLibrary.GetExport(Handle, "glmc_mat2_transpose");


            glmc_mat2_mulv = (delegate*<mat2, vec2, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_mat2_mulv");


            glmc_mat2_trace = (delegate*<mat2, float>)NativeLibrary.GetExport(Handle, "glmc_mat2_trace");


            glmc_mat2_scale = (delegate*<mat2, float, void>)NativeLibrary.GetExport(Handle, "glmc_mat2_scale");


            glmc_mat2_det = (delegate*<mat2, float>)NativeLibrary.GetExport(Handle, "glmc_mat2_det");


            glmc_mat2_inv = (delegate*<mat2, mat2, void>)NativeLibrary.GetExport(Handle, "glmc_mat2_inv");


            glmc_mat2_swap_col = (delegate*<mat2, int, int, void>)NativeLibrary.GetExport(Handle, "glmc_mat2_swap_col");


            glmc_mat2_swap_row = (delegate*<mat2, int, int, void>)NativeLibrary.GetExport(Handle, "glmc_mat2_swap_row");


            glmc_mat2_rmc = (delegate*<vec2, mat2, vec2, float>)NativeLibrary.GetExport(Handle, "glmc_mat2_rmc");


            glmc_mat3_copy = (delegate*<mat3, mat3, void>)NativeLibrary.GetExport(Handle, "glmc_mat3_copy");


            glmc_mat3_identity = (delegate*<mat3, void>)NativeLibrary.GetExport(Handle, "glmc_mat3_identity");


            glmc_mat3_zero = (delegate*<mat3, void>)NativeLibrary.GetExport(Handle, "glmc_mat3_zero");


            glmc_mat3_identity_array = (delegate*<mat3*, nuint, void>)NativeLibrary.GetExport(Handle, "glmc_mat3_identity_array");


            glmc_mat3_mul = (delegate*<mat3, mat3, mat3, void>)NativeLibrary.GetExport(Handle, "glmc_mat3_mul");


            glmc_mat3_transpose_to = (delegate*<mat3, mat3, void>)NativeLibrary.GetExport(Handle, "glmc_mat3_transpose_to");


            glmc_mat3_transpose = (delegate*<mat3, void>)NativeLibrary.GetExport(Handle, "glmc_mat3_transpose");


            glmc_mat3_mulv = (delegate*<mat3, vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_mat3_mulv");


            glmc_mat3_trace = (delegate*<mat3, float>)NativeLibrary.GetExport(Handle, "glmc_mat3_trace");


            glmc_mat3_quat = (delegate*<mat3, versor, void>)NativeLibrary.GetExport(Handle, "glmc_mat3_quat");


            glmc_mat3_scale = (delegate*<mat3, float, void>)NativeLibrary.GetExport(Handle, "glmc_mat3_scale");


            glmc_mat3_det = (delegate*<mat3, float>)NativeLibrary.GetExport(Handle, "glmc_mat3_det");


            glmc_mat3_inv = (delegate*<mat3, mat3, void>)NativeLibrary.GetExport(Handle, "glmc_mat3_inv");


            glmc_mat3_swap_col = (delegate*<mat3, int, int, void>)NativeLibrary.GetExport(Handle, "glmc_mat3_swap_col");


            glmc_mat3_swap_row = (delegate*<mat3, int, int, void>)NativeLibrary.GetExport(Handle, "glmc_mat3_swap_row");


            glmc_mat3_rmc = (delegate*<vec3, mat3, vec3, float>)NativeLibrary.GetExport(Handle, "glmc_mat3_rmc");


            glmc_mat4_ucopy = (delegate*<mat4, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_mat4_ucopy");


            glmc_mat4_copy = (delegate*<mat4, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_mat4_copy");


            glmc_mat4_identity = (delegate*<mat4, void>)NativeLibrary.GetExport(Handle, "glmc_mat4_identity");


            glmc_mat4_identity_array = (delegate*<mat4*, nuint, void>)NativeLibrary.GetExport(Handle, "glmc_mat4_identity_array");


            glmc_mat4_zero = (delegate*<mat4, void>)NativeLibrary.GetExport(Handle, "glmc_mat4_zero");


            glmc_mat4_pick3 = (delegate*<mat4, mat3, void>)NativeLibrary.GetExport(Handle, "glmc_mat4_pick3");


            glmc_mat4_pick3t = (delegate*<mat4, mat3, void>)NativeLibrary.GetExport(Handle, "glmc_mat4_pick3t");


            glmc_mat4_ins3 = (delegate*<mat3, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_mat4_ins3");


            glmc_mat4_mul = (delegate*<mat4, mat4, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_mat4_mul");


            glmc_mat4_mulN = (delegate*<void>)NativeLibrary.GetExport(Handle, "glmc_mat4_mulN");


            glmc_mat4_mulv = (delegate*<mat4, vec4, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_mat4_mulv");


            glmc_mat4_mulv3 = (delegate*<mat4, vec3, float, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_mat4_mulv3");


            glmc_mat4_trace = (delegate*<mat4, float>)NativeLibrary.GetExport(Handle, "glmc_mat4_trace");


            glmc_mat4_trace3 = (delegate*<mat4, float>)NativeLibrary.GetExport(Handle, "glmc_mat4_trace3");


            glmc_mat4_quat = (delegate*<mat4, versor, void>)NativeLibrary.GetExport(Handle, "glmc_mat4_quat");


            glmc_mat4_transpose_to = (delegate*<mat4, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_mat4_transpose_to");


            glmc_mat4_transpose = (delegate*<mat4, void>)NativeLibrary.GetExport(Handle, "glmc_mat4_transpose");


            glmc_mat4_scale_p = (delegate*<mat4, float, void>)NativeLibrary.GetExport(Handle, "glmc_mat4_scale_p");


            glmc_mat4_scale = (delegate*<mat4, float, void>)NativeLibrary.GetExport(Handle, "glmc_mat4_scale");


            glmc_mat4_det = (delegate*<mat4, float>)NativeLibrary.GetExport(Handle, "glmc_mat4_det");


            glmc_mat4_inv = (delegate*<mat4, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_mat4_inv");


            glmc_mat4_inv_precise = (delegate*<mat4, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_mat4_inv_precise");


            glmc_mat4_inv_fast = (delegate*<mat4, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_mat4_inv_fast");


            glmc_mat4_swap_col = (delegate*<mat4, int, int, void>)NativeLibrary.GetExport(Handle, "glmc_mat4_swap_col");


            glmc_mat4_swap_row = (delegate*<mat4, int, int, void>)NativeLibrary.GetExport(Handle, "glmc_mat4_swap_row");


            glmc_mat4_rmc = (delegate*<vec4, mat4, vec4, float>)NativeLibrary.GetExport(Handle, "glmc_mat4_rmc");


            glmc_plane_normalize = (delegate*<vec4, void>)NativeLibrary.GetExport(Handle, "glmc_plane_normalize");


            glmc_unprojecti = (delegate*<vec3, mat4, vec4, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_unprojecti");


            glmc_unproject = (delegate*<vec3, mat4, vec4, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_unproject");


            glmc_project = (delegate*<vec3, mat4, vec4, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_project");


            glmc_pickmatrix = (delegate*<vec2, vec2, vec4, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_pickmatrix");


            glmc_quat_identity = (delegate*<versor, void>)NativeLibrary.GetExport(Handle, "glmc_quat_identity");


            glmc_quat_identity_array = (delegate*<versor*, nuint, void>)NativeLibrary.GetExport(Handle, "glmc_quat_identity_array");


            glmc_quat_init = (delegate*<versor, float, float, float, float, void>)NativeLibrary.GetExport(Handle, "glmc_quat_init");


            glmc_quat = (delegate*<versor, float, float, float, float, void>)NativeLibrary.GetExport(Handle, "glmc_quat");


            glmc_quatv = (delegate*<versor, float, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_quatv");


            glmc_quat_copy = (delegate*<versor, versor, void>)NativeLibrary.GetExport(Handle, "glmc_quat_copy");


            glmc_quat_from_vecs = (delegate*<vec3, vec3, versor, void>)NativeLibrary.GetExport(Handle, "glmc_quat_from_vecs");


            glmc_quat_norm = (delegate*<versor, float>)NativeLibrary.GetExport(Handle, "glmc_quat_norm");


            glmc_quat_normalize_to = (delegate*<versor, versor, void>)NativeLibrary.GetExport(Handle, "glmc_quat_normalize_to");


            glmc_quat_normalize = (delegate*<versor, void>)NativeLibrary.GetExport(Handle, "glmc_quat_normalize");


            glmc_quat_dot = (delegate*<versor, versor, float>)NativeLibrary.GetExport(Handle, "glmc_quat_dot");


            glmc_quat_conjugate = (delegate*<versor, versor, void>)NativeLibrary.GetExport(Handle, "glmc_quat_conjugate");


            glmc_quat_inv = (delegate*<versor, versor, void>)NativeLibrary.GetExport(Handle, "glmc_quat_inv");


            glmc_quat_add = (delegate*<versor, versor, versor, void>)NativeLibrary.GetExport(Handle, "glmc_quat_add");


            glmc_quat_sub = (delegate*<versor, versor, versor, void>)NativeLibrary.GetExport(Handle, "glmc_quat_sub");


            glmc_quat_real = (delegate*<versor, float>)NativeLibrary.GetExport(Handle, "glmc_quat_real");


            glmc_quat_imag = (delegate*<versor, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_quat_imag");


            glmc_quat_imagn = (delegate*<versor, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_quat_imagn");


            glmc_quat_imaglen = (delegate*<versor, float>)NativeLibrary.GetExport(Handle, "glmc_quat_imaglen");


            glmc_quat_angle = (delegate*<versor, float>)NativeLibrary.GetExport(Handle, "glmc_quat_angle");


            glmc_quat_axis = (delegate*<versor, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_quat_axis");


            glmc_quat_mul = (delegate*<versor, versor, versor, void>)NativeLibrary.GetExport(Handle, "glmc_quat_mul");


            glmc_quat_mat4 = (delegate*<versor, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_quat_mat4");


            glmc_quat_mat4t = (delegate*<versor, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_quat_mat4t");


            glmc_quat_mat3 = (delegate*<versor, mat3, void>)NativeLibrary.GetExport(Handle, "glmc_quat_mat3");


            glmc_quat_mat3t = (delegate*<versor, mat3, void>)NativeLibrary.GetExport(Handle, "glmc_quat_mat3t");


            glmc_quat_lerp = (delegate*<versor, versor, float, versor, void>)NativeLibrary.GetExport(Handle, "glmc_quat_lerp");


            glmc_quat_lerpc = (delegate*<versor, versor, float, versor, void>)NativeLibrary.GetExport(Handle, "glmc_quat_lerpc");


            glmc_quat_nlerp = (delegate*<versor, versor, float, versor, void>)NativeLibrary.GetExport(Handle, "glmc_quat_nlerp");


            glmc_quat_slerp = (delegate*<versor, versor, float, versor, void>)NativeLibrary.GetExport(Handle, "glmc_quat_slerp");


            glmc_quat_look = (delegate*<vec3, versor, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_quat_look");


            glmc_quat_for = (delegate*<vec3, vec3, versor, void>)NativeLibrary.GetExport(Handle, "glmc_quat_for");


            glmc_quat_forp = (delegate*<vec3, vec3, vec3, versor, void>)NativeLibrary.GetExport(Handle, "glmc_quat_forp");


            glmc_quat_rotatev = (delegate*<versor, vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_quat_rotatev");


            glmc_quat_rotate = (delegate*<mat4, versor, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_quat_rotate");


            glmc_quat_rotate_at = (delegate*<mat4, versor, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_quat_rotate_at");


            glmc_quat_rotate_atm = (delegate*<mat4, versor, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_quat_rotate_atm");



            glmc_ray_triangle = (delegate*<vec3, vec3, vec3, vec3, vec3, float*, Bool>)NativeLibrary.GetExport(Handle, "glmc_ray_triangle");


            glmc_sphere_radii = (delegate*<vec4, float>)NativeLibrary.GetExport(Handle, "glmc_sphere_radii");


            glmc_sphere_transform = (delegate*<vec4, mat4, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_sphere_transform");


            glmc_sphere_merge = (delegate*<vec4, vec4, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_sphere_merge");



            glmc_sphere_sphere = (delegate*<vec4, vec4, Bool>)NativeLibrary.GetExport(Handle, "glmc_sphere_sphere");



            glmc_sphere_point = (delegate*<vec4, vec3, Bool>)NativeLibrary.GetExport(Handle, "glmc_sphere_point");


            glmc_vec2 = (delegate*<float*, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_vec2");


            glmc_vec2_copy = (delegate*<vec2, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_vec2_copy");


            glmc_vec2_zero = (delegate*<vec2, void>)NativeLibrary.GetExport(Handle, "glmc_vec2_zero");


            glmc_vec2_one = (delegate*<vec2, void>)NativeLibrary.GetExport(Handle, "glmc_vec2_one");


            glmc_vec2_dot = (delegate*<vec2, vec2, float>)NativeLibrary.GetExport(Handle, "glmc_vec2_dot");


            glmc_vec2_cross = (delegate*<vec2, vec2, float>)NativeLibrary.GetExport(Handle, "glmc_vec2_cross");


            glmc_vec2_norm2 = (delegate*<vec2, float>)NativeLibrary.GetExport(Handle, "glmc_vec2_norm2");


            glmc_vec2_norm = (delegate*<vec2, float>)NativeLibrary.GetExport(Handle, "glmc_vec2_norm");


            glmc_vec2_add = (delegate*<vec2, vec2, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_vec2_add");


            glmc_vec2_adds = (delegate*<vec2, float, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_vec2_adds");


            glmc_vec2_sub = (delegate*<vec2, vec2, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_vec2_sub");


            glmc_vec2_subs = (delegate*<vec2, float, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_vec2_subs");


            glmc_vec2_mul = (delegate*<vec2, vec2, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_vec2_mul");


            glmc_vec2_scale = (delegate*<vec2, float, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_vec2_scale");


            glmc_vec2_scale_as = (delegate*<vec2, float, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_vec2_scale_as");


            glmc_vec2_div = (delegate*<vec2, vec2, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_vec2_div");


            glmc_vec2_divs = (delegate*<vec2, float, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_vec2_divs");


            glmc_vec2_addadd = (delegate*<vec2, vec2, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_vec2_addadd");


            glmc_vec2_subadd = (delegate*<vec2, vec2, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_vec2_subadd");


            glmc_vec2_muladd = (delegate*<vec2, vec2, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_vec2_muladd");


            glmc_vec2_muladds = (delegate*<vec2, float, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_vec2_muladds");


            glmc_vec2_maxadd = (delegate*<vec2, vec2, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_vec2_maxadd");


            glmc_vec2_minadd = (delegate*<vec2, vec2, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_vec2_minadd");


            glmc_vec2_negate_to = (delegate*<vec2, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_vec2_negate_to");


            glmc_vec2_negate = (delegate*<vec2, void>)NativeLibrary.GetExport(Handle, "glmc_vec2_negate");


            glmc_vec2_normalize = (delegate*<vec2, void>)NativeLibrary.GetExport(Handle, "glmc_vec2_normalize");


            glmc_vec2_normalize_to = (delegate*<vec2, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_vec2_normalize_to");


            glmc_vec2_rotate = (delegate*<vec2, float, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_vec2_rotate");


            glmc_vec2_distance2 = (delegate*<vec2, vec2, float>)NativeLibrary.GetExport(Handle, "glmc_vec2_distance2");


            glmc_vec2_distance = (delegate*<vec2, vec2, float>)NativeLibrary.GetExport(Handle, "glmc_vec2_distance");


            glmc_vec2_maxv = (delegate*<vec2, vec2, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_vec2_maxv");


            glmc_vec2_minv = (delegate*<vec2, vec2, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_vec2_minv");


            glmc_vec2_clamp = (delegate*<vec2, float, float, void>)NativeLibrary.GetExport(Handle, "glmc_vec2_clamp");


            glmc_vec2_lerp = (delegate*<vec2, vec2, float, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_vec2_lerp");


            glmc_vec3 = (delegate*<vec4, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3");


            glmc_vec3_copy = (delegate*<vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_copy");


            glmc_vec3_zero = (delegate*<vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_zero");


            glmc_vec3_one = (delegate*<vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_one");


            glmc_vec3_dot = (delegate*<vec3, vec3, float>)NativeLibrary.GetExport(Handle, "glmc_vec3_dot");


            glmc_vec3_cross = (delegate*<vec3, vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_cross");


            glmc_vec3_crossn = (delegate*<vec3, vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_crossn");


            glmc_vec3_norm = (delegate*<vec3, float>)NativeLibrary.GetExport(Handle, "glmc_vec3_norm");


            glmc_vec3_norm2 = (delegate*<vec3, float>)NativeLibrary.GetExport(Handle, "glmc_vec3_norm2");


            glmc_vec3_norm_one = (delegate*<vec3, float>)NativeLibrary.GetExport(Handle, "glmc_vec3_norm_one");


            glmc_vec3_norm_inf = (delegate*<vec3, float>)NativeLibrary.GetExport(Handle, "glmc_vec3_norm_inf");


            glmc_vec3_normalize_to = (delegate*<vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_normalize_to");


            glmc_vec3_normalize = (delegate*<vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_normalize");


            glmc_vec3_add = (delegate*<vec3, vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_add");


            glmc_vec3_adds = (delegate*<vec3, float, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_adds");


            glmc_vec3_sub = (delegate*<vec3, vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_sub");


            glmc_vec3_subs = (delegate*<vec3, float, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_subs");


            glmc_vec3_mul = (delegate*<vec3, vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_mul");


            glmc_vec3_scale = (delegate*<vec3, float, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_scale");


            glmc_vec3_scale_as = (delegate*<vec3, float, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_scale_as");


            glmc_vec3_div = (delegate*<vec3, vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_div");


            glmc_vec3_divs = (delegate*<vec3, float, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_divs");


            glmc_vec3_addadd = (delegate*<vec3, vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_addadd");


            glmc_vec3_subadd = (delegate*<vec3, vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_subadd");


            glmc_vec3_muladd = (delegate*<vec3, vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_muladd");


            glmc_vec3_muladds = (delegate*<vec3, float, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_muladds");


            glmc_vec3_maxadd = (delegate*<vec3, vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_maxadd");


            glmc_vec3_minadd = (delegate*<vec3, vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_minadd");


            glmc_vec3_negate = (delegate*<vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_negate");


            glmc_vec3_negate_to = (delegate*<vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_negate_to");


            glmc_vec3_angle = (delegate*<vec3, vec3, float>)NativeLibrary.GetExport(Handle, "glmc_vec3_angle");


            glmc_vec3_rotate = (delegate*<vec3, float, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_rotate");


            glmc_vec3_rotate_m4 = (delegate*<mat4, vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_rotate_m4");


            glmc_vec3_rotate_m3 = (delegate*<mat3, vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_rotate_m3");


            glmc_vec3_proj = (delegate*<vec3, vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_proj");


            glmc_vec3_center = (delegate*<vec3, vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_center");


            glmc_vec3_distance2 = (delegate*<vec3, vec3, float>)NativeLibrary.GetExport(Handle, "glmc_vec3_distance2");


            glmc_vec3_distance = (delegate*<vec3, vec3, float>)NativeLibrary.GetExport(Handle, "glmc_vec3_distance");


            glmc_vec3_maxv = (delegate*<vec3, vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_maxv");


            glmc_vec3_minv = (delegate*<vec3, vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_minv");


            glmc_vec3_clamp = (delegate*<vec3, float, float, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_clamp");


            glmc_vec3_ortho = (delegate*<vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_ortho");


            glmc_vec3_lerp = (delegate*<vec3, vec3, float, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_lerp");


            glmc_vec3_lerpc = (delegate*<vec3, vec3, float, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_lerpc");


            glmc_vec3_step_uni = (delegate*<float, vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_step_uni");


            glmc_vec3_step = (delegate*<vec3, vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_step");


            glmc_vec3_smoothstep_uni = (delegate*<float, float, vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_smoothstep_uni");


            glmc_vec3_smoothstep = (delegate*<vec3, vec3, vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_smoothstep");


            glmc_vec3_smoothinterp = (delegate*<vec3, vec3, float, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_smoothinterp");


            glmc_vec3_smoothinterpc = (delegate*<vec3, vec3, float, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_smoothinterpc");


            glmc_vec3_mulv = (delegate*<vec3, vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_mulv");


            glmc_vec3_broadcast = (delegate*<float, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_broadcast");


            glmc_vec3_fill = (delegate*<vec3, float, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_fill");



            glmc_vec3_eq = (delegate*<vec3, float, Bool>)NativeLibrary.GetExport(Handle, "glmc_vec3_eq");



            glmc_vec3_eq_eps = (delegate*<vec3, float, Bool>)NativeLibrary.GetExport(Handle, "glmc_vec3_eq_eps");



            glmc_vec3_eq_all = (delegate*<vec3, Bool>)NativeLibrary.GetExport(Handle, "glmc_vec3_eq_all");



            glmc_vec3_eqv = (delegate*<vec3, vec3, Bool>)NativeLibrary.GetExport(Handle, "glmc_vec3_eqv");



            glmc_vec3_eqv_eps = (delegate*<vec3, vec3, Bool>)NativeLibrary.GetExport(Handle, "glmc_vec3_eqv_eps");


            glmc_vec3_max = (delegate*<vec3, float>)NativeLibrary.GetExport(Handle, "glmc_vec3_max");


            glmc_vec3_min = (delegate*<vec3, float>)NativeLibrary.GetExport(Handle, "glmc_vec3_min");



            glmc_vec3_isnan = (delegate*<vec3, Bool>)NativeLibrary.GetExport(Handle, "glmc_vec3_isnan");



            glmc_vec3_isinf = (delegate*<vec3, Bool>)NativeLibrary.GetExport(Handle, "glmc_vec3_isinf");



            glmc_vec3_isvalid = (delegate*<vec3, Bool>)NativeLibrary.GetExport(Handle, "glmc_vec3_isvalid");


            glmc_vec3_sign = (delegate*<vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_sign");


            glmc_vec3_abs = (delegate*<vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_abs");


            glmc_vec3_fract = (delegate*<vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_fract");


            glmc_vec3_hadd = (delegate*<vec3, float>)NativeLibrary.GetExport(Handle, "glmc_vec3_hadd");


            glmc_vec3_sqrt = (delegate*<vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_sqrt");


            glmc_vec4 = (delegate*<vec3, float, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4");


            glmc_vec4_zero = (delegate*<vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_zero");


            glmc_vec4_one = (delegate*<vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_one");


            glmc_vec4_copy3 = (delegate*<vec4, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_copy3");


            glmc_vec4_copy = (delegate*<vec4, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_copy");


            glmc_vec4_ucopy = (delegate*<vec4, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_ucopy");


            glmc_vec4_dot = (delegate*<vec4, vec4, float>)NativeLibrary.GetExport(Handle, "glmc_vec4_dot");


            glmc_vec4_norm = (delegate*<vec4, float>)NativeLibrary.GetExport(Handle, "glmc_vec4_norm");


            glmc_vec4_norm2 = (delegate*<vec4, float>)NativeLibrary.GetExport(Handle, "glmc_vec4_norm2");


            glmc_vec4_norm_one = (delegate*<vec4, float>)NativeLibrary.GetExport(Handle, "glmc_vec4_norm_one");


            glmc_vec4_norm_inf = (delegate*<vec4, float>)NativeLibrary.GetExport(Handle, "glmc_vec4_norm_inf");


            glmc_vec4_normalize_to = (delegate*<vec4, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_normalize_to");


            glmc_vec4_normalize = (delegate*<vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_normalize");


            glmc_vec4_add = (delegate*<vec4, vec4, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_add");


            glmc_vec4_adds = (delegate*<vec4, float, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_adds");


            glmc_vec4_sub = (delegate*<vec4, vec4, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_sub");


            glmc_vec4_subs = (delegate*<vec4, float, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_subs");


            glmc_vec4_mul = (delegate*<vec4, vec4, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_mul");


            glmc_vec4_scale = (delegate*<vec4, float, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_scale");


            glmc_vec4_scale_as = (delegate*<vec4, float, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_scale_as");


            glmc_vec4_div = (delegate*<vec4, vec4, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_div");


            glmc_vec4_divs = (delegate*<vec4, float, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_divs");


            glmc_vec4_addadd = (delegate*<vec4, vec4, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_addadd");


            glmc_vec4_subadd = (delegate*<vec4, vec4, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_subadd");


            glmc_vec4_muladd = (delegate*<vec4, vec4, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_muladd");


            glmc_vec4_muladds = (delegate*<vec4, float, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_muladds");


            glmc_vec4_maxadd = (delegate*<vec4, vec4, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_maxadd");


            glmc_vec4_minadd = (delegate*<vec4, vec4, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_minadd");


            glmc_vec4_negate = (delegate*<vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_negate");


            glmc_vec4_negate_to = (delegate*<vec4, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_negate_to");


            glmc_vec4_distance = (delegate*<vec4, vec4, float>)NativeLibrary.GetExport(Handle, "glmc_vec4_distance");


            glmc_vec4_distance2 = (delegate*<vec4, vec4, float>)NativeLibrary.GetExport(Handle, "glmc_vec4_distance2");


            glmc_vec4_maxv = (delegate*<vec4, vec4, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_maxv");


            glmc_vec4_minv = (delegate*<vec4, vec4, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_minv");


            glmc_vec4_clamp = (delegate*<vec4, float, float, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_clamp");


            glmc_vec4_lerp = (delegate*<vec4, vec4, float, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_lerp");


            glmc_vec4_lerpc = (delegate*<vec4, vec4, float, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_lerpc");


            glmc_vec4_step_uni = (delegate*<float, vec4, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_step_uni");


            glmc_vec4_step = (delegate*<vec4, vec4, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_step");


            glmc_vec4_smoothstep_uni = (delegate*<float, float, vec4, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_smoothstep_uni");


            glmc_vec4_smoothstep = (delegate*<vec4, vec4, vec4, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_smoothstep");


            glmc_vec4_smoothinterp = (delegate*<vec4, vec4, float, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_smoothinterp");


            glmc_vec4_smoothinterpc = (delegate*<vec4, vec4, float, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_smoothinterpc");


            glmc_vec4_cubic = (delegate*<float, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_cubic");


            glmc_vec4_mulv = (delegate*<vec4, vec4, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_mulv");


            glmc_vec4_broadcast = (delegate*<float, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_broadcast");


            glmc_vec4_fill = (delegate*<vec4, float, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_fill");



            glmc_vec4_eq = (delegate*<vec4, float, Bool>)NativeLibrary.GetExport(Handle, "glmc_vec4_eq");



            glmc_vec4_eq_eps = (delegate*<vec4, float, Bool>)NativeLibrary.GetExport(Handle, "glmc_vec4_eq_eps");



            glmc_vec4_eq_all = (delegate*<vec4, Bool>)NativeLibrary.GetExport(Handle, "glmc_vec4_eq_all");



            glmc_vec4_eqv = (delegate*<vec4, vec4, Bool>)NativeLibrary.GetExport(Handle, "glmc_vec4_eqv");



            glmc_vec4_eqv_eps = (delegate*<vec4, vec4, Bool>)NativeLibrary.GetExport(Handle, "glmc_vec4_eqv_eps");


            glmc_vec4_max = (delegate*<vec4, float>)NativeLibrary.GetExport(Handle, "glmc_vec4_max");


            glmc_vec4_min = (delegate*<vec4, float>)NativeLibrary.GetExport(Handle, "glmc_vec4_min");



            glmc_vec4_isnan = (delegate*<vec4, Bool>)NativeLibrary.GetExport(Handle, "glmc_vec4_isnan");



            glmc_vec4_isinf = (delegate*<vec4, Bool>)NativeLibrary.GetExport(Handle, "glmc_vec4_isinf");



            glmc_vec4_isvalid = (delegate*<vec4, Bool>)NativeLibrary.GetExport(Handle, "glmc_vec4_isvalid");


            glmc_vec4_sign = (delegate*<vec4, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_sign");


            glmc_vec4_abs = (delegate*<vec4, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_abs");


            glmc_vec4_fract = (delegate*<vec4, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_fract");


            glmc_vec4_hadd = (delegate*<vec4, float>)NativeLibrary.GetExport(Handle, "glmc_vec4_hadd");


            glmc_vec4_sqrt = (delegate*<vec4, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_sqrt");


            glmc_ortho_lh_no = (delegate*<float, float, float, float, float, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_lh_no");


            glmc_ortho_aabb_lh_no = (delegate*<vec3*, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_aabb_lh_no");

            glmc_ortho_aabb_p_lh_no = (delegate*<vec3*, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_aabb_p_lh_no");

            glmc_ortho_aabb_pz_lh_no = (delegate*<vec3*, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_aabb_pz_lh_no");

            glmc_ortho_default_lh_no = (delegate*<float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_default_lh_no");

            glmc_ortho_default_s_lh_no = (delegate*<float, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_default_s_lh_no");


            glmc_ortho_lh_zo = (delegate*<float, float, float, float, float, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_lh_zo");


            glmc_ortho_aabb_lh_zo = (delegate*<vec3*, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_aabb_lh_zo");

            glmc_ortho_aabb_p_lh_zo = (delegate*<vec3*, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_aabb_p_lh_zo");

            glmc_ortho_aabb_pz_lh_zo = (delegate*<vec3*, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_aabb_pz_lh_zo");



            glmc_ortho_default_lh_zo = (delegate*<float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_default_lh_zo");


            glmc_ortho_default_s_lh_zo = (delegate*<float, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_default_s_lh_zo");


            glmc_ortho_rh_no = (delegate*<float, float, float, float, float, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_rh_no");




            glmc_ortho_aabb_rh_no = (delegate*<vec3*, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_aabb_rh_no");

            glmc_ortho_aabb_p_rh_no = (delegate*<vec3*, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_aabb_p_rh_no");

            glmc_ortho_aabb_pz_rh_no = (delegate*<vec3*, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_aabb_pz_rh_no");




            glmc_ortho_default_rh_no = (delegate*<float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_default_rh_no");


            glmc_ortho_default_s_rh_no = (delegate*<float, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_default_s_rh_no");


            glmc_ortho_rh_zo = (delegate*<float, float, float, float, float, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_rh_zo");



            glmc_ortho_aabb_rh_zo = (delegate*<vec3*, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_aabb_rh_zo");

            glmc_ortho_aabb_p_rh_zo = (delegate*<vec3*, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_aabb_p_rh_zo");

            glmc_ortho_aabb_pz_rh_zo = (delegate*<vec3*, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_aabb_pz_rh_zo");



            glmc_ortho_default_rh_zo = (delegate*<float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_default_rh_zo");


            glmc_ortho_default_s_rh_zo = (delegate*<float, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_default_s_rh_zo");


            glmc_frustum_lh_no = (delegate*<float, float, float, float, float, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_frustum_lh_no");


            glmc_perspective_lh_no = (delegate*<float, float, float, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_perspective_lh_no");


            glmc_persp_move_far_lh_no = (delegate*<mat4, float, void>)NativeLibrary.GetExport(Handle, "glmc_persp_move_far_lh_no");


            glmc_persp_decomp_lh_no = (delegate*<mat4, float*, float*, float*, float*, float*, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_lh_no");


            glmc_persp_decompv_lh_no = (delegate*<mat4, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decompv_lh_no");


            glmc_persp_decomp_x_lh_no = (delegate*<mat4, float*, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_x_lh_no");


            glmc_persp_decomp_y_lh_no = (delegate*<mat4, float*, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_y_lh_no");


            glmc_persp_decomp_z_lh_no = (delegate*<mat4, float*, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_z_lh_no");


            glmc_persp_decomp_far_lh_no = (delegate*<mat4, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_far_lh_no");


            glmc_persp_decomp_near_lh_no = (delegate*<mat4, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_near_lh_no");


            glmc_persp_sizes_lh_no = (delegate*<mat4, float, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_persp_sizes_lh_no");


            glmc_persp_fovy_lh_no = (delegate*<mat4, float>)NativeLibrary.GetExport(Handle, "glmc_persp_fovy_lh_no");


            glmc_persp_aspect_lh_no = (delegate*<mat4, float>)NativeLibrary.GetExport(Handle, "glmc_persp_aspect_lh_no");


            glmc_frustum_lh_zo = (delegate*<float, float, float, float, float, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_frustum_lh_zo");


            glmc_perspective_lh_zo = (delegate*<float, float, float, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_perspective_lh_zo");


            glmc_persp_move_far_lh_zo = (delegate*<mat4, float, void>)NativeLibrary.GetExport(Handle, "glmc_persp_move_far_lh_zo");


            glmc_persp_decomp_lh_zo = (delegate*<mat4, float*, float*, float*, float*, float*, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_lh_zo");


            glmc_persp_decompv_lh_zo = (delegate*<mat4, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decompv_lh_zo");


            glmc_persp_decomp_x_lh_zo = (delegate*<mat4, float*, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_x_lh_zo");


            glmc_persp_decomp_y_lh_zo = (delegate*<mat4, float*, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_y_lh_zo");


            glmc_persp_decomp_z_lh_zo = (delegate*<mat4, float*, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_z_lh_zo");


            glmc_persp_decomp_far_lh_zo = (delegate*<mat4, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_far_lh_zo");


            glmc_persp_decomp_near_lh_zo = (delegate*<mat4, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_near_lh_zo");


            glmc_persp_sizes_lh_zo = (delegate*<mat4, float, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_persp_sizes_lh_zo");


            glmc_persp_fovy_lh_zo = (delegate*<mat4, float>)NativeLibrary.GetExport(Handle, "glmc_persp_fovy_lh_zo");


            glmc_persp_aspect_lh_zo = (delegate*<mat4, float>)NativeLibrary.GetExport(Handle, "glmc_persp_aspect_lh_zo");


            glmc_frustum_rh_no = (delegate*<float, float, float, float, float, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_frustum_rh_no");


            glmc_perspective_rh_no = (delegate*<float, float, float, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_perspective_rh_no");


            glmc_persp_move_far_rh_no = (delegate*<mat4, float, void>)NativeLibrary.GetExport(Handle, "glmc_persp_move_far_rh_no");


            glmc_persp_decomp_rh_no = (delegate*<mat4, float*, float*, float*, float*, float*, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_rh_no");


            glmc_persp_decompv_rh_no = (delegate*<mat4, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decompv_rh_no");


            glmc_persp_decomp_x_rh_no = (delegate*<mat4, float*, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_x_rh_no");


            glmc_persp_decomp_y_rh_no = (delegate*<mat4, float*, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_y_rh_no");


            glmc_persp_decomp_z_rh_no = (delegate*<mat4, float*, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_z_rh_no");


            glmc_persp_decomp_far_rh_no = (delegate*<mat4, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_far_rh_no");


            glmc_persp_decomp_near_rh_no = (delegate*<mat4, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_near_rh_no");


            glmc_persp_sizes_rh_no = (delegate*<mat4, float, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_persp_sizes_rh_no");


            glmc_persp_fovy_rh_no = (delegate*<mat4, float>)NativeLibrary.GetExport(Handle, "glmc_persp_fovy_rh_no");


            glmc_persp_aspect_rh_no = (delegate*<mat4, float>)NativeLibrary.GetExport(Handle, "glmc_persp_aspect_rh_no");


            glmc_frustum_rh_zo = (delegate*<float, float, float, float, float, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_frustum_rh_zo");


            glmc_perspective_rh_zo = (delegate*<float, float, float, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_perspective_rh_zo");


            glmc_persp_move_far_rh_zo = (delegate*<mat4, float, void>)NativeLibrary.GetExport(Handle, "glmc_persp_move_far_rh_zo");


            glmc_persp_decomp_rh_zo = (delegate*<mat4, float*, float*, float*, float*, float*, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_rh_zo");


            glmc_persp_decompv_rh_zo = (delegate*<mat4, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decompv_rh_zo");


            glmc_persp_decomp_x_rh_zo = (delegate*<mat4, float*, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_x_rh_zo");


            glmc_persp_decomp_y_rh_zo = (delegate*<mat4, float*, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_y_rh_zo");


            glmc_persp_decomp_z_rh_zo = (delegate*<mat4, float*, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_z_rh_zo");


            glmc_persp_decomp_far_rh_zo = (delegate*<mat4, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_far_rh_zo");


            glmc_persp_decomp_near_rh_zo = (delegate*<mat4, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_near_rh_zo");


            glmc_persp_sizes_rh_zo = (delegate*<mat4, float, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_persp_sizes_rh_zo");


            glmc_persp_fovy_rh_zo = (delegate*<mat4, float>)NativeLibrary.GetExport(Handle, "glmc_persp_fovy_rh_zo");


            glmc_persp_aspect_rh_zo = (delegate*<mat4, float>)NativeLibrary.GetExport(Handle, "glmc_persp_aspect_rh_zo");


            //glmc_unprojecti_no = (delegate*<vec3, mat4, vec4, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_unprojecti_no");


            //glmc_project_no = (delegate*<vec3, mat4, vec4, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_project_no");


            //glmc_unprojecti_zo = (delegate*<vec3, mat4, vec4, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_unprojecti_zo");


            //glmc_project_zo = (delegate*<vec3, mat4, vec4, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_project_zo");


            glmc_lookat_lh_no = (delegate*<vec3, vec3, vec3, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_lookat_lh_no");


            glmc_look_lh_no = (delegate*<vec3, vec3, vec3, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_look_lh_no");


            glmc_look_anyup_lh_no = (delegate*<vec3, vec3, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_look_anyup_lh_no");


            glmc_lookat_lh_zo = (delegate*<vec3, vec3, vec3, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_lookat_lh_zo");


            glmc_look_lh_zo = (delegate*<vec3, vec3, vec3, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_look_lh_zo");


            glmc_look_anyup_lh_zo = (delegate*<vec3, vec3, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_look_anyup_lh_zo");


            glmc_lookat_rh_no = (delegate*<vec3, vec3, vec3, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_lookat_rh_no");


            glmc_look_rh_no = (delegate*<vec3, vec3, vec3, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_look_rh_no");


            glmc_look_anyup_rh_no = (delegate*<vec3, vec3, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_look_anyup_rh_no");


            glmc_lookat_rh_zo = (delegate*<vec3, vec3, vec3, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_lookat_rh_zo");


            glmc_look_rh_zo = (delegate*<vec3, vec3, vec3, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_look_rh_zo");


            glmc_look_anyup_rh_zo = (delegate*<vec3, vec3, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_look_anyup_rh_zo");
        }


        public static unsafe delegate*<mat4, vec3, void> glmc_translate_make; //(delegate*<mat4, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_translate_make");


        public static unsafe delegate*<mat4, vec3, mat4, void> glmc_translate_to; //(delegate*<mat4, vec3, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_translate_to");


        public static unsafe delegate*<mat4, vec3, void> glmc_translate; //(delegate*<mat4, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_translate");


        public static unsafe delegate*<mat4, float, void> glmc_translate_x; //(delegate*<mat4, float, void>)NativeLibrary.GetExport(Handle, "glmc_translate_x");


        public static unsafe delegate*<mat4, float, void> glmc_translate_y; //(delegate*<mat4, float, void>)NativeLibrary.GetExport(Handle, "glmc_translate_y");


        public static unsafe delegate*<mat4, float, void> glmc_translate_z; //(delegate*<mat4, float, void>)NativeLibrary.GetExport(Handle, "glmc_translate_z");


        public static unsafe delegate*<mat4, vec3, void> glmc_scale_make; //(delegate*<mat4, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_scale_make");


        public static unsafe delegate*<mat4, vec3, mat4, void> glmc_scale_to; //(delegate*<mat4, vec3, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_scale_to");


        public static unsafe delegate*<mat4, vec3, void> glmc_scale; //(delegate*<mat4, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_scale");


        public static unsafe delegate*<mat4, float, void> glmc_scale_uni; //(delegate*<mat4, float, void>)NativeLibrary.GetExport(Handle, "glmc_scale_uni");


        public static unsafe delegate*<mat4, float, mat4, void> glmc_rotate_x; //(delegate*<mat4, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_rotate_x");


        public static unsafe delegate*<mat4, float, mat4, void> glmc_rotate_y; //(delegate*<mat4, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_rotate_y");


        public static unsafe delegate*<mat4, float, mat4, void> glmc_rotate_z; //(delegate*<mat4, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_rotate_z");


        public static unsafe delegate*<mat4, float, vec3, void> glmc_rotate_make; //(delegate*<mat4, float, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_rotate_make");


        public static unsafe delegate*<mat4, float, vec3, void> glmc_rotate; //(delegate*<mat4, float, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_rotate");


        public static unsafe delegate*<mat4, vec3, float, vec3, void> glmc_rotate_at; //(delegate*<mat4, vec3, float, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_rotate_at");


        public static unsafe delegate*<mat4, vec3, float, vec3, void> glmc_rotate_atm; //(delegate*<mat4, vec3, float, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_rotate_atm");


        public static unsafe delegate*<mat4, vec3, void> glmc_decompose_scalev; //(delegate*<mat4, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_decompose_scalev");



        public static unsafe delegate*<mat4, Bool> glmc_uniscaled; //(delegate*<mat4, Bool>)NativeLibrary.GetExport(Handle, "glmc_uniscaled");


        public static unsafe delegate*<mat4, mat4, vec3, void> glmc_decompose_rs; //(delegate*<mat4, mat4, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_decompose_rs");


        public static unsafe delegate*<mat4, vec4, mat4, vec3, void> glmc_decompose; //(delegate*<mat4, vec4, mat4, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_decompose");


        public static unsafe delegate*<mat4, mat4, mat4, void> glmc_mul; //(delegate*<mat4, mat4, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_mul");


        public static unsafe delegate*<mat4, mat4, mat4, void> glmc_mul_rot; //(delegate*<mat4, mat4, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_mul_rot");


        public static unsafe delegate*<mat4, void> glmc_inv_tr; //(delegate*<mat4, void>)NativeLibrary.GetExport(Handle, "glmc_inv_tr");


        public static unsafe delegate*<mat3, vec2, void> glmc_translate2d_make; //(delegate*<mat3, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_translate2d_make");


        public static unsafe delegate*<mat3, vec2, mat3, void> glmc_translate2d_to; //(delegate*<mat3, vec2, mat3, void>)NativeLibrary.GetExport(Handle, "glmc_translate2d_to");


        public static unsafe delegate*<mat3, vec2, void> glmc_translate2d; //(delegate*<mat3, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_translate2d");


        public static unsafe delegate*<mat3, float, void> glmc_translate2d_x; //(delegate*<mat3, float, void>)NativeLibrary.GetExport(Handle, "glmc_translate2d_x");


        public static unsafe delegate*<mat3, float, void> glmc_translate2d_y; //(delegate*<mat3, float, void>)NativeLibrary.GetExport(Handle, "glmc_translate2d_y");


        public static unsafe delegate*<mat3, vec2, mat3, void> glmc_scale2d_to; //(delegate*<mat3, vec2, mat3, void>)NativeLibrary.GetExport(Handle, "glmc_scale2d_to");


        public static unsafe delegate*<mat3, vec2, void> glmc_scale2d_make; //(delegate*<mat3, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_scale2d_make");


        public static unsafe delegate*<mat3, vec2, void> glmc_scale2d; //(delegate*<mat3, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_scale2d");


        public static unsafe delegate*<mat3, float, void> glmc_scale2d_uni; //(delegate*<mat3, float, void>)NativeLibrary.GetExport(Handle, "glmc_scale2d_uni");


        public static unsafe delegate*<mat3, float, void> glmc_rotate2d_make; //(delegate*<mat3, float, void>)NativeLibrary.GetExport(Handle, "glmc_rotate2d_make");


        public static unsafe delegate*<mat3, float, void> glmc_rotate2d; //(delegate*<mat3, float, void>)NativeLibrary.GetExport(Handle, "glmc_rotate2d");


        public static unsafe delegate*<mat3, float, mat3, void> glmc_rotate2d_to; //(delegate*<mat3, float, mat3, void>)NativeLibrary.GetExport(Handle, "glmc_rotate2d_to");


        public static unsafe delegate*<float, float, float, float, float, float> glmc_bezier; //(delegate*<float, float, float, float, float, float>)NativeLibrary.GetExport(Handle, "glmc_bezier");


        public static unsafe delegate*<float, float, float, float, float, float> glmc_hermite; //(delegate*<float, float, float, float, float, float>)NativeLibrary.GetExport(Handle, "glmc_hermite");


        public static unsafe delegate*<float, float, float, float, float, float> glmc_decasteljau; //(delegate*<float, float, float, float, float, float>)NativeLibrary.GetExport(Handle, "glmc_decasteljau");



        public static unsafe delegate*<vec3*, mat4, vec3*, void> glmc_aabb_transform;
        public static unsafe delegate*<vec3*, vec3*, vec3*, void> glmc_aabb_merge;
        public static unsafe delegate*<vec3*, vec3*, vec3*, void> glmc_aabb_crop;
        public static unsafe delegate*<vec3*, vec3*, vec3*, vec3*, void> glmc_aabb_crop_until;
        public static unsafe delegate*<vec3*, vec4*, bool> glmc_aabb_frustum;
        public static unsafe delegate*<vec3*, void> glmc_aabb_invalidate;
        public static unsafe delegate*<vec3*, Bool> glmc_aabb_isvalid;
        public static unsafe delegate*<vec3*, float> glmc_aabb_size;
        public static unsafe delegate*<vec3*, float> glmc_aabb_radius;
        public static unsafe delegate*<vec3*, vec3, void> glmc_aabb_center;
        public static unsafe delegate*<vec3*, vec3*, Bool> glmc_aabb_aabb;
        public static unsafe delegate*<vec3*, vec3, Bool> glmc_aabb_point;
        public static unsafe delegate*<vec3*, vec3*, Bool> glmc_aabb_contains;
        public static unsafe delegate*<vec3*, vec4, Bool> glmc_aabb_sphere;



        public static unsafe delegate*<float, float, float, float, float, float, mat4, void> glmc_frustum; //(delegate*<float, float, float, float, float, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_frustum");


        public static unsafe delegate*<float, float, float, float, float, float, mat4, void> glmc_ortho; //(delegate*<float, float, float, float, float, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho");


        public static unsafe delegate*<vec3*, mat4, void> glmc_ortho_aabb; //(delegate*<vec3*, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_aabb");


        public static unsafe delegate*<vec3*, float, mat4, void> glmc_ortho_aabb_p; //(delegate*<vec3*, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_aabb_p");


        public static unsafe delegate*<vec3*, float, mat4, void> glmc_ortho_aabb_pz; //(delegate*<vec3*, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_aabb_pz");


        public static unsafe delegate*<float, mat4, void> glmc_ortho_default; //(delegate*<float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_default");


        public static unsafe delegate*<float, float, mat4, void> glmc_ortho_default_s; //(delegate*<float, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_default_s");


        public static unsafe delegate*<float, float, float, float, mat4, void> glmc_perspective; //(delegate*<float, float, float, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_perspective");


        public static unsafe delegate*<mat4, float, void> glmc_persp_move_far; //(delegate*<mat4, float, void>)NativeLibrary.GetExport(Handle, "glmc_persp_move_far");


        public static unsafe delegate*<float, mat4, void> glmc_perspective_default; //(delegate*<float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_perspective_default");


        public static unsafe delegate*<float, mat4, void> glmc_perspective_resize; //(delegate*<float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_perspective_resize");


        public static unsafe delegate*<vec3, vec3, vec3, mat4, void> glmc_lookat; //(delegate*<vec3, vec3, vec3, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_lookat");


        public static unsafe delegate*<vec3, vec3, vec3, mat4, void> glmc_look; //(delegate*<vec3, vec3, vec3, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_look");


        public static unsafe delegate*<vec3, vec3, mat4, void> glmc_look_anyup; //(delegate*<vec3, vec3, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_look_anyup");


        public static unsafe delegate*<mat4, float*, float*, float*, float*, float*, float*, void> glmc_persp_decomp; //(delegate*<mat4, float*, float*, float*, float*, float*, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp");


        public static unsafe delegate*<mat4, float*, void> glmc_persp_decompv; //(delegate*<mat4, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decompv");


        public static unsafe delegate*<mat4, float*, float*, void> glmc_persp_decomp_x; //(delegate*<mat4, float*, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_x");


        public static unsafe delegate*<mat4, float*, float*, void> glmc_persp_decomp_y; //(delegate*<mat4, float*, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_y");


        public static unsafe delegate*<mat4, float*, float*, void> glmc_persp_decomp_z; //(delegate*<mat4, float*, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_z");


        public static unsafe delegate*<mat4, float*, void> glmc_persp_decomp_far; //(delegate*<mat4, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_far");


        public static unsafe delegate*<mat4, float*, void> glmc_persp_decomp_near; //(delegate*<mat4, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_near");


        public static unsafe delegate*<mat4, float> glmc_persp_fovy; //(delegate*<mat4, float>)NativeLibrary.GetExport(Handle, "glmc_persp_fovy");


        public static unsafe delegate*<mat4, float> glmc_persp_aspect; //(delegate*<mat4, float>)NativeLibrary.GetExport(Handle, "glmc_persp_aspect");


        public static unsafe delegate*<mat4, float, vec4, void> glmc_persp_sizes; //(delegate*<mat4, float, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_persp_sizes");


        public static unsafe delegate*<float, mat4, vec4, float> glmc_smc; //(delegate*<float, mat4, vec4, float>)NativeLibrary.GetExport(Handle, "glmc_smc");


        public static unsafe delegate*<float, float> glmc_ease_linear; //(delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_linear");


        public static unsafe delegate*<float, float> glmc_ease_sine_in; //(delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_sine_in");


        public static unsafe delegate*<float, float> glmc_ease_sine_out; //(delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_sine_out");


        public static unsafe delegate*<float, float> glmc_ease_sine_inout; //(delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_sine_inout");


        public static unsafe delegate*<float, float> glmc_ease_quad_in; //(delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_quad_in");


        public static unsafe delegate*<float, float> glmc_ease_quad_out; //(delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_quad_out");


        public static unsafe delegate*<float, float> glmc_ease_quad_inout; //(delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_quad_inout");


        public static unsafe delegate*<float, float> glmc_ease_cubic_in; //(delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_cubic_in");


        public static unsafe delegate*<float, float> glmc_ease_cubic_out; //(delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_cubic_out");


        public static unsafe delegate*<float, float> glmc_ease_cubic_inout; //(delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_cubic_inout");


        public static unsafe delegate*<float, float> glmc_ease_quart_in; //(delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_quart_in");


        public static unsafe delegate*<float, float> glmc_ease_quart_out; //(delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_quart_out");


        public static unsafe delegate*<float, float> glmc_ease_quart_inout; //(delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_quart_inout");


        public static unsafe delegate*<float, float> glmc_ease_quint_in; //(delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_quint_in");


        public static unsafe delegate*<float, float> glmc_ease_quint_out; //(delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_quint_out");


        public static unsafe delegate*<float, float> glmc_ease_quint_inout; //(delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_quint_inout");


        public static unsafe delegate*<float, float> glmc_ease_exp_in; //(delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_exp_in");


        public static unsafe delegate*<float, float> glmc_ease_exp_out; //(delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_exp_out");


        public static unsafe delegate*<float, float> glmc_ease_exp_inout; //(delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_exp_inout");


        public static unsafe delegate*<float, float> glmc_ease_circ_in; //(delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_circ_in");


        public static unsafe delegate*<float, float> glmc_ease_circ_out; //(delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_circ_out");


        public static unsafe delegate*<float, float> glmc_ease_circ_inout; //(delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_circ_inout");


        public static unsafe delegate*<float, float> glmc_ease_back_in; //(delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_back_in");


        public static unsafe delegate*<float, float> glmc_ease_back_out; //(delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_back_out");


        public static unsafe delegate*<float, float> glmc_ease_back_inout; //(delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_back_inout");


        public static unsafe delegate*<float, float> glmc_ease_elast_in; //(delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_elast_in");


        public static unsafe delegate*<float, float> glmc_ease_elast_out; //(delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_elast_out");


        public static unsafe delegate*<float, float> glmc_ease_elast_inout; //(delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_elast_inout");


        public static unsafe delegate*<float, float> glmc_ease_bounce_out; //(delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_bounce_out");


        public static unsafe delegate*<float, float> glmc_ease_bounce_in; //(delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_bounce_in");


        public static unsafe delegate*<float, float> glmc_ease_bounce_inout; //(delegate*<float, float>)NativeLibrary.GetExport(Handle, "glmc_ease_bounce_inout");


        public static unsafe delegate*<mat4, vec3, void> glmc_euler_angles; //(delegate*<mat4, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_euler_angles");


        public static unsafe delegate*<vec3, mat4, void> glmc_euler; //(delegate*<vec3, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_euler");


        public static unsafe delegate*<vec3, mat4, void> glmc_euler_xyz; //(delegate*<vec3, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_euler_xyz");


        public static unsafe delegate*<vec3, mat4, void> glmc_euler_zyx; //(delegate*<vec3, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_euler_zyx");


        public static unsafe delegate*<vec3, mat4, void> glmc_euler_zxy; //(delegate*<vec3, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_euler_zxy");


        public static unsafe delegate*<vec3, mat4, void> glmc_euler_xzy; //(delegate*<vec3, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_euler_xzy");


        public static unsafe delegate*<vec3, mat4, void> glmc_euler_yzx; //(delegate*<vec3, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_euler_yzx");


        public static unsafe delegate*<vec3, mat4, void> glmc_euler_yxz; //(delegate*<vec3, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_euler_yxz");


        public static unsafe delegate*<vec3, glm_euler_seq, mat4, void> glmc_euler_by_order; //(delegate*<vec3, glm_euler_seq, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_euler_by_order");


        public static unsafe delegate*<mat4, vec4*, void> glmc_frustum_planes;
        public static unsafe delegate*<mat4, vec4*, void> glmc_frustum_corners;
        public static unsafe delegate*<vec4*, vec4, void> glmc_frustum_center;
        public static unsafe delegate*<vec4*, mat4, vec3*, void> glmc_frustum_box;
        public static unsafe delegate*<vec4*, float, float, vec4*, void> glmc_frustum_corners_at;


        public static unsafe delegate*<mat4, _iobuf*, void> glmc_mat4_print; //(delegate*<mat4, _iobuf*, void>)NativeLibrary.GetExport(Handle, "glmc_mat4_print");



        public static unsafe delegate*<mat3, _iobuf*, void> glmc_mat3_print; //(delegate*<mat3, _iobuf*, void>)NativeLibrary.GetExport(Handle, "glmc_mat3_print");


        public static unsafe delegate*<vec4, _iobuf*, void> glmc_vec4_print; //(delegate*<vec4, _iobuf*, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_print");


        public static unsafe delegate*<vec3, _iobuf*, void> glmc_vec3_print; //(delegate*<vec3, _iobuf*, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_print");


        public static unsafe delegate*<versor, _iobuf*, void> glmc_versor_print; //(delegate*<versor, _iobuf*, void>)NativeLibrary.GetExport(Handle, "glmc_versor_print");


        public static unsafe delegate*<mat2, mat2, void> glmc_mat2_copy; //(delegate*<mat2, mat2, void>)NativeLibrary.GetExport(Handle, "glmc_mat2_copy");


        public static unsafe delegate*<mat2, void> glmc_mat2_identity; //(delegate*<mat2, void>)NativeLibrary.GetExport(Handle, "glmc_mat2_identity");


        public static unsafe delegate*<mat2*, nuint, void> glmc_mat2_identity_array; //(delegate*<mat2*, nuint, void>)NativeLibrary.GetExport(Handle, "glmc_mat2_identity_array");



        public static unsafe delegate*<mat2, void> glmc_mat2_zero; //(delegate*<mat2, void>)NativeLibrary.GetExport(Handle, "glmc_mat2_zero");


        public static unsafe delegate*<mat2, mat2, mat2, void> glmc_mat2_mul; //(delegate*<mat2, mat2, mat2, void>)NativeLibrary.GetExport(Handle, "glmc_mat2_mul");


        public static unsafe delegate*<mat2, mat2, void> glmc_mat2_transpose_to; //(delegate*<mat2, mat2, void>)NativeLibrary.GetExport(Handle, "glmc_mat2_transpose_to");


        public static unsafe delegate*<mat2, void> glmc_mat2_transpose; //(delegate*<mat2, void>)NativeLibrary.GetExport(Handle, "glmc_mat2_transpose");


        public static unsafe delegate*<mat2, vec2, vec2, void> glmc_mat2_mulv; //(delegate*<mat2, vec2, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_mat2_mulv");


        public static unsafe delegate*<mat2, float> glmc_mat2_trace; //(delegate*<mat2, float>)NativeLibrary.GetExport(Handle, "glmc_mat2_trace");


        public static unsafe delegate*<mat2, float, void> glmc_mat2_scale; //(delegate*<mat2, float, void>)NativeLibrary.GetExport(Handle, "glmc_mat2_scale");


        public static unsafe delegate*<mat2, float> glmc_mat2_det; //(delegate*<mat2, float>)NativeLibrary.GetExport(Handle, "glmc_mat2_det");


        public static unsafe delegate*<mat2, mat2, void> glmc_mat2_inv; //(delegate*<mat2, mat2, void>)NativeLibrary.GetExport(Handle, "glmc_mat2_inv");


        public static unsafe delegate*<mat2, int, int, void> glmc_mat2_swap_col; //(delegate*<mat2, int, int, void>)NativeLibrary.GetExport(Handle, "glmc_mat2_swap_col");


        public static unsafe delegate*<mat2, int, int, void> glmc_mat2_swap_row; //(delegate*<mat2, int, int, void>)NativeLibrary.GetExport(Handle, "glmc_mat2_swap_row");


        public static unsafe delegate*<vec2, mat2, vec2, float> glmc_mat2_rmc; //(delegate*<vec2, mat2, vec2, float>)NativeLibrary.GetExport(Handle, "glmc_mat2_rmc");


        public static unsafe delegate*<mat3, mat3, void> glmc_mat3_copy; //(delegate*<mat3, mat3, void>)NativeLibrary.GetExport(Handle, "glmc_mat3_copy");


        public static unsafe delegate*<mat3, void> glmc_mat3_identity; //(delegate*<mat3, void>)NativeLibrary.GetExport(Handle, "glmc_mat3_identity");


        public static unsafe delegate*<mat3, void> glmc_mat3_zero; //(delegate*<mat3, void>)NativeLibrary.GetExport(Handle, "glmc_mat3_zero");


        public static unsafe delegate*<mat3*, nuint, void> glmc_mat3_identity_array; //(delegate*<mat3*, nuint, void>)NativeLibrary.GetExport(Handle, "glmc_mat3_identity_array");


        public static unsafe delegate*<mat3, mat3, mat3, void> glmc_mat3_mul; //(delegate*<mat3, mat3, mat3, void>)NativeLibrary.GetExport(Handle, "glmc_mat3_mul");


        public static unsafe delegate*<mat3, mat3, void> glmc_mat3_transpose_to; //(delegate*<mat3, mat3, void>)NativeLibrary.GetExport(Handle, "glmc_mat3_transpose_to");


        public static unsafe delegate*<mat3, void> glmc_mat3_transpose; //(delegate*<mat3, void>)NativeLibrary.GetExport(Handle, "glmc_mat3_transpose");


        public static unsafe delegate*<mat3, vec3, vec3, void> glmc_mat3_mulv; //(delegate*<mat3, vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_mat3_mulv");


        public static unsafe delegate*<mat3, float> glmc_mat3_trace; //(delegate*<mat3, float>)NativeLibrary.GetExport(Handle, "glmc_mat3_trace");


        public static unsafe delegate*<mat3, versor, void> glmc_mat3_quat; //(delegate*<mat3, versor, void>)NativeLibrary.GetExport(Handle, "glmc_mat3_quat");


        public static unsafe delegate*<mat3, float, void> glmc_mat3_scale; //(delegate*<mat3, float, void>)NativeLibrary.GetExport(Handle, "glmc_mat3_scale");


        public static unsafe delegate*<mat3, float> glmc_mat3_det; //(delegate*<mat3, float>)NativeLibrary.GetExport(Handle, "glmc_mat3_det");


        public static unsafe delegate*<mat3, mat3, void> glmc_mat3_inv; //(delegate*<mat3, mat3, void>)NativeLibrary.GetExport(Handle, "glmc_mat3_inv");


        public static unsafe delegate*<mat3, int, int, void> glmc_mat3_swap_col; //(delegate*<mat3, int, int, void>)NativeLibrary.GetExport(Handle, "glmc_mat3_swap_col");


        public static unsafe delegate*<mat3, int, int, void> glmc_mat3_swap_row; //(delegate*<mat3, int, int, void>)NativeLibrary.GetExport(Handle, "glmc_mat3_swap_row");


        public static unsafe delegate*<vec3, mat3, vec3, float> glmc_mat3_rmc; //(delegate*<vec3, mat3, vec3, float>)NativeLibrary.GetExport(Handle, "glmc_mat3_rmc");


        public static unsafe delegate*<mat4, mat4, void> glmc_mat4_ucopy; //(delegate*<mat4, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_mat4_ucopy");


        public static unsafe delegate*<mat4, mat4, void> glmc_mat4_copy; //(delegate*<mat4, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_mat4_copy");


        public static unsafe delegate*<mat4, void> glmc_mat4_identity; //(delegate*<mat4, void>)NativeLibrary.GetExport(Handle, "glmc_mat4_identity");


        public static unsafe delegate*<mat4*, nuint, void> glmc_mat4_identity_array; //(delegate*<mat4*, nuint, void>)NativeLibrary.GetExport(Handle, "glmc_mat4_identity_array");


        public static unsafe delegate*<mat4, void> glmc_mat4_zero; //(delegate*<mat4, void>)NativeLibrary.GetExport(Handle, "glmc_mat4_zero");


        public static unsafe delegate*<mat4, mat3, void> glmc_mat4_pick3; //(delegate*<mat4, mat3, void>)NativeLibrary.GetExport(Handle, "glmc_mat4_pick3");


        public static unsafe delegate*<mat4, mat3, void> glmc_mat4_pick3t; //(delegate*<mat4, mat3, void>)NativeLibrary.GetExport(Handle, "glmc_mat4_pick3t");


        public static unsafe delegate*<mat3, mat4, void> glmc_mat4_ins3; //(delegate*<mat3, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_mat4_ins3");


        public static unsafe delegate*<mat4, mat4, mat4, void> glmc_mat4_mul; //(delegate*<mat4, mat4, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_mat4_mul");


        public static unsafe delegate*<void> glmc_mat4_mulN; //(delegate*<void>)NativeLibrary.GetExport(Handle, "glmc_mat4_mulN");


        public static unsafe delegate*<mat4, vec4, vec4, void> glmc_mat4_mulv; //(delegate*<mat4, vec4, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_mat4_mulv");


        public static unsafe delegate*<mat4, vec3, float, vec3, void> glmc_mat4_mulv3; //(delegate*<mat4, vec3, float, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_mat4_mulv3");


        public static unsafe delegate*<mat4, float> glmc_mat4_trace; //(delegate*<mat4, float>)NativeLibrary.GetExport(Handle, "glmc_mat4_trace");


        public static unsafe delegate*<mat4, float> glmc_mat4_trace3; //(delegate*<mat4, float>)NativeLibrary.GetExport(Handle, "glmc_mat4_trace3");


        public static unsafe delegate*<mat4, versor, void> glmc_mat4_quat; //(delegate*<mat4, versor, void>)NativeLibrary.GetExport(Handle, "glmc_mat4_quat");


        public static unsafe delegate*<mat4, mat4, void> glmc_mat4_transpose_to; //(delegate*<mat4, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_mat4_transpose_to");


        public static unsafe delegate*<mat4, void> glmc_mat4_transpose; //(delegate*<mat4, void>)NativeLibrary.GetExport(Handle, "glmc_mat4_transpose");


        public static unsafe delegate*<mat4, float, void> glmc_mat4_scale_p; //(delegate*<mat4, float, void>)NativeLibrary.GetExport(Handle, "glmc_mat4_scale_p");


        public static unsafe delegate*<mat4, float, void> glmc_mat4_scale; //(delegate*<mat4, float, void>)NativeLibrary.GetExport(Handle, "glmc_mat4_scale");


        public static unsafe delegate*<mat4, float> glmc_mat4_det; //(delegate*<mat4, float>)NativeLibrary.GetExport(Handle, "glmc_mat4_det");


        public static unsafe delegate*<mat4, mat4, void> glmc_mat4_inv; //(delegate*<mat4, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_mat4_inv");


        public static unsafe delegate*<mat4, mat4, void> glmc_mat4_inv_precise; //(delegate*<mat4, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_mat4_inv_precise");


        public static unsafe delegate*<mat4, mat4, void> glmc_mat4_inv_fast; //(delegate*<mat4, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_mat4_inv_fast");


        public static unsafe delegate*<mat4, int, int, void> glmc_mat4_swap_col; //(delegate*<mat4, int, int, void>)NativeLibrary.GetExport(Handle, "glmc_mat4_swap_col");


        public static unsafe delegate*<mat4, int, int, void> glmc_mat4_swap_row; //(delegate*<mat4, int, int, void>)NativeLibrary.GetExport(Handle, "glmc_mat4_swap_row");


        public static unsafe delegate*<vec4, mat4, vec4, float> glmc_mat4_rmc; //(delegate*<vec4, mat4, vec4, float>)NativeLibrary.GetExport(Handle, "glmc_mat4_rmc");


        public static unsafe delegate*<vec4, void> glmc_plane_normalize; //(delegate*<vec4, void>)NativeLibrary.GetExport(Handle, "glmc_plane_normalize");


        public static unsafe delegate*<vec3, mat4, vec4, vec3, void> glmc_unprojecti; //(delegate*<vec3, mat4, vec4, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_unprojecti");


        public static unsafe delegate*<vec3, mat4, vec4, vec3, void> glmc_unproject; //(delegate*<vec3, mat4, vec4, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_unproject");


        public static unsafe delegate*<vec3, mat4, vec4, vec3, void> glmc_project; //(delegate*<vec3, mat4, vec4, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_project");


        public static unsafe delegate*<vec2, vec2, vec4, mat4, void> glmc_pickmatrix; //(delegate*<vec2, vec2, vec4, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_pickmatrix");


        public static unsafe delegate*<versor, void> glmc_quat_identity; //(delegate*<versor, void>)NativeLibrary.GetExport(Handle, "glmc_quat_identity");


        public static unsafe delegate*<versor*, nuint, void> glmc_quat_identity_array; //(delegate*<versor*, nuint, void>)NativeLibrary.GetExport(Handle, "glmc_quat_identity_array");


        public static unsafe delegate*<versor, float, float, float, float, void> glmc_quat_init; //(delegate*<versor, float, float, float, float, void>)NativeLibrary.GetExport(Handle, "glmc_quat_init");


        public static unsafe delegate*<versor, float, float, float, float, void> glmc_quat; //(delegate*<versor, float, float, float, float, void>)NativeLibrary.GetExport(Handle, "glmc_quat");


        public static unsafe delegate*<versor, float, vec3, void> glmc_quatv; //(delegate*<versor, float, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_quatv");


        public static unsafe delegate*<versor, versor, void> glmc_quat_copy; //(delegate*<versor, versor, void>)NativeLibrary.GetExport(Handle, "glmc_quat_copy");


        public static unsafe delegate*<vec3, vec3, versor, void> glmc_quat_from_vecs; //(delegate*<vec3, vec3, versor, void>)NativeLibrary.GetExport(Handle, "glmc_quat_from_vecs");


        public static unsafe delegate*<versor, float> glmc_quat_norm; //(delegate*<versor, float>)NativeLibrary.GetExport(Handle, "glmc_quat_norm");


        public static unsafe delegate*<versor, versor, void> glmc_quat_normalize_to; //(delegate*<versor, versor, void>)NativeLibrary.GetExport(Handle, "glmc_quat_normalize_to");


        public static unsafe delegate*<versor, void> glmc_quat_normalize; //(delegate*<versor, void>)NativeLibrary.GetExport(Handle, "glmc_quat_normalize");


        public static unsafe delegate*<versor, versor, float> glmc_quat_dot; //(delegate*<versor, versor, float>)NativeLibrary.GetExport(Handle, "glmc_quat_dot");


        public static unsafe delegate*<versor, versor, void> glmc_quat_conjugate; //(delegate*<versor, versor, void>)NativeLibrary.GetExport(Handle, "glmc_quat_conjugate");


        public static unsafe delegate*<versor, versor, void> glmc_quat_inv; //(delegate*<versor, versor, void>)NativeLibrary.GetExport(Handle, "glmc_quat_inv");


        public static unsafe delegate*<versor, versor, versor, void> glmc_quat_add; //(delegate*<versor, versor, versor, void>)NativeLibrary.GetExport(Handle, "glmc_quat_add");


        public static unsafe delegate*<versor, versor, versor, void> glmc_quat_sub; //(delegate*<versor, versor, versor, void>)NativeLibrary.GetExport(Handle, "glmc_quat_sub");


        public static unsafe delegate*<versor, float> glmc_quat_real; //(delegate*<versor, float>)NativeLibrary.GetExport(Handle, "glmc_quat_real");


        public static unsafe delegate*<versor, vec3, void> glmc_quat_imag; //(delegate*<versor, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_quat_imag");


        public static unsafe delegate*<versor, vec3, void> glmc_quat_imagn; //(delegate*<versor, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_quat_imagn");


        public static unsafe delegate*<versor, float> glmc_quat_imaglen; //(delegate*<versor, float>)NativeLibrary.GetExport(Handle, "glmc_quat_imaglen");


        public static unsafe delegate*<versor, float> glmc_quat_angle; //(delegate*<versor, float>)NativeLibrary.GetExport(Handle, "glmc_quat_angle");


        public static unsafe delegate*<versor, vec3, void> glmc_quat_axis; //(delegate*<versor, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_quat_axis");


        public static unsafe delegate*<versor, versor, versor, void> glmc_quat_mul; //(delegate*<versor, versor, versor, void>)NativeLibrary.GetExport(Handle, "glmc_quat_mul");


        public static unsafe delegate*<versor, mat4, void> glmc_quat_mat4; //(delegate*<versor, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_quat_mat4");


        public static unsafe delegate*<versor, mat4, void> glmc_quat_mat4t; //(delegate*<versor, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_quat_mat4t");


        public static unsafe delegate*<versor, mat3, void> glmc_quat_mat3; //(delegate*<versor, mat3, void>)NativeLibrary.GetExport(Handle, "glmc_quat_mat3");


        public static unsafe delegate*<versor, mat3, void> glmc_quat_mat3t; //(delegate*<versor, mat3, void>)NativeLibrary.GetExport(Handle, "glmc_quat_mat3t");


        public static unsafe delegate*<versor, versor, float, versor, void> glmc_quat_lerp; //(delegate*<versor, versor, float, versor, void>)NativeLibrary.GetExport(Handle, "glmc_quat_lerp");


        public static unsafe delegate*<versor, versor, float, versor, void> glmc_quat_lerpc; //(delegate*<versor, versor, float, versor, void>)NativeLibrary.GetExport(Handle, "glmc_quat_lerpc");


        public static unsafe delegate*<versor, versor, float, versor, void> glmc_quat_nlerp; //(delegate*<versor, versor, float, versor, void>)NativeLibrary.GetExport(Handle, "glmc_quat_nlerp");


        public static unsafe delegate*<versor, versor, float, versor, void> glmc_quat_slerp; //(delegate*<versor, versor, float, versor, void>)NativeLibrary.GetExport(Handle, "glmc_quat_slerp");


        public static unsafe delegate*<vec3, versor, mat4, void> glmc_quat_look; //(delegate*<vec3, versor, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_quat_look");


        public static unsafe delegate*<vec3, vec3, versor, void> glmc_quat_for; //(delegate*<vec3, vec3, versor, void>)NativeLibrary.GetExport(Handle, "glmc_quat_for");


        public static unsafe delegate*<vec3, vec3, vec3, versor, void> glmc_quat_forp; //(delegate*<vec3, vec3, vec3, versor, void>)NativeLibrary.GetExport(Handle, "glmc_quat_forp");


        public static unsafe delegate*<versor, vec3, vec3, void> glmc_quat_rotatev; //(delegate*<versor, vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_quat_rotatev");


        public static unsafe delegate*<mat4, versor, mat4, void> glmc_quat_rotate; //(delegate*<mat4, versor, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_quat_rotate");


        public static unsafe delegate*<mat4, versor, vec3, void> glmc_quat_rotate_at; //(delegate*<mat4, versor, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_quat_rotate_at");


        public static unsafe delegate*<mat4, versor, vec3, void> glmc_quat_rotate_atm; //(delegate*<mat4, versor, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_quat_rotate_atm");



        public static unsafe delegate*<vec3, vec3, vec3, vec3, vec3, float*, Bool> glmc_ray_triangle; //(delegate*<vec3, vec3, vec3, vec3, vec3, float*, Bool>)NativeLibrary.GetExport(Handle, "glmc_ray_triangle");


        public static unsafe delegate*<vec4, float> glmc_sphere_radii; //(delegate*<vec4, float>)NativeLibrary.GetExport(Handle, "glmc_sphere_radii");


        public static unsafe delegate*<vec4, mat4, vec4, void> glmc_sphere_transform; //(delegate*<vec4, mat4, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_sphere_transform");


        public static unsafe delegate*<vec4, vec4, vec4, void> glmc_sphere_merge; //(delegate*<vec4, vec4, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_sphere_merge");



        public static unsafe delegate*<vec4, vec4, Bool> glmc_sphere_sphere; //(delegate*<vec4, vec4, Bool>)NativeLibrary.GetExport(Handle, "glmc_sphere_sphere");



        public static unsafe delegate*<vec4, vec3, Bool> glmc_sphere_point; //(delegate*<vec4, vec3, Bool>)NativeLibrary.GetExport(Handle, "glmc_sphere_point");


        public static unsafe delegate*<float*, vec2, void> glmc_vec2; //(delegate*<float*, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_vec2");


        public static unsafe delegate*<vec2, vec2, void> glmc_vec2_copy; //(delegate*<vec2, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_vec2_copy");


        public static unsafe delegate*<vec2, void> glmc_vec2_zero; //(delegate*<vec2, void>)NativeLibrary.GetExport(Handle, "glmc_vec2_zero");


        public static unsafe delegate*<vec2, void> glmc_vec2_one; //(delegate*<vec2, void>)NativeLibrary.GetExport(Handle, "glmc_vec2_one");


        public static unsafe delegate*<vec2, vec2, float> glmc_vec2_dot; //(delegate*<vec2, vec2, float>)NativeLibrary.GetExport(Handle, "glmc_vec2_dot");


        public static unsafe delegate*<vec2, vec2, float> glmc_vec2_cross; //(delegate*<vec2, vec2, float>)NativeLibrary.GetExport(Handle, "glmc_vec2_cross");


        public static unsafe delegate*<vec2, float> glmc_vec2_norm2; //(delegate*<vec2, float>)NativeLibrary.GetExport(Handle, "glmc_vec2_norm2");


        public static unsafe delegate*<vec2, float> glmc_vec2_norm; //(delegate*<vec2, float>)NativeLibrary.GetExport(Handle, "glmc_vec2_norm");


        public static unsafe delegate*<vec2, vec2, vec2, void> glmc_vec2_add; //(delegate*<vec2, vec2, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_vec2_add");


        public static unsafe delegate*<vec2, float, vec2, void> glmc_vec2_adds; //(delegate*<vec2, float, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_vec2_adds");


        public static unsafe delegate*<vec2, vec2, vec2, void> glmc_vec2_sub; //(delegate*<vec2, vec2, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_vec2_sub");


        public static unsafe delegate*<vec2, float, vec2, void> glmc_vec2_subs; //(delegate*<vec2, float, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_vec2_subs");


        public static unsafe delegate*<vec2, vec2, vec2, void> glmc_vec2_mul; //(delegate*<vec2, vec2, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_vec2_mul");


        public static unsafe delegate*<vec2, float, vec2, void> glmc_vec2_scale; //(delegate*<vec2, float, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_vec2_scale");


        public static unsafe delegate*<vec2, float, vec2, void> glmc_vec2_scale_as; //(delegate*<vec2, float, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_vec2_scale_as");


        public static unsafe delegate*<vec2, vec2, vec2, void> glmc_vec2_div; //(delegate*<vec2, vec2, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_vec2_div");


        public static unsafe delegate*<vec2, float, vec2, void> glmc_vec2_divs; //(delegate*<vec2, float, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_vec2_divs");


        public static unsafe delegate*<vec2, vec2, vec2, void> glmc_vec2_addadd; //(delegate*<vec2, vec2, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_vec2_addadd");


        public static unsafe delegate*<vec2, vec2, vec2, void> glmc_vec2_subadd; //(delegate*<vec2, vec2, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_vec2_subadd");


        public static unsafe delegate*<vec2, vec2, vec2, void> glmc_vec2_muladd; //(delegate*<vec2, vec2, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_vec2_muladd");


        public static unsafe delegate*<vec2, float, vec2, void> glmc_vec2_muladds; //(delegate*<vec2, float, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_vec2_muladds");


        public static unsafe delegate*<vec2, vec2, vec2, void> glmc_vec2_maxadd; //(delegate*<vec2, vec2, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_vec2_maxadd");


        public static unsafe delegate*<vec2, vec2, vec2, void> glmc_vec2_minadd; //(delegate*<vec2, vec2, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_vec2_minadd");


        public static unsafe delegate*<vec2, vec2, void> glmc_vec2_negate_to; //(delegate*<vec2, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_vec2_negate_to");


        public static unsafe delegate*<vec2, void> glmc_vec2_negate; //(delegate*<vec2, void>)NativeLibrary.GetExport(Handle, "glmc_vec2_negate");


        public static unsafe delegate*<vec2, void> glmc_vec2_normalize; //(delegate*<vec2, void>)NativeLibrary.GetExport(Handle, "glmc_vec2_normalize");


        public static unsafe delegate*<vec2, vec2, void> glmc_vec2_normalize_to; //(delegate*<vec2, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_vec2_normalize_to");


        public static unsafe delegate*<vec2, float, vec2, void> glmc_vec2_rotate; //(delegate*<vec2, float, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_vec2_rotate");


        public static unsafe delegate*<vec2, vec2, float> glmc_vec2_distance2; //(delegate*<vec2, vec2, float>)NativeLibrary.GetExport(Handle, "glmc_vec2_distance2");


        public static unsafe delegate*<vec2, vec2, float> glmc_vec2_distance; //(delegate*<vec2, vec2, float>)NativeLibrary.GetExport(Handle, "glmc_vec2_distance");


        public static unsafe delegate*<vec2, vec2, vec2, void> glmc_vec2_maxv; //(delegate*<vec2, vec2, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_vec2_maxv");


        public static unsafe delegate*<vec2, vec2, vec2, void> glmc_vec2_minv; //(delegate*<vec2, vec2, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_vec2_minv");


        public static unsafe delegate*<vec2, float, float, void> glmc_vec2_clamp; //(delegate*<vec2, float, float, void>)NativeLibrary.GetExport(Handle, "glmc_vec2_clamp");


        public static unsafe delegate*<vec2, vec2, float, vec2, void> glmc_vec2_lerp; //(delegate*<vec2, vec2, float, vec2, void>)NativeLibrary.GetExport(Handle, "glmc_vec2_lerp");


        public static unsafe delegate*<vec4, vec3, void> glmc_vec3; //(delegate*<vec4, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3");


        public static unsafe delegate*<vec3, vec3, void> glmc_vec3_copy; //(delegate*<vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_copy");


        public static unsafe delegate*<vec3, void> glmc_vec3_zero; //(delegate*<vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_zero");


        public static unsafe delegate*<vec3, void> glmc_vec3_one; //(delegate*<vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_one");


        public static unsafe delegate*<vec3, vec3, float> glmc_vec3_dot; //(delegate*<vec3, vec3, float>)NativeLibrary.GetExport(Handle, "glmc_vec3_dot");


        public static unsafe delegate*<vec3, vec3, vec3, void> glmc_vec3_cross; //(delegate*<vec3, vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_cross");


        public static unsafe delegate*<vec3, vec3, vec3, void> glmc_vec3_crossn; //(delegate*<vec3, vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_crossn");


        public static unsafe delegate*<vec3, float> glmc_vec3_norm; //(delegate*<vec3, float>)NativeLibrary.GetExport(Handle, "glmc_vec3_norm");


        public static unsafe delegate*<vec3, float> glmc_vec3_norm2; //(delegate*<vec3, float>)NativeLibrary.GetExport(Handle, "glmc_vec3_norm2");


        public static unsafe delegate*<vec3, float> glmc_vec3_norm_one; //(delegate*<vec3, float>)NativeLibrary.GetExport(Handle, "glmc_vec3_norm_one");


        public static unsafe delegate*<vec3, float> glmc_vec3_norm_inf; //(delegate*<vec3, float>)NativeLibrary.GetExport(Handle, "glmc_vec3_norm_inf");


        public static unsafe delegate*<vec3, vec3, void> glmc_vec3_normalize_to; //(delegate*<vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_normalize_to");


        public static unsafe delegate*<vec3, void> glmc_vec3_normalize; //(delegate*<vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_normalize");


        public static unsafe delegate*<vec3, vec3, vec3, void> glmc_vec3_add; //(delegate*<vec3, vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_add");


        public static unsafe delegate*<vec3, float, vec3, void> glmc_vec3_adds; //(delegate*<vec3, float, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_adds");


        public static unsafe delegate*<vec3, vec3, vec3, void> glmc_vec3_sub; //(delegate*<vec3, vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_sub");


        public static unsafe delegate*<vec3, float, vec3, void> glmc_vec3_subs; //(delegate*<vec3, float, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_subs");


        public static unsafe delegate*<vec3, vec3, vec3, void> glmc_vec3_mul; //(delegate*<vec3, vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_mul");


        public static unsafe delegate*<vec3, float, vec3, void> glmc_vec3_scale; //(delegate*<vec3, float, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_scale");


        public static unsafe delegate*<vec3, float, vec3, void> glmc_vec3_scale_as; //(delegate*<vec3, float, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_scale_as");


        public static unsafe delegate*<vec3, vec3, vec3, void> glmc_vec3_div; //(delegate*<vec3, vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_div");


        public static unsafe delegate*<vec3, float, vec3, void> glmc_vec3_divs; //(delegate*<vec3, float, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_divs");


        public static unsafe delegate*<vec3, vec3, vec3, void> glmc_vec3_addadd; //(delegate*<vec3, vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_addadd");


        public static unsafe delegate*<vec3, vec3, vec3, void> glmc_vec3_subadd; //(delegate*<vec3, vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_subadd");


        public static unsafe delegate*<vec3, vec3, vec3, void> glmc_vec3_muladd; //(delegate*<vec3, vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_muladd");


        public static unsafe delegate*<vec3, float, vec3, void> glmc_vec3_muladds; //(delegate*<vec3, float, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_muladds");


        public static unsafe delegate*<vec3, vec3, vec3, void> glmc_vec3_maxadd; //(delegate*<vec3, vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_maxadd");


        public static unsafe delegate*<vec3, vec3, vec3, void> glmc_vec3_minadd; //(delegate*<vec3, vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_minadd");


        public static unsafe delegate*<vec3, void> glmc_vec3_negate; //(delegate*<vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_negate");


        public static unsafe delegate*<vec3, vec3, void> glmc_vec3_negate_to; //(delegate*<vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_negate_to");


        public static unsafe delegate*<vec3, vec3, float> glmc_vec3_angle; //(delegate*<vec3, vec3, float>)NativeLibrary.GetExport(Handle, "glmc_vec3_angle");


        public static unsafe delegate*<vec3, float, vec3, void> glmc_vec3_rotate; //(delegate*<vec3, float, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_rotate");


        public static unsafe delegate*<mat4, vec3, vec3, void> glmc_vec3_rotate_m4; //(delegate*<mat4, vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_rotate_m4");


        public static unsafe delegate*<mat3, vec3, vec3, void> glmc_vec3_rotate_m3; //(delegate*<mat3, vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_rotate_m3");


        public static unsafe delegate*<vec3, vec3, vec3, void> glmc_vec3_proj; //(delegate*<vec3, vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_proj");


        public static unsafe delegate*<vec3, vec3, vec3, void> glmc_vec3_center; //(delegate*<vec3, vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_center");


        public static unsafe delegate*<vec3, vec3, float> glmc_vec3_distance2; //(delegate*<vec3, vec3, float>)NativeLibrary.GetExport(Handle, "glmc_vec3_distance2");


        public static unsafe delegate*<vec3, vec3, float> glmc_vec3_distance; //(delegate*<vec3, vec3, float>)NativeLibrary.GetExport(Handle, "glmc_vec3_distance");


        public static unsafe delegate*<vec3, vec3, vec3, void> glmc_vec3_maxv; //(delegate*<vec3, vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_maxv");


        public static unsafe delegate*<vec3, vec3, vec3, void> glmc_vec3_minv; //(delegate*<vec3, vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_minv");


        public static unsafe delegate*<vec3, float, float, void> glmc_vec3_clamp; //(delegate*<vec3, float, float, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_clamp");


        public static unsafe delegate*<vec3, vec3, void> glmc_vec3_ortho; //(delegate*<vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_ortho");


        public static unsafe delegate*<vec3, vec3, float, vec3, void> glmc_vec3_lerp; //(delegate*<vec3, vec3, float, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_lerp");


        public static unsafe delegate*<vec3, vec3, float, vec3, void> glmc_vec3_lerpc; //(delegate*<vec3, vec3, float, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_lerpc");


        public static unsafe delegate*<float, vec3, vec3, void> glmc_vec3_step_uni; //(delegate*<float, vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_step_uni");


        public static unsafe delegate*<vec3, vec3, vec3, void> glmc_vec3_step; //(delegate*<vec3, vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_step");


        public static unsafe delegate*<float, float, vec3, vec3, void> glmc_vec3_smoothstep_uni; //(delegate*<float, float, vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_smoothstep_uni");


        public static unsafe delegate*<vec3, vec3, vec3, vec3, void> glmc_vec3_smoothstep; //(delegate*<vec3, vec3, vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_smoothstep");


        public static unsafe delegate*<vec3, vec3, float, vec3, void> glmc_vec3_smoothinterp; //(delegate*<vec3, vec3, float, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_smoothinterp");


        public static unsafe delegate*<vec3, vec3, float, vec3, void> glmc_vec3_smoothinterpc; //(delegate*<vec3, vec3, float, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_smoothinterpc");


        public static unsafe delegate*<vec3, vec3, vec3, void> glmc_vec3_mulv; //(delegate*<vec3, vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_mulv");


        public static unsafe delegate*<float, vec3, void> glmc_vec3_broadcast; //(delegate*<float, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_broadcast");


        public static unsafe delegate*<vec3, float, void> glmc_vec3_fill; //(delegate*<vec3, float, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_fill");



        public static unsafe delegate*<vec3, float, Bool> glmc_vec3_eq; //(delegate*<vec3, float, Bool>)NativeLibrary.GetExport(Handle, "glmc_vec3_eq");



        public static unsafe delegate*<vec3, float, Bool> glmc_vec3_eq_eps; //(delegate*<vec3, float, Bool>)NativeLibrary.GetExport(Handle, "glmc_vec3_eq_eps");



        public static unsafe delegate*<vec3, Bool> glmc_vec3_eq_all; //(delegate*<vec3, Bool>)NativeLibrary.GetExport(Handle, "glmc_vec3_eq_all");



        public static unsafe delegate*<vec3, vec3, Bool> glmc_vec3_eqv; //(delegate*<vec3, vec3, Bool>)NativeLibrary.GetExport(Handle, "glmc_vec3_eqv");



        public static unsafe delegate*<vec3, vec3, Bool> glmc_vec3_eqv_eps; //(delegate*<vec3, vec3, Bool>)NativeLibrary.GetExport(Handle, "glmc_vec3_eqv_eps");


        public static unsafe delegate*<vec3, float> glmc_vec3_max; //(delegate*<vec3, float>)NativeLibrary.GetExport(Handle, "glmc_vec3_max");


        public static unsafe delegate*<vec3, float> glmc_vec3_min; //(delegate*<vec3, float>)NativeLibrary.GetExport(Handle, "glmc_vec3_min");



        public static unsafe delegate*<vec3, Bool> glmc_vec3_isnan; //(delegate*<vec3, Bool>)NativeLibrary.GetExport(Handle, "glmc_vec3_isnan");



        public static unsafe delegate*<vec3, Bool> glmc_vec3_isinf; //(delegate*<vec3, Bool>)NativeLibrary.GetExport(Handle, "glmc_vec3_isinf");



        public static unsafe delegate*<vec3, Bool> glmc_vec3_isvalid; //(delegate*<vec3, Bool>)NativeLibrary.GetExport(Handle, "glmc_vec3_isvalid");


        public static unsafe delegate*<vec3, vec3, void> glmc_vec3_sign; //(delegate*<vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_sign");


        public static unsafe delegate*<vec3, vec3, void> glmc_vec3_abs; //(delegate*<vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_abs");


        public static unsafe delegate*<vec3, vec3, void> glmc_vec3_fract; //(delegate*<vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_fract");


        public static unsafe delegate*<vec3, float> glmc_vec3_hadd; //(delegate*<vec3, float>)NativeLibrary.GetExport(Handle, "glmc_vec3_hadd");


        public static unsafe delegate*<vec3, vec3, void> glmc_vec3_sqrt; //(delegate*<vec3, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec3_sqrt");


        public static unsafe delegate*<vec3, float, vec4, void> glmc_vec4; //(delegate*<vec3, float, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4");


        public static unsafe delegate*<vec4, void> glmc_vec4_zero; //(delegate*<vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_zero");


        public static unsafe delegate*<vec4, void> glmc_vec4_one; //(delegate*<vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_one");


        public static unsafe delegate*<vec4, vec3, void> glmc_vec4_copy3; //(delegate*<vec4, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_copy3");


        public static unsafe delegate*<vec4, vec4, void> glmc_vec4_copy; //(delegate*<vec4, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_copy");


        public static unsafe delegate*<vec4, vec4, void> glmc_vec4_ucopy; //(delegate*<vec4, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_ucopy");


        public static unsafe delegate*<vec4, vec4, float> glmc_vec4_dot; //(delegate*<vec4, vec4, float>)NativeLibrary.GetExport(Handle, "glmc_vec4_dot");


        public static unsafe delegate*<vec4, float> glmc_vec4_norm; //(delegate*<vec4, float>)NativeLibrary.GetExport(Handle, "glmc_vec4_norm");


        public static unsafe delegate*<vec4, float> glmc_vec4_norm2; //(delegate*<vec4, float>)NativeLibrary.GetExport(Handle, "glmc_vec4_norm2");


        public static unsafe delegate*<vec4, float> glmc_vec4_norm_one; //(delegate*<vec4, float>)NativeLibrary.GetExport(Handle, "glmc_vec4_norm_one");


        public static unsafe delegate*<vec4, float> glmc_vec4_norm_inf; //(delegate*<vec4, float>)NativeLibrary.GetExport(Handle, "glmc_vec4_norm_inf");


        public static unsafe delegate*<vec4, vec4, void> glmc_vec4_normalize_to; //(delegate*<vec4, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_normalize_to");


        public static unsafe delegate*<vec4, void> glmc_vec4_normalize; //(delegate*<vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_normalize");


        public static unsafe delegate*<vec4, vec4, vec4, void> glmc_vec4_add; //(delegate*<vec4, vec4, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_add");


        public static unsafe delegate*<vec4, float, vec4, void> glmc_vec4_adds; //(delegate*<vec4, float, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_adds");


        public static unsafe delegate*<vec4, vec4, vec4, void> glmc_vec4_sub; //(delegate*<vec4, vec4, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_sub");


        public static unsafe delegate*<vec4, float, vec4, void> glmc_vec4_subs; //(delegate*<vec4, float, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_subs");


        public static unsafe delegate*<vec4, vec4, vec4, void> glmc_vec4_mul; //(delegate*<vec4, vec4, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_mul");


        public static unsafe delegate*<vec4, float, vec4, void> glmc_vec4_scale; //(delegate*<vec4, float, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_scale");


        public static unsafe delegate*<vec4, float, vec4, void> glmc_vec4_scale_as; //(delegate*<vec4, float, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_scale_as");


        public static unsafe delegate*<vec4, vec4, vec4, void> glmc_vec4_div; //(delegate*<vec4, vec4, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_div");


        public static unsafe delegate*<vec4, float, vec4, void> glmc_vec4_divs; //(delegate*<vec4, float, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_divs");


        public static unsafe delegate*<vec4, vec4, vec4, void> glmc_vec4_addadd; //(delegate*<vec4, vec4, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_addadd");


        public static unsafe delegate*<vec4, vec4, vec4, void> glmc_vec4_subadd; //(delegate*<vec4, vec4, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_subadd");


        public static unsafe delegate*<vec4, vec4, vec4, void> glmc_vec4_muladd; //(delegate*<vec4, vec4, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_muladd");


        public static unsafe delegate*<vec4, float, vec4, void> glmc_vec4_muladds; //(delegate*<vec4, float, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_muladds");


        public static unsafe delegate*<vec4, vec4, vec4, void> glmc_vec4_maxadd; //(delegate*<vec4, vec4, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_maxadd");


        public static unsafe delegate*<vec4, vec4, vec4, void> glmc_vec4_minadd; //(delegate*<vec4, vec4, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_minadd");


        public static unsafe delegate*<vec4, void> glmc_vec4_negate; //(delegate*<vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_negate");


        public static unsafe delegate*<vec4, vec4, void> glmc_vec4_negate_to; //(delegate*<vec4, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_negate_to");


        public static unsafe delegate*<vec4, vec4, float> glmc_vec4_distance; //(delegate*<vec4, vec4, float>)NativeLibrary.GetExport(Handle, "glmc_vec4_distance");


        public static unsafe delegate*<vec4, vec4, float> glmc_vec4_distance2; //(delegate*<vec4, vec4, float>)NativeLibrary.GetExport(Handle, "glmc_vec4_distance2");


        public static unsafe delegate*<vec4, vec4, vec4, void> glmc_vec4_maxv; //(delegate*<vec4, vec4, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_maxv");


        public static unsafe delegate*<vec4, vec4, vec4, void> glmc_vec4_minv; //(delegate*<vec4, vec4, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_minv");


        public static unsafe delegate*<vec4, float, float, void> glmc_vec4_clamp; //(delegate*<vec4, float, float, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_clamp");


        public static unsafe delegate*<vec4, vec4, float, vec4, void> glmc_vec4_lerp; //(delegate*<vec4, vec4, float, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_lerp");


        public static unsafe delegate*<vec4, vec4, float, vec4, void> glmc_vec4_lerpc; //(delegate*<vec4, vec4, float, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_lerpc");


        public static unsafe delegate*<float, vec4, vec4, void> glmc_vec4_step_uni; //(delegate*<float, vec4, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_step_uni");


        public static unsafe delegate*<vec4, vec4, vec4, void> glmc_vec4_step; //(delegate*<vec4, vec4, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_step");


        public static unsafe delegate*<float, float, vec4, vec4, void> glmc_vec4_smoothstep_uni; //(delegate*<float, float, vec4, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_smoothstep_uni");


        public static unsafe delegate*<vec4, vec4, vec4, vec4, void> glmc_vec4_smoothstep; //(delegate*<vec4, vec4, vec4, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_smoothstep");


        public static unsafe delegate*<vec4, vec4, float, vec4, void> glmc_vec4_smoothinterp; //(delegate*<vec4, vec4, float, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_smoothinterp");


        public static unsafe delegate*<vec4, vec4, float, vec4, void> glmc_vec4_smoothinterpc; //(delegate*<vec4, vec4, float, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_smoothinterpc");


        public static unsafe delegate*<float, vec4, void> glmc_vec4_cubic; //(delegate*<float, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_cubic");


        public static unsafe delegate*<vec4, vec4, vec4, void> glmc_vec4_mulv; //(delegate*<vec4, vec4, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_mulv");


        public static unsafe delegate*<float, vec4, void> glmc_vec4_broadcast; //(delegate*<float, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_broadcast");


        public static unsafe delegate*<vec4, float, void> glmc_vec4_fill; //(delegate*<vec4, float, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_fill");



        public static unsafe delegate*<vec4, float, Bool> glmc_vec4_eq; //(delegate*<vec4, float, Bool>)NativeLibrary.GetExport(Handle, "glmc_vec4_eq");



        public static unsafe delegate*<vec4, float, Bool> glmc_vec4_eq_eps; //(delegate*<vec4, float, Bool>)NativeLibrary.GetExport(Handle, "glmc_vec4_eq_eps");



        public static unsafe delegate*<vec4, Bool> glmc_vec4_eq_all; //(delegate*<vec4, Bool>)NativeLibrary.GetExport(Handle, "glmc_vec4_eq_all");



        public static unsafe delegate*<vec4, vec4, Bool> glmc_vec4_eqv; //(delegate*<vec4, vec4, Bool>)NativeLibrary.GetExport(Handle, "glmc_vec4_eqv");



        public static unsafe delegate*<vec4, vec4, Bool> glmc_vec4_eqv_eps; //(delegate*<vec4, vec4, Bool>)NativeLibrary.GetExport(Handle, "glmc_vec4_eqv_eps");


        public static unsafe delegate*<vec4, float> glmc_vec4_max; //(delegate*<vec4, float>)NativeLibrary.GetExport(Handle, "glmc_vec4_max");


        public static unsafe delegate*<vec4, float> glmc_vec4_min; //(delegate*<vec4, float>)NativeLibrary.GetExport(Handle, "glmc_vec4_min");



        public static unsafe delegate*<vec4, Bool> glmc_vec4_isnan; //(delegate*<vec4, Bool>)NativeLibrary.GetExport(Handle, "glmc_vec4_isnan");



        public static unsafe delegate*<vec4, Bool> glmc_vec4_isinf; //(delegate*<vec4, Bool>)NativeLibrary.GetExport(Handle, "glmc_vec4_isinf");



        public static unsafe delegate*<vec4, Bool> glmc_vec4_isvalid; //(delegate*<vec4, Bool>)NativeLibrary.GetExport(Handle, "glmc_vec4_isvalid");


        public static unsafe delegate*<vec4, vec4, void> glmc_vec4_sign; //(delegate*<vec4, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_sign");


        public static unsafe delegate*<vec4, vec4, void> glmc_vec4_abs; //(delegate*<vec4, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_abs");


        public static unsafe delegate*<vec4, vec4, void> glmc_vec4_fract; //(delegate*<vec4, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_fract");


        public static unsafe delegate*<vec4, float> glmc_vec4_hadd; //(delegate*<vec4, float>)NativeLibrary.GetExport(Handle, "glmc_vec4_hadd");


        public static unsafe delegate*<vec4, vec4, void> glmc_vec4_sqrt; //(delegate*<vec4, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_vec4_sqrt");


        public static unsafe delegate*<float, float, float, float, float, float, mat4, void> glmc_ortho_lh_no; //(delegate*<float, float, float, float, float, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_lh_no");


        public static unsafe delegate*<vec3*, mat4, void> glmc_ortho_aabb_lh_no; //(delegate*<vec3*, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_aabb_lh_no");

        public static unsafe delegate*<vec3*, float, mat4, void> glmc_ortho_aabb_p_lh_no; //(delegate*<vec3*, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_aabb_p_lh_no");

        public static unsafe delegate*<vec3*, float, mat4, void> glmc_ortho_aabb_pz_lh_no; //(delegate*<vec3*, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_aabb_pz_lh_no");

        public static unsafe delegate*<float, mat4, void> glmc_ortho_default_lh_no; //(delegate*<float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_default_lh_no");

        public static unsafe delegate*<float, float, mat4, void> glmc_ortho_default_s_lh_no; //(delegate*<float, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_default_s_lh_no");


        public static unsafe delegate*<float, float, float, float, float, float, mat4, void> glmc_ortho_lh_zo; //(delegate*<float, float, float, float, float, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_lh_zo");


        public static unsafe delegate*<vec3*, mat4, void> glmc_ortho_aabb_lh_zo; //(delegate*<vec3*, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_aabb_lh_zo");

        public static unsafe delegate*<vec3*, float, mat4, void> glmc_ortho_aabb_p_lh_zo; //(delegate*<vec3*, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_aabb_p_lh_zo");

        public static unsafe delegate*<vec3*, float, mat4, void> glmc_ortho_aabb_pz_lh_zo; //(delegate*<vec3*, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_aabb_pz_lh_zo");



        public static unsafe delegate*<float, mat4, void> glmc_ortho_default_lh_zo; //(delegate*<float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_default_lh_zo");


        public static unsafe delegate*<float, float, mat4, void> glmc_ortho_default_s_lh_zo; //(delegate*<float, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_default_s_lh_zo");


        public static unsafe delegate*<float, float, float, float, float, float, mat4, void> glmc_ortho_rh_no; //(delegate*<float, float, float, float, float, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_rh_no");




        public static unsafe delegate*<vec3*, mat4, void> glmc_ortho_aabb_rh_no; //(delegate*<vec3*, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_aabb_rh_no");

        public static unsafe delegate*<vec3*, float, mat4, void> glmc_ortho_aabb_p_rh_no; //(delegate*<vec3*, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_aabb_p_rh_no");

        public static unsafe delegate*<vec3*, float, mat4, void> glmc_ortho_aabb_pz_rh_no; //(delegate*<vec3*, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_aabb_pz_rh_no");




        public static unsafe delegate*<float, mat4, void> glmc_ortho_default_rh_no; //(delegate*<float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_default_rh_no");


        public static unsafe delegate*<float, float, mat4, void> glmc_ortho_default_s_rh_no; //(delegate*<float, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_default_s_rh_no");


        public static unsafe delegate*<float, float, float, float, float, float, mat4, void> glmc_ortho_rh_zo; //(delegate*<float, float, float, float, float, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_rh_zo");



        public static unsafe delegate*<vec3*, mat4, void> glmc_ortho_aabb_rh_zo; //(delegate*<vec3*, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_aabb_rh_zo");

        public static unsafe delegate*<vec3*, float, mat4, void> glmc_ortho_aabb_p_rh_zo; //(delegate*<vec3*, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_aabb_p_rh_zo");

        public static unsafe delegate*<vec3*, float, mat4, void> glmc_ortho_aabb_pz_rh_zo; //(delegate*<vec3*, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_aabb_pz_rh_zo");



        public static unsafe delegate*<float, mat4, void> glmc_ortho_default_rh_zo; //(delegate*<float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_default_rh_zo");


        public static unsafe delegate*<float, float, mat4, void> glmc_ortho_default_s_rh_zo; //(delegate*<float, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_ortho_default_s_rh_zo");


        public static unsafe delegate*<float, float, float, float, float, float, mat4, void> glmc_frustum_lh_no; //(delegate*<float, float, float, float, float, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_frustum_lh_no");


        public static unsafe delegate*<float, float, float, float, mat4, void> glmc_perspective_lh_no; //(delegate*<float, float, float, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_perspective_lh_no");


        public static unsafe delegate*<mat4, float, void> glmc_persp_move_far_lh_no; //(delegate*<mat4, float, void>)NativeLibrary.GetExport(Handle, "glmc_persp_move_far_lh_no");


        public static unsafe delegate*<mat4, float*, float*, float*, float*, float*, float*, void> glmc_persp_decomp_lh_no; //(delegate*<mat4, float*, float*, float*, float*, float*, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_lh_no");


        public static unsafe delegate*<mat4, float*, void> glmc_persp_decompv_lh_no; //(delegate*<mat4, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decompv_lh_no");


        public static unsafe delegate*<mat4, float*, float*, void> glmc_persp_decomp_x_lh_no; //(delegate*<mat4, float*, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_x_lh_no");


        public static unsafe delegate*<mat4, float*, float*, void> glmc_persp_decomp_y_lh_no; //(delegate*<mat4, float*, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_y_lh_no");


        public static unsafe delegate*<mat4, float*, float*, void> glmc_persp_decomp_z_lh_no; //(delegate*<mat4, float*, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_z_lh_no");


        public static unsafe delegate*<mat4, float*, void> glmc_persp_decomp_far_lh_no; //(delegate*<mat4, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_far_lh_no");


        public static unsafe delegate*<mat4, float*, void> glmc_persp_decomp_near_lh_no; //(delegate*<mat4, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_near_lh_no");


        public static unsafe delegate*<mat4, float, vec4, void> glmc_persp_sizes_lh_no; //(delegate*<mat4, float, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_persp_sizes_lh_no");


        public static unsafe delegate*<mat4, float> glmc_persp_fovy_lh_no; //(delegate*<mat4, float>)NativeLibrary.GetExport(Handle, "glmc_persp_fovy_lh_no");


        public static unsafe delegate*<mat4, float> glmc_persp_aspect_lh_no; //(delegate*<mat4, float>)NativeLibrary.GetExport(Handle, "glmc_persp_aspect_lh_no");


        public static unsafe delegate*<float, float, float, float, float, float, mat4, void> glmc_frustum_lh_zo; //(delegate*<float, float, float, float, float, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_frustum_lh_zo");


        public static unsafe delegate*<float, float, float, float, mat4, void> glmc_perspective_lh_zo; //(delegate*<float, float, float, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_perspective_lh_zo");


        public static unsafe delegate*<mat4, float, void> glmc_persp_move_far_lh_zo; //(delegate*<mat4, float, void>)NativeLibrary.GetExport(Handle, "glmc_persp_move_far_lh_zo");


        public static unsafe delegate*<mat4, float*, float*, float*, float*, float*, float*, void> glmc_persp_decomp_lh_zo; //(delegate*<mat4, float*, float*, float*, float*, float*, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_lh_zo");


        public static unsafe delegate*<mat4, float*, void> glmc_persp_decompv_lh_zo; //(delegate*<mat4, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decompv_lh_zo");


        public static unsafe delegate*<mat4, float*, float*, void> glmc_persp_decomp_x_lh_zo; //(delegate*<mat4, float*, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_x_lh_zo");


        public static unsafe delegate*<mat4, float*, float*, void> glmc_persp_decomp_y_lh_zo; //(delegate*<mat4, float*, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_y_lh_zo");


        public static unsafe delegate*<mat4, float*, float*, void> glmc_persp_decomp_z_lh_zo; //(delegate*<mat4, float*, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_z_lh_zo");


        public static unsafe delegate*<mat4, float*, void> glmc_persp_decomp_far_lh_zo; //(delegate*<mat4, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_far_lh_zo");


        public static unsafe delegate*<mat4, float*, void> glmc_persp_decomp_near_lh_zo; //(delegate*<mat4, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_near_lh_zo");


        public static unsafe delegate*<mat4, float, vec4, void> glmc_persp_sizes_lh_zo; //(delegate*<mat4, float, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_persp_sizes_lh_zo");


        public static unsafe delegate*<mat4, float> glmc_persp_fovy_lh_zo; //(delegate*<mat4, float>)NativeLibrary.GetExport(Handle, "glmc_persp_fovy_lh_zo");


        public static unsafe delegate*<mat4, float> glmc_persp_aspect_lh_zo; //(delegate*<mat4, float>)NativeLibrary.GetExport(Handle, "glmc_persp_aspect_lh_zo");


        public static unsafe delegate*<float, float, float, float, float, float, mat4, void> glmc_frustum_rh_no; //(delegate*<float, float, float, float, float, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_frustum_rh_no");


        public static unsafe delegate*<float, float, float, float, mat4, void> glmc_perspective_rh_no; //(delegate*<float, float, float, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_perspective_rh_no");


        public static unsafe delegate*<mat4, float, void> glmc_persp_move_far_rh_no; //(delegate*<mat4, float, void>)NativeLibrary.GetExport(Handle, "glmc_persp_move_far_rh_no");


        public static unsafe delegate*<mat4, float*, float*, float*, float*, float*, float*, void> glmc_persp_decomp_rh_no; //(delegate*<mat4, float*, float*, float*, float*, float*, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_rh_no");


        public static unsafe delegate*<mat4, float*, void> glmc_persp_decompv_rh_no; //(delegate*<mat4, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decompv_rh_no");


        public static unsafe delegate*<mat4, float*, float*, void> glmc_persp_decomp_x_rh_no; //(delegate*<mat4, float*, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_x_rh_no");


        public static unsafe delegate*<mat4, float*, float*, void> glmc_persp_decomp_y_rh_no; //(delegate*<mat4, float*, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_y_rh_no");


        public static unsafe delegate*<mat4, float*, float*, void> glmc_persp_decomp_z_rh_no; //(delegate*<mat4, float*, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_z_rh_no");


        public static unsafe delegate*<mat4, float*, void> glmc_persp_decomp_far_rh_no; //(delegate*<mat4, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_far_rh_no");


        public static unsafe delegate*<mat4, float*, void> glmc_persp_decomp_near_rh_no; //(delegate*<mat4, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_near_rh_no");


        public static unsafe delegate*<mat4, float, vec4, void> glmc_persp_sizes_rh_no; //(delegate*<mat4, float, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_persp_sizes_rh_no");


        public static unsafe delegate*<mat4, float> glmc_persp_fovy_rh_no; //(delegate*<mat4, float>)NativeLibrary.GetExport(Handle, "glmc_persp_fovy_rh_no");


        public static unsafe delegate*<mat4, float> glmc_persp_aspect_rh_no; //(delegate*<mat4, float>)NativeLibrary.GetExport(Handle, "glmc_persp_aspect_rh_no");


        public static unsafe delegate*<float, float, float, float, float, float, mat4, void> glmc_frustum_rh_zo; //(delegate*<float, float, float, float, float, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_frustum_rh_zo");


        public static unsafe delegate*<float, float, float, float, mat4, void> glmc_perspective_rh_zo; //(delegate*<float, float, float, float, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_perspective_rh_zo");


        public static unsafe delegate*<mat4, float, void> glmc_persp_move_far_rh_zo; //(delegate*<mat4, float, void>)NativeLibrary.GetExport(Handle, "glmc_persp_move_far_rh_zo");


        public static unsafe delegate*<mat4, float*, float*, float*, float*, float*, float*, void> glmc_persp_decomp_rh_zo; //(delegate*<mat4, float*, float*, float*, float*, float*, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_rh_zo");


        public static unsafe delegate*<mat4, float*, void> glmc_persp_decompv_rh_zo; //(delegate*<mat4, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decompv_rh_zo");


        public static unsafe delegate*<mat4, float*, float*, void> glmc_persp_decomp_x_rh_zo; //(delegate*<mat4, float*, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_x_rh_zo");


        public static unsafe delegate*<mat4, float*, float*, void> glmc_persp_decomp_y_rh_zo; //(delegate*<mat4, float*, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_y_rh_zo");


        public static unsafe delegate*<mat4, float*, float*, void> glmc_persp_decomp_z_rh_zo; //(delegate*<mat4, float*, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_z_rh_zo");


        public static unsafe delegate*<mat4, float*, void> glmc_persp_decomp_far_rh_zo; //(delegate*<mat4, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_far_rh_zo");


        public static unsafe delegate*<mat4, float*, void> glmc_persp_decomp_near_rh_zo; //(delegate*<mat4, float*, void>)NativeLibrary.GetExport(Handle, "glmc_persp_decomp_near_rh_zo");


        public static unsafe delegate*<mat4, float, vec4, void> glmc_persp_sizes_rh_zo; //(delegate*<mat4, float, vec4, void>)NativeLibrary.GetExport(Handle, "glmc_persp_sizes_rh_zo");


        public static unsafe delegate*<mat4, float> glmc_persp_fovy_rh_zo; //(delegate*<mat4, float>)NativeLibrary.GetExport(Handle, "glmc_persp_fovy_rh_zo");


        public static unsafe delegate*<mat4, float> glmc_persp_aspect_rh_zo; //(delegate*<mat4, float>)NativeLibrary.GetExport(Handle, "glmc_persp_aspect_rh_zo");


        //public static unsafe delegate*<vec3, mat4, vec4, vec3, void> glmc_unprojecti_no; //(delegate*<vec3, mat4, vec4, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_unprojecti_no");


        //public static unsafe delegate*<vec3, mat4, vec4, vec3, void> glmc_project_no; //(delegate*<vec3, mat4, vec4, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_project_no");


        //public static unsafe delegate*<vec3, mat4, vec4, vec3, void> glmc_unprojecti_zo; //(delegate*<vec3, mat4, vec4, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_unprojecti_zo");


        //public static unsafe delegate*<vec3, mat4, vec4, vec3, void> glmc_project_zo; //(delegate*<vec3, mat4, vec4, vec3, void>)NativeLibrary.GetExport(Handle, "glmc_project_zo");


        public static unsafe delegate*<vec3, vec3, vec3, mat4, void> glmc_lookat_lh_no; //(delegate*<vec3, vec3, vec3, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_lookat_lh_no");


        public static unsafe delegate*<vec3, vec3, vec3, mat4, void> glmc_look_lh_no; //(delegate*<vec3, vec3, vec3, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_look_lh_no");


        public static unsafe delegate*<vec3, vec3, mat4, void> glmc_look_anyup_lh_no; //(delegate*<vec3, vec3, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_look_anyup_lh_no");


        public static unsafe delegate*<vec3, vec3, vec3, mat4, void> glmc_lookat_lh_zo; //(delegate*<vec3, vec3, vec3, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_lookat_lh_zo");


        public static unsafe delegate*<vec3, vec3, vec3, mat4, void> glmc_look_lh_zo; //(delegate*<vec3, vec3, vec3, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_look_lh_zo");


        public static unsafe delegate*<vec3, vec3, mat4, void> glmc_look_anyup_lh_zo; //(delegate*<vec3, vec3, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_look_anyup_lh_zo");


        public static unsafe delegate*<vec3, vec3, vec3, mat4, void> glmc_lookat_rh_no; //(delegate*<vec3, vec3, vec3, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_lookat_rh_no");


        public static unsafe delegate*<vec3, vec3, vec3, mat4, void> glmc_look_rh_no; //(delegate*<vec3, vec3, vec3, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_look_rh_no");


        public static unsafe delegate*<vec3, vec3, mat4, void> glmc_look_anyup_rh_no; //(delegate*<vec3, vec3, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_look_anyup_rh_no");


        public static unsafe delegate*<vec3, vec3, vec3, mat4, void> glmc_lookat_rh_zo; //(delegate*<vec3, vec3, vec3, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_lookat_rh_zo");


        public static unsafe delegate*<vec3, vec3, vec3, mat4, void> glmc_look_rh_zo; //(delegate*<vec3, vec3, vec3, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_look_rh_zo");


        public static unsafe delegate*<vec3, vec3, mat4, void> glmc_look_anyup_rh_zo; //(delegate*<vec3, vec3, mat4, void>)NativeLibrary.GetExport(Handle, "glmc_look_anyup_rh_zo");

    }


}
