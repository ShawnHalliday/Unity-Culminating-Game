using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class TImedisplay : MonoBehaviour
{
    public TMP_Text secondsPlayed;
    private TimeTracking tt;
    //get the variable from TimeTracking script
    void Start()
    {
        tt = GetComponent<TimeTracking>();
    }

    // Update the time displayed
    void Update()
    {
        secondsPlayed.text = "Seconds Played: " + Math.Round(tt.totalTimePlayed);
    }
}
