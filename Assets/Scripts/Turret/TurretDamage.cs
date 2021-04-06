using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretDamage : MonoBehaviour
{
    [SerializeField]
    private int _damage = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            var enemy = other.GetComponent<Health>();
            enemy.Hurt(_damage);
            Destroy(gameObject);
        }
    }
}

