var minh = new MinHeap<string>();
minh.Insert("bebra 4", 4);
minh.Insert("bebra 1", 1);
minh.Insert("bebra 5", 5);
minh.Insert("bebra 2", 2);
minh.Insert("bebra 3", 3);
Console.WriteLine(minh.Pop());
Console.WriteLine(minh.Pop());
Console.WriteLine(minh.Pop());
Console.WriteLine(minh.Pop());
Console.WriteLine(minh.Pop());
Console.WriteLine(minh.Pop()); // empty output

public sealed class MinHeap<T>
{
    private class Node<TNodeValue>
    {
        private readonly TNodeValue _value;
        private readonly int _priority;

        public Node(TNodeValue value, int priority)
        {
            _value = value;
            _priority = priority;
        }

        public TNodeValue Value { get { return _value; } }

        public int Priority { get { return _priority; } }
    }

    private readonly List<Node<T>> _values;

    public MinHeap()
    {
        _values = [];
    }

    public MinHeap(T[] values)
    {
        _values = values.Select((x, i) => new Node<T>(x, i)).ToList();
    }

    public int Count => _values.Count;

    public T? Peek()
    {
        return _values[0].Value;
    }

    public T? Pop()
    {
        return RemoveRoot();
    }

    public void Insert(T value, int priority)
    {
        _values.Add(new Node<T>(value, priority));
        SiftUp(_values.Count - 1);
    }

    // BELOW ARE PRIVATE METHODS:

    private T? RemoveRoot()
    {
        if (_values.Count == 0)
        {
            return default;
        }

        var value = Peek();
        RemoveAt();
        return value;
    }

    private void RemoveAt(int rootIndex = 0)
    {
        SwapWithLeaf(rootIndex);
        _values.RemoveAt(Count - 1);
        SiftDown();
    }

    private void SwapWithLeaf(int index)
    {
    }

    private void SiftDown(int index = 0)
    {
    }

    private void SiftUp(int index)
    {
    }
}
