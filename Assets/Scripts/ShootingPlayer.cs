using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingPlayer : MonoBehaviour
{
    private GameObject _laserObject;
    private float _firingRate;
    private float _timerShoot;

    // Start is called before the first frame update
    void Start()
    {
        _laserObject = Resources.Load<GameObject>("Laser");
        _firingRate = 0.5f;
        _timerShoot = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }

    private void Shoot()
    {
        _timerShoot += 1 * Time.deltaTime;
        if (Input.GetKey(KeyCode.Space) && _timerShoot > _firingRate)
        {
            Instantiate(_laserObject,transform.Find("LeftSpawnShoot").position, Quaternion.identity);
            Instantiate(_laserObject, transform.Find("RightSpawnShoot").position, Quaternion.identity);
            _timerShoot = 0;
        }
    }
}
