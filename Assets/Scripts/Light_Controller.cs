using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Light_Controller : MonoBehaviour
{
    
    [SerializeField] Light LightManager;
    public Slider slider;  
    // Start is called before the first frame update
    void Start()
    {
        LightManager.intensity = 1;
    }

    // Update is called once per frame
    void Update()
    {
        LightManager.intensity = slider.value;
    }

   // public void LightController()
    //{
      //  LightManager.intensity = slider.value;
        
    //}
}
