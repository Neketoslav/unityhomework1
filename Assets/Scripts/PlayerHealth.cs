using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] 
    private int _health;
    [SerializeField]
    private GameObject _heal;

    public void HurtPlayer(int damage)
    {
        print("Ouch:" + damage);

        _health -= damage; ;

        if (_health <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Heal"))
        {
            _health++;
            Destroy(other.gameObject);
        }
    }
}
