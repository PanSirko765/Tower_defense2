using UnityEngine;
using UnityEngine.UI;


public class ShopScript : MonoBehaviour
{
    [SerializeField] private GameObject game;
    [SerializeField] private GameObject shopScript;
    private void OnMouseDown()
    {
        game.SetActive(true);
        shopScript.SetActive(true);
    }
}
