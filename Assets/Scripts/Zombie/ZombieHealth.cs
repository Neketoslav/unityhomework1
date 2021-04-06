using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieHealth : MonoBehaviour
{
    [SerializeField]
    private int _health;

    public void Hurt(int damage)
    {
        print("Ouch:" + damage);

        _health -= damage; ;

        if (_health <= 0)
        {
            Destroy(gameObject);
        }
    }

}

