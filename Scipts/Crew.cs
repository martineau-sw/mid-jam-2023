using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crew : MonoBehaviour
{
    CrewMember technician;
    CrewMember doctor;
    CrewMember pilot;
    CrewMember selli;

    public void Start() 
    {
        technician = new CrewMember("Mika Berta");
        doctor = new CrewMember("Sean Night");
        pilot = new CrewMember("Loretta Saint");
        selli = new CrewMember("S.E.L.L.I.");
    }
}

public class CrewMember 
{
    const int MAX_STATUS = 3;

    [SerializeField]
    string _name;
    [SerializeField]
    int _status;

    public string Name => _name;

    public int Status 
    {
        get => _status;
        set 
        {
            if(value < 0) value = 0;
            if(value > MAX_STATUS) value = MAX_STATUS;
        }
    }

    public CrewMember(string name) 
    {
        _name = name;
    }
}
