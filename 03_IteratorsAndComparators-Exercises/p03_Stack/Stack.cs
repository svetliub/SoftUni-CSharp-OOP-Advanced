using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Stack<T> : IEnumerable<T>
{
    private const int DEFAULT_CAPACITY = 4;
    private T[] data;
    public int Count { get; private set; }
    private int capacity;

    public Stack()
    {
        this.capacity = DEFAULT_CAPACITY;
        this.data = new T[this.capacity];
        this.Count = 0;
    }

    public void Push(params T[] elements)
    {
        for (int i = 0; i < elements.Length; i++)
        {
            this.Count++;
            if (this.Count > this.capacity)
            {
                T[] newData = new T[this.capacity * 2];
                this.capacity *= 2;
                Array.Copy(this.data, newData, this.Count - 1);
                this.data = newData;
            }

            this.data[this.Count - 1] = elements[i];
        }
    }

    public void Pop()
    {
        if (this.Count == 0)
        {
            Console.WriteLine("No elements");
            return;
        }

        this.Count--;
        this.data[this.Count] = default(T);
        
        if (this.Count < this.capacity / 3 && this.Count > 0)
        {
            T[] newData = new T[this.capacity / 2];
            this.capacity /= 2;
            Array.Copy(this.data, newData, this.Count - 1);
            this.data = newData;
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = this.Count - 1; i >= 0; i--)
        {
            yield return this.data[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}