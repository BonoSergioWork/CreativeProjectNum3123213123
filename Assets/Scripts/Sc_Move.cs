using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;


public class Sc_Move : Sc_DequeElement
{
    private S_Move assignedMove;
    /// <summary>
    /// no target means directed to the env
    /// </summary>
    public List<Sc_Unit> targetList = new List<Sc_Unit>();

    public void SetMove(S_Move passedMove)
    {
        assignedMove = passedMove;
    }
    public void MakeMove()
    {

    }
}
