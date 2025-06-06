using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.CompilerServices;

public class MobSpawn : MonoBehaviour
{
  
   

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
    [SerializeField] private GameObject button1;
    [SerializeField] private GameObject BuildMode;
    [SerializeField] private GameObject PlayerCamera;
    private void Update()
    {
        if (start)
        {
            
            if (End == false)
            {
                button1.SetActive(false);
                PlayerCamera.SetActive(true);
                BuildMode.SetActive(false);
                StartSpawnMob -= Time.deltaTime;
                if (StartSpawnMob < 0)
                {
                    MobWolna mobWolna = mobWolnas[Id];

                    if (startWolna == false)
                    {
                        TimeSpawnSpeed_ = mobWolna.TimeSpawnSpeed;
                        startWolna = true;
                    }
                    else
                    {
                        TimeSpawnSpeed_ -= Time.deltaTime;
                        if (TimeSpawnSpeed_ < 0)
                        {
                            prefabsInGame.Add(Instantiate(mobWolna.prefab, transform.position, Quaternion.identity));
                            MobSpawnLenght_++;

                            if (MobSpawnLenght_ == mobWolna.MobSpawnLenght)
                            {
                                MobSpawnLenght_ = 0;
                                Id++;
                                

                                if (Id > mobWolnas.Count - 1)
                                {
                                    End = true;
                                    
                                }
                                else
                                {
                                    
                                    start = false;
                                }

                            }
                            

                            startWolna = false;
                        }
                    }

                }
            }
           
        }

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

}





