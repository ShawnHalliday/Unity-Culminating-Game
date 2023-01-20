using UnityEngine;
using UnityEngine.SceneManagement;

public class KillColider : MonoBehaviour
{
    //Defining object
    public GameObject objectToTeleport;
    //checks if you collide with the object, if you do, you get teleported to 0,2,0
    private void OnCollisionEnter(Collision collision)
    {
        objectToTeleport.transform.position = new Vector3(0, 2, 0);
    }
}
