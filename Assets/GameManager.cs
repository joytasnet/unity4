using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    int score = 0;
    public TextMeshProUGUI scoreText;
    public GameObject msgText;

    public void IncreaseScore(){
        score++;
        scoreText.text=score.ToString();
    }

    public void GameEnd(){
        msgText.SetActive(true);
        Time.timeScale=0f;
    }
}
