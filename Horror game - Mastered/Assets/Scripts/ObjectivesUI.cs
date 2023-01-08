using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ObjectivesUI : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private TMP_Text partsText;

    private void Start()
    {
        EventManager.current.onPartsUpdate += UpdatePartsText;
    }
    private void UpdatePartsText()
    {
        partsText.text = "Parts collected: " + GameManager.Instance.partsCollected + "/5";
    }
}
