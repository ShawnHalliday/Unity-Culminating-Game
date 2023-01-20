using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class UpdateMainTime : MonoBehaviour
{
    public TMP_Text TimeText;
    private TimeTracking tt;
    // Start is called before the first frame update
    void Start()
    {
        tt = GetComponent<TimeTracking>();
    }

    // Update is called once per frame
    void Update()
    {
        TimeText.text = "Total Seconds Played: " + Math.Round(tt.totalTimePlayed);
    }
}
