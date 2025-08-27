using UnityEngine;
using System.Collections.Generic;
using static Enums;

public class Sc_CombatManager : Singleton<Sc_CombatManager>
{
    [SerializeField] private List<Sc_Unit> unitsInCombatList = new List<Sc_Unit>();
    [SerializeField] private List<string> FTR_messages = new List<string>();
    private LinkedList<S_CombatAction> d = new LinkedList<S_CombatAction>();
    private Sc_EventManager eventManagerRef;
    private E_CombatPhases currentPhase;

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
        currentPhase=E_CombatPhases.START;
        eventManagerRef.SendTextToAnnounce(FTR_messages);
        //Scp_TurnDurationTimer.Instance.FTR_StartTimer();
    }
}

