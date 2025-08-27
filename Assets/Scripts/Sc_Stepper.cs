using UnityEngine;

public class Sc_Stepper : MonoBehaviour
{
    private Sc_EventManager eventManagerRef;
    private void OnEnable()
    {
        if (!eventManagerRef)
            eventManagerRef = Sc_EventManager.Instance;
    }

    public void MakeStep()
    {
        eventManagerRef.MakeStep();
    }
}
