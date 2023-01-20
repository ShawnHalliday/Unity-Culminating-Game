using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class DebugButton : MonoBehaviour
{
    // Start is called before the first frame update
    public void DebugLogOnButton()
    {
        Debug.Log("Works???");
    }
    void Update()
    {
        UnityEngine.Cursor.visible = true;
        UnityEngine.Cursor.lockState = CursorLockMode.None;
    }
}
