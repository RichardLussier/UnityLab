using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PongManager : MonoBehaviour
{
    [SerializeField] private PongBall ball;
    [SerializeField] private PongGoal redGoal;
    [SerializeField] private PongGoal blueGoal;
    [SerializeField] private TMP_Text redScore;
    private int redScoreNumber = 0;
    [SerializeField] private TMP_Text blueScore;
    private int blueScoreNumber = 0;
    [SerializeField] private int amountToWin;
    [SerializeField] private TMP_Text winningText;


    private void Awake()
    {
        redGoal.onScore += HandleBlueScore;
        blueGoal.onScore += HandleRedScore;
        ball.RestartGame();
    }

    private void HandleBlueScore() {
        blueScoreNumber++;
        if(blueScoreNumber == amountToWin) {
            DisplayWinText(true);
        }
        blueScore.SetText(blueScoreNumber.ToString());
        ball.RestartGame();
    }

    private void HandleRedScore() {
        redScoreNumber++;
        if(redScoreNumber == amountToWin) {
            DisplayWinText(false);
        }
        redScore.SetText(redScoreNumber.ToString());
        ball.RestartGame();
    }

    private IEnumerator DisplayWinText(bool blueWins) {
        if(blueWins) {
            winningText.SetText("Blue Team Wins!");
        } else {
            winningText.SetText("Red Team Wins!");
        }

        float timeUntilReload = Time.realtimeSinceStartup + 3;
        while(timeUntilReload > Time.realtimeSinceStartup) {
            yield return null;
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
