using UnityEngine;

public class TestScript : MonoBehaviour
{
    [SerializeField] private string select = "selectCanon";
    [SerializeField] private GameObject Canon;
    [SerializeField] private GameObject Minigan;
    [SerializeField] private Camera Camera;
    [SerializeField] private GameObject Laser;
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
        else
        {
            gameObject = Minigan;
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
}
