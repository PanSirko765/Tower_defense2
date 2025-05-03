using UnityEngine;
using UnityEngine.UI;

public class VolumeEditScript : MonoBehaviour
{
    public Slider slider;
    public AudioSource audioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        slider.onValueChanged.AddListener(SetVolume);
    }

    public void SetVolume(float value)
    {
        audioSource.volume = audioSource.volume * value;
    }


    
}
