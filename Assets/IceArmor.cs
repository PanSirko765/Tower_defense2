using UnityEngine;

public class IceArmor : MonoBehaviour
{
	public int have;
	public int select;
	public float hpPlus;
	public float slowEmpyty;
	public int levelSuper;
	public float cost = 950;
	public float updateCost;
	public float updateSuperCost;
	private void Awake()
	{
		have = PlayerPrefs.GetInt("HaveIceArmor", 0);
		select = PlayerPrefs.GetInt("SelectIceArmor", 0);
		hpPlus = PlayerPrefs.GetFloat("hpIceArmor", 10);
		slowEmpyty = PlayerPrefs.GetFloat("IceArmorSlow", 0.2f);
		levelSuper = PlayerPrefs.GetInt("IceArmorLevelSuper", 1);
		updateCost = PlayerPrefs.GetFloat("updateCostIceArmor", 60);
		updateSuperCost = PlayerPrefs.GetFloat("SupCostIceArmor", 700);
	}
}

