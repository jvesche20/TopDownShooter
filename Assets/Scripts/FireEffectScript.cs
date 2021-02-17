using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireEffectScript : MonoBehaviour
{
    public Transform effect;
    public Transform nozzlePos;
    public ParticleSystem partSystem;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            //Instantiate(effect, nozzlePos.position, nozzlePos.rotation);
            partSystem.Play();
        }
    }
}
