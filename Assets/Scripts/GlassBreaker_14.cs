using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassBreaker_14 : MonoBehaviour
{
    public GameObject torottUveg;
    public GameObject uveg;
    public GameObject ko;
    public GameObject ember;
    public GameObject gbActivator;
    public GameObject manActivator;
    public GameObject breakNoise;


    void OnTriggerEnter(Collider other)
    {
        breakNoise.SetActive(true);
        torottUveg.SetActive(true);
        ko.SetActive(true);
        ember.SetActive(true);

        uveg.SetActive(false);

        gbActivator.SetActive(false);
        manActivator.SetActive(true);
    }
}
