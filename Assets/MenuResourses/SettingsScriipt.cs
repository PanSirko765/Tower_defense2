using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Runtime.CompilerServices;

using UnityEngine.Rendering.PostProcessing;



public class SettingsScriipt : MonoBehaviour
{
    public GameObject gameObject;
    public GameObject MainPanel;
    public GameObject VolumePanel;
    public GameObject GrSetPanel;
    public Slider sliderVolume;
    public float volumeData;
    public GameObject gameObjectCamera;
    public OnOffPostProcessing postProcessing;
    public Light spot;
    public Light fire;

    public PostProcessVolume volume;
    
    public Bloom bloom;

    public Material skyMat;
    
    void Start()
    {
        sliderVolume.maxValue = 1f;
        sliderVolume.minValue = 0f;
        volume.profile.TryGetSettings(out bloom);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.F5))
        {
            OnOffSettings();
        }
        if (Input.GetKeyUp(KeyCode.F4))
        {
            SelectSkin();
        }

        if (Input.GetKeyUp(KeyCode.F3))
        {

            GoGame();
        }
        
        if(GrSetPanel.activeSelf == true)
        {

            if(postProcessing.postProcessing == 1)
            {
                bloom.intensity.value = postProcessing.sliderBloom.value;
                
                

                RenderSettings.skybox = skyMat;
                volume.enabled = true;
                skyMat.SetFloat("_Exposure", 0.7f);
                DynamicGI.UpdateEnvironment();
                fire.intensity = 6;
                spot.intensity = 1;
            }
            if(postProcessing.postProcessing == 0)
            {
                RenderSettings.skybox = skyMat;
                volume.enabled = false;
                skyMat.SetFloat("_Exposure", 0.4f);
                DynamicGI.UpdateEnvironment();
                fire.intensity = 4;
                spot.intensity = 0.6f;
            }
        }
    }
    
    public void GoGame()
    {
        SceneManager.LoadScene(2);
    }
    public void OnOffSettings()
    {
        gameObject.SetActive(!gameObject.activeSelf);
          
       
    }

    public void SelectSkin()
    {
        SceneManager.LoadScene(1);
    }
    public void SettingsGraphicsOnOff()
    {

    }
    public void GoVolumeSettings()
    {
        MainPanel.SetActive(false);
        VolumePanel.SetActive(true);
    }
    public void GoToMainPanel()
    {
        VolumePanel.SetActive(false);
        GrSetPanel.SetActive(false);
        MainPanel.SetActive(true);
    }
    public void GoToGrSet()
    {
        MainPanel.SetActive(false);
        GrSetPanel.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
