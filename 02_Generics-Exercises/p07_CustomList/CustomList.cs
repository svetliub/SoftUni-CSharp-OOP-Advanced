using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CustomList<T> : IEnumerable<T>
    where T : IComparable<T>
{
    private List<T> data;

    public CustomList()
    {
        this.data = new List<T>();
    }

    public T this[int index]
    {
        get { return this.data[index]; }
        set { this.data[index] = value; }
    }

    public int Count => this.data.Count;

    public void Add(T element)
    {
        this.data.Add(element);
    }

    public T Remove(int index)
    {
        T item = this.data[index];
        this.data.RemoveAt(index);
        return item;
    }

    public bool Contains(T element)
    {
        return this.data.Any(i => i.Equals(element));
    }

    public void SwapString(int firstIndex, int secondIndex)
    {
        T firstBox = this.data[firstIndex];
        T secondBox = this.data[secondIndex];

        this.data[firstIndex] = secondBox;
        this.data[secondIndex] = firstBox;
    }

    public int CountGreaterThan(T element)
    {
        int count = 0;
        foreach (var box in this.data)
        {
            if (box.CompareTo(element) > 0)
            {
                count++;
            }
        }

        return count;
    }

    public T Max()
    {
        T max = this.data[0];
        for (int i = 1; i < this.Count; i++)
        {
            if (max.CompareTo(this.data[i]) < 0)
            {
                max = this.data[i];
            }
        }

        return max;
    }

    public T Min()
    {
        T min = this.data[0];
        for (int i = 1; i < this.Count; i++)
        {
            if (min.CompareTo(this.data[i]) > 0)
            {
                min = this.data[i];
            }
        }

        return min;
    }

    public void Print()
    {
        foreach (var item in this.data)
        {
            Console.WriteLine(item);
        }
    }

    public void Sort()
    {
        this.data.Sort();
    }

    public IEnumerator<T> GetEnumerator()
    {
        return this.data.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}