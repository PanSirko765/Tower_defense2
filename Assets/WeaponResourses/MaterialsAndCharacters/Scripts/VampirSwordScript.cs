using System;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.UI;

public class VampirSwordSe : MonoBehaviour
{
    public int have;
    public int select;
    public float damage;
    public float hpReturn;
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
        have = PlayerPrefs.GetInt("HaveVampirSword", 0);
        select = PlayerPrefs.GetInt("SelectVampirSword", 0);
        damage = PlayerPrefs.GetFloat("DamageVampirSword", 45);
        hpReturn = PlayerPrefs.GetFloat("VampirSwordHpReturn", 0.1f);
        levelSuper = PlayerPrefs.GetInt("VampirSwordLevelSuper", 1);
        updateCost = PlayerPrefs.GetFloat("VampirSwordUpdateSword", 90);
        updateSuperCost = PlayerPrefs.GetFloat("SupCostVampirSword", 1000);
        update.text = "��������� ��" + updateCost;
        text.text = damage + " ������";
        LevelText.text = levelSuper + "level";
        textcostupdate.text = "��������� �� " + updateSuperCost;
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
            PlayerPrefs.SetInt("SelectVampirSword", select);
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
        active1.OnSelectItem(1);
    }
    public void Upgrade()
    {
        if(ShopScriptCoin22.instance.coins >= updateCost)
        {
            damage *= 1.2f;
            Math.Round(damage);
            PlayerPrefs.SetFloat("DamageVampirSword", damage);
            updateCost *= 1.3f;
            Math.Round(updateCost);
            PlayerPrefs.SetFloat("VampirSwordUpdateSword", updateCost);
            text.text = damage + "������";
            update.text = "��������� ��" + updateCost;
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
                PlayerPrefs.SetInt("VampirSwordLevelSuper", levelSuper);
                hpReturn = 0.15f;
                PlayerPrefs.SetFloat("VampirSwordHpReturn", hpReturn);
                LevelText.text = levelSuper + "level";
                updateSuperCost = 1250;
                textcostupdate.text = "��������� �� " + updateSuperCost;
                PlayerPrefs.SetFloat("SupCostVampirSword", updateSuperCost);
                ShopScriptCoin22.instance.coins -= updateSuperCost;
            }
            else if (levelSuper == 2 && ShopScriptCoin22.instance.coins >= updateSuperCost)
            {
                levelSuper = 3;
                PlayerPrefs.SetInt("VampirSwordLevelSuper", levelSuper);
                hpReturn = 0.25f;
                PlayerPrefs.SetFloat("VampirSwordHpReturn", hpReturn);
                LevelText.text = levelSuper + "level";
                updateSuperCost = 1500;
                textcostupdate.text = "��������� �� " + updateSuperCost;
                PlayerPrefs.SetFloat("SupCostVampirSword", updateSuperCost);
                ShopScriptCoin22.instance.coins -= updateSuperCost;
            }
            else if (levelSuper == 3 && ShopScriptCoin22.instance.coins >= updateSuperCost)
            {
                levelSuper = 4;
                PlayerPrefs.SetInt("VampirSwordLevelSuper", levelSuper);
                hpReturn = 0.3f;
                PlayerPrefs.SetFloat("VampirSwordHpReturn", hpReturn);
                LevelText.text = levelSuper + "level";
                updateSuperCost = 2500;
                textcostupdate.text = "��������� �� " + updateSuperCost;
                PlayerPrefs.SetFloat("SupCostVampirSword", updateSuperCost);
                ShopScriptCoin22.instance.coins -= updateSuperCost;
            }
            else if(ShopScriptCoin22.instance.coins >= updateSuperCost)
            {
                levelSuper = 5;
                PlayerPrefs.SetInt("VampirSwordLevelSuper", levelSuper);
                hpReturn = 0.5f;
                PlayerPrefs.SetFloat("VampirSwordHpReturn", hpReturn);
                LevelText.text = levelSuper + "level";
                OnLevel();
                ShopScriptCoin22.instance.coins -= updateSuperCost;
            }
        }
    }




}



