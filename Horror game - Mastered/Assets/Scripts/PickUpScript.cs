using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PickUpScript : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private StarterAssetsInputs input;

    private void Start()
    {
        input = player.GetComponent<StarterAssetsInputs>();
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (input.interact)
            {
                this.gameObject.SetActive(false);
            }
               
        }
        
    }
}
