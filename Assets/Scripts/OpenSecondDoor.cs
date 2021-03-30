using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSecondDoor : MonoBehaviour
{
    [SerializeField]
    private GameObject _door;
    private Animator _animator;
    private void Start()
    {
        _animator = _door.GetComponent<Animator>();
    }
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            var OpenDoor = _animator.GetBool("OpenDoor");
            _animator.SetBool("OpenDoor", !OpenDoor);
        }
    }
}
