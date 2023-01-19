using UnityEngine;

public class TeleportOnHit : MonoBehaviour
{
    public Vector3 teleportPosition = new Vector3(0, 2, 0);

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.position = teleportPosition;
        }
    }
}
