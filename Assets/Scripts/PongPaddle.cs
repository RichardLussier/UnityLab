using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongPaddle : MonoBehaviour
{
    [SerializeField] private Transform paddle;
    [SerializeField] private KeyCode UpKey;
    [SerializeField] private KeyCode DownKey;
    [Range(150, 350)][SerializeField] private float moveSpeed;
    static int maxY = 265;
    static int minY = -265;

    void Update() {

        float currentY = paddle.position.y;

        if(Input.GetKey(UpKey) && paddle.position.y < maxY) {
            currentY += Time.deltaTime * moveSpeed;
        } else if(Input.GetKey(DownKey) && paddle.position.y > minY) {
            currentY -= Time.deltaTime * moveSpeed;
        }
        paddle.position = new Vector2(paddle.position.x, currentY);

    }
}
