using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoScript : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject cim;
    public void BackToMainMenu()
    {
        gameObject.SetActive(false);
        MainMenu.SetActive(true);
        cim.SetActive(true);
    }
}
