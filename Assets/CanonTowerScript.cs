using UnityEngine;

public class CanonTowerScript : MonoBehaviour
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
    public SelectTowers SelectTowers;

    private void Start()
    {
        _select = PlayerPrefs.GetInt("SelectCanonTower", 0);
    }

    void OnMouseDown()
    {
        canon.SetActive(true);
        DJ.SetActive(false); 
        Minigun.SetActive(false);
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
            canon.SetActive(false);
        }
    }

    public void Select()
    {
        if(SelectTowers.selectItems < 4)
        {
            _select = 1;
            PlayerPrefs.SetInt("SelectCanonTower", _select);
            SelectTowers.instance.selectItems++;
            PlayerPrefs.SetInt("Item", SelectTowers.selectItems);
        }
    }

    public void NoSelect()
    {
        if (_select == 1)
        {
            _select = 0;
            PlayerPrefs.SetInt("SelectCanonTower", _select);
            SelectTowers.instance.selectItems++;
            PlayerPrefs.SetInt("Item", SelectTowers.selectItems);
        }
    }

}
