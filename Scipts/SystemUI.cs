using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[System.Serializable]
public class SystemUI : MonoBehaviour
{
    [SerializeField]
    ShipSystem _system;

    [SerializeField]
    TextMeshProUGUI _power;
    [SerializeField]
    Button _powerUp;
    [SerializeField]
    Button _powerDown;

    public void Start() 
    {
        _power = transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        _powerUp = transform.GetChild(1).GetComponent<Button>();
        _powerDown = transform.GetChild(2).GetComponent<Button>();
    }

    public void Update() 
    {
        _power.text = _system.Power.ToString();
    }
}
