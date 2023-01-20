using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadTutMain : MonoBehaviour
{
    //Play function for main menu loads the tutorial scene
    public void Play()
    {
        SceneManager.LoadScene("Tutorial");
    }
}