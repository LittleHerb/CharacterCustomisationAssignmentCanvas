using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadOnAwake : PlayerStats
{
    void Awake()
    {
        Load();
    }

    public void Load()
    {
        DataToSave data = SaveToBinary.LoadData(this);
        maxHp = data.maxHp;
        curHp = data.curHp;
        maxMana = data.maxMana;
        curMana = data.curMana;
    }
}
