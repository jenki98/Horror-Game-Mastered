using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; set;}
    public int partsCollected = 0;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
            Instance = this;
        }
    }
        
    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddParts()
    {
        partsCollected++;
        EventManager.current.PartsUpdate();
    }
}
