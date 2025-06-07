using UnityEngine;

public class MiniTowerScript : MonoBehaviour
{
    public GameObject canon;
    public GameObject DJ;
    public GameObject Minigun;
    public GameObject MIni;
    public GameObject Normal;
    public GameObject Rokcet;
    public GameObject Shoker;
    public GameObject Fan;
    public int _select;
    public int _have;
    public SelectTowers SelectTowers;
    public GameObject buy;

    private void Start()
    {
        _select = PlayerPrefs.GetInt("SelectMiniTower", 0);
        _have = PlayerPrefs.GetInt("HaveMiniTower", 0);

        if (_have == 0)
        {
            buy.SetActive(true);
        }

        else { buy.SetActive(false); }


    }

    public void Buy() { if (ShopScriptCoin22.instance.coins >= 0) { ShopScriptCoin22.instance.coins -= 0; _have = 1; PlayerPrefs.SetInt("HaveMiniTower", 1); buy.SetActive(false); } }

    void OnMouseDown()
    {
        canon.SetActive(false);
        DJ.SetActive(false);
        Minigun.SetActive(false);
        MIni.SetActive(true);
        Normal.SetActive(false);
        Rokcet.SetActive(false);
        Shoker.SetActive(false);
        Fan.SetActive(false);
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            MIni.SetActive(false);
        }
    }

    public void Select()
    {
        if (SelectTowers.selectItems < 4)
        {
            _select = 1;
            PlayerPrefs.SetInt("SelectMiniTower", _select);
            SelectTowers.selectItems++;
            PlayerPrefs.SetInt("Item", SelectTowers.selectItems);
        }
    }

    public void NoSelect()
    {
        if (_select == 1)
        {
            _select = 0;
            PlayerPrefs.SetInt("SelectMiniTower", _select);
            SelectTowers.selectItems++;
            PlayerPrefs.SetInt("Item", SelectTowers.selectItems);
        }
    }
}
