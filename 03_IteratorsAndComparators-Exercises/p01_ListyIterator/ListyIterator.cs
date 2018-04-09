using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class ListyIterator<T> : IEnumerable<T>
{
    private List<T> data;

    private int index;

    public ListyIterator(List<T> data)
    {
        this.data = data;
        this.index = 0;
    }

    public bool Move()
    {
        this.index++;
        var isMovable = this.index < this.data.Count;
        if (!isMovable)
        {
            this.index--;
        }
        return isMovable;
    }

    public bool HasNext()
    {
        return this.index < this.data.Count - 1;
    }

    public void Print()
    {
        if (this.data.Count <= 0)
        {
            throw new InvalidOperationException("Invalid Operation!");
        }

        Console.WriteLine(this.data[this.index]);
    }

    public void PrintAll()
    {
        Console.WriteLine(string.Join(" ", this.data));
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < this.data.Count; i++)
        {
            yield return this.data[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}