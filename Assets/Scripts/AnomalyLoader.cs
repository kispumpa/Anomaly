using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class nextscene : MonoBehaviour
{
    public static bool isThereAnomaly = false;
    public static bool isFirst = true;
    public static int anomalia = 0;
    public static int mistakes = 0;

    public List<GameObject> objektum;
    static List<int> anomalies = new List<int>() { 0, 1, 2, 3, 12, 14, 4, 6, 5, 13, 7, 8, 9, 10, 11 }; //12-nek elõbb kell lennie mint 14-nek
    List<GameObject> normals = new List<GameObject>();
    List<GameObject> anoms = new List<GameObject>();
    public Material materialBasic;
    public Material materialLight;
    public Material materialPicture;
    public Material materialJumpscare;
    public GameObject reflectionProbes;
    public Camera cam;
    public GameObject creepySound;

    public GameObject blokkerB1;
    public GameObject blokkerB2;
    public GameObject checker;
    public GameObject success;
    public GameObject fail;

    public static void anomBack()
    {
        anomalies = new List<int>() { 0, 1, 2, 3, 12, 14, 4, 6, 5, 13, 7, 8, 9, 10, 11 };
    }

    void OnTriggerEnter(Collider other)
    {
        isFirst = false;
        if (anomalia == 6)
        {
            success.SetActive(true);
        }
        else if (mistakes == 4)
        {
            fail.SetActive(true);
        }
        else
        {
            if (other.CompareTag("Player"))
            {
                Default();

                int esely = UnityEngine.Random.Range(0, 5);
                if (esely < 2) //semmi
                {
                    Debug.Log("semmi");
                    isThereAnomaly = false;

                }
                else
                {
                    isThereAnomaly = true;
                    int anomaly = 0;
                    try
                    {
                        anomaly = anomalies.First();
                    }
                    catch (InvalidOperationException)
                    {
                        Debug.Log("nincs tobb");
                        anomaly = -1;

                    }

                    switch (anomaly)
                    {
                        case 0:
                            Debug.Log("kuka");

                            GameObject ujkuka = Finder("trash_can_anom");
                            ujkuka.SetActive(true);
                            anoms.Add(ujkuka);

                            var t = GameObject.Find("trash_can");
                            t.SetActive(false);
                            normals.Add(t);

                            anomalies.Remove(anomaly);
                            break;

                        case 1:
                            Debug.Log("agyuveg");

                            var b = GameObject.Find("brain_jar 1");
                            var g = GameObject.Find("glass_jar");
                            b.SetActive(false);
                            g.SetActive(false);
                            normals.Add(b);
                            normals.Add(g);

                            var ba = Finder("glass_jar_anom");
                            var ga = Finder("brain_jar_anom");
                            ba.SetActive(true);
                            ga.SetActive(true);
                            anoms.Add(ba);
                            anoms.Add(ga);

                            anomalies.Remove(anomaly);
                            break;

                        case 2: //EXEP
                            Debug.Log("verEgetobol");

                            var ver = Finder("BloodSprayFX_anom");
                            ver.SetActive(true);
                            anoms.Add(ver);

                            var mosogato_a = Finder("metal_sink_anom");
                            var tabla_a = Finder("writing_board_anom");
                            mosogato_a.SetActive(true);
                            tabla_a.SetActive(true);
                            anoms.Add(mosogato_a);
                            anoms.Add(tabla_a);

                            var mosogat = GameObject.Find("metal_sink");
                            var tabla = GameObject.Find("writing_board");
                            mosogat.SetActive(false);
                            tabla.SetActive(false);
                            normals.Add(mosogat);
                            normals.Add(tabla);

                            anomalies.Remove(anomaly);
                            break;

                        case 3:
                            Debug.Log("lefolyoFedel");

                            var r = GameObject.Find("drain_decal 2");
                            var l = GameObject.Find("drain_decal 1");
                            r.SetActive(false);
                            l.SetActive(false);
                            normals.Add(r);
                            normals.Add(l);

                            var ra = Finder("drain_decal_anom");
                            var la = Finder("drain_decal_anom_left");
                            ra.SetActive(true);
                            la.SetActive(true);
                            anoms.Add(ra);
                            anoms.Add(la);

                            anomalies.Remove(anomaly);
                            break;

                        case 4: //EXEP
                            Debug.Log("egetoAjto");

                            Vector3 x = new Vector3(0, -3, 0);
                            var a = Finder("corpse_drawer_door");
                            a.transform.Rotate(x);
                            anoms.Add(a);

                            anomalies.Remove(anomaly);
                            break;

                        case 5:
                            Debug.Log("ceruza");

                            var ca = Finder("pencil_anom");
                            ca.SetActive(true);
                            anoms.Add(ca);

                            var c = GameObject.Find("pencil");
                            c.SetActive(false);
                            normals.Add(c);

                            anomalies.Remove(anomaly);
                            break;

                        case 6:
                            Debug.Log("szike");

                            var sza = Finder("scalp_anom");
                            sza.SetActive(true);
                            anoms.Add(sza);

                            var sz = GameObject.Find("scalp");
                            sz.SetActive(false);
                            normals.Add(sz);

                            anomalies.Remove(anomaly);
                            break;

                        case 7:
                            Debug.Log("furesz");

                            var fa = Finder("bonesaw_anom");
                            fa.SetActive(true);
                            anoms.Add(fa);

                            var f = GameObject.Find("bonesaw");
                            f.SetActive(false);
                            normals.Add(f);

                            anomalies.Remove(anomaly);
                            break;

                        case 8: //EXEP
                            Debug.Log("szekrenyAjto");

                            var aba = Finder("lp_cabinet_door2_anom");
                            var aja = Finder("lp_cabinet_door3_anom");
                            aba.SetActive(true);
                            aja.SetActive(true);
                            anoms.Add(aba);
                            anoms.Add(aja);

                            var ab = GameObject.Find("lp_cabinet_door2");
                            var aj = GameObject.Find("lp_cabinet_door3");
                            ab.SetActive(false);
                            aj.SetActive(false);
                            normals.Add(ab);
                            normals.Add(aj);


                            anomalies.Remove(anomaly);
                            break;

                        case 9:
                            Debug.Log("lampa");

                            GameObject lightInput = Finder("lights");
                            List<Light> lights = new List<Light>();
                            lightInput.GetComponentsInChildren<Light>(lights);
                            foreach (var lampa in lights)
                            {
                                lampa.enabled = false;
                            }
                            anoms.Add(lightInput);

                            List<MeshRenderer> meshRenderers = new List<MeshRenderer>();
                            lightInput.GetComponentsInChildren<MeshRenderer>(meshRenderers);
                            foreach (var mr in meshRenderers)
                            {
                                mr.material = materialBasic;
                            }

                            List<ReflectionProbe> probes = new List<ReflectionProbe>();
                            reflectionProbes.GetComponentsInChildren<ReflectionProbe>(probes);
                            foreach (var rp in probes)
                            {
                                rp.enabled = false;
                            }

                            anomalies.Remove(anomaly);
                            break;

                        case 10: //EXEP
                            Debug.Log("kep");

                            var kep = Finder("photo_frame");
                            kep.GetComponent<MeshRenderer>().material = materialJumpscare;
                            anoms.Add(kep);

                            anomalies.Remove(anomaly);
                            break;

                        case 11:
                            Debug.Log("forgoLampa");

                            var lamp = Finder("ceiling_light");
                            lamp.SetActive(false);
                            normals.Add(lamp);

                            var lampa_a = Finder("ceiling_light_anom");
                            lampa_a.SetActive(true);
                            anoms.Add(lampa_a);

                            anomalies.Remove(anomaly);
                            break;

                        case 12:
                            Debug.Log("magassag");

                            cam.transform.position = new Vector3(cam.transform.position.x, cam.transform.position.y - 1.2f, cam.transform.position.z);
                            anoms.Add(new GameObject("kamera"));
                            var secret = Finder("secretNote");
                            secret.SetActive(true);
                            anoms.Add(secret);

                            anomalies.Remove(anomaly);
                            break;

                        case 13:
                            Debug.Log("agyKukaban");

                            var b1 = Finder("brain_1_anom");
                            var b2 = Finder("brain_2_anom");
                            var b3 = Finder("brain_3_anom");
                            b1.SetActive(true);
                            b2.SetActive(true);
                            b3.SetActive(true);
                            anoms.Add(b1);
                            anoms.Add(b2);
                            anoms.Add(b3);

                            anomalies.Remove(anomaly);
                            break;

                        case 14:
                            Debug.Log("szalad");

                            var activator = Finder("glassBreaker");
                            activator.SetActive(true);

                            var torott = Finder("Glass");
                            var ko = Finder("Rock");
                            var embi = Finder("Banana Man");
                            var lampakPiros = Finder("lights");
                            anoms.Add(torott);
                            anoms.Add(ko);
                            anoms.Add(embi);
                            anoms.Add(lampakPiros);


                            var toretlen = GameObject.Find("glass_jar");
                            normals.Add(toretlen);


                            anomalies.Remove(anomaly);
                            break;
                        default:

                            break;
                    } //switch vege
                }
            }
        }


        blokkerB1.SetActive(true);
        blokkerB2.SetActive(false);
        checker.SetActive(true);
        gameObject.SetActive(false);
    }

    void Default()
    {
        if (normals.Count != 0) //alaptargyak visszaallitasa
        {
            foreach (var o in normals)
            {
                o.SetActive(true);
            }
            normals.Clear();
        }
        if (anoms.Count != 0) //anomaliak eltavolitasa
        {
            foreach (var o in anoms)
            {
                if (o.name != "corpse_drawer_door" && o.name != "lights" && o.name != "photo_frame" && o.name != "kamera")
                {
                    o.SetActive(false);
                }
                else if (o.name == "kamera")
                {
                    cam.transform.position = new Vector3(cam.transform.position.x, cam.transform.position.y + 1.2f, cam.transform.position.z);
                }
                else if (o.name == "photo_frame")
                {
                    o.GetComponent<MeshRenderer>().material = materialPicture;
                }
                else if (o.name == "lights")
                {
                    List<Light> lights = new List<Light>();
                    o.GetComponentsInChildren<Light>(lights);
                    foreach (var lampa in lights)
                    {
                        lampa.enabled = true;
                        lampa.color = Color.white;
                    }
                    List<MeshRenderer> meshRenderers = new List<MeshRenderer>();
                    o.GetComponentsInChildren<MeshRenderer>(meshRenderers);
                    foreach (var mr in meshRenderers)
                    {
                        mr.material = materialLight;
                    }
                    List<ReflectionProbe> probes = new List<ReflectionProbe>();
                    reflectionProbes.GetComponentsInChildren<ReflectionProbe>(probes);
                    foreach (var rp in probes)
                    {
                        rp.enabled = true;
                    }
                    creepySound.SetActive(false);
                }
                else
                {
                    Vector3 x = new Vector3(0, 3, 0);
                    Finder("corpse_drawer_door").transform.Rotate(x);
                }
            }
            anoms.Clear();
        }
    }
    GameObject Finder(string name)
    {
        foreach (var go in objektum)
        {
            if (go.name == name)
            {
                return go;
            }
        }
        Debug.Log($"nemtalalt: {name}");
        return null;
    }
}


