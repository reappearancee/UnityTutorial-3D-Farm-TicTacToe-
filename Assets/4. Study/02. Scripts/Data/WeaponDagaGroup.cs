using UnityEngine;

[CreateAssetMenu(fileName = "WeaponDagaGroup", menuName = "Scriptable Objects/WeaponDagaGroup")]
public class WeaponDagaGroup : ScriptableObject
{
    public WData[] wData;
}

[System.Serializable]
public class WData
{
    public string name;
    public int damage;
    public int range;
    public DetailData detailData;
}
[System.Serializable]
public class DetailData
{
    public int cost;
    public int upgradeLevel;
}

[System.Serializable]
public class DamageSystem
{
    public int minDamage;
    public int maxDamage;
    public int successPercent;
    public int criticalPercent;
}

