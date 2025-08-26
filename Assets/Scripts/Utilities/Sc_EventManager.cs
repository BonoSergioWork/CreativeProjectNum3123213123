using System;
using UnityEngine;

/// <summary>
/// There should be only ONE event manager per gamesession, and it's created at the very start
///public event Action<> OnEvent;
///public event Action<type value> OnParameterEvent;
/// </summary>
/// 
public class Sc_EventManager : Singleton<Sc_EventManager>
{
    public event Action<string> OnSendTextToAnnounce;

    //checks if the instance exists
    public void SendTextToAnnounce(string msg)
    {
        if (OnSendTextToAnnounce != null)
        {
            OnSendTextToAnnounce(msg);
        }
    }

}
