using System.Runtime.CompilerServices;
using UnityEngine;

public class EscapeHud : MonoBehaviour
{
    public GameObject hud;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
            hud.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }
    }
}