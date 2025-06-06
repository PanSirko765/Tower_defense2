using UnityEngine;

public class SelectTowers : MonoBehaviour
{
    public int selectItems;
    public static SelectTowers instance;


    private void Start()
    {
        selectItems = PlayerPrefs.GetInt("Item", 0);
    }
}
