using UnityEngine;
using UnityEngine.UI;

public class OnOffPostProcessing : MonoBehaviour
{
    public Slider slider; 
    public int postProcessing;

    private void Start()
    {
        slider.value = PlayerPrefs.GetFloat("sliderPost", 0f);
        postProcessing = PlayerPrefs.GetInt("post", 1);
    }
    // Update is called once per frame
    void Update()
    {
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
