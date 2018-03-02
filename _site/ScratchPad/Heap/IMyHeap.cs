namespace ScratchPadTests.Heap
{
    public interface IMyHeap<T>
    {
        T ExtractMin();

        T PeekMin();

        void DecreaseKey(int i, T newValue);

        void Insert(T newValue);

        void DeleteKey(int i);
    }
}