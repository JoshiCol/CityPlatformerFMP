using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevelController : MonoBehaviour
{
    public bool isPaused;
    public Canvas UIPauseScreen;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            isPaused = !isPaused;

        }

        if(isPaused == false)
        {
            UIPauseScreen.enabled = false;
        }
        else
        {
            UIPauseScreen.enabled = true;
            if(Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(2);
            }
            void OnEnable()
    {
        // Unlock the cursor and make it visible when the script is enabled
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    void OnDisable()
    {
        // You can optionally lock and hide the cursor when the script is disabled
        // Cursor.lockState = CursorLockMode.Locked;
        // Cursor.visible = false;
    }
        }
    }
}

