using UnityEngine;

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
    public bool have;
    public bool select;
    public int hpPlus;
    public int cost;
}

public class IronArmor : CommonArmor
{
    public float slow;
}

public class FireArmor : CommonArmor
{
    public float fire;
}

public class IceArmor : CommonArmor
{
    public float slowsec;
}

public class CommonSword
{
    public bool have;
    public bool select;
    public int cost;
    public float damage;
}

public class VampirSword : CommonSword
{
    public float hpRet;
}

public class SpeedSword : CommonSword
{
    public float speedBoost;
}

public class ShieldSword : CommonSword
{
    public float Shield;
}

public class UpSword : CommonSword
{
    public float plusDamage;
}