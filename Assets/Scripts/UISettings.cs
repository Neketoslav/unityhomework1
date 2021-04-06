using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class UISettings : MonoBehaviour
{
    [SerializeField]
    private GameObject _window;
    private bool act = false;
    [SerializeField]
    private Slider _slider;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && act == true)
        {
            _window.SetActive(true);
            act = false;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && act == false)
        {
            _window.SetActive(false);
            act = true;
        }
        AudioListener.volume = _slider.value;
    }
}
