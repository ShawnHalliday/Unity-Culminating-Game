using UnityEngine;
using UnityEngine.SceneManagement;

public class KillColider : MonoBehaviour
{
    public GameObject objectToTeleport;
    private void OnCollisionEnter(Collision collision)
    {
        objectToTeleport.transform.position = new Vector3(0, 2, 0);
    }
}
