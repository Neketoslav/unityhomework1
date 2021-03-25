using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeBoom : MonoBehaviour
{
    [SerializeField]
    private int _damage;
    private void Update()
    {
        Invoke("Boom", 5f);
        Destroy(gameObject, 6f);
    }
    private void Boom()
    {
        gameObject.SetActive(true);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            var damage = other.GetComponent<Health>();
            damage.Hurt(_damage);
        }
    }
}
