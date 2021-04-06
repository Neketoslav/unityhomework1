using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    private Animator _animatorRun;
    private void Start()
    {
        _animatorRun = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            _animatorRun.SetBool("Walking", true);
        }
        else if (!Input.GetKey(KeyCode.W) || !Input.GetKey(KeyCode.S))
        {
            _animatorRun.SetBool("Walking", false);
        }
    }
}
