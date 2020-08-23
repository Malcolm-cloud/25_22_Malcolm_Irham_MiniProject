using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalValue : MonoBehaviour
{
    public Text HealthRemainingText;
    public Text FinalScoreText;

    float HealthRemaining;
    float FinalScore;
    // Start is called before the first frame update
    void Start()
    {
        HealthRemaining = PlayerPrefs.GetFloat("PlayerHealth");
        FinalScore = PlayerPrefs.GetFloat("PlayerScore");

        HealthRemainingText.text = "Remaining Health : " + HealthRemaining;
        FinalScoreText.text = "Score : " + FinalScore;
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}
