using UnityEngine;
using System.Collections.Generic;

public class Sc_CombatManager : Singleton<Sc_CombatManager>
{
    [SerializeField] private List<Sc_Unit> unitsInCombatList = new List<Sc_Unit>();
    [SerializeField] private List<string> FTR_messages = new List<string>();
    private Sc_EventManager eventManagerRef;
    protected override void OnEnable()
    {
        base.OnEnable();
        if (!eventManagerRef)
            eventManagerRef = Sc_EventManager.Instance;
    }

    private void Start()
    {
        //TOREMOVESECTION
        StartCombat();
        //
    }

    public void StartCombat()
    {
        eventManagerRef.SendTextToAnnounce(FTR_messages);
        //Scp_TurnDurationTimer.Instance.FTR_StartTimer();
    }
}

