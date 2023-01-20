using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StatsMain : MonoBehaviour
{
    public GameObject PlayButton;
    public GameObject QuitButton;
    public GameObject StatsButton;
    public GameObject BackButton;
    public GameObject StatValueHolder;

    private void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void Stats()
    {
        PlayButton.SetActive(false);
        QuitButton.SetActive(false);
        StatsButton.SetActive(false);
        BackButton.SetActive(true);
        StatValueHolder.SetActive(true);
    }
    public void Back()
    {
        PlayButton.SetActive(true);
        QuitButton.SetActive(true);
        StatsButton.SetActive(true);
        BackButton.SetActive(false);
        StatValueHolder.SetActive(false);
    }
}
