using System;
using System.Collections;
using System.Collections.Generic;

public class PriorityQueue<T, TPriority> : IEnumerable<T>
{
    private List<Tuple<T, TPriority>> elements = new List<Tuple<T, TPriority>>();
    private IComparer<TPriority> comparer;

    public PriorityQueue()
    {
        this.elements = new List<Tuple<T, TPriority>>();
        this.comparer = comparer ?? Comparer<TPriority>.Default;
    }

    public PriorityQueue(IComparer<TPriority> comparer)
    {
        this.elements = new List<Tuple<T, TPriority>>();
        this.comparer = comparer ?? Comparer<TPriority>.Default;
    }

    public int Count => elements.Count;

    public void Enqueue(T item, TPriority priority)
    {
        elements.Add(new Tuple<T, TPriority>(item, priority));
        elements.Sort((x, y) => comparer.Compare(x.Item2, y.Item2));
    }

    public bool IsEmpty()
    {
        return elements.Count == 0;
    }

    public T Dequeue()
    {
        if (elements.Count == 0)
            throw new InvalidOperationException("PriorityQueue is empty.");

        T result = elements[0].Item1;
        elements.RemoveAt(0);
        return result;
    }

    public IEnumerator<T> GetEnumerator()
    {
        foreach (var element in elements)
        {
            yield return element.Item1;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
