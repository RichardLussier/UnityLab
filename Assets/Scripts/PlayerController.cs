using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private Rigidbody2D mainRigidbody;
    [SerializeField] private SpriteRenderer mainSpriteRenderer;
    [Range(50, 500)][SerializeField] private float moveSpeed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            mainRigidbody.AddForce(new Vector2(-moveSpeed * Time.deltaTime, 0));
            mainSpriteRenderer.flipX = true;
        } else if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            mainRigidbody.AddForce(new Vector2(moveSpeed * Time.deltaTime, 0));
            mainSpriteRenderer.flipX = false;
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            mainRigidbody.AddForce(new Vector2(0, 200));
        }
    }
}
