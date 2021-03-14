using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerEnemy : MonoBehaviour
{
    [SerializeField]
    private GameObject _zobmie;
    [SerializeField]
    private Transform _zombieSpawnPlace;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            
        {
            Instantiate(_zobmie, _zombieSpawnPlace.position, _zombieSpawnPlace.rotation);
        }

    }
}
