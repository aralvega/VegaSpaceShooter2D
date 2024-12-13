using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    private GameObject _enemyObject;
    private float _velocity;

    // Start is called before the first frame update
    void Start()
    {
        _enemyObject = Resources.Load<GameObject>("BasicEnemy");
        transform.position = new Vector2(-8.41f, 4.46f);
        _velocity = 3.364f;
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        //first enemies wave

        for (int i = 0; i < 5; i++)
        {
            Instantiate(_enemyObject, transform.position, Quaternion.identity);
            transform.Translate(Vector2.right * _velocity);
            yield return new WaitForSeconds(0.5f);
        }


        
    }
}
