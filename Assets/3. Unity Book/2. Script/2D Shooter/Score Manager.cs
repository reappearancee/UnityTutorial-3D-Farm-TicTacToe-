using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance = null;
    public TextMeshProUGUI currentScoreUI;
    public TextMeshProUGUI bestScoreUI;
    
    public int currentScore;
    public int bestScore;

    public int Score
    {
        get { return currentScore; }

        set
        {
            currentScore = value;
            currentScoreUI.text = "현재 점수 : " + currentScore;
            if (currentScore > bestScore)
            {
                bestScore = currentScore;
                bestScoreUI.text = "최고 점수 : " + bestScore;

                PlayerPrefs.SetInt("BestScore", bestScore);
            }
        }
    }

    
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    void Start()
    {
        bestScore = PlayerPrefs.GetInt("BestScore",0); 
        
        bestScoreUI.text = "최고 점수 : " + bestScore;
    }

    public void SetScore(int value)
    {
        currentScoreUI.text = "현재 점수 : " + currentScore;

        if (currentScore > bestScore)
        {
            bestScore = currentScore;
            bestScoreUI.text = "최고 점수 : " + bestScore;
            
            PlayerPrefs.SetInt("BestScore", bestScore);
        }
    }

    public int GetScore()
    {
        return currentScore;
    }
}