using System.Collections;

public class Node
{
    public object data;
    public Node next;
}
public class MyStack
{
    Node top;
    public int count = 0;
    public bool IsEmpty()
    {
        return top == null;
    }
    public void Push(object data)
    {
        Node newNode = new Node();
        newNode.data = data;
        newNode.next = top;
        top = newNode;
        count++;
    }
    public object Pop()
    {
        if (IsEmpty())
        {
            return null;
        }
        object data = top.data;
        top = top.next;
        if(count>=0)
            count--;
        return data;
    }
    public int Count()
    {
        int count = 0;
        MyStack temp = new MyStack();
        object ob = (int)Pop();
        while (ob != null)
        {
            temp.Push(ob);
            count++;
            ob = Pop();
        }
        while (!temp.IsEmpty())
            Push(temp.Pop());
        return count;
    }
    public object Peek()
    {
        /*object t = Pop();
        Push(t);
        return t;*/
        return top.data;
    }
    public void Reverse()
    {
        List<object> list = new List<object>();
        while (!IsEmpty())
            list.Add(Pop());
        for (int i = 0; i < list.Count; i++)
            Push(list[i]);
    }
    //Bổ sung các phương thức: Sort, Clear, Contains, Remove.
}
public class Node2
{
    public Node2 prev, next;
    public object data;
}
public class MyQueue
{
    Node2 rear, front;
    public int count = 0;

    public bool IsEmpty()
    {
        return rear == null || front == null;
    }
    public void Enqueue(object ele)
    {
        Node2 n = new Node2();
        n.data = ele;
        if (rear == null)
        {
            rear = n; front = n;
        }
        else
        {
            rear.prev = n;
            n.next = rear; rear = n;
        }
        count++;
    }
    public Node2 Dequeue()
    {
        if (front == null) return null;
        Node2 d = front;
        front = front.prev;
        if (front == null)
            rear = null;
        else
            front.next = null;
        if(count>=0)
            count--;
        return d;
    }
    public object Peek(){
        return front.data;
    }
    //Bổ sung các phương thức: Reverse, Sort, Clear, Contains, Remove.
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();

        MyStack stack = new MyStack();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        //int v = (int)stack.Pop();
        Console.WriteLine(stack.Count());
        Console.WriteLine(stack.count);
        Console.WriteLine("Peek: " + stack.Peek());
        stack.Reverse();

        Stack st = new Stack();
        Stack<int> stint = new Stack<int>();
        //st.Peek

    }
}
