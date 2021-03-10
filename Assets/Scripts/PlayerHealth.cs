using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private int _health;

    public void HurtPlayer(int damage)
    {
        print("Ouch:" + damage);

        _health -= damage; ;

        if (_health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
