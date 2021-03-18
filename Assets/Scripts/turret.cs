using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    [SerializeField]
    private Transform _target;
    [SerializeField]
    private GameObject _shot;
    [SerializeField]
    private Transform _startShot;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Vector3 Pos = _target.position - transform.position;
            Quaternion rotation = Quaternion.LookRotation(Pos);
            transform.rotation = rotation;
            InvokeRepeating("shot", 0f, 4f);
        }
    }
    private void shot()
    {
        Instantiate(_shot, _startShot.position, _startShot.rotation);
        GetComponent<Rigidbody>().AddForce(Vector3.forward * 10, ForceMode.Impulse);
    }

} 
