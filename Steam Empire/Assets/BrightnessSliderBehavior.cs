using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BrightnessSliderBehavior : MonoBehaviour
{
    public Slider brightnessSlider;
    void Start()
    {
        brightnessSlider.minValue = 1.5f;
        brightnessSlider.maxValue = 6.0f;
        brightnessSlider.value = RenderSettings.ambientIntensity;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setBrightness(float value)
    {
        RenderSettings.ambientIntensity = value;
    }
}
