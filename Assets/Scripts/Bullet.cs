using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Bullet : MonoBehaviour
{
    public GameObject projectile;
    public float shootForce = 20f;

    //public ParticleSystem explosion;
    //public GameObject Enemy;
    public static int killed = 0;

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            GameObject shot = GameObject.Instantiate(projectile, transform.position, transform.rotation);
            shot.GetComponent<Rigidbody>().AddForce(transform.forward * shootForce);
            Destroy(shot, 3);

        }
        if(killed == 18)
        {
            killed = 0; 
            LoadScene("Win Screen 1");
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            killed++;
            
        }
    }
    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }

}
