using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParalaxEffect : MonoBehaviour
{
    private float _velocity;
    private Vector2 _direction;
    private float _imageSideSize;
    private Vector2 _initialPosition;
    
    // Start is called before the first frame update
    void Start()
    {
        _initialPosition = transform.position;
        _velocity = 0.5f;
        _direction = Vector2.down;
        _imageSideSize = 20;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = _initialPosition + ((_velocity * Time.time) % _imageSideSize) * _direction;
    }
}
