using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAttack : MonoBehaviour
{
    [SerializeField]
    private int _damage;
    [SerializeField]
    private GameObject _target;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            InvokeRepeating(nameof(Attack), 1f,2f);
           
        }
    }
    private void Attack()
    {     
            var player = _target.GetComponent<Health>();
            player.Hurt(_damage);
           CancelInvoke(nameof(Attack));
    }
}
