using System.Collections.Generic;
using UnityEngine;

public class Sc_Effect : MonoBehaviour
{
    private S_Effect assignedEffect;
    /// <summary>
    /// no target means directed to the env
    /// </summary>
    public List<Sc_Unit> targetList = new List<Sc_Unit>();

    public void SetEffect(S_Effect passedEffect)
    {
        assignedEffect = passedEffect;
    }
    public void MakeMove()
    {

    }
}
