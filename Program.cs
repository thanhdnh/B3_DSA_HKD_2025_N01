public class Node{
    public object data;
    public Node next;  
}
public class MyStack{
    Node top;
    public bool IsEmpty(){
        return top == null;
    }
    public void Push(object data){
        Node newNode = new Node();
        newNode.data = data;
        newNode.next = top;
        top = newNode;
    }
    public object Pop(){
        if(IsEmpty()){
            return null;
        }
        object data = top.data;
        top = top.next;
        return data;
    }
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
        int v = (int)stack.Pop();
        Console.WriteLine(v);
    }
}