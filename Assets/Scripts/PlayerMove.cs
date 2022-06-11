using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    Rigidbody _rb;
    [SerializeField] float speed = 0;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        
    }

    private void FixedUpdate()
    {
        var _hori = Input.GetAxis("Horizontal");
        var _vert = Input.GetAxis("Vertical");

        _rb.velocity = new Vector3(_hori, 0, _vert) * speed;
    }

    
}
