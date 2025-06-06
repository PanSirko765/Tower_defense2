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


    private void Start()
    {
        shop.coinsForGame = 100000;
        Limit = 15;
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
                   if (Limit >= HWM)
                   {
                    sdgiuvgf(select, ref Laser);
                    Vector3 vector3 = new Vector3(hit.point.x, 0.3f, hit.point.z);
                    Instantiate(Laser, vector3, Quaternion.Euler(0, 0, 0));
                    shop.coinsForGame -= price;
                    HWM++;
                   }
                   else
                   {
                    Debug.Log("Erorr:Towers limit is Reached!You can only place 15 towers !");
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
