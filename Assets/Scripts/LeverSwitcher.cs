using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class LeverSwitcher : MonoBehaviour
{
    static int correct;
    public static bool piros = true;
    public static bool zold = false;
    public GameObject green;
    public GameObject red;
    public GameObject white;
    public GameObject black;
    //public TextMeshPro anomPanel;
    public void Switch()
    {
        Quaternion down = new Quaternion(50, 0, 0, 0);
        Debug.Log($"lefele: {down}");
        Quaternion up = new Quaternion(-50, 0, 0, 0);
        var r = GameObject.Find("Lever_morgue").transform.rotation;
        Vector3 f = new Vector3(-100, 0, 0);
        Vector3 l = new Vector3(100, 0, 0);
        Debug.Log($"aktualis: {r}");
        if (r == down)
        {
            Debug.Log("fel");
            GameObject.Find("Lever_morgue").transform.Rotate(f);            
            green.SetActive(true);
            zold = true;
            red.SetActive(false);
            piros = false;
            white.SetActive(false);
            black.SetActive(true);


        }
        else if (r == up)
        {
            Debug.Log("le");
            GameObject.Find("Lever_morgue").transform.Rotate(l);            
            green.SetActive(false);
            zold = false;
            red.SetActive(true);
            piros = true;
            white.SetActive(true);
            black.SetActive(false);
        }
        else
        {
            Debug.Log("hiba");
        }
    }
}
