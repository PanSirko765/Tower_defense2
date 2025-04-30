using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Runtime.CompilerServices;


public class SettingsScriipt : MonoBehaviour
{
    public GameObject gameObject;
    public GameObject MainPanel;
    public GameObject VolumePanel;
    public Slider sliderVolume;
    public float volumeData;
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
        MainPanel.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
