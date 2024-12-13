using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ShotBehaviour : MonoBehaviour
{
    private float _velocity;
    // Start is called before the first frame update
    void Start()
    {
        _velocity = 8;
    }

    // Update is called once per frame
    void Update()
    {
        MoveShot();
        DestroyShoot();
    }

    private void MoveShot()
    {
        transform.Translate(Vector2.up * _velocity * Time.deltaTime);
    }

    private void DestroyShoot()
    {
        if(transform.position.y > 4.46f)
        {
            Destroy(this.gameObject);
        }
    }
}
