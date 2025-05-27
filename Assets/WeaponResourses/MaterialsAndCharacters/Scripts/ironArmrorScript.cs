using System;
using UnityEngine;
using UnityEngine.UI;

public class ironArmrorScript : MonoBehaviour
{
    public IronArmor armor;
    public Text text;
    public Text update;
    public GameObject @object;
    private void Start()
    {
        update.text = "Прокачати за" + armor.updateCost;
        text.text = "+" + armor.hpPlus + "hp";
        IfHave();
    }

    public void IfHave()
    {
        if(armor.have == 0)
        {
            @object.SetActive(true);
        }
        else
        {
            @object.SetActive(false);
        }
    }
    
    public void BuyThis()
    {
        @object.SetActive(false);
        armor.have = 1;
        PlayerPrefs.SetInt("HaveIronArmor", armor.have);
    }
    public void Upgrade()
    {
        armor.hpPlus = armor.hpPlus * 1.2f;
        Math.Round(armor.hpPlus);
        PlayerPrefs.SetFloat("hpIronArmor", armor.hpPlus);
        armor.updateCost *= 1.3f;
        Math.Round(armor.updateCost);
        PlayerPrefs.SetFloat("updateCostIronArmor", armor.updateCost);
        text.text = "+" + armor.hpPlus + "hp";
        update.text = "Прокачати за" + armor.updateCost;
    }

   
}
