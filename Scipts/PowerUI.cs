using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PowerUI : MonoBehaviour
{
    [SerializeField] 
    PowerSystem _powerSystem;
    [SerializeField] 
    TextMeshProUGUI _powerDisplay;

    public void Update() 
    {
        _powerDisplay.text = _powerSystem.AvailablePower.ToString();
    }
}
