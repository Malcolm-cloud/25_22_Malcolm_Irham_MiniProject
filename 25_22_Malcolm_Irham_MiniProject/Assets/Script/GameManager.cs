using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public enum GameState { GameOver, GameInProgress, GamePaused };
    public static GameState CurrentState = GameState.GamePaused;

    public static GameManager thisManager;
    public Text Txt_Message;
    public Text ScoreText;
    public Text LivesText;

    public static float Health = 20;
    public static float Score = 0;

    void Start()
    {
        CurrentState = GameState.GamePaused;
        Scene CurrentScene = SceneManager.GetActiveScene();
        Scene FirstScene = SceneManager.GetSceneByName("level 1");
        if(CurrentScene == FirstScene)
        {
            Health = 20;
        }
        
        Time.timeScale = 0;
        thisManager = this;
    }

    void Update()
    {
        PlayerPrefs.SetFloat("PlayerHealth", Health);
        PlayerPrefs.SetFloat("PlayerScore", Score);
        if (CurrentState == GameState.GamePaused)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Time.timeScale = 1;
                CurrentState = GameState.GameInProgress;
                Txt_Message.gameObject.SetActive(false);
            }
        }
        ScoreText.text = "Score : " + Score;
        LivesText.text = "Health : " + Health;

        if(Health <= 0)
        {
            CurrentState = GameState.GamePaused;
            SceneManager.LoadScene("Lose");
        }
    }
}
