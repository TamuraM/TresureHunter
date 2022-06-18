using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>�v���C���[�̈ړ�</summary>
public class PlayerMove : MonoBehaviour
{
    Rigidbody _rb;
    [SerializeField] float speed = 0;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        
    }

    private void FixedUpdate()
    {
        //���E�ړ�
        var _hori = Input.GetAxis("Horizontal");
        var _vert = Input.GetAxis("Vertical");

        _rb.velocity = new Vector3(_hori, 0, _vert) * speed;
    }

    
}
