using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenFire : MonoBehaviour
{
    [SerializeField]
    private GameObject _bullet;
    [SerializeField]
    private Transform _pointStart;
    [SerializeField]
    private float _power = 20f;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject b = Instantiate(_bullet, transform.position, transform.rotation);
            GetComponent<Rigidbody>().AddForce(Vector3.forward * _power, ForceMode.Impulse);
        }
    }
}
