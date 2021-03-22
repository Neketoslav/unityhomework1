using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    [SerializeField]
    private Transform _target;
    [SerializeField]
    private GameObject _bullet;
    [SerializeField]
    private Transform _pointStart;
    [SerializeField]
    private Transform _pointEnd;
    [SerializeField]
    private int _power = 100;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Vector3 Pos = _target.position - transform.position;
            Quaternion rotation = Quaternion.LookRotation(Pos);
            transform.rotation = rotation;          
            Invoke("shot", 10f*Time.deltaTime);
        }
    }
    private void shot()
    {
        var a = Instantiate(_bullet, _pointStart.position, _pointStart.rotation);
        a.GetComponent<Rigidbody>().AddForce(_pointStart.forward * _power, ForceMode.Impulse);
        Destroy(a, 10f * Time.deltaTime);
    }

} 
