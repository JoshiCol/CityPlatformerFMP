using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenuController : MonoBehaviour
{
    public bool isPaused;
    public Canvas UIPauseScreen;
    public GameObject firstPersonCamera;
    public GameObject overheadCamera;
    public GameObject playerCamPos;


    void Start()
    {
        firstPersonCamera.SetActive(true);
        overheadCamera.SetActive(false);
        playerCamPos.SetActive(true);
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
            if(Input.GetKeyDown(KeyCode.T))
            {
                if(firstPersonCamera.activeSelf == true)
                {
                    overheadCamera.transform.position = playerCamPos.transform.position;
                    overheadCamera.transform.rotation = playerCamPos.transform.rotation;
                }

                firstPersonCamera.SetActive(!firstPersonCamera.activeSelf);
                overheadCamera.SetActive(!overheadCamera.activeSelf);
            }

            UIPauseScreen.enabled = true;
            
            if(Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(2);
            }
        }
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

    // Call this function to disable FPS camera,
    // and enable overhead camera.
    void ShowOverheadView() {
        firstPersonCamera.SetActive(false);
        overheadCamera.SetActive(true);
    }
    
    // Call this function to enable FPS camera,
    // and disable overhead camera.
    void ShowFirstPersonView() {
        firstPersonCamera.SetActive(true);
        overheadCamera.SetActive(false);
    }
}
