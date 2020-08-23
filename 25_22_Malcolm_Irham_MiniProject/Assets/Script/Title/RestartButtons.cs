using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RestartButtons : MonoBehaviour
{
    public void RestartingGame()
    {
        SceneManager.LoadScene(0);
        GameManager.Score = 0;
        Debug.Log("IS IT WORKING YET?????");
    }
}
