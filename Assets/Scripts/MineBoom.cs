using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineBoom : MonoBehaviour
{
    [SerializeField]
    private int _damage;
    [SerializeField]
    private GameObject _explos;
    [SerializeField]
    private Transform _boomhere;
    private GameObject boom;
   

    private void OnTriggerEnter(Collider other)
     {

        if (other.gameObject.CompareTag("Enemy"))
         {
            boom = Instantiate(_explos, _boomhere.position, _boomhere.rotation);
            var enemy = other.GetComponent<ZombieHealth>();
             enemy.Hurt(_damage);
             Destroy(gameObject);
            
        }
         else if (other.gameObject.CompareTag("Player"))
         {
             var player = other.GetComponent<PlayerHealth>();
             player.HurtPlayer(_damage);
             Destroy(gameObject);
        }
        
        Invoke("Test", 5f);
    }
    private void Test()
    {
        Destroy(boom);
        print("test");
    }
}

