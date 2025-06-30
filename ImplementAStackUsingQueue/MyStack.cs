namespace ImplementAStackUsingQueue;

internal class MyStack
{
    private Queue<int> data = new Queue<int>();
    private Queue<int> helper = new Queue<int>();

    public MyStack() { }

    public void Push(int x)
    {
        helper.Enqueue(x);
        while(data.Count > 0)
        {
            helper.Enqueue(data.Dequeue());
        }
        data = new Queue<int>(helper);
        helper.Clear();
    }

    public void PushupWithOneArm(int x)
    {
        data.Enqueue(x);
        for (int i = 0; i < data.Count - 1; i++)
        {
            data.Enqueue(data.Dequeue());
        }
    }

    public int Pop()
    {
        return data.Dequeue();
    }

    public int Top()
    {
        return data.Peek();
    }

    public bool Empty()
    {
        return data.Count == 0;
    }
}