using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeyOpenDoor : MonoBehaviour
{
    [SerializeField]
    private GameObject door;
    private Animator _animator;
    [SerializeField]
    private TMP_Text _task1;

    private void Start()
    {
        _animator = door.GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            var openDoor = _animator.GetBool("OpenDoor");
            _animator.SetBool("OpenDoor", !openDoor);
            _task1.fontStyle = FontStyles.Strikethrough;
            Destroy(gameObject);
        }
    }
}
