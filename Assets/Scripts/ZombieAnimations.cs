using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAnimations : MonoBehaviour
{

    private Animator _animationRun;

    private void Start()
    {
        _animationRun = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            var isChangeState = _animationRun.GetBool("isChangeState");
            _animationRun.SetBool("isChangeState", !isChangeState);
        }
    }


    private void OnTriggerEnter(Collider other)
     {
        if (other.gameObject.CompareTag("Player"))
        {
            _animationRun.SetTrigger("Run");
        }
    }
     private void OnTriggerExit(Collider other)
     {
        if (other.gameObject.CompareTag("Player"))
        {
            _animationRun.SetTrigger("Run");
        }
    } 
}
