using UnityEngine;
using System;

public class GameEvents : MonoBehaviour
{
    public static GameEvents current;
    
    private void Awake()
    {
        current = this;
    }

    public event Action eventCradleActive;


    public void SetCradleActive()
    {
        Debug.Log("Event function called");
        if (eventCradleActive != null)
        {
            eventCradleActive();
            Debug.Log("cradle active event");
        }
    }
}