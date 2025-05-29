using OpenCover.Framework.Model;
using UnityEngine;

public class SelectItemScript : MonoBehaviour
{
    [SerializeField] private CommonArmor commonArmor;
    [SerializeField] private IronArmor ironArmor;
    [SerializeField] private IceArmor iceArmor;
    [SerializeField] private FireArmor fireArmor;
    public void Select (int hzyaknazvati)
    {
        if (hzyaknazvati == 0)
        {
            commonArmor.select = 0;
            PlayerPrefs.SetInt("SelectCommonArmor", commonArmor.select);
            ironArmor.select = 0;
            PlayerPrefs.SetInt("SelectIronArmor", ironArmor.select);
            iceArmor.select = 0;
            PlayerPrefs.SetInt("SelectIceArmor", iceArmor.select);
            fireArmor.select = 0;
            PlayerPrefs.SetInt("SelectFireArmor", fireArmor.select);
            commonArmor.select = 1;
            PlayerPrefs.SetInt("SelectCommonArmor", commonArmor.select);
        }
        else if (hzyaknazvati == 1)
        {
            commonArmor.select = 0;
            PlayerPrefs.SetInt("SelectCommonArmor", commonArmor.select);
            ironArmor.select = 0;
            PlayerPrefs.SetInt("SelectIronArmor", ironArmor.select);
            iceArmor.select = 0;
            PlayerPrefs.SetInt("SelectIceArmor", iceArmor.select);
            fireArmor.select = 0;
            PlayerPrefs.SetInt("SelectFireArmor", fireArmor.select);
            ironArmor.select = 1;
            PlayerPrefs.SetInt("SelectIronArmor", ironArmor.select);
        }
        else if (hzyaknazvati == 2)
        {
            commonArmor.select = 0;
            PlayerPrefs.SetInt("SelectCommonArmor", commonArmor.select);
            ironArmor.select = 0;
            PlayerPrefs.SetInt("SelectIronArmor", ironArmor.select);
            iceArmor.select = 0;
            PlayerPrefs.SetInt("SelectIceArmor", iceArmor.select);
            fireArmor.select = 0;
            PlayerPrefs.SetInt("SelectFireArmor", fireArmor.select);
            iceArmor.select = 1;
            PlayerPrefs.SetInt("SelectIceArmor", iceArmor.select);
        }
        else if (hzyaknazvati == 3) 
        {
            commonArmor.select = 0;
            PlayerPrefs.SetInt("SelectCommonArmor", commonArmor.select);
            ironArmor.select = 0;
            PlayerPrefs.SetInt("SelectIronArmor", ironArmor.select);
            iceArmor.select = 0;
            PlayerPrefs.SetInt("SelectIceArmor", iceArmor.select);
            fireArmor.select = 0;
            PlayerPrefs.SetInt("SelectFireArmor", fireArmor.select);
            fireArmor.select = 1;
            PlayerPrefs.SetInt("SelectFireArmor", fireArmor.select);

        }

    }
}
