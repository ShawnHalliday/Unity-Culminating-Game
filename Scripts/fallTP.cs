using UnityEngine;

public class fallTP : MonoBehaviour
{
    //Checks every frame if you fall below -15 and if you do it teleports you back to 0, 2, 0
    void Update()
    {
        if (transform.position.y <= -15)
        {
            transform.position = new Vector3(0, 2, 0);
        }
    }
}