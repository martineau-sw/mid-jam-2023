using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSystem : MonoBehaviour
{
    [SerializeField]
    const int MAX_POWER = 12;
    [SerializeField]
    int _powerUse = 0;
    [SerializeField]
    int _status = 3;

    public int MaxPower => MAX_POWER / (4 - _status);
    public int AvailablePower => MaxPower - _powerUse;
    public int PowerUse 
    {
        get 
        {
            return _powerUse;
        }

        private set 
        {
            if(value > MaxPower) _powerUse = MaxPower;
            if(value < 0) _powerUse = 0;
            _powerUse = value;
        }
    }


    public int ApplyPower(int amount) 
    {
        if(amount < 0) return 0;

        if(amount > AvailablePower) 
        {
            amount = AvailablePower;
            PowerUse = MaxPower;
            return 0;
        }

        PowerUse += amount;
        return amount;
    }

    public int RemovePower(int amount) 
    {
        if(amount < 0) return 0;
        
        if(MaxPower == AvailablePower) 
        {
            return 0;
        }

        PowerUse -= amount;
        return amount;
    }


    public void Start() 
    {
        _status = 3;
        _powerUse = 0;
    }
}
