using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyEnemy : MonoBehaviour
{
    // Start is called before the first frame update

    public ParticleSystem explosion;
    public GameObject Enemy;
    float elapsed = 0f;
    
    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Bullet")
        {
            
            ParticleSystem explosionEffect = Instantiate(explosion) as ParticleSystem;
            explosionEffect.transform.position = transform.position;
            explosionEffect.Play();
            Enemy.SetActive(false);

            elapsed += Time.deltaTime;
            if (elapsed >= 3f)
                Destroy(this.gameObject);
            
            

            
            

        }
    }
    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }
}