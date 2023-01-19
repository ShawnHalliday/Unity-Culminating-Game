using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseMenu : MonoBehaviour
{
    public GameObject hud;
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
    public void statsMenu()
    {

    }
}
