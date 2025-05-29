using UnityEngine;

public class FireArmor : MonoBehaviour
{
    public int have;
    public int select;
    public float hpPlus;
    public float fireEmpyty;
    public int levelSuper;
    public float cost = 100;
    public float updateCost;
    public float updateSuperCost;
    private void Awake()
    {
        have = PlayerPrefs.GetInt("HaveFireArmor", 0);
        select = PlayerPrefs.GetInt("SelectFireArmor", 0);
        hpPlus = PlayerPrefs.GetFloat("hpFireArmor", 200);
        fireEmpyty = PlayerPrefs.GetFloat("FireArmorSlow", 5f);
        levelSuper = PlayerPrefs.GetInt("FireArmorLevelSuper", 1);
        updateCost = PlayerPrefs.GetFloat("updateCostFireArmor", 60);
        updateSuperCost = PlayerPrefs.GetFloat("SupCostFireArmor", 160);
    }
}


