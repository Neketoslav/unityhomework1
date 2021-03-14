using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heal : MonoBehaviour
{
    [SerializeField]
    private Transform _heal;
    void Update()
    {
        _heal.Rotate(Vector3.up * Time.deltaTime * 20);    
    }
}
