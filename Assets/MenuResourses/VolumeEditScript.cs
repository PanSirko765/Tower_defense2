using UnityEngine;

public class VolumeEditScript : MonoBehaviour
{
    public SettingsScriipt scriipt;
    public AudioSource audioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    

    // Update is called once per frame
    void FixedUpdate()
    {
        audioSource.volume = audioSource.volume * scriipt.volumeData;
    }
}
