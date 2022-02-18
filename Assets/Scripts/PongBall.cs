using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongBall : MonoBehaviour
{
    [SerializeField] private  ball;

    private static readonly WaitForSeconds restartWait = new WaitForSeconds(1);

    private void RestartGame()
    {
        mainRigidbody.position = Vector2.zero;
        mainRigidbody.velocity = Vector2.zero;

        StartCoroutine(WaitThenRestart());
    }

    private IEnumerator WaitThenRestart()
    {
        yield return restartWait;
        Vector2 newVelocity = new Vector2(Random.Range(0f, 5f), Random.Range(0f, 1f));
        mainRigidbody.velocity = newVelocity.normalized * startSpeed;

    }
}
