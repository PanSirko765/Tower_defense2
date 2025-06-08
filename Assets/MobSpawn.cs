using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.CompilerServices;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class MobSpawn : MonoBehaviour
{
    public static MobSpawn Instanse;
    void Awake()
    {
        Instanse = this;
    }



    public Transform Finish;
    [SerializeField]
    private float StartSpawnMob;

    [SerializeField]
    private List<MobWolna> mobWolnas = new List<MobWolna>();

    private int Id;
    private float TimeSpawnSpeed_;
    private int MobSpawnLenght_;
    private bool startWolna = false;
    private bool End = false;
    public float TimeSpawnSpeed;
    public float RoundTime_;
    
    
    private float TimeSpawnSpeed_2;
    private int MobSpawnLenght_2;



    
    [SerializeField] private GameObject button1;
    [SerializeField] private GameObject BuildMode;
    [SerializeField] private GameObject PlayerCamera;
    [SerializeField] private ShopScriptCoin22 shop;
    [SerializeField] private GameObject panel;


    private void Start()
    {
       
        button1.SetActive(true);
        PlayerCamera.SetActive(false);
        BuildMode.SetActive(true);

    }
    
    private void Update()

    {

        if (start)
        {
            
            
            
            if (End == false)
            {
                StartSpawnMob -= Time.deltaTime;

                if (StartSpawnMob < 0)
                {
                    MobWolna mobWolna = mobWolnas[Id];
                    if (startWolna == false)
                    {
                        TimeSpawnSpeed_ = mobWolna.TimeSpawnSpeed;
                        TimeSpawnSpeed_2 = mobWolna.TimeSpawnSpeed2;
                        startWolna = true;
                    }
                    else
                    {
                        TimeSpawnSpeed_ -= Time.deltaTime;
                        TimeSpawnSpeed_2 -= Time.deltaTime;


                        if (TimeSpawnSpeed_ < 0)
                        {
                            prefabsInGame.Add(Instantiate(mobWolna.prefab, transform.position, Quaternion.identity));
                            prefabsInGame.Add(Instantiate(mobWolna.prefab2, transform.position, Quaternion.identity));
                            MobSpawnLenght_++;
                            

                            if (MobSpawnLenght_ == mobWolna.MobSpawnLenght)
                            {
                                MobSpawnLenght_ = 0;
                                MobSpawnLenght_2 = 0;
                                Id++;

                                if (Id > mobWolnas.Count - 1)
                                {
                                    End = true;
                                   
                                }
                                else
                                {
                                    
                                    start = false;
                                    shop.coinsForGame += mobWolna.coins22;
                                }
                               
                                
                            }
                         
                           

                            startWolna = false;
                        }
                    }

                }
            }
            else
            {
                panel.SetActive(true);
                shop.coins += 700;
                PlayerPrefs.SetFloat("coins", shop.coins);
                SceneManager.LoadScene(2);
            }

        }

    }


    public void SamoRemove(GameObject gameObjects)
    {
        prefabsInGame.Remove(gameObjects);
    }



    private List<GameObject> prefabsInGame = new List<GameObject>();

    private bool start = false;
    [SerializeField]
    private GameObject button;
    public void StartGame()
    {
        start = true;
    }

}

[Serializable]
public class MobWolna
{
    public GameObject prefab;
    public int MobSpawnLenght;
    public float TimeSpawnSpeed;
    public GameObject prefab2;
    public int MobSpawnLenght2;
    public float TimeSpawnSpeed2;
    public int coins22;
}





