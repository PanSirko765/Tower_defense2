using UnityEngine;
using UnityEngine.UI;

public class OnOffPostProcessing : MonoBehaviour
{
    public Slider slider; 
    public int postProcessing;
    public Slider sliderBloom;
    public Slider sliderRatio;

    private void Start()
    {
        sliderBloom.value = PlayerPrefs.GetFloat("Bloom", 40);
        sliderRatio.value = PlayerPrefs.GetFloat("Ratio", 40);
        slider.value = PlayerPrefs.GetFloat("sliderPost", 0f);
        postProcessing = PlayerPrefs.GetInt("post", 1);
    }
    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("Bloom", sliderBloom.value);
        PlayerPrefs.SetFloat("Ratio", sliderRatio.value);
        if(slider.value <= 0.6f)
        {
            postProcessing = 1;
            PlayerPrefs.SetFloat("sliderPost", slider.value);
            PlayerPrefs.SetInt("post", postProcessing);
        }
        else
        {
            postProcessing = 0;
            PlayerPrefs.SetFloat("sliderPost", slider.value);
            PlayerPrefs.SetInt("post", postProcessing);
        }

    }
}
