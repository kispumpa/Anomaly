using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScript : MonoBehaviour
{
    public GameObject scene;
    public Animator anim;
    public GameObject fadeEgesz;
    void OnTriggerEnter(Collider other)
    {
        scene.SetActive(true);
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            fadeEgesz.SetActive(false);
            SceneManager.LoadScene(0);
            Cursor.visible = true;
            Time.timeScale = 1f;
            PlayerMovement.motva = false;
            nextscene.anomalia = 0;
            nextscene.mistakes = 0;
            nextscene.anomBack();
            nextscene.isFirst = true;
            anim.SetBool("isClicked", false);
            anim.SetBool("isMotva", true);
        }
    }


}
