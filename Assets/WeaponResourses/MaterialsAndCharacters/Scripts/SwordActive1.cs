using UnityEngine;

public class SwordActive1 : MonoBehaviour
{
    public GameObject CommonSword;
    public GameObject VampirSword;
    public GameObject SpeedSword;
    public GameObject ShiedldSword;
    public GameObject UpSword;
    public int qw;

    public CiommonSwordScript common;
    public VampirSwordSe vampir;
    public SpeedSword speed;
    public ShielsdSword shielsd;
    public UpSword up;

    

    private void OnMouseDown()
    {
        Slect();
    }
    public void Slect()
    {
        OnSelect(qw);
        
    }

    public void OnSelectItem(int index)
    {
        switch (index)
        {

            case 0:
                common.select = 1;
                PlayerPrefs.SetInt("SelectCommonSword", common.select);
                vampir.select = 0;
                PlayerPrefs.SetInt("SelectVampirSword", vampir.select);
                speed.select = 0;
                PlayerPrefs.SetInt("SelectSpeedSword", speed.select);
                shielsd.select = 0;
                PlayerPrefs.SetInt("SelectSSword", shielsd.select);
                up.select = 0;
                PlayerPrefs.SetInt("SelectUSword", up.select);
                break;

            case 1:
                common.select = 0;
                PlayerPrefs.SetInt("SelectCommonSword", common.select);
                vampir.select = 1;
                PlayerPrefs.SetInt("SelectVampirSword", vampir.select);
                speed.select = 0;
                PlayerPrefs.SetInt("SelectSpeedSword", speed.select);
                shielsd.select = 0;
                PlayerPrefs.SetInt("SelectSSword", shielsd.select);
                up.select = 0;
                PlayerPrefs.SetInt("SelectUSword", up.select);
                break;

            case 2:
                common.select = 0;
                PlayerPrefs.SetInt("SelectCommonSword", common.select);
                vampir.select = 0;
                PlayerPrefs.SetInt("SelectVampirSword", vampir.select);
                speed.select = 1;
                PlayerPrefs.SetInt("SelectSpeedSword", speed.select);
                shielsd.select = 0;
                PlayerPrefs.SetInt("SelectSSword", shielsd.select);
                up.select = 0;
                PlayerPrefs.SetInt("SelectUSword", up.select);
                break;

            case 3:
                common.select = 0;
                PlayerPrefs.SetInt("SelectCommonSword", common.select);
                vampir.select = 0;
                PlayerPrefs.SetInt("SelectVampirSword", vampir.select);
                speed.select = 0;
                PlayerPrefs.SetInt("SelectSpeedSword", speed.select);
                shielsd.select = 1;
                PlayerPrefs.SetInt("SelectSSword", shielsd.select);
                up.select = 0;
                PlayerPrefs.SetInt("SelectUSword", up.select);

                break;

            case 4:
                common.select = 0;
                PlayerPrefs.SetInt("SelectCommonSword", common.select);
                vampir.select = 0;
                PlayerPrefs.SetInt("SelectVampirSword", vampir.select);
                speed.select = 0;
                PlayerPrefs.SetInt("SelectSpeedSword", speed.select);
                shielsd.select = 0;
                PlayerPrefs.SetInt("SelectSSword", shielsd.select);
                up.select = 1;
                PlayerPrefs.SetInt("SelectUSword", up.select);

                break;


        }

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
        }
        else if (r == 1)
        {
            CommonSword.SetActive(false);
            VampirSword.SetActive(false);
            SpeedSword.SetActive(false);
            ShiedldSword.SetActive(false);
            UpSword.SetActive(false);
            VampirSword.SetActive(true);

        }
        else if (r == 2)
        {
            CommonSword.SetActive(false);
            VampirSword.SetActive(false);
            SpeedSword.SetActive(false);
            ShiedldSword.SetActive(false);
            UpSword.SetActive(false);
            SpeedSword.SetActive(true);
        }
        else if (r == 3) 
        {
            CommonSword.SetActive(false);
            VampirSword.SetActive(false);
            SpeedSword.SetActive(false);
            ShiedldSword.SetActive(false);
            UpSword.SetActive(false);
            ShiedldSword.SetActive(true);

        }
        else
        {
            CommonSword.SetActive(false);
            VampirSword.SetActive(false);
            SpeedSword.SetActive(false);
            ShiedldSword.SetActive(false);
            UpSword.SetActive(false);
            UpSword.SetActive(true);
        }




    }

}
