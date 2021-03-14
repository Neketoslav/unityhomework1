using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openFire : MonoBehaviour
{
    [SerializeField]
    private GameObject _fire;
    [SerializeField]
    private Transform _startFire;
    [SerializeField]
    private Transform _endFire;
    void start()
    {
        var shot = Instantiate(_fire, _startFire.position, _startFire.rotation);
        transform.Translate(Vector3.forward * Time.deltaTime);

    }
}
