using UnityEngine;

public class IronArmor : MonoBehaviour
{
    public int have;
    public int select;
    public float hpPlus;
    public float slow;
    public int levelSuper;
    public float cost = 1000;
    public float updateCost;
    public float updateSuperCost;
    private void Awake()
    {
        have = PlayerPrefs.GetInt("HaveIronArmor", 0);
        select = PlayerPrefs.GetInt("SelectIronArmor", 0);
        hpPlus = PlayerPrefs.GetFloat("hpIronArmor", 50);
        slow = PlayerPrefs.GetFloat("IronArmorSlow", 0.3f);
        levelSuper = PlayerPrefs.GetInt("IronArmorLevelSuper", 1);
        updateCost = PlayerPrefs.GetFloat("updateCostIronArmor", 60);
        updateSuperCost = PlayerPrefs.GetFloat("SupCostIronArmor", 160);
    }
}
