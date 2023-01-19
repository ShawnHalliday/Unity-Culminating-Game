using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretControl : MonoBehaviour
{
    //listing variables
    private Transform Player;
    private float distance;
    public float maxDistance;
    public Transform Turret;
    public Transform TurretRotRef;
    public Vector3 offset = new Vector3(-90, 0, -90);
    public GameObject Projectile;
    public float projectileForce;
    public float firerate;
    private float nextfire = 1;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        //calculate the distance between the player and the turret and check if it will be less then the maxDistance variable
        distance = Vector3.Distance(Player.position, transform.position);
        if (distance <= maxDistance)
        {
            //Make the reference object rotate following the Player and set the actual turrets rotation equal to that with offsets for bug fixes
            TurretRotRef.LookAt(Player);
            Turret.transform.rotation = TurretRotRef.transform.rotation * Quaternion.Euler(offset);
            if(Time.time >= nextfire)
            {
                nextfire = Time.time + 1f/firerate;
                shoot();
            }
            
        }
    }

    void shoot()
    {
        GameObject clone = Instantiate(Projectile, Turret.position, TurretRotRef.transform.rotation);
        clone.GetComponent<Rigidbody>().AddForce(TurretRotRef.transform.forward * projectileForce);
        Destroy(clone, 2);
        //add force forward
    }
}
