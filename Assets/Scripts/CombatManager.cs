using UnityEngine;
using System.Collections.Generic;

public class Sc_CombatManager : Singleton<Sc_CombatManager>
{
    [SerializeField] private List<Sc_Unit> unitsInCombatList = new List<Sc_Unit>();
}

