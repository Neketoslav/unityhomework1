using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretOffTerminal : MonoBehaviour
{
    [SerializeField]
    private GameObject _turret;
    [SerializeField]
    private GameObject _turret2;
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            _turret.gameObject.GetComponent<BoxCollider>().enabled = false;
            _turret2.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
}
