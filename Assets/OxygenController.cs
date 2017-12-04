using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxygenController : Singleton<OxygenController>
{
    public float StartingAmmount = 360;
    public float Ammount;
    public float usageAmmount = 1;
    public StatusBar status;

    // Use this for initialization
    void Start()
    {
        Ammount = StartingAmmount;
        InvokeRepeating("DecreaseAmmount", 0, 1);
    }

    private void DecreaseAmmount()
    {
        Ammount -= usageAmmount;
        status.SetStatus(Ammount / StartingAmmount);
    }
}
