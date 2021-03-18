using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed = 5;
    [SerializeField]
    private Vector3 _direction;
    [SerializeField]
    private Transform _forward;
    [SerializeField]
    private Transform _left;
    [SerializeField]
    private Transform _right;

    private void Start()
    {
        
    }
    void Update()
    {
       // _direction.x = Input.GetAxis("Horizontal");
        _direction.z = Input.GetAxis("Vertical");
        _direction.y = Input.GetAxis("Jump");
        if (Input.GetKey(KeyCode.D))
        {
            transform.RotateAround(_right.position, Vector3.up, 80 * Time.deltaTime);
        }

        else if (Input.GetKey(KeyCode.A))
        {
            transform.RotateAround(_left.position, Vector3.down, 80 * Time.deltaTime);
        }
    }
    private void FixedUpdate()
{
    var speed = _direction * _speed * Time.deltaTime;
    transform.Translate(speed);
        
    }

}
