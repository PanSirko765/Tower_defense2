using UnityEngine;
using UnityEngine.SceneManagement;

public class SkinSelect : MonoBehaviour
{
    public int characterNum;
    private int preCharNum;
    [SerializeField] private GameObject lameObject;
    Vector3 tr = Vector3.zero;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tr.y = 19.84f;
        tr.z = 0.167f;
        characterNum = PlayerPrefs.GetInt("numchar", 0);
        preCharNum = characterNum;
        if(characterNum == 0)
        {
           
            tr.x = 262;
            lameObject.transform.position = tr;

            
        }
        else if(characterNum == 1)
        {
            tr.x = 240;
            lameObject.transform.position = tr;

        }
        else if(characterNum == 2)
        {
            tr.x = 218;
            lameObject.transform.position = tr;
        }
        else if(characterNum == 3)
        {
            tr.x = 196;
            lameObject.transform.position = tr;
        }
        else
        {
            tr.x = 174;
            lameObject.transform.position = tr;
        }
    }

    
    
    public void Plus()
    {
        if(preCharNum < 4)
        {
            Vector3 pos = lameObject.transform.position;
            pos.x -= 22;
            lameObject.transform.position = pos;
            preCharNum++;
        }
    }
    public void Minus()
    {
        if(preCharNum > 0)
        {
            Vector3 pos = lameObject.transform.position;
            pos.x += 22;
            lameObject.transform.position = pos;
            preCharNum--;
        }
    }
    public void Select()
    {
        characterNum = preCharNum;
        PlayerPrefs.SetInt("numchar", characterNum);
        SceneManager.LoadScene(0);
    }

}
