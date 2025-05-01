using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Runtime.CompilerServices;
using UnityEditor.Rendering.PostProcessing;


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
    public Skybox skybox;
    
    public Component component;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sliderVolume.maxValue = 1f;
        sliderVolume.minValue = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.F5))
        {
            OnOffSettings();
        }
        if(volumeData != sliderVolume.value)
        {
            volumeData = sliderVolume.value;
        }
        if(GrSetPanel.activeSelf == true)
        {
            if(postProcessing.postProcessing == 1)
            {
                
            }
            if(postProcessing.postProcessing == 0)
            {
                
            }
        }
    }
    
    public void OnOffSettings()
    {
        gameObject.SetActive(!gameObject.activeSelf);
        if (gameObject.activeSelf == true)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1.0f;
        }
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
