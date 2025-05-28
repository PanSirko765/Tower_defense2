using UnityEngine;

public class IceArmor : MonoBehaviour
{
	public int have;
	public int select;
	public float hpPlus;
	public float slowEmpyty;
	public int levelSuper;
	public float cost = 100;
	public float updateCost;
	public float updateSuperCost;
	private void Start()
	{
		have = PlayerPrefs.GetInt("HaveIceArmor", 0);
		select = PlayerPrefs.GetInt("SelectIceArmor", 0);
		hpPlus = PlayerPrefs.GetFloat("hpIceArmor", 200);
		slowEmpyty = PlayerPrefs.GetFloat("IceArmorSlow", 0.1f);
		levelSuper = PlayerPrefs.GetInt("IceArmorLevelSuper", 1);
		updateCost = PlayerPrefs.GetFloat("updateCostIceArmor", 60);
		updateSuperCost = PlayerPrefs.GetFloat("SupCostIceArmor", 160);
	}
}

