using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Systems : MonoBehaviour
{
    [SerializeField]
    PowerSystem _power;
    [SerializeField]
    ShipSystem _oxygen;
    [SerializeField]
    ShipSystem _selli;
    [SerializeField]
    ShipSystem _climate;
    [SerializeField]
    ShipSystem _engines;

    public PowerSystem Power => _power;
    public ShipSystem Oxygen => _oxygen;
    public ShipSystem Climate => _climate;
    public ShipSystem Engines => _engines;
    public ShipSystem Selli => _selli;

}

