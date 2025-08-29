using System.Collections.Generic;
using UnityEngine;

public class Sc_Deque : MonoBehaviour
{
    private LinkedList<S_Move> flagDeque = new LinkedList<S_Move>();
    
    public bool isDequeEmpty()
    {
        if (flagDeque.Count <= 0)
            return true;
        return false;
    }

    public void QueueFlagToTop(S_Move flag)
    {
        flagDeque.AddFirst(flag);
    }
    public void QueueFlagToBottom(S_Move flag)
    {
        flagDeque.AddLast(flag);
    }

    public S_Move GetTopFlag()
    {
        S_Move flag = flagDeque.First.Value;
        flagDeque.RemoveFirst();
        return flag;
    }
    public S_Move GetLastFlag()
    {
        S_Move flag = flagDeque.Last.Value;
        flagDeque.RemoveLast();
        return flag;
    }
    public S_Move PeekTopFlag()
    {
        S_Move flag = flagDeque.First.Value;
        return flag;
    }
    public S_Move PeekLastFlag()
    {
        S_Move flag = flagDeque.Last.Value;
        return flag;
    }
}
