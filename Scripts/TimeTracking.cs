using UnityEngine;
using System.IO;

public class TimeTracking : MonoBehaviour
{
    [SerializeField] private float startTime;
    public float totalTimePlayed;

    void Start()
    {
        // Load the total time played from a file
        if (File.Exists("total_time_played.txt"))
        {
            totalTimePlayed = float.Parse(File.ReadAllText("total_time_played.txt"));
        }

        // Set the start time
        startTime = Time.time;
    }

    void Update()
    {
        // Update the total time played
        totalTimePlayed += Time.deltaTime;
    }

    void OnApplicationQuit()
    {
        // Save the total time played to a file
        File.WriteAllText("total_time_played.txt", totalTimePlayed.ToString());
    }
}
