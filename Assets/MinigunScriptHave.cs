using UnityEngine;

public class MinigunScriptHave : MonoBehaviour
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
        _select = PlayerPrefs.GetInt("SelectMinigunTower", 0);
        _have = PlayerPrefs.GetInt("HaveMinigunTower", 0);

        if (_have == 0)
        {
            buy.SetActive(true);
        }

        else { buy.SetActive(false); }


    }

    public void Buy() { if (ShopScriptCoin22.instance.coins >= 2500) { ShopScriptCoin22.instance.coins -= 2500; _have = 1; PlayerPrefs.SetInt("HaveMinigunTower", 1); buy.SetActive(false); } }

    void OnMouseDown()
    {
        canon.SetActive(false);
        DJ.SetActive(false);
        Minigun.SetActive(true);
        MIni.SetActive(false);
        Normal.SetActive(false);
        Rokcet.SetActive(false);
        Shoker.SetActive(false);
        Fan.SetActive(false);
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Minigun.SetActive(false);
        }
    }

    public void Select()
    {
        if (SelectTowers.selectItems < 4)
        {
            _select = 1;
            PlayerPrefs.SetInt("SelectMinigunTower", _select);
            SelectTowers.selectItems++;
            PlayerPrefs.SetInt("Item", SelectTowers.selectItems);
        }
    }

    public void NoSelect()
    {
        if (_select == 1)
        {
            _select = 0;
            PlayerPrefs.SetInt("SelectMinigunTower", _select);
            SelectTowers.selectItems++;
            PlayerPrefs.SetInt("Item", SelectTowers.selectItems);
        }
    }
}
