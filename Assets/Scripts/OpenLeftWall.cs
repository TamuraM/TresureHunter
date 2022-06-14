using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLeftWall : MonoBehaviour
{
    [SerializeField] GameObject _enemy;
    [SerializeField] float _speed;
    [SerializeField] float _xRange;

    void Update()
    {
        if (!_enemy.activeSelf)
        {
            if (transform.position.x > _xRange)
            {
                transform.position += new Vector3(_speed, 0, 0);
            }

        }
    }
}
