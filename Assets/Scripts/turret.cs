using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turret : MonoBehaviour
{
    [SerializeField]
    private Transform _target;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Vector3 Pos = _target.position - transform.position;
            Quaternion rotation = Quaternion.LookRotation(Pos);
            transform.rotation = rotation;
        }
    }
}
