using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Finish : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _task3;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _task3.fontStyle = FontStyles.Strikethrough;
        }
    }
}
