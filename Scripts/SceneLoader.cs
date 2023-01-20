using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string sceneName;
    //Loads a scene on mouse up
    private void OnMouseUpAsButton() {
        SceneManager.LoadScene(sceneName);
    }
}
