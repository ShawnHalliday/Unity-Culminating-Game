using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class UpdateMainTime : MonoBehaviour
{
    public TMP_Text TimeText;
    private TimeTracking tt;
    // allowing me to use variables from a different script
    void Start()
    {
        tt = GetComponent<TimeTracking>();
    }

    // Displaying Total time played
    void Update()
    {
        TimeText.text = "Total Seconds Played: " + Math.Round(tt.totalTimePlayed);
    }
}
