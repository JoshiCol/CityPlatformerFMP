using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class Interactions : MonoBehaviour
{

    public bool Teleport;
    public Transform TeleportPoint;
    public Material material;
    public TMP_Text interactText;
    MeshRenderer meshRenderer;
    bool interactedWith;
    bool inRadius;
    Collider player;
    

    // Start is called before the first frame update
    void Start()
    {
        interactText = GameObject.FindGameObjectWithTag("InteractText").GetComponent<TMP_Text>();
        interactText.enabled = false;
        meshRenderer = gameObject.GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(inRadius)
        {
            if(Input.GetKey(KeyCode.E))
            {
                if(Teleport)
                {
                    player.gameObject.transform.position = TeleportPoint.position;
                }
                else
                {
                    if(!interactedWith)
                    {
                        meshRenderer.sharedMaterial = material;
                        interactedWith = true;
                    }
                }
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            player = other;
            interactText.enabled = true;
            inRadius = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            interactText.enabled = false;
            inRadius = false;
        }
    }
}
