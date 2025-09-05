using System.Collections.Generic;
using UnityEngine;

public class Sc_Deque : MonoBehaviour
{
    private LinkedList<Sc_DequeElement> elementsDeque = new LinkedList<Sc_DequeElement>();
    
    public bool isDequeEmpty()
    {
        if (elementsDeque.Count <= 0)
            return true;
        return false;
    }

    public void QueueFlagToTop(Sc_DequeElement flag)
    {
        elementsDeque.AddFirst(flag);
    }
    public void QueueFlagToBottom(Sc_DequeElement flag)
    {
        elementsDeque.AddLast(flag);
    }

    public Sc_DequeElement GetTopFlag()
    {
        Sc_DequeElement flag = elementsDeque.First.Value;
        elementsDeque.RemoveFirst();
        return flag;
    }
    public Sc_DequeElement GetLastFlag()
    {
        Sc_DequeElement flag = elementsDeque.Last.Value;
        elementsDeque.RemoveLast();
        return flag;
    }
    public Sc_DequeElement PeekTopFlag()
    {
        Sc_DequeElement flag = elementsDeque.First.Value;
        return flag;
    }
    public Sc_DequeElement PeekLastFlag()
    {
        Sc_DequeElement flag = elementsDeque.Last.Value;
        return flag;
    }
    public void ClearDeque()
    {
        elementsDeque.Clear();
    }
}
