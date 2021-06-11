using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class calidad : MonoBehaviour
{
    public Dropdown dropdown; 
    public int Calidad;
    void Start()
    {
        Calidad = PlayerPrefs.GetInt("numeroDeCalidad", 3);
        dropdown.value = Calidad;
        AjustarCalidad();  
    }

    public void AjustarCalidad()
    {
        QualitySettings.SetQualityLevel(dropdown.value);
        PlayerPrefs.SetInt("numeroDeCalidad", dropdown.value);
        Calidad = dropdown.value;  

    } 
    void Update()
    {
        
    }
}
