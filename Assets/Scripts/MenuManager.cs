using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
 //   [SerializeField]
    public GameObject panel;

    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
        
    public void ExitGame()
    {
        Application.Quit();
    }

    public void OpenPanel()
    {
        panel.SetActive(true);
    }

    public void ExitPanel()
    {
        panel.SetActive(false);
    }
}


