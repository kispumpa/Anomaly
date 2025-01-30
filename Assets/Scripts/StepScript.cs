using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepScript : MonoBehaviour
{
    public GameObject footstep;
    public GameObject runstep;
    public Camera kamera;


    // Start is called before the first frame update
    void Start()
    {
        footstep.SetActive(false);
        runstep.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w") || Input.GetKey("s") || Input.GetKey("a") || Input.GetKey("d"))
        {
            if (Input.GetKey(KeyCode.LeftShift))
                Runsteps();
            else
                Footsteps();
        }
        if (Input.GetKeyUp("w") || Input.GetKeyUp("s") || Input.GetKeyUp("a") || Input.GetKeyUp("d"))
        {
            StopSteps();
        }
    }

    void Footsteps()
    {
        
        footstep.SetActive(true);
        runstep.SetActive(false);
    }

    void Runsteps()
    {
        
        runstep.SetActive(true);
        footstep.SetActive(false);
    }

    void StopSteps()
    {
        footstep.SetActive(false);
        runstep.SetActive(false);
    }
}
