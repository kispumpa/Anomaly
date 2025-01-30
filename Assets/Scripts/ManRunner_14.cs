using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManRunner_14 : MonoBehaviour
{
    public GameObject lampak;
    public GameObject ember;
    public Material piros;
    public GameObject reflectionProbes;
    public GameObject manActivator;
    public GameObject creepySound;
    

    void OnTriggerEnter(Collider other)
    {
        creepySound.SetActive(true);
        manActivator.SetActive(false);

        List<Light> lights = new List<Light>();
        lampak.GetComponentsInChildren<Light>(lights);
        foreach (var lampa in lights)
        {
            lampa.color = Color.red;
        }

        List<MeshRenderer> meshRenderers = new List<MeshRenderer>();
        lampak.GetComponentsInChildren<MeshRenderer>(meshRenderers);
        foreach (var mr in meshRenderers)
        {
            mr.material = piros;
        }

        List<ReflectionProbe> probes = new List<ReflectionProbe>();
        reflectionProbes.GetComponentsInChildren<ReflectionProbe>(probes);
        foreach (var rp in probes)
        {
            rp.enabled = false;
        }

        ember.GetComponent<Animator>().enabled = true;
    }
}
