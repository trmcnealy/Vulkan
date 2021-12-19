namespace Vulkan
{
    public enum QueueType
    {
        TRANSFER = 0x01,
        GRAPHICS = 0x02,
        COMPUTE  = 0x04,
        PRESENT  = 0x08,
        RENDER   = 0x07,
        ALL      = 0x0F
    }


    public enum CommandBufferType
    {
        TRANSFERS,
        GRAPHICS,
        COMPUTE,
        GUI
    }


    public enum BufferType
    {
        UNDEFINED,
        STAGING,
        VERTEX,
        INDEX,
        UNIFORM,
        STORAGE,
        UNIFORM_MAPPABLE,
        COUNT
    }


    public enum GraphicsFlagBits
    {
        DEPTH_TEST = 0x0100,
        PICK       = 0x0200
    }


    public enum GraphicsType
    {
        NONE,
        POINT,

        LINE,
        LINE_STRIP,
        TRIANGLE,
        TRIANGLE_STRIP,
        TRIANGLE_FAN,

        MARKER,

        SEGMENT,
        ARROW,
        PATH,
        TEXT,

        IMAGE,
        IMAGE_CMAP,

        VOLUME_SLICE,
        MESH,

        FAKE_SPHERE,
        VOLUME,

        COUNT,
        CUSTOM
    }


    public enum TextureAxis
    {
        U,
        V,
        W
    }


    public enum BlendType
    {
        DISABLE,
        ENABLE
    }


    public enum DepthTest
    {
        DISABLE,
        ENABLE
    }


    public enum RenderpassAttachmentType
    {
        COLOR,
        DEPTH,
        PICK
    }


    public enum DefaultQueue
    {
        TRANSFER,
        COMPUTE,
        RENDER,
        PRESENT,
        COUNT
    }


    public enum FilterType
    {
        MIN,
        MAG
    }


    public  enum ObjectType
    {
        UNDEFINED,
        APP,
        GPU,
        WINDOW,
        SWAPCHAIN,
        CANVAS,
        COMMANDS,
        BUFFER,
        TEXTURE,
        IMAGES,
        SAMPLER,
        BINDINGS,
        COMPUTE,
        GRAPHICS,
        BARRIER,
        FENCES,
        SEMAPHORES,
        RENDERPASS,
        FRAMEBUFFER,
        SUBMIT,
        SCREENCAST,
        ARRAY,
        VISUAL,
        PROP,
        SOURCE,
        SCENE,
        GRID,
        PANEL,
        CONTROLLER,
        AXES_2D,
        AXES_3D,
        GUI,
        CUSTOM,
    }

    public enum ObjectStatus
    {
        NONE,
        ALLOC,           
        DESTROYED,       
        INIT,                 
        CREATED,             
        NEED_RECREATE,     
        NEED_UPDATE,       
        NEED_DESTROY,      
        INACTIVE,       
        INVALID         
    }


    public class Object
    {
        public ObjectType   type    {get; set;}
        public ObjectStatus status  {get; set;}
        public int             request {get; set;}

        public uint group_id {get; set;}   
        public uint id       {get; set;}            
    }



    public  struct Container
    {
        public uint             count;
        public uint             capacity;
        public ObjectType type;
        public object[]         items;
    }



    public struct ContainerIterator
    {
        public Container container;
        public uint            idx;
        public object          item;
    }

    public class DvzThread
    {
        public Object       obj    {get; set;}
        public pthread_t       thread {get; set;}
        public pthread_mutex_t @lock  {get; set;}
        atomic(int, lock_idx);
    }


    public class FontAtlas
    {
        public readonly string  Name;
        public          uint    width        { get; set; }
        public          uint    height       { get; set; }
        public          uint    cols         { get; set; }
        public          uint    rows         { get; set; }
        public          byte    font_texture { get; set; }
        public          float   glyph_width  { get; set; }
        public          float   glyph_height { get; set; }
        public readonly string  FontStr;
        public          Texture texture { get; set; }
    }


    public class ColorTexture
    {
        public byte    arr     { get; set; }
        public Texture texture { get; set; }
    }


    public class Fifo
    {
        public int      tail      {get; set;}
        public int      head      {get; set;}
        public int      capacity  {get; set;}
        public object[] items     {get; set;}
        public object   user_data {get; set;}

        public pthread_mutex_t @lock {get; set;}
        public pthread_cond_t  cond  {get; set;}

        atomic(bool, is_processing);
        atomic(bool, is_empty);
    }


    public class Context
    {
        public Object obj { get; set; }
        public Gpu    gpu { get; set; }

        public Container buffers  { get; set; }
        public Container images   { get; set; }
        public Container samplers { get; set; }
        public Container textures { get; set; }
        public Container computes { get; set; }

        public Fifo transfers { get; set; }

        public FontAtlas    font_atlas       { get; set; }
        public ColorTexture color_texture    { get; set; }
        public Texture      transfer_texture { get; set; }
    }


    public class Queues
    {
        public Object obj { get; set; }

        public uint queue_family_count { get; set; }

        public bool[] support_transfer { get; set; }
        public bool[] support_graphics { get; set; }
        public bool[] support_compute  { get; set; }
        public bool[] support_present  { get; set; }
        public uint[] max_queue_count  { get; set; }

        public uint queue_count { get; set; }

        public QueueType[] queue_types { get; set; }

        public uint[]          queue_families { get; set; }
        public uint[]          queue_indices  { get; set; }
        public VkQueue[]       queues         { get; set; }
        public VkCommandPool[] cmd_pools      { get; set; }
    }


    public class Gpu
    {
        public Object obj { get; set; }
        public App    app { get; set; }

        public          uint   idx { get; set; }
        public readonly string Name;

        public VkPhysicalDevice                 physical_device   { get; set; }
        public VkPhysicalDeviceProperties       device_properties { get; set; }
        public VkPhysicalDeviceFeatures         device_features   { get; set; }
        public VkPhysicalDeviceMemoryProperties memory_properties { get; set; }
        public uint                             vram              { get; set; }

        public uint               present_mode_count { get; set; }
        public VkPresentModeKHR[] present_modes      { get; set; }

        public Queues           queues    { get; set; }
        public VkDescriptorPool dset_pool { get; set; }

        public VkPhysicalDeviceFeatures requested_features { get; set; }
        public VkDevice                 device             { get; set; }

        public Context context { get; set; }
    }


    public class Window
    {
        public Object obj { get; set; }
        public App    app { get; set; }

        public object backend_window { get; set; }
        public uint   width          { get; set; }
        public uint   height         { get; set; }

        public bool                     close_on_esc { get; set; }
        public VkSurfaceKHR             surface      { get; set; }
        public VkSurfaceCapabilitiesKHR caps         { get; set; }
    }


    public class Swapchain
    {
        public Object obj    { get; set; }
        public Gpu    gpu    { get; set; }
        public Window window { get; set; }

        private VkFormat         format           { get; set; }
        public  VkPresentModeKHR present_mode     { get; set; }
        public  bool             support_transfer { get; set; }


        public uint requested_width  { get; set; }
        public uint requested_height { get; set; }

        public uint           img_count { get; set; }
        public uint           img_idx   { get; set; }
        public VkSwapchainKHR swapchain { get; set; }


        public Images[] images { get; set; }
    }


    public class Commands
    {
        public Object obj { get; set; }
        public Gpu    gpu { get; set; }

        public uint              queue_idx { get; set; }
        public uint              count     { get; set; }
        public VkCommandBuffer[] cmds      { get; set; }
    }


    public class Buffer
    {
        public Object obj { get; set; }
        public Gpu    gpu { get; set; }

        public BufferType     type          { get; set; }
        public VkBuffer       buffer        { get; set; }
        public VkDeviceMemory device_memory { get; set; }

        public uint   queue_count { get; set; }
        public uint[] queues      { get; set; }

        public uint                     size           { get; set; }
        public uint                     allocated_size { get; set; }
        public VkBufferUsageFlagBits    usage          { get; set; }
        public VkMemoryPropertyFlagBits memory         { get; set; }

        public object mmap { get; set; }
    }


    public class BufferRegions
    {
        public Buffer buffer       { get; set; }
        public uint   count        { get; set; }
        public uint   size         { get; set; }
        public uint   aligned_size { get; set; }
        public uint   alignment    { get; set; }
        public uint[] offsets      { get; set; }
    }


    public class Images
    {
        public Object obj { get; set; }
        public Gpu    gpu { get; set; }

        public uint count        { get; set; }
        public bool is_swapchain { get; set; }

        public uint   queue_count { get; set; }
        public uint[] queues      { get; set; }

        public  VkImageType              image_type { get; set; }
        public  VkImageViewType          view_type  { get; set; }
        public  uint                     width      { get; set; }
        public  uint                     height     { get; set; }
        public  uint                     depth      { get; set; }
        private VkFormat                 format     { get; set; }
        public  VkImageLayout            layout     { get; set; }
        public  VkImageTiling            tiling     { get; set; }
        public  VkImageUsageFlagBits     usage      { get; set; }
        public  VkMemoryPropertyFlagBits memory     { get; set; }
        public  VkImageAspectFlagBits    aspect     { get; set; }
        public  uint                     size       { get; set; }

        public VkImage[]        images      { get; set; }
        public VkDeviceMemory[] memories    { get; set; }
        public VkImageView[]    image_views { get; set; }
    }


    public class Sampler
    {
        public Object obj { get; set; }
        public Gpu    gpu { get; set; }

        public VkFilter               min_filter    { get; set; }
        public VkFilter               mag_filter    { get; set; }
        public VkSamplerAddressMode[] address_modes { get; set; }
        public VkSampler              sampler       { get; set; }
    }


    public class Slots
    {
        public Object obj { get; set; }
        public Gpu    gpu { get; set; }

        public uint               slot_count { get; set; }
        public VkDescriptorType[] types      { get; set; }

        public uint                    push_count   { get; set; }
        public uint[]                  push_offsets { get; set; }
        public uint[]                  push_sizes   { get; set; }
        public VkShaderStageFlagBits[] push_shaders { get; set; }

        public VkPipelineLayout      pipeline_layout { get; set; }
        public VkDescriptorSetLayout dset_layout     { get; set; }
    }


    public class Bindings
    {
        public Object obj { get; set; }
        public Gpu    gpu { get; set; }

        public Slots slots { get; set; }

        public uint              dset_count { get; set; }
        public VkDescriptorSet[] dsets      { get; set; }

        public BufferRegions[] br       { get; set; }
        public Images[]        images   { get; set; }
        public Sampler[]       samplers { get; set; }
    }


    public class Compute
    {
        public Object  obj     { get; set; }
        public Gpu     gpu     { get; set; }
        public Context context { get; set; }

        public          string shader_path { get; set; } = new(new char[1024]);
        public readonly string ShaderCode;

        public VkPipeline     pipeline      { get; set; }
        public Slots          slots         { get; set; }
        public Bindings       bindings      { get; set; }
        public VkShaderModule shader_module { get; set; }
    }


    public class VertexBinding
    {
        public uint binding { get; set; }
        public uint stride  { get; set; }
    }


    public class VertexAttr
    {
        public  uint     binding  { get; set; }
        public  uint     location { get; set; }
        private VkFormat format   { get; set; }
        public  uint     offset   { get; set; }
    }


    public class Graphics
    {
        public Object obj { get; set; }
        public Gpu    gpu { get; set; }

        public GraphicsType type         { get; set; }
        public int          flags        { get; set; }
        public bool         support_pick { get; set; }
        public object       user_data    { get; set; }

        public Renderpass renderpass { get; set; }
        public uint       subpass    { get; set; }

        public VkPrimitiveTopology topology     { get; set; }
        public BlendType           blend_type   { get; set; }
        public DepthTest           depth_test   { get; set; }
        public VkPolygonMode       polygon_mode { get; set; }
        public VkCullModeFlagBits  cull_mode    { get; set; }
        public VkFrontFace         front_face   { get; set; }

        public VkPipeline pipeline { get; set; }
        public Slots      slots    { get; set; }

        public uint            vertex_binding_count { get; set; }
        public VertexBinding[] vertex_bindings      { get; set; public

        private uint         vertex_attr_count { get; set; }
        public  VertexAttr[] vertex_attrs      { get; set; }

        public uint                    shader_count   { get; set; }
        public VkShaderStageFlagBits[] shader_stages  { get; set; }
        public VkShaderModule[]        shader_modules { get; set; }

        public GraphicsCallback callback { get; set; }
    }


    public class BarrierBuffer
    {
        public BufferRegions br             { get; set; }
        public bool          queue_transfer { get; set; }

        public VkAccessFlagBits src_access { get; set; }
        public uint             src_queue  { get; set; }

        public VkAccessFlagBits dst_access { get; set; }
        public uint             dst_queue  { get; set; }
    }


    public class BarrierImage
    {
        public Images[] images         { get; set; }
        public bool     queue_transfer { get; set; }

        public VkAccessFlagBits src_access { get; set; }
        public uint             src_queue  { get; set; }
        public VkImageLayout    src_layout { get; set; }

        public VkAccessFlagBits dst_access { get; set; }
        public uint             dst_queue  { get; set; }
        public VkImageLayout    dst_layout { get; set; }
    }


    public class Barrier
    {
        public Object obj { get; set; }
        public Gpu    gpu { get; set; }

        public VkPipelineStageFlagBits src_stage { get; set; }
        public VkPipelineStageFlagBits dst_stage { get; set; }

        public uint            buffer_barrier_count { get; set; }
        public BarrierBuffer[] buffer_barriers      { get; set; }

        public uint           image_barrier_count { get; set; }
        public BarrierImage[] image_barriers      { get; set; }
    }


    public class Fences
    {
        public Object obj { get; set; }
        public Gpu    gpu { get; set; }

        public uint      count  { get; set; }
        public VkFence[] fences { get; set; }
    }


    public class Semaphores
    {
        public Object obj { get; set; }
        public Gpu    gpu { get; set; }

        public uint          count      { get; set; }
        public VkSemaphore[] semaphores { get; set; }
    }


    public class RenderpassAttachment
    {
        public  VkImageLayout            ref_layout { get; set; }
        public  RenderpassAttachmentType type       { get; set; }
        private VkFormat                 format     { get; set; }

        public VkImageLayout src_layout { get; set; }
        public VkImageLayout dst_layout { get; set; }

        public VkAttachmentLoadOp  load_op  { get; set; }
        public VkAttachmentStoreOp store_op { get; set; }
    }


    public class RenderpassSubpass
    {
        public uint   attachment_count { get; set; }
        public uint[] attachments      { get; set; }
    }


    public class RenderpassDependency
    {
        public uint                    src_subpass { get; set; }
        public VkPipelineStageFlagBits src_stage   { get; set; }
        public VkAccessFlagBits        src_access  { get; set; }

        public uint                    dst_subpass { get; set; }
        public VkPipelineStageFlagBits dst_stage   { get; set; }
        public VkAccessFlagBits        dst_access  { get; set; }
    }


    public class Framebuffers
    {
        public Object     obj        { get; set; }
        public Gpu        gpu        { get; set; }
        public Renderpass renderpass { get; set; }

        public uint attachment_count { get; set; }

        public Images[]        attachments       { get; set; }
        public uint            framebuffer_count { get; set; }
        public VkFramebuffer[] framebuffers      { get; set; }
    }


    public class Renderpass
    {
        public Object obj { get; set; }
        public Gpu    gpu { get; set; }

        public uint                   attachment_count { get; set; }
        public RenderpassAttachment[] attachments      { get; set; }

        public uint           clear_count  { get; set; }
        public VkClearValue[] clear_values { get; set; }

        public uint                subpass_count { get; set; }
        public RenderpassSubpass[] subpasses     { get; set; }

        public uint                   dependency_count { get; set; }
        public RenderpassDependency[] dependencies     { get; set; }

        public VkRenderPass renderpass { get; set; }
    }


    public class Submit
    {
        public Object obj { get; set; }
        public Gpu    gpu { get; set; }

        public uint       commands_count { get; set; }
        public Commands[] commands       { get; set; }

        public uint                      wait_semaphores_count { get; set; }
        public uint[]                    wait_semaphores_idx   { get; set; }
        public Semaphores[]              wait_semaphores       { get; set; }
        public VkPipelineStageFlagBits[] wait_stages           { get; set; }

        public uint         signal_semaphores_count { get; set; }
        public uint[]       signal_semaphores_idx   { get; set; }
        public Semaphores[] signal_semaphores       { get; set; }
    }


    public class Texture
    {
        public Object obj { get; set; }

        public Context context { get; set; }

        public Images  image   { get; set; }
        public Sampler sampler { get; set; }
    }
}
