using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
   
    public GameObject game0;
    public GameObject game1;
    public GameObject game2;
    public GameObject game3;
    public GameObject game4;
    public int id;
    private void Start()
    {

        
        id = PlayerPrefs.GetInt("numchar", 0);
        if (id == 0)
        {
            g();
            game0.SetActive(true);
        }
        else if (id == 1)
        {
            g();
            game1.SetActive(true);
        }
        else if (id == 2)
        {
            g();
            game2.SetActive(true);
        }
        else if (id == 3)
        {
            g();
            game3.SetActive(true);
        }
        else if (id == 4)
        {
            g();
            game4.SetActive(true);
        }
    }

    private void g()
    {
        game0.SetActive(false);
        game1.SetActive(false);
        game2.SetActive(false);
        game3.SetActive(false);
        game4.SetActive(false);
    }

}
