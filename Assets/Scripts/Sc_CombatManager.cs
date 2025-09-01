using UnityEngine;
using System.Collections.Generic;
using static Enums;
using System.Collections;
using System;
using UnityEngine.Events;

[System.Serializable]
public struct ST_ActionFlag
{
    public string message;
    public float time;
    public E_CombatPhases phaseLabel;
}

public class Sc_CombatManager : Singleton<Sc_CombatManager>
{
    [SerializeField] private List<Sc_Unit> unitsInCombatList = new List<Sc_Unit>();
    [SerializeField] private List<string> FTR_messages = new List<string>();
    [SerializeField] private Sc_Deque dequeRef;
    [SerializeField] private ST_ActionFlag af_startCombat;
    [SerializeField] private ST_ActionFlag af_decisionMaking;
    private Sc_EventManager eventManagerRef;
    private E_CombatPhases currentPhase=E_CombatPhases.START;

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
        Announce(af_startCombat);
    }

    private void Announce(ST_ActionFlag flag)
    {
        eventManagerRef.SendTextToAnnounce(flag.message);
        StartCoroutine(ActionTimer(flag.time));
    }

    private IEnumerator ActionTimer(float timeToWait)
    {
        Scp_TurnDurationTimer.Instance.FTR_StartTimer(timeToWait);
        yield return new WaitForSeconds(timeToWait);
        //toremove, it's just for feedback
        eventManagerRef.SendTextToAnnounce("");
        //       
        CallNextAction();
    }

    private void CallNextAction()
    {
        if (!dequeRef.isDequeEmpty())
        {
            SwitchPhase();
        }else
        {

        }
        //if(dequeRef.isDequeEmpty())
        Debug.Log("Fuck it I need a canbeputinthequeue class");
        //S_Move currentMove=dequeRef.GetTopFlag();
       // switch(currentMove.hide)
    }

    private void SwitchPhase()
    {
        //debugstuff
        bool isEnding = false;
        bool isDecision = true;
        //
        //if the combat is not ended, switch to decisionmaking
        //if the combat ended, switch to ending(not necessary needed to pass trough the deque in that case)
        if (isDecision)
        {
            Announce(af_decisionMaking);
            eventManagerRef.DecisionPhaseStart();
        }
        if (isEnding)
        {
            Debug.Log("endingcalled");
        }
    }
}

