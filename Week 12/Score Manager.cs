using UnityEngine;
using TMPro;  // note this is TextMeshPro

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public int score = 0;
    public TMP_Text scoreText;  // TMP_Text instead of Text

    void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);
    }

    public void AddScore(int amount)
    {
        score += amount;
        if (scoreText != null) scoreText.text = "Score: " + score;
    }
}
