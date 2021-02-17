using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodingScript : MonoBehaviour
{
    public Transform explosionEffect;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Damage")
        {
            Instantiate(explosionEffect, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
