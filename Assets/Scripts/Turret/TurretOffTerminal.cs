using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TurretOffTerminal : MonoBehaviour
{
    [SerializeField]
    private GameObject _turret;
    [SerializeField]
    private GameObject _turret2;
    [SerializeField]
    private TMP_Text _task2;
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            _task2.fontStyle = FontStyles.Strikethrough;
            _turret.gameObject.GetComponent<BoxCollider>().enabled = false;
            _turret2.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
}
