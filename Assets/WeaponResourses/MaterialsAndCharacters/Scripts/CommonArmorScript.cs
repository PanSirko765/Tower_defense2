using System;
using UnityEngine;
using UnityEngine.UI;

public class CommonArmorScript : MonoBehaviour
{
    public CommonArmor common;
    [SerializeField] private Text text;
    [SerializeField] private Text update;
    [SerializeField] private SelectItemScript delete;
    void Start()
    {
        
        update.text = "Прокачати за" + common.updateCost;
        text.text = "+" + common.hpPlus + "hp";
    }

    public void Upgrade()
    {
        common.hpPlus = common.hpPlus * 1.2f;
        Math.Round(common.hpPlus);
        PlayerPrefs.SetFloat("hpCommonArmor", common.hpPlus);
        common.updateCost *= 1.3f;
        Math.Round(common.updateCost);
        PlayerPrefs.SetFloat("updateCostCommonArmor", common.updateCost);
        text.text = "+" + common.hpPlus + "hp";
        update.text = "Прокачати за" + common.updateCost;
    }
    public void Select()
    {
        delete.Select(0);
    }
    
}
