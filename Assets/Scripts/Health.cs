using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] 
    private int _health;
    [SerializeField]
    private GameObject _heal;

    public void Hurt(int damage)
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
