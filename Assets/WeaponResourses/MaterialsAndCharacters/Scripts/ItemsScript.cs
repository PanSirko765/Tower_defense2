using UnityEngine;
using UnityEngine.UI;


public class ItemsScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}

public class CommonArmor
{
    public int have = 1;
    public int select = PlayerPrefs.GetInt("SelectCommonArmor", 1);
    public int hpPlus = PlayerPrefs.GetInt("hpCommonArmor", 50);
    public int cost;
}

public class IronArmor 
{
    public int have = PlayerPrefs.GetInt("HaveIronArmor", 0);
    public int select = PlayerPrefs.GetInt("SelectIronArmor", 0);
    public int hpPlus = PlayerPrefs.GetInt("hpCommonArmor", 250);
    public float slow = 0.4f;
    public int cost = 100;
}

public class FireArmor 
{
    public int have = PlayerPrefs.GetInt("HaveIronArmor", 0);
    public int select = PlayerPrefs.GetInt("SelectIronArmor", 0);
    public int hpPlus = PlayerPrefs.GetInt("hpCommonArmor", 200);
    public float fire = 55;
    public int cost = 130;
}

public class IceArmor 
{
    public int have = PlayerPrefs.GetInt("HaveIronArmor", 0);
    public int select = PlayerPrefs.GetInt("SelectIronArmor", 0);
    public int hpPlus = PlayerPrefs.GetInt("hpCommonArmor", 270);
    public float slowsec = 1.5f;
    public int cost = 200;
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