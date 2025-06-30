namespace ImplementQueueUsingStacks;

internal class MyQueue
{
    private Stack<int> data = new Stack<int>();
    private Stack<int> helper = new Stack<int>();

    public MyQueue() { }

    public void Push(int x)
    {
        helper.Push(x);
    }

    public int Pop()
    {
        if (data.Count == 0)
        {
            while (helper.Count > 0)
            {
                data.Push(helper.Pop());
            }
        }
        return data.Pop();
    }

    public int Peek()
    {
        if (data.Count == 0)
        {
            while (helper.Count > 0)
            {
                data.Push(helper.Pop());
            }
        }
        return data.Peek();
    }

    public bool Empty()
    {
        return data.Count == 0 && helper.Count == 0;
    }
}
