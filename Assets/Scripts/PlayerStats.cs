using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    [Header("Stats")]
    public string[] stats;
    public int[] statData;
    public string playerName;
    public float maxHp, maxMana;
    public float curHp, curMana;

   /* [Header("Game Reference")]
    public Slider hpBar;
    public Slider manaBar;*/

    void Start()
    {

    }

    public void Save()
    {
        SaveToBinary.SaveData(this);
    }

    public void Load()
    {
        DataToSave data = SaveToBinary.LoadData(this);
        maxHp = data.maxHp;
        curHp = data.curHp;
        maxMana = data.maxMana;
        curMana = data.curMana;
    }

   /* void Update()
    {
        hpBar.value = Mathf.Clamp01(curHp/maxHp);
        manaBar.value = Mathf.Clamp01(curMana/maxMana);
    }*/


}
