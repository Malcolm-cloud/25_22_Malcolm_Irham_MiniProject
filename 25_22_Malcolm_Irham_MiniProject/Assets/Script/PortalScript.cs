using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PortalScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            if (SceneManager.GetActiveScene().buildIndex != 2)
            {
                GameManager.Health = 20;
            }
        }
        if(other.tag == "Bullet")
        {
            Destroy(other.gameObject);
        }
    }
}
