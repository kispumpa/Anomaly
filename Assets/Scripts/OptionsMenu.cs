using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public GameObject MainMenu;

    public Slider slide;
    public void LowQuality()
    {
        Screen.SetResolution(1280, 720, true);
    }
    public void NormalQuality()
    {
        Screen.SetResolution(1920, 1080, true);
    }
    public void UltraQuality()
    {
        Screen.SetResolution(3840, 2160, true);
    }
    public void BackToMainMenu()
    {
        gameObject.SetActive(false);
        MainMenu.SetActive(true);
        PlayerMovement.motva = false;
    }
    public void Update()
    {
        Debug.Log(slide.value.ToString());
        PlayerMovement.nezelodesSebesseg = (float)slide.value;
    }

}
