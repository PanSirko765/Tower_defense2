using System;
using UnityEngine;
using UnityEngine.UI;

public class UpSword : MonoBehaviour
{
    public int have;
    public int select;
    public float damage;
    public float shield;
    public int levelSuper;
    public float cost = 4000;
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
        have = PlayerPrefs.GetInt("HaveUSword", 0);
        select = PlayerPrefs.GetInt("SelectUSword", 0);
        damage = PlayerPrefs.GetFloat("DamageUSword", 20);
        shield = PlayerPrefs.GetFloat("USwordHpReturn", 0.01f);
        levelSuper = PlayerPrefs.GetInt("USwordLevelSuper", 1);
        updateCost = PlayerPrefs.GetFloat("USwordUpdateSword", 90);
        updateSuperCost = PlayerPrefs.GetFloat("SupCostUSword", 1000);
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
        select = 1;
        PlayerPrefs.SetInt("SelectUSword", select);
        buttonBuy.SetActive(false);
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
        active1.OnSelect(4);
    }
    public void Upgrade()
    {
        damage *= 1.2f;
        Math.Round(damage);
        PlayerPrefs.SetFloat("DamageUSword", damage);
        updateCost *= 1.3f;
        Math.Round(updateCost);
        PlayerPrefs.SetFloat("USwordUpdateSword", updateCost);
        text.text = "+" + damage + "hp";
        update.text = "Прокачати за" + updateCost;
    }

    public void UpdradeSuper()
    {
        if (levelSuper < 5)
        {
            if (levelSuper == 1)
            {
                levelSuper = 2;
                PlayerPrefs.SetInt("USwordLevelSuper", levelSuper);
                shield = 0.02f;
                PlayerPrefs.SetFloat("USwordHpReturn", shield);
                LevelText.text = levelSuper + "level";
                updateSuperCost = 2350;
                textcostupdate.text = "Прокачати за " + updateSuperCost;
                PlayerPrefs.SetFloat("SupCostUSword", updateSuperCost);
            }
            else if (levelSuper == 2)
            {
                levelSuper = 3;
                PlayerPrefs.SetInt("USwordLevelSuper", levelSuper);
                shield = 0.03f;
                PlayerPrefs.SetFloat("USwordHpReturn", shield);
                LevelText.text = levelSuper + "level";
                updateSuperCost = 3350;
                textcostupdate.text = "Прокачати за " + updateSuperCost;
                PlayerPrefs.SetFloat("SupCostUSword", updateSuperCost);
            }
            else if (levelSuper == 3)
            {
                levelSuper = 4;
                PlayerPrefs.SetInt("USwordLevelSuper", levelSuper);
                shield = 0.04f;
                PlayerPrefs.SetFloat("USwordHpReturn", shield);
                LevelText.text = levelSuper + "level";
                updateSuperCost = 5000;
                textcostupdate.text = "Прокачати за " + updateSuperCost;
                PlayerPrefs.SetFloat("SupCostUSword", updateSuperCost);
            }
            else
            {
                levelSuper = 5;
                PlayerPrefs.SetInt("USwordLevelSuper", levelSuper);
                shield = 0.06f;
                PlayerPrefs.SetFloat("USwordHpReturn", shield);
                LevelText.text = levelSuper + "level";
                OnLevel();

            }
        }
    }
}
