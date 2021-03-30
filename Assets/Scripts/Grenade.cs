using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour
{
    [SerializeField]
    private GameObject _grenade;
    [SerializeField]
    private Transform _pointStart;
    [SerializeField]
    private float _power = 5f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            var a = Instantiate(_grenade, _pointStart.position, _pointStart.rotation);
            a.GetComponent<Rigidbody>().AddForce(_pointStart.forward * _power, ForceMode.Impulse);
        }
    }
}
