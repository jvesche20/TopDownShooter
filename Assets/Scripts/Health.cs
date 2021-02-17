using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    // Start is called before the first frame update
    // 18 zombies

    private int lives = 3;
    

    public Image h1;
    public Image h2;
    public Image h3;
    private bool isColliding = false;



    // Update is called once per frame


    private void OnTriggerEnter(Collider other)
    {
        if (isColliding)
            return;
        isColliding = true;
        if (other.gameObject.tag == "Enemy" || other.gameObject.tag == "EnemyBullet")
        {
            lives--;
            transform.position = new Vector3(-29, 1, -23);
            
            Debug.Log(lives);
        }
        if (lives <= 0)
        {

            LoadScene("Lose Screen");
        }
        if(lives == 2)
        {
            Destroy(h1.gameObject);
        }
        if(lives == 1)
        {
            Destroy(h2.gameObject);
        }

    }
    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }
    void Update()
    {
        isColliding = false;
    }

}
