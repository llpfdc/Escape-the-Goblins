using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Contador : MonoBehaviour
{
    private TextMeshProUGUI diamondText;
    // Start is called before the first frame update
    void Start()
    {
        diamondText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    public void UpdateDiamondText(Inventory inventory)
    { 
        diamondText.text = inventory.NumberOfDiamonds.ToString();
    }
}
