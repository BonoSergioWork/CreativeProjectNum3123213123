using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "S_Move", menuName = "Scriptable Objects/S_Move")]
public class S_Move : ScriptableObject
{
    public string moveName;
    public string moveDesc;
    public List<S_Effect> effectList= new List<S_Effect>();
}
