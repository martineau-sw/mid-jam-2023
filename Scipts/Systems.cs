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

    public void Start() 
    {
        PowerUp();
    }

    public void PowerUp() 
    {
        _oxygen.Power += _power.ApplyPower(3);
        _climate.Power += _power.ApplyPower(3);
        _engines.Power += _power.ApplyPower(3);
        _selli.Power += _power.ApplyPower(3);
    }
}

[System.Serializable]
public class PowerSystem 
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

        set 
        {
            if(value > MaxPower) _powerUse = MaxPower;
            if(value < 0) _powerUse = 0;
            _powerUse = value;
        }
    }

    public PowerSystem() 
    {
        _status = 3;
        _powerUse = 0;
    }

    public int ApplyPower(int amount) 
    {
        if(amount < 0) return 0;

        if(amount > AvailablePower) 
        {
            amount = AvailablePower;
            PowerUse = MaxPower;
            return amount;
        }

        PowerUse += amount;
        return amount;
    }

    public int RemovePower(int amount) 
    {
        if(amount < 0) return 0;
        
        if(amount > AvailablePower) 
        {
            amount = AvailablePower;
            PowerUse = 0;
            return amount;
        }

        PowerUse -= amount;
        return amount;
    }
}

[System.Serializable]
public class ShipSystem 
{
    [SerializeField]
    const int POWER_REQUIREMENT = 3;
    [SerializeField]
    int _power;
    [SerializeField]
    int _status;

    public int PowerRequirement => 3 + (POWER_REQUIREMENT - _status);
    public int PowerState => PowerRequirement - Power;


    public int Power 
    {
        get 
        {
            return _power;
        }

        set 
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

        set 
        {
            if(value < 0) value = 0;
            _power = value;
        }
    }


    public ShipSystem() 
    {
        _status = 3;
        _power = 0;
    }
}