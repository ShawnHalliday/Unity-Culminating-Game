using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class TImedisplay : MonoBehaviour
{
    public TMP_Text secondsPlayed;
    private TimeTracking tt;
    void Start()
    {
        tt = GetComponent<TimeTracking>();
    }

    // Update is called once per frame
    void Update()
    {
        secondsPlayed.text = "Seconds Played: " + Math.Round(tt.totalTimePlayed);
    }
}
