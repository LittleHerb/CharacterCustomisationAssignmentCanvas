[System.Serializable]

public class DataToSave
{
    public string playerName;
    public float maxHp, maxMana;
    public float curHp, curMana;

    public DataToSave(PlayerStats player)
    {
        playerName = player.playerName;
        maxHp = player.maxHp;
        curHp = player.curHp;
        maxMana = player.maxMana;
        curMana = player.curMana;

    }

}
