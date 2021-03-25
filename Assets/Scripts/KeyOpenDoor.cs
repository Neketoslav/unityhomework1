using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyOpenDoor : MonoBehaviour
{
    [SerializeField]
    private GameObject door;
    private Animator _animator;

    private void Start()
    {
        _animator = door.GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            var OpenDoor = _animator.GetBool("OpenDoor");
            _animator.SetBool("OpenDoor", !OpenDoor);
            Destroy(gameObject);
        }
    }
}
