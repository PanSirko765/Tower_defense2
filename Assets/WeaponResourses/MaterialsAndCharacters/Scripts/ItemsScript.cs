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
    
    private void Awake()
    {
        select = PlayerPrefs.GetInt("SelectCommonArmor", 1);
        hpPlus = PlayerPrefs.GetFloat("hpCommonArmor", 10);
        updateCost = PlayerPrefs.GetFloat("updateCostCommonArmor", 80);
    }
    
}







