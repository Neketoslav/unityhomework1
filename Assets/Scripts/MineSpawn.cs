using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineSpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject _mina;
    [SerializeField]
    private Transform _minaPositions;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Instantiate(_mina, _minaPositions.position, _minaPositions.rotation);
        }
    }
}
