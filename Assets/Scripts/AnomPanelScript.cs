using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AnomPanelScript : MonoBehaviour
{
    public GameObject anomCounter;
    public GameObject mistakeCounter;

    public GameObject blokkerB1;
    public GameObject blokkerB2;
    public GameObject anomLoader;

    void OnTriggerEnter(Collider other)
    {
        bool elso = nextscene.isFirst;
        bool anomalia = nextscene.isThereAnomaly;



        if (elso == false)
        {
            if ((anomalia == true && LeverSwitcher.piros == true) || (anomalia == false && LeverSwitcher.zold == true))
            {
                nextscene.anomalia++;
                anomCounter.GetComponent<TextMeshProUGUI>().text = $"6 / {nextscene.anomalia}";
            }
            else
            {
                mistakeCounter.GetComponent<TextMeshProUGUI>().text = $"{++nextscene.mistakes}";
                nextscene.anomalia = 0;
                anomCounter.GetComponent<TextMeshProUGUI>().text = $"6 / {nextscene.anomalia}";

            }
        }

        blokkerB2.SetActive(true);
        blokkerB1.SetActive(false);
        anomLoader.SetActive(true);
        gameObject.SetActive(false);
    }

}
