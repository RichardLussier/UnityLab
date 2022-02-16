using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongManager : MonoBehaviour
{
    [SerializeField] private GameObject ball;
    [SerializeField] private GameObject redPaddle;
    [SerializeField] private GameObject bluePaddle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private static readonly WaitForSeconds restartWait = new WaitForSeconds(1);

    private void RestartGame()
    {
        Destroy(ball);
        StartCoroutine(WaitThenReload());
    }

    private IEnumerator WaitThenRestart()
    {
        yield return restartWait;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name());
    }
}
