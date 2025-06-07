using System;
using UnityEngine;
using UnityEngine.UI;

public class ironArmrorScript : MonoBehaviour
{
    public IronArmor armor;
    public Text text;
    public Text update;
    public GameObject @object;
    public Text LevelText;
    public GameObject updateButton;
    public Text textcostupdate;
    public SelectItemScript itemScript;
    private void Start()
    {
        update.text = "Прокачати за" + armor.updateCost;
        text.text = "+" + armor.hpPlus + "hp";
        LevelText.text = armor.levelSuper + "level";
        textcostupdate.text = "Прокачати за " + armor.updateSuperCost;
        IfHave();
        OnLevel();
    }

    public void OnLevel()
    {
        if(armor.levelSuper >= 5)
        {
            updateButton.SetActive(false);
        }
        else
        {
            updateButton.SetActive(true);
        }
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
        if(ShopScriptCoin22.instance.coins >= 1000)
        {
            @object.SetActive(false);
            armor.have = 1;
            PlayerPrefs.SetInt("HaveIronArmor", armor.have);
            ShopScriptCoin22.instance.coins -= 1000; 
        }
       
    }
    public void Upgrade()
    {
        if(ShopScriptCoin22.instance.coins >= armor.updateCost)
        {
            ShopScriptCoin22.instance.coins -= armor.updateCost;
            armor.hpPlus *= 1.2f;
            Math.Round(armor.hpPlus);
            PlayerPrefs.SetFloat("hpIronArmor", armor.hpPlus);
            armor.updateCost *= 1.3f;
            Math.Round(armor.updateCost);
            PlayerPrefs.SetFloat("updateCostIronArmor", armor.updateCost);
            text.text = "+" + armor.hpPlus + "hp";
            update.text = "Прокачати за" + armor.updateCost;
        }
        
    }
    public void Select()
    {
        itemScript.Select(1);
    }
    public void UpdradeSuper()
    {
        if(armor.levelSuper < 5)
        {
            if(armor.levelSuper == 1)
            {
                if(ShopScriptCoin22.instance.coins >= armor.updateSuperCost)
                {
                    ShopScriptCoin22.instance.coins -= armor.updateSuperCost;
                    armor.levelSuper = 2;
                    PlayerPrefs.SetInt("IronArmorLevelSuper", armor.levelSuper);
                    armor.slow = 0.2f;
                    PlayerPrefs.SetFloat("IronArmorSlow", armor.slow);
                    LevelText.text = armor.levelSuper + "level";
                    armor.updateSuperCost = 750;
                    textcostupdate.text = "Прокачати за " + armor.updateSuperCost;
                    PlayerPrefs.SetFloat("SupCostIronArmor", armor.updateSuperCost);
                }
                
            }
            else if(armor.levelSuper == 2)
            {
                if (ShopScriptCoin22.instance.coins >= armor.updateSuperCost)
                {
                    ShopScriptCoin22.instance.coins -= armor.updateSuperCost;
                    armor.levelSuper = 3;
                    PlayerPrefs.SetInt("IronArmorLevelSuper", armor.levelSuper);
                    armor.slow = 0.15f;
                    PlayerPrefs.SetFloat("IronArmorSlow", armor.slow);
                    LevelText.text = armor.levelSuper + "level";
                    armor.updateSuperCost = 1250;
                    textcostupdate.text = "Прокачати за " + armor.updateSuperCost;
                    PlayerPrefs.SetFloat("SupCostIronArmor", armor.updateSuperCost);
                }
               
            }
            else if( armor.levelSuper == 3)
            {
                if (ShopScriptCoin22.instance.coins >= armor.updateSuperCost)
                {
                    ShopScriptCoin22.instance.coins -= armor.updateSuperCost;
                    armor.levelSuper = 4;
                    PlayerPrefs.SetInt("IronArmorLevelSuper", armor.levelSuper);
                    armor.slow = 0.1f;
                    PlayerPrefs.SetFloat("IronArmorSlow", armor.slow);
                    LevelText.text = armor.levelSuper + "level";
                    armor.updateSuperCost = 1500;
                    textcostupdate.text = "Прокачати за " + armor.updateSuperCost;
                    PlayerPrefs.SetFloat("SupCostIronArmor", armor.updateSuperCost);
                }
                    
            }
            else
            {
                if (ShopScriptCoin22.instance.coins >= armor.updateSuperCost)
                {
                    ShopScriptCoin22.instance.coins -= armor.updateSuperCost;
                    armor.levelSuper = 5;
                    PlayerPrefs.SetInt("IronArmorLevelSuper", armor.levelSuper);
                    armor.slow = 0.05f;
                    PlayerPrefs.SetFloat("IronArmorSlow", armor.slow);
                    LevelText.text = armor.levelSuper + "level";
                    OnLevel();
                }
                    
                
            }
        }
    }
}
