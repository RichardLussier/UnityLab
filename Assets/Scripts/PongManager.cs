using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongManager : MonoBehaviour
{
    [SerializeField] private GameObject ball;
    [SerializeField] private GameObject redPaddle;
    [SerializeField] private GameObject bluePaddle;
    [SerializeField] private GameObject redGoal;
    [SerializeField] private GameObject blueGoal;

    private void Awake()
    {
        redGoal.onScore += HandleBlueScore;
        blueGoal.onScore += HandleRedScore;
        ball.Restart();
    }

    private static readonly WaitForSeconds restartWait = new WaitForSeconds(1);

    private void RestartGame()
    {
        Destroy(ball);
        StartCoroutine(WaitThenRestart());
    }

 
    private IEnumerator WaitThenRestart()
    {
        yield return restartWait;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name());
    }
}
