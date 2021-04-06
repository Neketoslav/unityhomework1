using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineBoom : MonoBehaviour
{
    [SerializeField]
    private int _damage = 1;
    [SerializeField]
    public float _explosionRadius = 10f;
    [SerializeField]
    public float _power = 250f;
    [SerializeField]
    private Transform _physicObjects;
    private Rigidbody[] _physicObject;
    private AudioSource _boomSound;

    private void Awake()
    {
        _boomSound = GetComponent<AudioSource>();
       // _boomSound.Stop();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            BoomForce();
            _boomSound.Play();
            var enemy = other.GetComponent<ZombieHealth>();
            enemy.Hurt(_damage);
            Destroy(gameObject, 1f);
        }
        else if (other.gameObject.CompareTag("Player"))
        {
            BoomForce();
            _boomSound.Play();
            var player = other.GetComponent<Health>();
            player.Hurt(_damage);
            Destroy(gameObject, 1f);
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            _boomSound.Play();
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

