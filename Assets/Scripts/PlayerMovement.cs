using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float _velocity;
    void Start()
    {
        _velocity = 5;
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        ClampMovement();
    }

    private void MovePlayer()
    {
        float inputH = Input.GetAxisRaw("Horizontal");
        float inputV = Input.GetAxisRaw("Vertical");
        transform.Translate(new Vector2(inputH, inputV).normalized * _velocity * Time.deltaTime);
   
    }

    private void ClampMovement()
    {
        float xClamped = Mathf.Clamp(transform.position.x, -8.41f, 8.41f);
        float yClamped = Mathf.Clamp(transform.position.y, -4.46f, 4.46f);
        transform.position = new Vector2(xClamped, yClamped);
    }
}
