using System;
using UnityEngine;
using UnityEngine.UI;

public class FireArmrorScript : MonoBehaviour
{
    public FireArmor armor;
    public Text text;
    public Text update;
    public GameObject @object;
    public Text LevelText;
    public GameObject updateButton;
    public Text textcostupdate;
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
        if (armor.levelSuper >= 5)
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
        if (armor.have == 0)
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
        PlayerPrefs.SetInt("HaveIceArmor", armor.have);
    }
    public void Upgrade()
    {
        armor.hpPlus *= 1.2f;
        Math.Round(armor.hpPlus);
        PlayerPrefs.SetFloat("hpIceArmor", armor.hpPlus);
        armor.updateCost *= 1.3f;
        Math.Round(armor.updateCost);
        PlayerPrefs.SetFloat("updateCostIceArmor", armor.updateCost);
        text.text = "+" + armor.hpPlus + "hp";
        update.text = "Прокачати за" + armor.updateCost;
    }

    public void UpdradeSuper()
    {
        if (armor.levelSuper < 5)
        {
            if (armor.levelSuper == 1)
            {
                armor.levelSuper = 2;
                PlayerPrefs.SetInt("IceArmorLevelSuper", armor.levelSuper);
                armor.fireEmpyty = 0.3f;
                PlayerPrefs.SetFloat("IceArmorSlow", armor.fireEmpyty);
                LevelText.text = armor.levelSuper + "level";
                armor.updateSuperCost *= 2;
                textcostupdate.text = "Прокачати за " + armor.updateSuperCost;
                PlayerPrefs.SetFloat("SupCostIceArmor", armor.updateSuperCost);
            }
            else if (armor.levelSuper == 2)
            {
                armor.levelSuper = 3;
                PlayerPrefs.SetInt("IceArmorLevelSuper", armor.levelSuper);
                armor.fireEmpyty = 0.2f;
                PlayerPrefs.SetFloat("IceArmorSlow", armor.fireEmpyty);
                LevelText.text = armor.levelSuper + "level";
                armor.updateSuperCost *= 2;
                textcostupdate.text = "Прокачати за " + armor.updateSuperCost;
                PlayerPrefs.SetFloat("SupCostIceArmor", armor.updateSuperCost);
            }
            else if (armor.levelSuper == 3)
            {
                armor.levelSuper = 4;
                PlayerPrefs.SetInt("IceArmorLevelSuper", armor.levelSuper);
                armor.fireEmpyty = 0.1f;
                PlayerPrefs.SetFloat("IceArmorSlow", armor.fireEmpyty);
                LevelText.text = armor.levelSuper + "level";
                armor.updateSuperCost *= 2;
                textcostupdate.text = "Прокачати за " + armor.updateSuperCost;
                PlayerPrefs.SetFloat("SupCostIceArmor", armor.updateSuperCost);
            }
            else
            {
                armor.levelSuper = 5;
                PlayerPrefs.SetInt("IceArmorLevelSuper", armor.levelSuper);
                armor.fireEmpyty = 0.08f;
                PlayerPrefs.SetFloat("IceArmorSlow", armor.fireEmpyty);
                LevelText.text = armor.levelSuper + "level";
                OnLevel();

            }
        }
    }
}

