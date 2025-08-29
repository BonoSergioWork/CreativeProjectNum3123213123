using System.ComponentModel;
using TMPro;
using UnityEngine;

/// <summary>
/// SCP stands for SCRIPT PRODUCTION and FTR_ for "function to remove", so it's not to be included in the game.<br/>
/// make all public, I need to read D A T A S.<br/><br/>
///need this script to simulate the animations and stuff like that
///it moves along with the stepper
/// </summary>
public class Scp_TurnDurationTimer : Singleton<Scp_TurnDurationTimer>
{
    public TextMeshProUGUI txtTimer;
    public float maxtime=0f;
    public float currentTime=0f;
    public bool canCount=false;

    public void FTR_StartTimer(float allDuration=3f)
    {
        maxtime = allDuration;
        canCount = true;
    }
    private void Update()
    {
        CountUp();
    }

    private void CountUp()
    {
        if (canCount)
        {
            currentTime += Time.deltaTime;
            txtTimer.text = Mathf.FloorToInt(currentTime).ToString();
            if (currentTime >= maxtime)
            {
                currentTime = 0f;
                canCount = false;
                txtTimer.text = currentTime.ToString();
                Debug.Log("TIMER STOPPED WEEEEEEEE");
            }
        }
    }
}
