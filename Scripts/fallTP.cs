using UnityEngine;

public class fallTP : MonoBehaviour
{
    void Update()
    {
        if (transform.position.y <= -15)
        {
            transform.position = new Vector3(0, 2, 0);
        }
    }
}