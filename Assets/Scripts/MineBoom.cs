using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineBoom : MonoBehaviour
{
    [SerializeField]
    private int _damage = 1;
    [SerializeField]
    public float _explosionRadius = 10;
    [SerializeField]
    public float _power = 250;
    [SerializeField]
    private Transform _physicObjects;
    private Rigidbody[] _physicObject;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            BoomForce();
            var enemy = other.GetComponent<ZombieHealth>();
            enemy.Hurt(_damage);
            Destroy(gameObject);
        }
        else if (other.gameObject.CompareTag("Player"))
        {
            BoomForce();
            var player = other.GetComponent<Health>();
            player.Hurt(_damage);
            Destroy(gameObject);
        }
    }
    private void BoomForce()
    {
        _physicObject = FindObjectsOfType(typeof(Rigidbody)) as Rigidbody[];
        for (int i = 0; i < _physicObject.Length; i++)
        {
            if (Vector3.Distance(transform.position, _physicObject[i].transform.position) <= _explosionRadius)
            {
                _physicObject[i].AddForce((_physicObjects.position - transform.position).normalized * _power);
            }
        }
    }
}

