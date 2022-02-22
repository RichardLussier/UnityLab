using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PongGoal : MonoBehaviour
{
    public event Action onScore;

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("ball")) {
            onScore?.Invoke();
        }
    }
}