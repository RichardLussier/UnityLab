using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongBall : MonoBehaviour
{
    [SerializeField] private Rigidbody2D mainRigidbody;
    [Range(100,300)][SerializeField] private int startSpeed;

    private static readonly WaitForSeconds restartWait = new WaitForSeconds(1);

    public void RestartGame()
    {
        mainRigidbody.position = Vector2.zero;
        mainRigidbody.velocity = Vector2.zero;

        StartCoroutine(WaitThenRestart());
    }

    private IEnumerator WaitThenRestart()
    {
        yield return restartWait;
        Vector2 newVelocity = new Vector2(Random.Range(-5f, 5f), Random.Range(-0.5f, 0.5f));
        mainRigidbody.velocity = newVelocity.normalized * startSpeed;

    }
}
