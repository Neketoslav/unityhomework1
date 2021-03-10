using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
[SerializeField]
private float _speed = 5;
[SerializeField]
private Vector3 _direction;

    void Update()
    {
        _direction.x = Input.GetAxis("Horizontal");
        _direction.z = Input.GetAxis("Vertical");
        _direction.y = Input.GetAxis("Jump");
    }
    private void FixedUpdate()
{
    var speed = _direction * _speed * Time.deltaTime;
    transform.Translate(speed);
}

}
