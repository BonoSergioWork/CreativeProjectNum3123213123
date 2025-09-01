using System.Collections.Generic;
using UnityEngine;

public class Sc_Deque : MonoBehaviour
{
    private LinkedList<S_DequeElement> elementsDeque = new LinkedList<S_DequeElement>();
    
    public bool isDequeEmpty()
    {
        if (elementsDeque.Count <= 0)
            return true;
        return false;
    }

    public void QueueFlagToTop(S_DequeElement flag)
    {
        elementsDeque.AddFirst(flag);
    }
    public void QueueFlagToBottom(S_DequeElement flag)
    {
        elementsDeque.AddLast(flag);
    }

    public S_DequeElement GetTopFlag()
    {
        S_DequeElement flag = elementsDeque.First.Value;
        elementsDeque.RemoveFirst();
        return flag;
    }
    public S_DequeElement GetLastFlag()
    {
        S_DequeElement flag = elementsDeque.Last.Value;
        elementsDeque.RemoveLast();
        return flag;
    }
    public S_DequeElement PeekTopFlag()
    {
        S_DequeElement flag = elementsDeque.First.Value;
        return flag;
    }
    public S_DequeElement PeekLastFlag()
    {
        S_DequeElement flag = elementsDeque.Last.Value;
        return flag;
    }
    public void ClearDeque()
    {
        elementsDeque.Clear();
    }
}
