using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    int score = 0;
    public TextMeshProUGUI scoreText;
    public GameObject msgText;
    public CameraShooter cs;

    public void IncreaseScore(){
        score++;
        scoreText.text=score.ToString();
    }

    public void GameEnd(){
        msgText.SetActive(true);
        cs.enabled = false;
        Time.timeScale=0f;
    }
}
