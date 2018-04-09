using System;
using System.Collections.Generic;
using System.Text;

public class Node<T>
{
    public Node(T value)
    {
        this.Value = value;
        this.Next = null;
    }

    public T Value { get; set; }

    public Node<T> Next { get; set; }
}