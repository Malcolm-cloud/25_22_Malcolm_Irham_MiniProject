using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class QuitBaton : MonoBehaviour
{
    public void Quitt()
    {
        Application.Quit();
        Debug.Log("Casting - Sudoku on application");
    }

}
