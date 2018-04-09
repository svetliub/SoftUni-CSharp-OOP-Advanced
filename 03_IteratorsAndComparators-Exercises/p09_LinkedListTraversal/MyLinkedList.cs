using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class MyLinkedList<T> : IEnumerable<T>
{
    public MyLinkedList()
    {
        this.Head = null;
        this.Tail = null;
        this.Count = 0;
    }

    public Node<T> Head { get; private set; }

    public Node<T> Tail { get; private set; }

    public int Count { get; private set; }

    public void Add(T element)
    {
        Node<T> oldNode = this.Tail;
        this.Tail = new Node<T>(element);

        if (this.Count == 0)
        {
            this.Head = this.Tail;
        }
        else
        {
            oldNode.Next = this.Tail;
        }

        this.Count++;
    }
    
    public bool Remove(T element)
    {
        if (this.Count == 0)
        {
            return false;
        }
        
        Node<T> currentNode = this.Head;
        Node<T> previousNode = null;

        while (currentNode != null)
        {
            if (currentNode.Value.Equals(element))
            {
                if (previousNode != null)
                {
                    previousNode.Next = currentNode.Next;
                }
                else
                {
                    this.Head = this.Head.Next;
                }

                break;
            }

            previousNode = currentNode;
            currentNode = currentNode.Next;
        }

        int count = 0;
        Node<T> tempNode = this.Head;

        while (tempNode != null)
        {
            count++;
            tempNode = tempNode.Next;
        }

        if (this.Count > count)
        {
            this.Count--;
            return true;
        }

        return false;
    }

    public IEnumerator<T> GetEnumerator()
    {
        Node<T> current = this.Head;
        while (current != null)
        {
            yield return current.Value;
            current = current.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}