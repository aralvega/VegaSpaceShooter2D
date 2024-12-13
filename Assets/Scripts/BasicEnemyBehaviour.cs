using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemyBehaviour : MonoBehaviour
{
    private GameObject _laserObject;
    private float _velocity;

    // Start is called before the first frame update
    void Start()
    {
        _velocity = 7;
        _laserObject = Resources.Load<GameObject>("BasicEnemyLaser");
        StartCoroutine("Shoot");
    }

    // Update is called once per frame
    void Update()
    {
        Move();   
    }

    private void Move()
    {
        transform.Translate(Vector2.down * _velocity * Time.deltaTime);
    }

    IEnumerator Shoot()
    {
        Instantiate(_laserObject, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(0.2f);
    }

    


}
