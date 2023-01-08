using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PickUpScript : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject worldCanvas;
    private StarterAssetsInputs input;

    private void Start()
    {
        input = player.GetComponent<StarterAssetsInputs>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            worldCanvas.SetActive(true);

            if (input.interact)
            {
                GameManager.Instance.AddParts();
                this.gameObject.SetActive(false);
            }
               
        }
        
    }
}
