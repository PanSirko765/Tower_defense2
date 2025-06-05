using UnityEngine;

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

    
    
    private void Update()
    {
        Ray ray = Camera.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if(Physics.Raycast(ray, out hit) && Input.GetMouseButtonUp(0))
        {
            sdgiuvgf(select, ref Laser);
            Vector3 vector3 = new Vector3(hit.point.x, 0.3f, hit.point.z);
            Instantiate(Laser, vector3 , Quaternion.Euler(0,180,0));
            Debug.Log(Input.mousePosition);
        }
    }

    void sdgiuvgf(string _name, ref GameObject gameObject)
    {
        if (select == "CanonSelect")
        {
            gameObject = Canon;
        }
        if (select == "Minigan")
        {
            gameObject = Minigan;
        }
        if (select == "Shocker")
        {
            gameObject = Shocker;
        }
        if (select == "Fan")
        {
            gameObject = Fan;
        }
        if (select == "Turret")
        {
            gameObject = Turret;
        }
        if (select == "MiniTurret")
        {
            gameObject = MiniTurret;
        }
        if (select == "RocketTurret")
        {
            gameObject = RocketTurret;
        }
        if (select == "DJ")
        {
            gameObject = DJ;
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
