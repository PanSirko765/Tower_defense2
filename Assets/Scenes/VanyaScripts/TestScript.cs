using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TestScript : MonoBehaviour
{
    [SerializeField] private string select = "selectCanon";
    [SerializeField] private GameObject Canon;
    [SerializeField] private GameObject Minigan;
    [SerializeField] private GameObject Shocker;
    [SerializeField] private GameObject Fan;
    [SerializeField] private GameObject Turret;
    [SerializeField] private GameObject MiniTurret;
    [SerializeField] private GameObject DJ;
    [SerializeField] private GameObject RocketTurret;
    [SerializeField] private Camera Camera;
    [SerializeField] private GameObject Laser;
    [SerializeField] private int price;
    [SerializeField] private ShopScriptCoin22 shop;
    [SerializeField] public Text text;
    [SerializeField] private int Limit;
    [SerializeField] private int HWM;

    [SerializeField] private GameObject _miniturret;
    [SerializeField] private int _selectMoini;

    [SerializeField] private GameObject DiJi;
    [SerializeField] private int _selectDiJi;

    [SerializeField] private GameObject MiniGang;
    [SerializeField] private int _selectMiniGang;

    [SerializeField] private GameObject NormalTow;
    [SerializeField] private int _selectNormalTow;

    [SerializeField] private GameObject Cononi;
    [SerializeField] private int _selectCononi;

    [SerializeField] private GameObject RockTow;
    [SerializeField] private int _selectRockTow;

    [SerializeField] private GameObject ShokTow;
    [SerializeField] private int _selectShokTow;

    [SerializeField] private GameObject FanTow;
    [SerializeField] private int _selectFanTow;
    private void Start()
    {
        shop.coinsForGame = 100000000;
        Limit = 20;
        _selectMoini = PlayerPrefs.GetInt("SelectMiniTower");
        if(_selectMoini == 0)
        {
            _miniturret.SetActive(false);
        }

        _selectDiJi = PlayerPrefs.GetInt("SelectDJTower");
        if (_selectDiJi == 0)
        {
            DiJi.SetActive(false);
        }
        
        _selectMiniGang = PlayerPrefs.GetInt("SelectMinigunTower");
        if (_selectMiniGang == 0)
        {
            MiniGang.SetActive(false);
        }

        _selectShokTow = PlayerPrefs.GetInt("SelectShokerTower");
        if (_selectShokTow == 0)
        {
            NormalTow.SetActive(false);
        }

        _selectCononi = PlayerPrefs.GetInt("SelectCanonTower");
        if (_selectCononi == 0)
        {
            Cononi.SetActive(false);
        }

        _selectRockTow = PlayerPrefs.GetInt("SelectRocketTower");
        if (_selectRockTow == 0)
        {
            RockTow.SetActive(false);
        }

        _selectFanTow = PlayerPrefs.GetInt("SelectFanTower");
        if (_selectFanTow == 0)
        {
            FanTow.SetActive(false);
        }


    }
   

    private void Update()
    {
        text.text = shop.coinsForGame + "Coins";
        Ray ray = Camera.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;
        
            if (Physics.Raycast(ray, out hit) && Input.GetMouseButtonUp(0))
            {
                 if (shop.coinsForGame > 0)
                 {
                   if (Limit >= HWM && hit.point.x > 401 && hit.point.x < 600 && hit.point.z > 397.5f && hit.point.z < 481)
                   {
                    sdgiuvgf(select, ref Laser);
                    Vector3 vector3 = new Vector3(hit.point.x, 0.3f, hit.point.z);
                    Instantiate(Laser, vector3, Quaternion.Euler(0, 0, 0));
                    shop.coinsForGame -= price;
                    HWM++;
                   }
                   else
                   {
                    Debug.Log("Erorr:Towers limit is Reached!You can only place 20 towers !");
                   }
                 }
                 else
                 {
                   Debug.Log("Erorr:You dont have enough coins!");
                 }
            }

            else if (Physics.Raycast(ray, out hit) && Input.GetMouseButtonUp(1) )
            {
                if (hit.transform.gameObject.tag == "DeleteTheTower")
                {
                    Destroy(hit.transform.gameObject);
                }


            }
        
       

        
    }

    void sdgiuvgf(string _name, ref GameObject gameObject)
    {
        if (select == "CanonSelect")
        {
            gameObject = Canon;
            price = 1850;
        }
        if (select == "Minigan")
        {
            gameObject = Minigan;
            price = 3000;
        }
        if (select == "Shocker")
        {
            gameObject = Shocker;
            price = 1350;
        }
        if (select == "Fan")
        {
            gameObject = Fan;
            price=1250;
        }
        if (select == "Turret")
        {
            gameObject = Turret;
            price = 1750;
        }
        if (select == "MiniTurret")
        {
            gameObject = MiniTurret;
            price = 1000;
        }
        if (select == "RocketTurret")
        {
            gameObject = RocketTurret;
            price = 1500;
        }
        if (select == "DJ")
        {
            gameObject = DJ;
            price = 1500;
        }
        
        
    }

    public void SelectCanon()
    {
        select = "CanonSelect";
    }
    public void SelectMinigan()
    {
        select = "Minigan";
    }
    public void SelectShocker()
    {
        select = "Shocker";
    }
    public void SelectFan()
    {
        select = "Fan";
    }
    public void SelectTurret()
    {
        select = "Turret";
    }
    public void SelectMiniTurret()
    {
        select = "MiniTurret";
    }
    public void SelectRocketTurret()
    {
        select = "RocketTurret";
    }
    public void SelectDJ()
    {
        select = "DJ";
    }
}
