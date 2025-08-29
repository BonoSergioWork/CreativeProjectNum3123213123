using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SOmove_", menuName = "ScriptableObjects/NewMove", order = 1)]
public class S_Move : ScriptableObject
{
    public string name;
    public Animation anim;
    public int damage;
    public float timeNeeded;
    public List<Sc_Unit> unitsTargetedList= new List<Sc_Unit>();
    public List<Sc_EffectFather> effectsList= new List<Sc_EffectFather>();
}
