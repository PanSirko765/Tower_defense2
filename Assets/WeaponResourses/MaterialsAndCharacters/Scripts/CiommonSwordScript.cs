using System;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.UI;

public class CiommonSwordScript : MonoBehaviour
{
    public int have;
    public int select;
    public float damage;
    public float boostLoot;
    public int levelSuper;
    public float cost;
    public float updateCost;
    public float updateSuperCost;
    public Text text;
    public Text update;
    public Text LevelText;
    public GameObject updateButton;
    public Text textcostupdate;
    public SwordActive1 active1;
    void Start()
    {
        have = PlayerPrefs.GetInt("HaveCommonSword", 1);
        select = PlayerPrefs.GetInt("SelectCommonSword", 1);
        damage = PlayerPrefs.GetFloat("DamageCommonSword", 30);
        boostLoot = PlayerPrefs.GetFloat("CommonSwordBoostLoot", 0.1f);
        levelSuper = PlayerPrefs.GetInt("CommonSwordLevelSuper", 1);
        updateCost = PlayerPrefs.GetFloat("CommonSwordUpdateSword", 80);
        updateSuperCost = PlayerPrefs.GetFloat("SupCostCommonSword", 500);
        update.text = "Прокачати за" + updateCost;
        text.text = damage + " дамагу";
        LevelText.text = levelSuper + "level";
        textcostupdate.text = "Прокачати за " + updateSuperCost;
        
        OnLevel();
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
        active1.OnSelectItem(0);
    }
    public void Upgrade()
    {
        if(ShopScriptCoin22.instance.coins >= updateSuperCost)
        {
            damage *= 1.2f;
            Math.Round(damage);
            PlayerPrefs.SetFloat("DamageCommonSword", damage);
            updateCost *= 1.3f;
            Math.Round(updateCost);
            PlayerPrefs.SetFloat("CommonSwordUpdateSword", updateCost);
            text.text = damage + "дамагу";
            update.text = "Прокачати за" + updateCost;
            ShopScriptCoin22.instance.coins -= updateSuperCost;
        }
        
    }

    public void UpdradeSuper()
    {
        if (levelSuper < 5)
        {
            if (levelSuper == 1 && ShopScriptCoin22.instance.coins >= updateSuperCost)
            {
                levelSuper = 2;
                PlayerPrefs.SetInt("CommonSwordLevelSuper", levelSuper);
                boostLoot = 0.2f;
                PlayerPrefs.SetFloat("CommonSwordBoostLoot", boostLoot);
                LevelText.text = levelSuper + "level";
                updateSuperCost = 750;
                textcostupdate.text = "Прокачати за " + updateSuperCost;
                PlayerPrefs.SetFloat("SupCostCommonSword", updateSuperCost);
                ShopScriptCoin22.instance.coins -= updateSuperCost;
            }
            else if (levelSuper == 2 && ShopScriptCoin22.instance.coins >= updateSuperCost)
            {
                levelSuper = 3;
                PlayerPrefs.SetInt("CommonSwordLevelSuper", levelSuper);
                boostLoot = 0.3f;
                PlayerPrefs.SetFloat("CommonSwordBoostLoot", boostLoot);
                LevelText.text = levelSuper + "level";
                updateSuperCost = 1250;
                textcostupdate.text = "Прокачати за " + updateSuperCost;
                PlayerPrefs.SetFloat("SupCostCommonSword",     updateSuperCost);
                ShopScriptCoin22.instance.coins -= updateSuperCost;
            }
            else if (levelSuper == 3 && ShopScriptCoin22.instance.coins >= updateSuperCost)
            {
                levelSuper = 4;
                PlayerPrefs.SetInt("CommonSwordLevelSuper", levelSuper);
                boostLoot = 0.5f;
                PlayerPrefs.SetFloat("CommonSwordBoostLoot", boostLoot);
                LevelText.text = levelSuper + "level";
                updateSuperCost = 2000;
                textcostupdate.text = "Прокачати за " + updateSuperCost;
                PlayerPrefs.SetFloat("SupCostCommonSword", updateSuperCost);
                ShopScriptCoin22.instance.coins -= updateSuperCost;
            }
            else if(ShopScriptCoin22.instance.coins >= updateSuperCost)
            {
                levelSuper = 5;
                PlayerPrefs.SetInt("CommonSwordLevelSuper", levelSuper);
                boostLoot = 1f;
                PlayerPrefs.SetFloat("CommonSwordBoostLoot", boostLoot);
                LevelText.text = levelSuper + "level";
                OnLevel();
                ShopScriptCoin22.instance.coins -= updateSuperCost;

            }
        }
    }




}
