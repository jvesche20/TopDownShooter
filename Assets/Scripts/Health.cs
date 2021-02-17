using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    // Start is called before the first frame update

    private int lives = 3;
    public Text myText;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        myText.text = "Lives: " + lives;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy" || other.gameObject.tag == "EnemyBullet")
        {
            lives--;
            transform.position = new Vector3(0, 0, 0);
        }
        if (lives == 0)
        {

            LoadScene("Lose Screen");
        }

    }
    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }


}
