using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMAINMENUS : MonoBehaviour
{
    public Canvas PlayMenu;
    public Canvas OptionsMenu;
    public Canvas MainMenu;

    void Start()
    {
        MainMenu.enabled = true;
        PlayMenu.enabled = false;
        OptionsMenu.enabled = false;
    }

    public void OnPlayMenu()
    {
        OptionsMenu.enabled = false;
        PlayMenu.enabled = true;
        MainMenu.enabled = false;
    }

    public void BlockoutLoad()
    {
        SceneManager.LoadScene(1);
    }

    public void PrototypeLoad()
    {
        SceneManager.LoadScene(2);
    }

    public void OnOptionsMenu()
    {
        MainMenu.enabled = false;
        PlayMenu.enabled = false;
        OptionsMenu.enabled = true;
    }

    public void OnBackToMain()
    {
        MainMenu.enabled = true;
        PlayMenu.enabled = false;
        OptionsMenu.enabled = false;
    }

    public void OnQuit()
    {
        Application.Quit();
    }
}
