// Shawn Halliday
// 2023/01/20
// Movement Game
// This script and the following script is telling the engine to do something either when the function is called or at the start or every frame
// The stuff it gets told to do can varry from player movement and the functionality of a button.
// All scripts play a crucial role in the game working and are all needed
using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public class CloseMenu : MonoBehaviour
{
    //Setting Variables as Public so I cana define what they are based on what I attach in the unity inspector
    public GameObject hud;
    public GameObject settingUI;
    public GameObject closeMenuButton;
    public GameObject leaveGameButton;
    public GameObject settingButton;

    //Hides the cursor and closes the menu and locks the cursor back to the middle of the screen
    public void closeMenu()
    {
        Cursor.visible = false;
        hud.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }
    //Quits the game
    public void leaveGame()
    {
        Application.Quit();
    }
    //Changing the visible ui elements to show stats
    public void settingsbuttonMenu()
    {
        settingUI.SetActive(true);
        closeMenuButton.SetActive(false);
        leaveGameButton.SetActive(false);
        settingButton.SetActive(false);


    }
    //Chaninging ui elements to go back to the regular escape menu ui
    public void back()
    {
        settingUI.SetActive(false);
        closeMenuButton.SetActive(true);
        leaveGameButton.SetActive(true);
        settingButton.SetActive(true);
        //debugging code
        Debug.Log("????");
    }
}
