using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }
    public GameObject OptionsMenu;
    public GameObject PauseMenu;
    public GameObject InfoPanel;
    public GameObject HUDs;
    public Image black;
    public GameObject fadeEgesz;
    public Animator anim;
    public GameObject LoadingScreen;
    public GameObject cim;
    public void PlayGame()
    {
        StartCoroutine(Fading());
            //SceneManager.LoadScene(1);
        
        
    }
    IEnumerator Fading()
    {
      
        AsyncOperation oper = SceneManager.LoadSceneAsync(1);
        LoadingScreen.SetActive(true);

        while (!oper.isDone)
        {
            yield return null;
        }

        //anim.SetBool("FadeOut", true);
    }
    public void BackToMain()
    {
        anim.SetBool("isClicked", false);
        //anim.SetBool("isMotva", true);
        fadeEgesz.SetActive(false);
        Time.timeScale = 1f;
        PlayerMovement.motva = false;
        nextscene.isFirst = true;
        nextscene.anomalia = 0;
        nextscene.mistakes = 0;
        nextscene.anomBack();
        SceneManager.LoadScene(0);
    }
    public void ResumeGame()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        HUDs.SetActive(true);
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = false;
    }
    public void PauseGame()
    {
        PauseMenu.SetActive(true);
        //Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = true;
        HUDs.SetActive(false);
        Time.timeScale = 0f;
    }
    public void OwnExitGame()
    {
        Debug.Log("EXIT");
        Application.Quit();
        //UnityEditor.EditorApplication.isPlaying = false;
    }
    public void Options()
    {
        Debug.Log("Options");
        gameObject.SetActive(false);
        OptionsMenu.SetActive(true);
    }

    public void Info()
    {
        Debug.Log("Info");
        gameObject.SetActive(false);
        InfoPanel.SetActive(true);
        cim.SetActive(false);
    }
}
