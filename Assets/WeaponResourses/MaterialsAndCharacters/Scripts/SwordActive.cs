using UnityEngine;

public class SwordActive : MonoBehaviour
{
    public GameObject CommonSword;
    public GameObject VampirSword;
    public GameObject SpeedSword;
    public GameObject ShiedldSword;
    public GameObject UpSword;
    public GameObject PanelNo;
    public GameObject PanelYes;
    public int qw;

    private void OnMouseDown()
    {
        Slect();
    }
    public void Slect()
    {
        OnSelect(qw);
    }
    public void OnSelect(int r)
    {
        if (r == 0)
        {
            CommonSword.SetActive(false);
            VampirSword.SetActive(false);
            SpeedSword.SetActive(false);
            ShiedldSword.SetActive(false);
            UpSword.SetActive(false);
            CommonSword.SetActive(true);
            PanelNo.SetActive(false);
            PanelYes.SetActive(true);
        }
        else if (r == 1)
        {
            CommonSword.SetActive(false);
            VampirSword.SetActive(false);
            SpeedSword.SetActive(false);
            ShiedldSword.SetActive(false);
            UpSword.SetActive(false);
            VampirSword.SetActive(true);
            PanelNo.SetActive(false);
            PanelYes.SetActive(true);

        }
        else if (r == 2)
        {
            CommonSword.SetActive(false);
            VampirSword.SetActive(false);
            SpeedSword.SetActive(false);
            ShiedldSword.SetActive(false);
            UpSword.SetActive(false);
            SpeedSword.SetActive(true);
            PanelNo.SetActive(false);
            PanelYes.SetActive(true);
        }
        else if (r == 3) 
        {
            CommonSword.SetActive(false);
            VampirSword.SetActive(false);
            SpeedSword.SetActive(false);
            ShiedldSword.SetActive(false);
            UpSword.SetActive(false);
            ShiedldSword.SetActive(true);
            PanelNo.SetActive(false);
            PanelYes.SetActive(true);

        }
        else
        {
            CommonSword.SetActive(false);
            VampirSword.SetActive(false);
            SpeedSword.SetActive(false);
            ShiedldSword.SetActive(false);
            UpSword.SetActive(false);
            UpSword.SetActive(true);
            PanelNo.SetActive(false);
            PanelYes.SetActive(true);
        }




    }

}
