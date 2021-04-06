using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Finish : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _taskThree;
    [SerializeField]
    private GameObject _win;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _taskThree.fontStyle = FontStyles.Strikethrough;
            _win.SetActive(true);
        }
    }
}
