using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyShootScript : MonoBehaviour
{
    public NavMeshAgent pathfinding;
    public GameObject muzzle;
    public GameObject projectle;
    public float visionRange;
    public GameObject eyes;
    public bool pursuing = false;
    private GameObject target;
    float elapsed = 0f;

    public GameObject projectile;
    public float shootForce = 20f;
    public GameObject Muzzle;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!pursuing)
        {
            Ray ray = new Ray(eyes.transform.position, this.transform.forward * visionRange);
            Debug.DrawRay(ray.origin, ray.direction * visionRange, Color.red);

            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                //Debug.Log("I see something");
                pursuing = true;
                target = hit.transform.gameObject;
            }
        }
        else
        {
            elapsed += Time.deltaTime;
            //Debug.Log(target.name);
            pathfinding.SetDestination(target.transform.position);
            if(elapsed >= 3f)
            {
                elapsed = elapsed % 3f;
                GameObject shot = GameObject.Instantiate(projectile, Muzzle.transform.position, Muzzle.transform.rotation);
                shot.GetComponent<Rigidbody>().AddForce(transform.forward * shootForce);
                Destroy(shot, 3);
                //Debug.Log(Time.time);
            }
            

        }
    }
}
