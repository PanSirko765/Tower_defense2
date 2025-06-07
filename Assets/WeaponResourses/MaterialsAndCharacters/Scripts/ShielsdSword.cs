using System;
using UnityEngine;
using UnityEngine.UI;

public class ShielsdSword : MonoBehaviour
{
    public int have;
    public int select;
    public float damage;
    public float shield;
    public int levelSuper;
    public float cost = 1150;
    public float updateCost;
    public float updateSuperCost;
    public Text text;
    public Text update;
    public Text LevelText;
    public GameObject updateButton;
    public Text textcostupdate;
    public GameObject buttonBuy;
    public SwordActive1 active1;

    
    void Start()
    {
        have = PlayerPrefs.GetInt("HaveSSword", 0);
        select = PlayerPrefs.GetInt("SelectSSword", 0);
        damage = PlayerPrefs.GetFloat("DamageSSword", 20);
        shield = PlayerPrefs.GetFloat("SSwordHpReturn", 0.2f);
        levelSuper = PlayerPrefs.GetInt("SSwordLevelSuper", 1);
        updateCost = PlayerPrefs.GetFloat("SSwordUpdateSword", 90);
        updateSuperCost = PlayerPrefs.GetFloat("SupCostSSword", 850);
        update.text = "Прокачати за" + updateCost;
        text.text = damage + " дамагу";
        LevelText.text = levelSuper + "level";
        textcostupdate.text = "Прокачати за " + updateSuperCost;
        Have();
        OnLevel();
    }

    public void Have()
    {
        if (select == 0)
        {
            buttonBuy.SetActive(true);
        }
    }

    public void Buy()
    {
        if(ShopScriptCoin22.instance.coins >= cost)
        {
            select = 1;
            PlayerPrefs.SetInt("SelectSpeedSword", select);
            buttonBuy.SetActive(false);
            ShopScriptCoin22.instance.coins -= cost;
        }
        
    }
    public void OnLevel()
    {
        if (levelSuper >= 5)
        {
            updateButton.SetActive(false);
        }
        else
        {
            updateButton.SetActive(true);
        }
    }
    public void Select()
    {
        active1.OnSelectItem(3);
    }
    public void Upgrade()
    {
        if(ShopScriptCoin22.instance.coins >= updateCost)
        {
            damage *= 1.2f;
            Math.Round(damage);
            PlayerPrefs.SetFloat("DamageSSword", damage);
            updateCost *= 1.3f;
            Math.Round(updateCost);
            PlayerPrefs.SetFloat("SSwordUpdateSword", updateCost);
            text.text = damage + "дамагу";
            update.text = "Прокачати за" + updateCost;
            ShopScriptCoin22.instance.coins -= updateCost;
        }
        
    }

    public void UpdradeSuper()
    {
        if (levelSuper < 5)
        {
            if (levelSuper == 1 && ShopScriptCoin22.instance.coins >= updateSuperCost)
            {
                levelSuper = 2;
                PlayerPrefs.SetInt("SSwordLevelSuper", levelSuper);
                shield = 0.3f;
                PlayerPrefs.SetFloat("SSwordHpReturn", shield);
                LevelText.text = levelSuper + "level";
                updateSuperCost = 1350;
                textcostupdate.text = "Прокачати за " + updateSuperCost;
                PlayerPrefs.SetFloat("SupCostSSword", updateSuperCost);
                ShopScriptCoin22.instance.coins -= updateSuperCost;
            }
            else if (levelSuper == 2 && ShopScriptCoin22.instance.coins >= updateSuperCost)
            {
                levelSuper = 3;
                PlayerPrefs.SetInt("SSwordLevelSuper", levelSuper);
                shield = 0.4f;
                PlayerPrefs.SetFloat("SSwordHpReturn", shield);
                LevelText.text = levelSuper + "level";
                updateSuperCost = 1750;
                textcostupdate.text = "Прокачати за " + updateSuperCost;
                PlayerPrefs.SetFloat("SupCostSSword", updateSuperCost);
                ShopScriptCoin22.instance.coins -= updateSuperCost;
            }
            else if (levelSuper == 3 && ShopScriptCoin22.instance.coins >= updateSuperCost)
            {
                levelSuper = 4;
                PlayerPrefs.SetInt("SSwordLevelSuper", levelSuper);
                shield = 0.5f;
                PlayerPrefs.SetFloat("SSwordHpReturn", shield);
                LevelText.text = levelSuper + "level";
                updateSuperCost = 2500;
                textcostupdate.text = "Прокачати за " + updateSuperCost;
                PlayerPrefs.SetFloat("SupCostSSword", updateSuperCost);
                ShopScriptCoin22.instance.coins -= updateSuperCost;
            }
            else if( ShopScriptCoin22.instance.coins >= updateSuperCost)
            {
                levelSuper = 5;
                PlayerPrefs.SetInt("SSwordLevelSuper", levelSuper);
                shield = 1f;
                PlayerPrefs.SetFloat("SSwordHpReturn", shield);
                LevelText.text = levelSuper + "level";
                OnLevel();
                ShopScriptCoin22.instance.coins -= updateSuperCost;
            }
        }
    }
}
