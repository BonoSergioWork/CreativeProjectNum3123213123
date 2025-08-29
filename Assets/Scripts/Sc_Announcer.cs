using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

/// <summary>
/// Announcer can't be singleton, but it should have an event listener so it can be used everywhere
/// </summary>

public class Sc_Announcer : MonoBehaviour
{
    [SerializeField] private float typeWritingTime=0.05f;

    private TextMeshProUGUI txtAnnouncer;
    /// <summary>
    /// Text to write is always the active text to show, therefore it isn't necessary to pass it as parameter
    /// </summary>
    private string textToWrite;
    private bool isWriting;
    private int currentIndex = 0;
    private Sc_EventManager eventManagerRef;

    private void Awake()
    {
        try
        {
            txtAnnouncer = GetComponent<TextMeshProUGUI>();
        }
        catch (System.Exception e)
        {
            Debug.LogError(e.ToString());
        }
    }

    private void OnEnable()
    {
        if (!eventManagerRef)
            eventManagerRef = Sc_EventManager.Instance;

        eventManagerRef.OnSendTextToAnnounce += ReceiveText;
    }
    private void OnDisable()
    {
        eventManagerRef.OnSendTextToAnnounce -= ReceiveText;
    }

    public void ReceiveText(string textList)
    {
        textToWrite = textList;
        currentIndex = 0;
        ImmediateWriteText();
    }

    private void ImmediateWriteText()
    {
        txtAnnouncer.text = textToWrite;

        isWriting = false;
        currentIndex++;
    }
    public void ContinueText()
    {
        ImmediateWriteText();
    }
}
