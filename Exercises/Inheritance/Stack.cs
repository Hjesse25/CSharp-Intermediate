using System.Collections;

namespace Inheritance;

public class Stack
{
    private readonly ArrayList _list = [];

    public void Push(object obj)
    {
        if (obj is null)
        {
            throw new InvalidOperationException("Object cannot be null.");
        }
        else
        {
            _list.Add(obj);
        }
    }

    public object Pop()
    {
        object? lastElement = null;
        int lastIndex = _list.Count - 1;

        foreach (var element in _list)
        {
            if (_list.IndexOf(element) == lastIndex)
            {
                lastElement = element;
            }
        }

        if (lastElement != null)
        {
            _list.Remove(lastElement);
            return lastElement;
        }

        return "null";
    }

    public void Clear()
    {
        _list.Clear();
    }
}
