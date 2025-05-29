using UnityEngine;
using UnityEngine.UI;


public class ShopScript : MonoBehaviour
{
    [SerializeField] private GameObject ObjectOn;
    [SerializeField] private GameObject shopScript;
    [SerializeField] private GameObject CommonArmor;
    [SerializeField] private GameObject IronArmor;
    [SerializeField] private GameObject IceArmor;
    [SerializeField] private GameObject FireArmor;
    private void OnMouseDown()
    {
        
        shopScript.SetActive(true);
        CommonArmor.SetActive(false);
        IceArmor.SetActive(false);
        //FireArmor.SetActive(false);
        IronArmor.SetActive(false);
        ObjectOn.SetActive(true);
    }
}
