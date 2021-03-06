using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{
    public Slider slider;
    public float sliderValue;
    public Image imageMute;

    void Start ()
    {
        slider.value = PlayerPrefs.GetFloat("volumeaudio", 0.5f);
        AudioListener.volume = slider.value;
        IsMute();
    }

    public void ChangeSlider(float valor)
    {
        sliderValue = valor;
        PlayerPrefs.SetFloat("volumeaudio", sliderValue);
        AudioListener.volume = sliderValue;
        IsMute();
    }

    public void IsMute()
    {
        if(sliderValue == 0)
        {
            imageMute.enabled = true;
        }else{
            imageMute.enabled = false; 
        }
    }

}
