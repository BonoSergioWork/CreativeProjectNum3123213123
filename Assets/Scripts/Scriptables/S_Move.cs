using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MOVE_", menuName = "ScriptableObjects/NewMove", order = 1)]
public class S_Move : ScriptableObject
{
    [SerializeField] private List<Sc_EffectFather> EffectList= new List<Sc_EffectFather>();
}
