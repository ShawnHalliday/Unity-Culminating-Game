using System.Runtime.CompilerServices;
using UnityEngine;

public class EscapeHud : MonoBehaviour
{
    public GameObject hud;

    void Update()
    {
        //Checks if you press escape and if you do it unhides the escape menu ui
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
            hud.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }
    }
}