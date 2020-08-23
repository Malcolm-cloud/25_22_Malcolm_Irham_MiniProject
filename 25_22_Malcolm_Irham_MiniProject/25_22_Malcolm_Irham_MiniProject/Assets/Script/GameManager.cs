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

    public static float Lives = 3;
    public static float Score = 0;

    void Start()
    {
        thisManager = this;
    }

    void Update()
    {
        if (CurrentState == GameState.GamePaused)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                CurrentState = GameState.GameInProgress;
                Txt_Message.gameObject.SetActive(false);
            }
        }
        ScoreText.text = "Score : " + Score;
        LivesText.text = "Lives : " + Lives;
    }
}
