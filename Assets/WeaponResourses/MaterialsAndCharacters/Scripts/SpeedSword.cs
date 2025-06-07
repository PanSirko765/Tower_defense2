using System;
using UnityEngine;
using UnityEngine.UI;

public class SpeedSword : MonoBehaviour
{
    public int have;
    public int select;
    public float damage;
    public float speedBoost;
    public int levelSuper;
    public float cost = 1000;
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
        have = PlayerPrefs.GetInt("HaveSpeedSword", 0);
        select = PlayerPrefs.GetInt("SelectSpeedSword", 0);
        damage = PlayerPrefs.GetFloat("DamageSpeedSword", 30);
        speedBoost = PlayerPrefs.GetFloat("SpeedSwordHpReturn", 0.1f);
        levelSuper = PlayerPrefs.GetInt("SpeedSwordLevelSuper", 1);
        updateCost = PlayerPrefs.GetFloat("SpeedSwordUpdateSword", 90);
        updateSuperCost = PlayerPrefs.GetFloat("SupCostSpeedSword", 750);
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
        active1.OnSelectItem(2);
    }
    public void Upgrade()
    {
        if(ShopScriptCoin22.instance.coins >= updateCost)
        {
            damage *= 1.2f;
            Math.Round(damage);
            PlayerPrefs.SetFloat("DamageSpeedSword", damage);
            updateCost *= 1.3f;
            Math.Round(updateCost);
            PlayerPrefs.SetFloat("SpeedSwordUpdateSword", updateCost);
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
                PlayerPrefs.SetInt("SpeedSwordLevelSuper", levelSuper);
                speedBoost = 0.15f;
                PlayerPrefs.SetFloat("SpeedSwordHpReturn", speedBoost);
                LevelText.text = levelSuper + "level";
                updateSuperCost = 1250;
                textcostupdate.text = "Прокачати за " + updateSuperCost;
                PlayerPrefs.SetFloat("SupCostSpeedSword", updateSuperCost);
                ShopScriptCoin22.instance.coins -= updateSuperCost;
            }
            else if (levelSuper == 2 && ShopScriptCoin22.instance.coins >= updateSuperCost)
            {
                levelSuper = 3;
                PlayerPrefs.SetInt("SpeedSwordLevelSuper", levelSuper);
                speedBoost = 0.2f;
                PlayerPrefs.SetFloat("SpeedSwordHpReturn", speedBoost);
                LevelText.text = levelSuper + "level";
                updateSuperCost = 1500;
                textcostupdate.text = "Прокачати за " + updateSuperCost;
                PlayerPrefs.SetFloat("SupCostSpeedSword", updateSuperCost);
                ShopScriptCoin22.instance.coins -= updateSuperCost;
            }
            else if (levelSuper == 3 && ShopScriptCoin22.instance.coins >= updateSuperCost)
            {
                levelSuper = 4;
                PlayerPrefs.SetInt("SpeedSwordLevelSuper", levelSuper);
                speedBoost = 0.3f;
                PlayerPrefs.SetFloat("SpeedSwordHpReturn", speedBoost);
                LevelText.text = levelSuper + "level";
                updateSuperCost = 2000;
                textcostupdate.text = "Прокачати за " + updateSuperCost;
                PlayerPrefs.SetFloat("SupCostSpeedSword", updateSuperCost);
                ShopScriptCoin22.instance.coins -= updateSuperCost;
            }
            else if(ShopScriptCoin22.instance.coins >= updateSuperCost)
            {
                levelSuper = 5;
                PlayerPrefs.SetInt("SpeedSwordLevelSuper", levelSuper);
                speedBoost = 0.4f;
                PlayerPrefs.SetFloat("SpeedSwordHpReturn", speedBoost);
                LevelText.text = levelSuper + "level";
                OnLevel();
                ShopScriptCoin22.instance.coins -= updateSuperCost;

            }
        }
    }
}
