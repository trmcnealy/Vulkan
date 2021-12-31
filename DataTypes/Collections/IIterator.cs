namespace Vulkan
{
    public interface IIterator
    {
        int GetBias();
        int Move(int _Offset);
        void Next();
        void Prev();
        bool Valid();
    }
}