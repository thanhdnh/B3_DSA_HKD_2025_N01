using System.Collections;

public class Node{
    public object data;
    public Node next;  
}
public class MyStack{
    Node top;
    public int count = 0;
    public bool IsEmpty(){
        return top == null;
    }
    public void Push(object data){
        Node newNode = new Node();
        newNode.data = data;
        newNode.next = top;
        top = newNode;
        count++;
    }
    public object Pop(){
        if(IsEmpty()){
            return null;
        }
        object data = top.data;
        top = top.next;
        count--;
        return data;
    }
    public int Count(){
        int count = 0;
        MyStack temp = new MyStack();
        object ob = (int)Pop();
        while(ob!=null){
            temp.Push(ob);
            count++;
            ob = Pop();
        }
        while(!temp.IsEmpty())
            Push(temp.Pop());
        return count;
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
        //int v = (int)stack.Pop();
        Console.WriteLine(stack.Count());
        Console.WriteLine(stack.count);

        //Stack st = new Stack();
        
    }
}