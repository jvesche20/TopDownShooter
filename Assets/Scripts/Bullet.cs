using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Bullet : MonoBehaviour
{
    public GameObject projectile;
    public float shootForce = 20f;

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            GameObject shot = GameObject.Instantiate(projectile, transform.position, transform.rotation);
            shot.GetComponent<Rigidbody>().AddForce(transform.forward * shootForce);
            Destroy(shot, 3);

        }
        
    }

    

}
