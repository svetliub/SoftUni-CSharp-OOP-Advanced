using System;
using System.Collections.Generic;

public class Box<T>
    where T : IComparable<T>
{
    private List<T> boxList;
    //public T Value { get; set; }

    public Type FullName { get; }

    public Box(List<T> boxList)
    {
        //this.Value = value;
        this.FullName = typeof(T);
        this.boxList = boxList;
    }

    public int CompareCount(T element)
    {
        int count = 0;
        foreach (var box in this.boxList)
        {
            if (box.CompareTo(element) > 0)
            {
                count++;
            }
        }

        return count;
    }

    //public override string ToString()
    //{
    //    return $"{this.FullName}: {this.Value}";
    //}
}