using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;




public class CommonArmor : MonoBehaviour
{
    public int have = 1;
    public int select;
    public float hpPlus ;
    public int cost;
    public float updateCost;
    
    private void Start()
    {
        select = 1;
        hpPlus = PlayerPrefs.GetFloat("hpCommonArmor", 50);
        updateCost = PlayerPrefs.GetFloat("updateCostCommonArmor", 50);
    }
    
}



public class FireArmor 
{
    public int have = PlayerPrefs.GetInt("HaveIronArmor", 0);
    public int select = PlayerPrefs.GetInt("SelectIronArmor", 0);
    public int hpPlus = PlayerPrefs.GetInt("hpCommonArmor", 200);
    public float fire = 55;
    public int cost = 130;
}



public class CommonSword
{
    public int have = 1;
    public int select = PlayerPrefs.GetInt("SelectCommonSword", 1);
    public int cost;
    public float damage = 500;
}

public class VampirSword : CommonSword
{
    public int have = PlayerPrefs.GetInt("HaveVamSword", 0);
    public int select = PlayerPrefs.GetInt("SelectVampirSword", 0);
    public int cost = 200;
    public float damage = 410;
    public float hpRet = 0.08f;
}

public class SpeedSword : CommonSword
{
    public int have = PlayerPrefs.GetInt("HaveVamSword", 0);
    public int select = PlayerPrefs.GetInt("SelectVampirSword", 0);
    public int cost = 470;
    public float damage = 450;
    public float speedBoost = 1.4f;
}

public class ShieldSword : CommonSword
{
    public int have = PlayerPrefs.GetInt("HaveVamSword", 0);
    public int select = PlayerPrefs.GetInt("SelectVampirSword", 0);
    public int cost = 600;
    public float damage = 480;
    public float Shield = 0.2f;
}

public class UpSword : CommonSword
{
    public int have = PlayerPrefs.GetInt("HaveVamSword", 0);
    public int select = PlayerPrefs.GetInt("SelectVampirSword", 0);
    public int cost = 870;
    public float damage = 500;
    public float plusDamage = 1.04f;
}