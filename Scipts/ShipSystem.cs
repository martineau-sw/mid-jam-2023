using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipSystem : MonoBehaviour
{
    [SerializeField]
    const int POWER_REQUIREMENT = 3;
    [SerializeField]
    int _power = 0;
    [SerializeField]
    int _status = 3;

    public int PowerRequirement => 3 + (POWER_REQUIREMENT - _status);
    public int PowerState => PowerRequirement - Power;


    public int Power 
    {
        get 
        {
            return _power;
        }

        private set 
        {
            if(value < 0) value = 0;
            _power = value;
        }
    }

    public int SystemState 
    {
        get 
        {
            return _status;
        }

        private set 
        {
            if(value < 0) value = 0;
            _power = value;
        }
    }

    public void PowerIncrement(PowerSystem system) 
    {
        if(Power == PowerRequirement) return;
        Power += system.ApplyPower(1);
    }

    public void PowerDecrement(PowerSystem system) 
    {
        if(Power == 0) return;
        Power -= system.RemovePower(1);
    }
}
