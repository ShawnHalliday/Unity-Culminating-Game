using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Samething as CloseMenu.CS except it works on the tutorial scene
public class lvl1closemenu : MonoBehaviour
{
    public GameObject hud;
    public GameObject settingsopt;
    public GameObject closemenubut;
    public GameObject leavegamebut;
    public GameObject settingsbut;

    // Start is called before the first frame update
    public void closeMenu()
    {
        Cursor.visible = false;
        hud.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void leaveGame()
    {
        Application.Quit();
    }
    public void settingsbuttonMenu()
    {
        settingsopt.SetActive(true);
        closemenubut.SetActive(false);
        leavegamebut.SetActive(false);
        settingsbut.SetActive(false);


    }
    public void back()
    {
        settingsopt.SetActive(false);
        closemenubut.SetActive(true);
        leavegamebut.SetActive(true);
        settingsbut.SetActive(true);
        Debug.Log("????");
    }
}
