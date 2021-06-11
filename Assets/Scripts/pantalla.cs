using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class pantalla : MonoBehaviour
{
    public Toggle toggle;
    public Dropdown Resolution;
    Resolution[] resoluciones;
    void Start()
    {
        if(Screen.fullScreen)
        {
            toggle.isOn = true;
        }
        else
        {
            toggle.isOn = false;
        }

        RevisarResolucion();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivarPantallaCompleta(bool pantallaCompleta)
    {
        Screen.fullScreen = pantallaCompleta;  
    }

    public void RevisarResolucion()
    {
        resoluciones = Screen.resolutions;
        Resolution.ClearOptions();
        List<string> opciones = new List<string>();
        int resolucionActual = 0;
        
        for (int i = 0; i < resoluciones.Length; i++)
        {
            string opcion = resoluciones[i].width+ " x " + resoluciones[i].height;
            opciones.Add(opcion);

            if(Screen.fullScreen && resoluciones[i].width == Screen.currentResolution.width && 
            resoluciones[i].height == Screen.currentResolution.height)
            {
                resolucionActual = i; 
            }
        }  
        Resolution.AddOptions(opciones);
        Resolution.value = resolucionActual;
        Resolution.RefreshShownValue(); 

    }

    public void CambiarResolucion(int IndiceResolucion)
    {
        Resolution resolucion = resoluciones[IndiceResolucion];
        Screen.SetResolution(resolucion.width, resolucion.height, Screen.fullScreen); 
    }
}
